using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class LojaCollection : List<Loja>
    {

        #region Contrutor

        public LojaCollection(DataTable dataTable)
        {
            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.AsEnumerable())
                {
                    Loja loja = new Loja();

                    loja.CodigoLoja = dataRow.Field<int>("CodigoLoja");
                    loja.Descricao = dataRow.Field<string>("Descricao");

                    if (dataTable.Columns.Contains("Morada"))
                    {
                        loja.Morada = dataRow.Field<string>("Morada");
                    }

                    if (dataTable.Columns.Contains("Area"))
                    {
                        loja.Area = dataRow.Field<float>("Area");
                    }
                    if (dataTable.Columns.Contains("DataInicioAtividade"))
                    {
                        loja.DataInicioAtividade = dataRow.Field<DateTime>("DataInicioAtividade");
                    }
                    this.Add(loja);
                }   
            }
        }

        #endregion

        #region Metodos

        #endregion
    }
}
