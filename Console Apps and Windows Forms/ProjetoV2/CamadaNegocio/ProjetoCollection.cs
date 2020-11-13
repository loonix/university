using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class ProjetoCollection : List<Projeto>
    {

        public ProjetoCollection(DataTable dataTable)
        {
            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.AsEnumerable())
                {
                    Projeto projeto = new Projeto();

                    projeto.IDProjeto = dataRow.Field<string>("IDProjeto");
                    projeto.Descricao = dataRow.Field<string>("Descricao"); 
                    projeto.DataInicio = dataRow.Field<DateTime>("DataInicio"); 
                    projeto.DataFim = dataRow.Field<DateTime>("DataFim"); 
                    projeto.Valor = dataRow.Field<float>("Valor");

                    this.Add(projeto);
                }   
            }
        }

    }
}
