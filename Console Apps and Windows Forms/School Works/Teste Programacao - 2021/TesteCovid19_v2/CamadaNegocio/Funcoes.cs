using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class Funcoes
    {        

        public static bool CheckDatabase()
        {
            bool ok = false;

            try
            {
                SqlConnection sqlConnection = CamadaDados.GlobalData.OpenDatabase();
                if (sqlConnection != null)
                {
                    ok = true;
                }
            }
            catch (Exception ex)
            {
                ok = false;
            }

            return ok;
        }

    }
}
