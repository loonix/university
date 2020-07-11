using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Codr.Core.Classes.ClassBD;

namespace Codr.Core.Classes
{
    class ClassSnippets
    {
        public static void InserirCodigo(string title, string description, string id_extension, string path)
        {
            try
            {
                SqlConnection sqlConnection = ClassBD.OpenDatabase();
                string comandoSQL = "INSERT INTO snippets (title, description, id_extension, path) VALUES " +
                    "(@title, @description, @id_extension, @path)";

                if (sqlConnection == null)
                {
                    MessageBox.Show("Nao foi possivel abrir a tabela snippets",
                       "CODr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlCommand comando = new SqlCommand(comandoSQL, sqlConnection);
                comando.Parameters.AddWithValue("title", title.Trim());
                comando.Parameters.AddWithValue("description", description.Trim());
                comando.Parameters.AddWithValue("id_extension", id_extension);
                comando.Parameters.AddWithValue("path", path);

                comando.ExecuteNonQuery();
                sqlConnection.Close();
                return;
            }
            catch (Exception err)
            {
                MessageBox.Show("Nao foi possivel adicionar a extension \n" + err,
                        "CODr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        public static ClassSnippet OpenSnippet(string id)
        {

            //1. Abrir BD
            SqlConnection sqlConnection = ClassBD.OpenDatabase();
            //verificar sucesso da abertura
            if (sqlConnection == null)
            {
                return null;
            }

            //2. Criar comando SQL SELECT para submeter à BD
            string SQL;
            SQL = "SELECT * FROM snippets WHERE snippets.id = @id";

            SqlCommand sqlCommand = new SqlCommand(SQL, sqlConnection);
            sqlCommand.Parameters.AddWithValue("id", id.Trim());
            //ojeto para armazenar o que o resultado do comando (SQL, SELECT....)
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //verificar se tem linhas o resultado (sqlDataReader)
            if (sqlDataReader.Read())
            {
                //exite estudante
                //criar um objto mdo tipo ClassNotas
                ClassSnippet snippet = new ClassSnippet();
                snippet.id = id;
                snippet.title = sqlDataReader["title"].ToString();
                snippet.description = sqlDataReader["description"].ToString();
                snippet.id_extension = int.Parse(sqlDataReader["id_extension"].ToString());
                snippet.path = sqlDataReader["path"].ToString();
                return snippet;
            }
            else
            {
                //Não exite
                return null;
            }

        }
    }
}
