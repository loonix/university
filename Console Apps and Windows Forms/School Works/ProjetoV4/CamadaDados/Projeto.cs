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
    public class Projeto
    {

        #region Metodos

        public static bool Gravar(string idProjeto, string descricao,
                                  DateTime dataInicio, DateTime dataFim, float valor, int grau, int atributo, out string erro)
        {
            erro = string.Empty;
            bool ok = true;

            try
            {
                //SqlConnection sqlConnection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Programacao1;Data Source=DEVJC\\SQL2008R2");
                //sqlConnection.Open();
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("ProjetoGravar", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("IDProjeto", System.Data.SqlDbType.NVarChar, 10);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = idProjeto;

                sqlParameter = sqlCommand.Parameters.Add("Descricao", System.Data.SqlDbType.NVarChar, 100);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = descricao;

                sqlParameter = sqlCommand.Parameters.Add("DataInicio", System.Data.SqlDbType.DateTime);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = dataInicio;

                sqlParameter = sqlCommand.Parameters.Add("DataFim", System.Data.SqlDbType.DateTime);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = dataFim;

                sqlParameter = sqlCommand.Parameters.Add("Valor", System.Data.SqlDbType.Real);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = valor;

                sqlParameter = sqlCommand.Parameters.Add("Grau", System.Data.SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = grau;

                sqlParameter = sqlCommand.Parameters.Add("Atributo", System.Data.SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = atributo;

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

        public static bool ObterProjeto(string idProjeto,
                                        ref string descricao, ref DateTime dataInicio, ref DateTime dataFim, 
                                        ref float valor, ref int grau, ref int atributo, out string erro)
        {
            bool ok = false;
            erro = string.Empty;

            try
            {
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("ProjetoObter", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("IDProjeto", System.Data.SqlDbType.NVarChar, 10);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = idProjeto;

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
                        dataInicio = sqlDataReader.GetDateTime(2);
                    }
                    if (!sqlDataReader.IsDBNull(3))
                    {
                        dataFim = sqlDataReader.GetDateTime(3);
                    }
                    if (!sqlDataReader.IsDBNull(4))
                    {
                        valor = sqlDataReader.GetFloat(4);
                    }
                    if (!sqlDataReader.IsDBNull(5))
                    {
                        grau = sqlDataReader.GetInt32(5);
                    }
                    if (!sqlDataReader.IsDBNull(6))
                    {
                        atributo = sqlDataReader.GetInt32(6);
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

        public static DataTable ObterListaProjetos()
        {
            DataTable dataTable = null;
            try
            {
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("ProjetoListar", sqlConnection);
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

        public static bool Eliminar(string idProjeto, out string erro)
        {
            erro = string.Empty;
            bool ok = true;

            try
            {
                //SqlConnection sqlConnection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Programacao1;Data Source=DEVJC\\SQL2008R2");
                //sqlConnection.Open();
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("ProjetoEliminar", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("IDProjeto", System.Data.SqlDbType.NVarChar, 10);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = idProjeto;

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
