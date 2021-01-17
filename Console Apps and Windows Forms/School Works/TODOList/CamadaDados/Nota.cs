using System;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class Nota
    {
        #region Metodos
        public static bool Gravar(string idNota, string titulo, DateTime dataCriacao, DateTime dataExpiracao, int tags, string conteudo, bool destaque, out string erro)
        {
            erro = string.Empty;
            bool ok = true;

            try
            {
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("GravarNota", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("IDNota", System.Data.SqlDbType.NVarChar, 10);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = idNota;

                sqlParameter = sqlCommand.Parameters.Add("Titulo", System.Data.SqlDbType.NVarChar, int.MaxValue);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = titulo;

                sqlParameter = sqlCommand.Parameters.Add("DataCriacao", System.Data.SqlDbType.DateTime);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = dataCriacao;

                sqlParameter = sqlCommand.Parameters.Add("DataExpiracao", System.Data.SqlDbType.DateTime);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = dataExpiracao;

                sqlParameter = sqlCommand.Parameters.Add("Tags", System.Data.SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = tags;

                sqlParameter = sqlCommand.Parameters.Add("Conteudo", System.Data.SqlDbType.NVarChar, int.MaxValue);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = conteudo;

                sqlParameter = sqlCommand.Parameters.Add("Destaque", System.Data.SqlDbType.Bit);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = destaque;

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

        public static bool Obter(string idNota, ref string titulo, ref DateTime dataCriacao, ref DateTime dataExpiracao, ref int tags, ref string conteudo, ref bool destaque, out string erro)
        {
            bool ok = false;
            erro = string.Empty;

            try
            {
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("ObterNota", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("IDNota", System.Data.SqlDbType.NVarChar, 10);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = idNota;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    if (!sqlDataReader.IsDBNull(1))
                    {
                        titulo = sqlDataReader.GetString(1);
                    }
                    if (!sqlDataReader.IsDBNull(2))
                    {
                        dataCriacao = sqlDataReader.GetDateTime(2);
                    }
                    if (!sqlDataReader.IsDBNull(3))
                    {
                        dataExpiracao = sqlDataReader.GetDateTime(3);
                    }
                    if (!sqlDataReader.IsDBNull(4))
                    {
                        tags = sqlDataReader.GetInt32(4);
                    }
                    if (!sqlDataReader.IsDBNull(5))
                    {
                        conteudo = sqlDataReader.GetString(5);
                    }
                    if (!sqlDataReader.IsDBNull(6))
                    {
                        destaque = sqlDataReader.GetBoolean(6);
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
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("ListarNota", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

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

        public static bool Eliminar(string idNota, out string erro)
        {
            erro = string.Empty;
            bool ok = true;

            try
            {
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("EliminarNota", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("IDNota", System.Data.SqlDbType.NVarChar, 10);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = idNota;

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
