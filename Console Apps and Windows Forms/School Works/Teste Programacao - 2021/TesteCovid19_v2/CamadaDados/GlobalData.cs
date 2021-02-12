using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados
{
    public class GlobalData
    {

        public static SqlConnection OpenDatabase()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=testeProgramacao;Data Source=DESKTOP-G275AMS\\SQLEXPRESS";
            sqlConnection.Open();

            return sqlConnection;
        }

    }
}
