using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados
{
    public class ProjetoVdf
    {

        #region Metodos

        public static bool Gravar(long idWo, string cliente,
                                  DateTime dataInicioPedido, DateTime dataDaProposta, string duracaoContrato, string latitude, string longitude, int tipoNegocio, int estadoNegocio, string nomePV, out string erro)
        {
            erro = string.Empty;
            bool ok = true;

            try
            {
                //SqlConnection sqlConnection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Programacao1;Data Source=DEVJC\\SQL2008R2");
                //sqlConnection.Open();
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("GravarProjetoVdf", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("IdWo", System.Data.SqlDbType.BigInt);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = idWo;

                sqlParameter = sqlCommand.Parameters.Add("Cliente", System.Data.SqlDbType.NVarChar, 100);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = cliente;

                sqlParameter = sqlCommand.Parameters.Add("DataInicioPedido", System.Data.SqlDbType.DateTime);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = dataInicioPedido;

                sqlParameter = sqlCommand.Parameters.Add("DataDaProposta", System.Data.SqlDbType.DateTime);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = dataDaProposta;

                sqlParameter = sqlCommand.Parameters.Add("DuracaoContrato", System.Data.SqlDbType.NVarChar, 30);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = duracaoContrato;

                sqlParameter = sqlCommand.Parameters.Add("Latitude", System.Data.SqlDbType.NVarChar, 20);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = latitude;        
                
                sqlParameter = sqlCommand.Parameters.Add("Longitude", System.Data.SqlDbType.NVarChar, 20);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = longitude;

                sqlParameter = sqlCommand.Parameters.Add("TipoNegocio", System.Data.SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = tipoNegocio;

                sqlParameter = sqlCommand.Parameters.Add("EstadoNegocio", System.Data.SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = estadoNegocio;

                sqlParameter = sqlCommand.Parameters.Add("NomePV", System.Data.SqlDbType.NVarChar, 20);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = nomePV;



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

        public static bool Obter(long idWo,
                                 ref string cliente, ref DateTime dataInicioPedido, ref DateTime dataDaProposta,

                                 ref string duracaoContrato, ref string latitude, ref string longitude, ref int tipoNegocio,  ref int estadoNegocio, ref string nomePV, out string erro)
        {
            bool ok = false;
            erro = string.Empty;

            try
            {
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("ObterProjetoVdf", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("IdWo", System.Data.SqlDbType.BigInt);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = idWo;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    if (!sqlDataReader.IsDBNull(1))
                    {
                        cliente = sqlDataReader.GetString(1);
                    }
                    if (!sqlDataReader.IsDBNull(2))
                    {
                        dataInicioPedido = sqlDataReader.GetDateTime(2);
                    }
                    if (!sqlDataReader.IsDBNull(3))
                    {
                        dataDaProposta = sqlDataReader.GetDateTime(3);
                    }
                    if (!sqlDataReader.IsDBNull(4))
                    {
                        duracaoContrato = sqlDataReader.GetString(4);
                    }
                    if (!sqlDataReader.IsDBNull(5))
                    {
                        latitude = sqlDataReader.GetString(5);
                    }
                    if (!sqlDataReader.IsDBNull(6))
                    {
                        longitude = sqlDataReader.GetString(6);
                    }
                    if (!sqlDataReader.IsDBNull(7))
                    {
                        tipoNegocio = sqlDataReader.GetInt32(7);
                    }
                    ok = true;
                    if (!sqlDataReader.IsDBNull(8))
                    {
                        estadoNegocio = sqlDataReader.GetInt32(8);
                    }
                    if (!sqlDataReader.IsDBNull(9))
                    {
                       nomePV = sqlDataReader.GetString(9);
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

                SqlCommand sqlCommand = new SqlCommand("ListarProjetoVdf", sqlConnection);
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

        public static bool Eliminar(long idWo, out string erro)
        {
            erro = string.Empty;
            bool ok = true;

            try
            {
                //SqlConnection sqlConnection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Programacao1;Data Source=DEVJC\\SQL2008R2");
                //sqlConnection.Open();
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("EliminarProjetoVdf", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("IdWo", System.Data.SqlDbType.BigInt);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = idWo;

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
