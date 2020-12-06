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
    public class Loja
    {

        #region Metodos

        public static bool Gravar(int codigoLoja, string descricao,
                                  string morada, float area, DateTime dataInicioAtividade, out string erro)
        {
            erro = string.Empty;
            bool ok = true;

            try
            {
                //SqlConnection sqlConnection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Programacao1;Data Source=DEVJC\\SQL2008R2");
                //sqlConnection.Open();
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("Gravar_Loja", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("CodigoLoja", System.Data.SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = codigoLoja;

                sqlParameter = sqlCommand.Parameters.Add("Descricao", System.Data.SqlDbType.NVarChar, 90);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = descricao;

                sqlParameter = sqlCommand.Parameters.Add("Morada", System.Data.SqlDbType.NVarChar, 100);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = morada;

                sqlParameter = sqlCommand.Parameters.Add("Area", System.Data.SqlDbType.Real);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = area;

                sqlParameter = sqlCommand.Parameters.Add("DataInicioAtividade", System.Data.SqlDbType.DateTime);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = dataInicioAtividade;

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

        public static bool Obter(int codigoLoja,
                                 ref string descricao, ref string morada, 
                                 ref float area, ref DateTime dataInicioAtividade, out string erro)
        {
            bool ok = false;
            erro = string.Empty;

            try
            {
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("Obter_Loja", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("CodigoLoja", System.Data.SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = codigoLoja;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    if (!sqlDataReader.IsDBNull(1))
                    {
                        descricao = sqlDataReader.GetString(1);
                    }
                    if (!sqlDataReader.IsDBNull(2))
                    {
                        morada = sqlDataReader.GetString(2);
                    }
                    if (!sqlDataReader.IsDBNull(3))
                    {
                        area = sqlDataReader.GetFloat(3);
                    }
                    if (!sqlDataReader.IsDBNull(4))
                    {
                        dataInicioAtividade = sqlDataReader.GetDateTime(4);
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

                SqlCommand sqlCommand = new SqlCommand("Listar_Loja", sqlConnection);
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

        public static DataTable ObterListaSimples()
        {
            DataTable dataTable = null;
            try
            {
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("SELECT CodigoLoja, Descricao FROM Loja", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.Text;

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

        public static bool Eliminar(int codigoLoja, out string erro)
        {
            erro = string.Empty;
            bool ok = true;

            try
            {
                //SqlConnection sqlConnection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Programacao1;Data Source=DEVJC\\SQL2008R2");
                //sqlConnection.Open();
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("Eliminar_Loja", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("CodigoLoja", System.Data.SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = codigoLoja;

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
