using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BDGlobal
    {
        internal static SqlConnection OpenDatabase()
        {
            //SqlConnection sqlConnection = new SqlConnection("Integrated Security=SSPI;" +
            //    "Persist Security Info=False;Initial Catalog=Programacao1;Data Source=BONECOMYDEAR\\SQLEXPRESS");
            SqlConnection sqlConnection = new SqlConnection("Integrated Security=SSPI;" +
                      "Persist Security Info=False;Initial Catalog=Programacao1;Data Source=BONECOMYDEAR\\SQLEXPRESS");
            sqlConnection.Open();

            return sqlConnection;
        }
    }
}
