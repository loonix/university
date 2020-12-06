using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class ComboioCollection : List<Comboio>
    {

        #region Construtor

        public ComboioCollection(DataTable dataTable)
        {
            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.AsEnumerable())
                {
                    Comboio comboio = new Comboio();

                    comboio.CodigoComboio = dataRow.Field<long>("CodigoComboio");
                    comboio.NumeroLugares = dataRow.Field<int>("NumeroLugares"); 
                    comboio.DataFabrico = dataRow.Field<DateTime>("DataFabrico"); 
                    comboio.Modelo = dataRow.Field<string>("Modelo"); 

                    this.Add(comboio);
                }   
            }
        }

        #endregion

        #region Metodos

        #endregion
    }
}
