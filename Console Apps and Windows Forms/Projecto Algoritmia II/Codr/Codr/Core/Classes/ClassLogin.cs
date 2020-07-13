using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Codr.Core.Classes
{
    public static class ClassLogin
    {
        /// <summary>
        /// Logs the user into the software
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static bool SignIn(string user, string pwd)
        {
            try
            {
                SqlConnection sqlConnection = ClassBD.OpenDatabase();
                string sqlCmd = "SELECT * FROM users WHERE username=@username AND password=@password";

                if (sqlConnection == null)
                {
                    MessageBox.Show("Unable to open users",
                       "CODr | Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string hasPassw = ClassCryptography.GenerateSHA512String(pwd.Trim());

                SqlCommand sqlCommand = new SqlCommand(sqlCmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("username", user.Trim());
                sqlCommand.Parameters.AddWithValue("password", hasPassw);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


                if (sqlDataReader.Read() == true)
                {
                    // Logged in successfully
                    sqlDataReader.Close();
                    return true;
                }
                sqlDataReader.Close();
                return false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Unable to login \n" + err,
                        "CODr | Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Allows users to register in the app
        /// </summary>
        /// <param name="name"></param>
        /// <param name="user"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static bool Register(string name, string user, string pwd)
        {
            try
            {
                SqlConnection sqlConnection = ClassBD.OpenDatabase();

                string sqlCmd = "INSERT INTO users (name, userName, password) VALUES (@name, @userName, @password)";

                if (sqlConnection == null)
                {
                    MessageBox.Show("Unable to open users",
                       "CODr | Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string hasPassw = ClassCryptography.GenerateSHA512String(pwd.Trim());

                SqlCommand sqlCommand = new SqlCommand(sqlCmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("name", name.Trim());
                sqlCommand.Parameters.AddWithValue("userName", user.Trim());
                sqlCommand.Parameters.AddWithValue("password", hasPassw);

                int execute = sqlCommand.ExecuteNonQuery();

                if (execute > 0)
                {
                    // Logged in successfully
                    sqlConnection.Close();
                    return true;
                }
                sqlConnection.Close();
                return false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Unable to register \n" + err,
                        "CODr | Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
