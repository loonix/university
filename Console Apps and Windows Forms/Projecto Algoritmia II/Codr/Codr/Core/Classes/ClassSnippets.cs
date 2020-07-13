using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Codr.Core.Classes.ClassBD;

namespace Codr.Core.Classes
{
    class ClassSnippets
    {

        /// <summary>
        /// Creates a new code snippet and also adds a new file on the main proj folder
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="id_extension"></param>
        /// <returns></returns>
        public static string AddSnippet(string title, string description, string id_extension)
        {
            try
            {
                string extName = ClassExtensions.GetExtensionName(int.Parse(id_extension));

                SqlConnection sqlConnection = ClassBD.OpenDatabase();

                string sqlCmd = "INSERT INTO snippets (title, description, id_extension, path) VALUES " +
                    "(@title, @description, @id_extension, @path)";

                if (sqlConnection == null)
                {
                    MessageBox.Show("Unable to open snippets",
                       "CODr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }

                string filePath = extName + "\\" + title + extName;

                SqlCommand comando = new SqlCommand(sqlCmd, sqlConnection);
                comando.Parameters.AddWithValue("title", title.Trim());
                comando.Parameters.AddWithValue("description", description.Trim());
                comando.Parameters.AddWithValue("id_extension", id_extension);
                comando.Parameters.AddWithValue("path", filePath);

                comando.ExecuteNonQuery();
                sqlConnection.Close();
                return filePath;
            }
            catch (Exception err)
            {
                MessageBox.Show("Nao foi possivel adicionar a extension \n" + err,
                        "CODr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

        }

        /// <summary>
        /// Function that edits a particular snippet, creates a new file
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="id_extension"></param>
        /// <returns></returns>
        public static string EditSnippet(int id, string title, string description, string id_extension)
        {
            try
            {
                string extName = ClassExtensions.GetExtensionName(int.Parse(id_extension));

                SqlConnection sqlConnection = ClassBD.OpenDatabase();

                string sqlCmd = "UPDATE snippets " +
                    "SET title=@title, description=@description, id_extension=@id_extension, path=@path " +
                    "WHERE id=@id";

                if (sqlConnection == null)
                {
                    MessageBox.Show("Unable to open snippets",
                       "CODr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }

                string filePath = extName + "\\" + title + extName;

                SqlCommand comando = new SqlCommand(sqlCmd, sqlConnection);
                comando.Parameters.AddWithValue("id", id);
                comando.Parameters.AddWithValue("title", title.Trim());
                comando.Parameters.AddWithValue("description", description.Trim());
                comando.Parameters.AddWithValue("id_extension", id_extension);
                comando.Parameters.AddWithValue("path", filePath);

                comando.ExecuteNonQuery();
                sqlConnection.Close();
                return filePath;
            }
            catch (Exception err)
            {
                MessageBox.Show("Unable to edit this snippet \n" + err,
                        "CODr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

        }

        /// <summary>
        /// Gets a specific snippet by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ClassSnippet OpenSnippet(string id)
        {

            // Opens DB
            SqlConnection sqlConnection = ClassBD.OpenDatabase();
            // checks if sql connection is successfull
            if (sqlConnection == null)
            {
                return null;
            }

            // creates the sql select command
            string SQL;
            SQL = "SELECT * FROM snippets WHERE snippets.id = @id";

            SqlCommand sqlCommand = new SqlCommand(SQL, sqlConnection);
            sqlCommand.Parameters.AddWithValue("id", id.Trim());
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            // checks if there is data
            if (sqlDataReader.Read())
            {
                // creates a new snippet and assigns data to it
                ClassSnippet snippet = new ClassSnippet();
                snippet.id = id;
                snippet.title = sqlDataReader["title"].ToString();
                snippet.description = sqlDataReader["description"].ToString();
                snippet.id_extension = int.Parse(sqlDataReader["id_extension"].ToString());
                snippet.path = sqlDataReader["path"].ToString();
                return snippet;
            }
            else
            {
                // Does not exist
                return null;
            }

        }
    }
}
