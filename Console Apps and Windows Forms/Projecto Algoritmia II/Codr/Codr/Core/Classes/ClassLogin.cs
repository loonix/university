using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Codr.Core.Classes
{
    public static class ClassLogin
    {
        public static bool SignIn(string user, string pwd)
        {
            try
            {
                SqlConnection sqlConnection = ClassBD.OpenDatabase();
                string comandoSQL = "SELECT * FROM users WHERE username=@username AND password=@password";

                if (sqlConnection == null)
                {
                    MessageBox.Show("Nao foi possivel abrir a tabela users",
                       "CODr | Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string hasPassw = ClassCryptography.GenerateSHA512String(pwd.Trim());

                SqlCommand sqlCommand = new SqlCommand(comandoSQL, sqlConnection);
                sqlCommand.Parameters.AddWithValue("username", user.Trim());
                sqlCommand.Parameters.AddWithValue("password", hasPassw);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


                if (sqlDataReader.Read() == true)
                {
                   // Logged in successfully
                    return true;
                }
                return false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Unable to login \n" + err,
                        "CODr | Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
