using System.Data.SqlClient;

namespace CamadaDados
{
    public class BDGlobal
    {
        /// <summary>
        /// Abre a base de dados
        /// </summary>
        /// <returns>Retorna a conecao a base de dados</returns>
        internal static SqlConnection OpenDatabase()
        {
            SqlConnection sqlConnection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=notas;Data Source=DESKTOP-5BF80AR\\SQLEXPRESS");
            sqlConnection.Open();

            return sqlConnection;
        }
    }
}
