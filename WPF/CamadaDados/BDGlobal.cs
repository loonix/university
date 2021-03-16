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
            SqlConnection sqlConnection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Programacao1;Data Source=devjc\\SQL2008R2");
            sqlConnection.Open();

            return sqlConnection;
        }
    }
}
