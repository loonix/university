using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PreVendaCollection : List<PreVenda>
    {

        #region Contrutor

        public PreVendaCollection()
        {
                
        }

        public PreVendaCollection(DataTable dataTable)
        {
            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.AsEnumerable())
                {
                    PreVenda preVenda = new PreVenda();



                    preVenda.NomePV = dataRow.Field<string>("NomePV");
                    this.Add(preVenda);                 

                }

                
                    
            }
        }
        #endregion 

    }
}
