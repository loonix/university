using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Codr.Core.Classes.ClassBD;

namespace Codr.Core.Classes
{
    class ClassSnippets
    {
        public static void InserirCodigo(string titulo, string descricao, string idCat, string path)
        {
            try
            {
                SqlConnection sqlConnection = ClassBD.OpenDatabase();
                string comandoSQL = "INSERT INTO codigos (titulo, descricao, id_categoria, path) VALUES " +
                    "(@titulo, @descricao, @idCat, @path)";

                if (sqlConnection == null)
                {
                    MessageBox.Show("Nao foi possivel abrir a tabela codigos",
                       "CODr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlCommand comando = new SqlCommand(comandoSQL, sqlConnection);
                comando.Parameters.AddWithValue("titulo", titulo.Trim());
                comando.Parameters.AddWithValue("descricao", descricao.Trim());
                comando.Parameters.AddWithValue("idCat", idCat);
                comando.Parameters.AddWithValue("path", path);

                comando.ExecuteNonQuery();
                sqlConnection.Close();
                return;
            }
            catch (Exception err)
            {
                MessageBox.Show("Nao foi possivel adicionar a categoria \n" + err,
                        "CODr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        public static ClassSnippet AbreNota(string id)
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
            SQL = "SELECT * FROM codigos WHERE codigos.Id = @id";

            SqlCommand sqlCommand = new SqlCommand(SQL, sqlConnection);
            sqlCommand.Parameters.AddWithValue("id", id.Trim());
            //ojeto para armazenar o que o resultado do comando (SQL, SELECT....)
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //verificar se tem linhas o resultado (sqlDataReader)
            if (sqlDataReader.Read())
            {
                //exite estudante
                //criar um objto mdo tipo ClassNotas
                ClassSnippet nota = new ClassSnippet();
                nota.id = id;
                nota.titulo = sqlDataReader["titulo"].ToString();
                nota.descricao = sqlDataReader["descricao"].ToString();
                nota.id_categoria = int.Parse(sqlDataReader["id_categoria"].ToString());
                nota.path = sqlDataReader["path"].ToString();
                return nota;
            }
            else
            {
                //Não exite
                return null;
            }

        }
    }
}
