using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Codr.Core.Classes
{
    public class ClassCategories
    {

        public static string SearchCategory(string NomeCategoria)
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
            SQL = "SELECT * FROM categorias WHERE categorias.nome_categoria = @NomeCat";

            SqlCommand sqlCommand = new SqlCommand(SQL, sqlConnection);
            sqlCommand.Parameters.AddWithValue("NomeCat", NomeCategoria.Trim());
            //ojeto para armazenar o que o resultado do comando (SQL, SELECT....)
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //verificar se tem linhas o resultado (sqlDataReader)
            if (sqlDataReader.HasRows)
            {
                //tem linhas (registos)
                //se quisermos ler o primeiro registo temos que fazer
                DataTable table = new DataTable();
                table.Load(sqlDataReader); // Carrega os dados para a datatable
                var id_cat = table.Rows[0].ItemArray[0].ToString();
                //var nome_cat = table.Rows[0].ItemArray[1];
                return id_cat;
            }
            return "";
        }

        public static string AddCategory(string NomeCategoria)
        {
            try
            {
                // verifica se ja existe uma categoria com o mesmo nome
                string catId = SearchCategory(NomeCategoria);

                if (catId != "")
                {
                    return catId;
                }

                SqlConnection sqlConnection = ClassBD.OpenDatabase();
                string comandoSQL = "INSERT INTO categorias (nome_categoria) VALUES (@nome)";

                if (sqlConnection == null)
                {
                    MessageBox.Show("Nao foi possivel abrir a tabela categorias",
                       "CODr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }

                SqlCommand comando = new SqlCommand(comandoSQL, sqlConnection);
                comando.Parameters.AddWithValue("nome", NomeCategoria);
                comando.ExecuteNonQuery();
                sqlConnection.Close();
                return SearchCategory(NomeCategoria);
            }
            catch (Exception err)
            {
                MessageBox.Show("Nao foi possivel adicionar a categoria \n" + err,
                        "CODr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

        }


    }
}
