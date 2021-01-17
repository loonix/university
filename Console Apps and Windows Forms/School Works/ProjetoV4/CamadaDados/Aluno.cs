

using System;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class Aluno
    {
        #region Metodos

        public static bool Gravar(int codigoAluno, string nome,
                                  DateTime dataNascimento, string telefone, out string erro)
        {
            erro = string.Empty;
            bool ok = true;

            try
            {
                //SqlConnection sqlConnection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Programacao1;Data Source=DEVJC\\SQL2008R2");
                //sqlConnection.Open();
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("Gravar_Aluno", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("CodigoAluno", System.Data.SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = codigoAluno;

                sqlParameter = sqlCommand.Parameters.Add("Nome", System.Data.SqlDbType.NVarChar, 95);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = nome;

                sqlParameter = sqlCommand.Parameters.Add("DataNascimento", System.Data.SqlDbType.DateTime);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = dataNascimento;

                sqlParameter = sqlCommand.Parameters.Add("Telefone", System.Data.SqlDbType.NVarChar, 25);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = telefone;

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

        public static bool ObterAluno(int codigoAluno,
                                        ref string nome, ref DateTime dataNascimento, ref string telefone)
        {
            bool ok = false;

            try
            {
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("Obter_Aluno", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("CodigoAluno", System.Data.SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = codigoAluno;

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
                        dataNascimento = sqlDataReader.GetDateTime(2);
                    }
                    if (!sqlDataReader.IsDBNull(3))
                    {
                        telefone = sqlDataReader.GetString(3);
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

        public static DataTable ObterListaAlunos()
        {
            DataTable dataTable = null;
            try
            {
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("Listar_Aluno", sqlConnection);
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

        public static bool Eliminar(int codigoAluno, out string erro)
        {
            erro = string.Empty;
            bool ok = true;

            try
            {
                //SqlConnection sqlConnection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Programacao1;Data Source=DEVJC\\SQL2008R2");
                //sqlConnection.Open();
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("Eliminar_Aluno", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("CodigoAluno", System.Data.SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = codigoAluno;

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
