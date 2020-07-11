using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Codr.Core.Classes
{
    public class ClassCategories
    {

        public static string SearchExtensions(string extension)
        {

            //1. Abrir BD
            SqlConnection sqlConnection = ClassBD.OpenDatabase();
            //verificar sucesso da abertura
            if (sqlConnection == null)
            {
                return "";
            }

            //2. Criar comando SQL SELECT para submeter à BD
            string SQL;
            SQL = "SELECT * FROM extensions WHERE extensions.name = @extension";

            SqlCommand sqlCommand = new SqlCommand(SQL, sqlConnection);
            sqlCommand.Parameters.AddWithValue("extension", extension.Trim());
            //ojeto para armazenar o que o resultado do comando (SQL, SELECT....)
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //verificar se tem linhas o resultado (sqlDataReader)
            if (sqlDataReader.HasRows)
            {
                //tem linhas (registos)
                //se quisermos ler o primeiro registo temos que fazer
                DataTable table = new DataTable();
                table.Load(sqlDataReader); // Carrega os dados para a datatable
                var id_extension = table.Rows[0].ItemArray[0].ToString();
                //var nome_cat = table.Rows[0].ItemArray[1];
                return id_extension;
            }
            return "";
        }

        public static string AddExtension(string extension)
        {
            try
            {
                // verifica se ja existe uma categoria com o mesmo nome
                string catId = SearchExtensions(extension);

                if (catId != "")
                {
                    return catId;
                }

                SqlConnection sqlConnection = ClassBD.OpenDatabase();
                string comandoSQL = "INSERT INTO extensions (name) VALUES (@name)";

                if (sqlConnection == null)
                {
                    MessageBox.Show("Nao foi possivel abrir a tabela extensions",
                       "CODr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }

                SqlCommand comando = new SqlCommand(comandoSQL, sqlConnection);
                comando.Parameters.AddWithValue("name", extension);
                comando.ExecuteNonQuery();
                sqlConnection.Close();
                return SearchExtensions(extension);
            }
            catch (Exception err)
            {
                MessageBox.Show("Nao foi possivel adicionar a extension \n" + err,
                        "CODr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

        }


    }
}
