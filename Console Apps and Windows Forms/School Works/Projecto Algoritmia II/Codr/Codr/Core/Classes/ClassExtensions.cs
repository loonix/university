using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Codr.Core.Classes
{
    public class ClassExtensions
    {

        /// <summary>
        /// Gets the extension name by checking the extension id
        /// </summary>
        /// <param name="id_extension"></param>
        /// <returns></returns>
        public static string GetExtensionName(int id_extension)
        {
            SqlConnection sqlConnection = ClassBD.OpenDatabase();

            string SQL;
            SQL = "SELECT name FROM extensions where id=@id_extension";

            SqlCommand sqlExtCommand = new SqlCommand(SQL, sqlConnection);
            sqlExtCommand.Parameters.AddWithValue("id_extension", id_extension);

            SqlDataReader sqlDataReader = sqlExtCommand.ExecuteReader();

            string extName = "";
            while (sqlDataReader.Read())
            {
                extName = sqlDataReader["name"].ToString();
            }

            sqlConnection.Close();

            if (extName == "")
            {
                extName = AddExtension(extName);
            }

            return extName;
        }

        /// <summary>
        /// Searches an extension name and returns the respective ID
        /// </summary>
        /// <param name="extension"></param>
        /// <returns></returns>
        public static string SearchExtensions(string extension)
        {

            SqlConnection sqlConnection = ClassBD.OpenDatabase();
            if (sqlConnection == null)
            {
                return "";
            }

            string SQL;
            SQL = "SELECT * FROM extensions WHERE extensions.name = @extension";

            SqlCommand sqlCommand = new SqlCommand(SQL, sqlConnection);
            sqlCommand.Parameters.AddWithValue("extension", extension.Trim());
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                DataTable table = new DataTable();
                table.Load(sqlDataReader); // loads data to the datatable
                var id_extension = table.Rows[0].ItemArray[0].ToString();
                return id_extension;
            }
            return "";
        }

        /// <summary>
        /// Creates a new extension
        /// </summary>
        /// <param name="extension"></param>
        /// <returns></returns>
        public static string AddExtension(string extension)
        {
            try
            {
                // verifica se ja existe uma categoria com o mesmo nome
                string extId = SearchExtensions(extension);

                if (extId != "")
                {
                    return extId;
                }

                SqlConnection sqlConnection = ClassBD.OpenDatabase();
                string sqlCmd = "INSERT INTO extensions (name) VALUES (@name)";

                if (sqlConnection == null)
                {
                    MessageBox.Show("Unable to open extensions table",
                       "CODr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }

                SqlCommand cmd = new SqlCommand(sqlCmd, sqlConnection);
                cmd.Parameters.AddWithValue("name", extension);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                return SearchExtensions(extension);
            }
            catch (Exception err)
            {
                MessageBox.Show("Unable to create extension \n" + err,
                        "CODr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

        }

        /// <summary>
        /// Deletes an extension by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool DeleteExtension(int id)
        {
            try
            {
                SqlConnection sqlConnection = ClassBD.OpenDatabase();

                string sql = "DELETE FROM extensions WHERE id=@id";
                SqlCommand cmd = new SqlCommand();

                cmd = new SqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("id", id);

                cmd.ExecuteNonQuery();
                sqlConnection.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "CODr",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        /// <summary>
        /// Edits an existing extension and assigns a new name
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newName"></param>
        /// <returns></returns>
        public static bool EditExtension(int id, string newName)
        {
            try
            {
                SqlConnection sqlConnection = ClassBD.OpenDatabase();

                string sql = "UPDATE extensions SET name=@name WHERE id=@id";
                SqlCommand cmd = new SqlCommand();

                cmd = new SqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("name", newName);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "CODr",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }


    }
}
