using System;
using System.Data;
using System.Data.SqlClient;

namespace Codr.Core.Classes
{
    public class ClassBD
    {

        public class ClassSnippet
        {
            public string id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public int id_extension { get; set; }
            public string path { get; set; }
        }

        /// <summary>
        /// Open the sql database connection
        /// </summary>
        /// <returns></returns>
        public static SqlConnection OpenDatabase()
        {
            // reads the projects saved connection string
            string StringConn = Properties.Settings.Default.DB_CodrConnectionString;
            // defines the sql connection
            SqlConnection sqlConnection = new SqlConnection(StringConn);
            // opens db with params
            try
            {
                sqlConnection.Open();
            }
            catch (Exception)
            {
                return null;
            }
            return sqlConnection;
        }

        /// <summary>
        /// Dynamic function that requires the sql command to be passed into
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetData(string sql)
        {
            // opens connection
            SqlConnection sqlConnection = OpenDatabase();

            // creates the sql command from params
            string sqlCmd = sql;

            // sets the command
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand(sqlCmd, sqlConnection);

            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader()); // loads data to datatable

            return table;
        }

    }
}
