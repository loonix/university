 #region Metodos

        public static bool Gravar(long codigoComboio, int numeroLugares,
                                  DateTime dataFabrico, string modelo, out string erro)
        {
            erro = string.Empty;
            bool ok = true;

            try
            {
                //SqlConnection sqlConnection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Programacao1;Data Source=DEVJC\\SQL2008R2");
                //sqlConnection.Open();
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("GravarComboio", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("CodigoComboio", System.Data.SqlDbType.BigInt);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = codigoComboio;

                sqlParameter = sqlCommand.Parameters.Add("NumeroLugares", System.Data.SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = numeroLugares;

                sqlParameter = sqlCommand.Parameters.Add("DataFabrico", System.Data.SqlDbType.DateTime);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = dataFabrico;

                sqlParameter = sqlCommand.Parameters.Add("Modelo", System.Data.SqlDbType.NVarChar, 25);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = modelo;

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

        public static bool Obter(long codigoComboio,
                                 ref int numeroLugares, ref DateTime dataFabrico, 
                                 ref string modelo, out string erro)
        {
            bool ok = false;
            erro = string.Empty;

            try
            {
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("ObterComboio", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("CodigoComboio", System.Data.SqlDbType.BigInt);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = codigoComboio;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    if (!sqlDataReader.IsDBNull(1))
                    {
                        numeroLugares = sqlDataReader.GetInt32(1);
                    }
                    if (!sqlDataReader.IsDBNull(2))
                    {
                        dataFabrico = sqlDataReader.GetDateTime(2);
                    }
                    if (!sqlDataReader.IsDBNull(3))
                    {
                        modelo = sqlDataReader.GetString(3);
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

                SqlCommand sqlCommand = new SqlCommand("ListarComboio", sqlConnection);
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

        public static bool Eliminar(long codigoComboio, out string erro)
        {
            erro = string.Empty;
            bool ok = true;

            try
            {
                //SqlConnection sqlConnection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Programacao1;Data Source=DEVJC\\SQL2008R2");
                //sqlConnection.Open();
                SqlConnection sqlConnection = BDGlobal.OpenDatabase();

                SqlCommand sqlCommand = new SqlCommand("EliminarComboio", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = sqlCommand.Parameters.Add("CodigoComboio", System.Data.SqlDbType.BigInt);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = codigoComboio;

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