using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados
{
    public class BDGlobal
    {
        internal static SqlConnection OpenDatabase()
        {
            SqlConnection sqlConnection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=programacao2;Data Source=DESKTOP-5BF80AR\\SQLEXPRESS");
            sqlConnection.Open();

            return sqlConnection;
        }
    }
}
