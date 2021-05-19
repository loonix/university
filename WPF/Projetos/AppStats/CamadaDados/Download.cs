using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados
{
    public class Download
    {
        #region Metodos

        public static bool Obter(string id, ref string appName, ref DateTime timestamp, ref string country, ref string gender)
        {
            bool ok = false;

            try
            {
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("Obter", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("id", System.Data.SqlDbType.VarChar);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = id;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    if (!sqlDataReader.IsDBNull(1))
                    {
                        appName = sqlDataReader.GetString(1);
                    }
                    if (!sqlDataReader.IsDBNull(2))
                    {
                        timestamp = sqlDataReader.GetDateTime(2);
                    }
                    if (!sqlDataReader.IsDBNull(3))
                    {
                        country = sqlDataReader.GetString(3);
                    }
                    if (!sqlDataReader.IsDBNull(4))
                    {
                        gender = sqlDataReader.GetString(4);
                    }
                    ok = true;
                }

                sqlParameter = null;
                sqlCommand.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
                ok = false;
            }


            return ok;
        }

        public static DataTable ObterLista()
        {
            DataTable dataTable = null;
            try
            {
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("Listar", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult);

                dataTable = new DataTable();
                dataTable.Load(dataReader);

                sqlCommand.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
            }
            return dataTable;
        }

       
        #endregion
    }
}
