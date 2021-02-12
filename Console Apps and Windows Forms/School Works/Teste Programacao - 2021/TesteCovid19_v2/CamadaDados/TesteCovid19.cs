

using System;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class TesteCovid19
    {
        #region Metodos
        public static bool Gravar(string codTeste, string nome, DateTime dataTeste, int idadeCidadao, int resultadoTeste, out string erro)
        {
            erro = string.Empty;
            bool ok = true;

            try
            {
                SqlConnection sqlConnection = GlobalData.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("Gravar_TesteCovid19", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("CodigoTesteCovid19", System.Data.SqlDbType.NVarChar, 10);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = codTeste;

                sqlParameter = sqlCommand.Parameters.Add("Nome", System.Data.SqlDbType.NVarChar, 90);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = nome;

                sqlParameter = sqlCommand.Parameters.Add("DataTeste", System.Data.SqlDbType.DateTime);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = dataTeste;

                sqlParameter = sqlCommand.Parameters.Add("IdadeCidadao", System.Data.SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = idadeCidadao;

                sqlParameter = sqlCommand.Parameters.Add("ResultadoTeste", System.Data.SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = resultadoTeste;

                sqlCommand.ExecuteNonQuery();

                sqlParameter = null;
                sqlCommand.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
                ok = false;
            }
            return ok;
        }

        public static bool Obter(string codTeste, ref string nome, ref DateTime dataTeste, ref int idadeCidadao, ref int resultadoTeste, out string erro)
        {
            bool ok = false;
            erro = string.Empty;

            try
            {
                SqlConnection sqlConnection = GlobalData.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("Obter_TesteCovid19", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("CodigoTesteCovid19", System.Data.SqlDbType.NVarChar, 10);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = codTeste;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    if (!sqlDataReader.IsDBNull(1))
                    {
                        nome = sqlDataReader.GetString(1);
                    }
                    if (!sqlDataReader.IsDBNull(2))
                    {
                        dataTeste = sqlDataReader.GetDateTime(2);
                    }
                    if (!sqlDataReader.IsDBNull(3))
                    {
                        idadeCidadao = sqlDataReader.GetInt32(3);
                    }
                    if (!sqlDataReader.IsDBNull(4))
                    {
                        resultadoTeste = sqlDataReader.GetInt32(4);
                    }

                    ok = true;
                }

                sqlParameter = null;
                sqlCommand.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
                ok = false;
            }
            return ok;
        }

        public static DataTable ObterLista()
        {
            DataTable dataTable = null;
            try
            {
                SqlConnection sqlConnection = GlobalData.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("Listar_TesteCovid19", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult);

                dataTable = new DataTable();
                dataTable.Load(dataReader);

                sqlCommand.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataTable;
        }

        public static bool Eliminar(string codTeste, out string erro)
        {
            erro = string.Empty;
            bool ok = true;

            try
            {
                SqlConnection sqlConnection = GlobalData.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("Eliminar_TesteCovid19", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("IDNota", System.Data.SqlDbType.NVarChar, 10);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = codTeste;

                sqlCommand.ExecuteNonQuery();

                sqlParameter = null;
                sqlCommand.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
                ok = false;
            }

            return ok;
        }

        #endregion

    }

}
