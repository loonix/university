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

        #region Contrutor

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

        #endregion

        #region Metodos

        public float ObterTotalValor()
        {
            float totalValorProjetos = 0;

            foreach (Projeto projeto in this)
            {
                totalValorProjetos += projeto.Valor;
            }

            return totalValorProjetos;
        }

        public float ObterTotalValorV2()
        {
            // SELECT SUM(Valor) FROM Projeto WHERE ID = 5
            // FROM Projeto WHERE ID = 5 SELECT SUM(Valor) 
            float totalValorProjetos = (from element in this
                                        select element.Valor).Sum();

            return totalValorProjetos;
        }

        public float ObterMediaValor()
        {
            float mediaValorProjetos = (from element in this
                                        select element.Valor).Average();

            return mediaValorProjetos;
        }

        public float ObterTotalValorProjetosPagos()
        {
            float totalValorProjetos = (from element in this
                                        where (element.Atributo & AtributoProjetoEnum.Pago) == AtributoProjetoEnum.Pago
                                        select element.Valor).Sum();

            return totalValorProjetos;
        }

        public float ObterTotalValorProjetosPagosV2()
        {
            float totalValorProjetos = (from element in this
                                        where element.AtributoPago()
                                        select element.Valor).Sum();

            return totalValorProjetos;
        }

        public float ObterTotalValorProjetosPagosV3()
        {
            float totalValorProjetos = this.Where(k => k.AtributoPago()).Sum(k => k.Valor); 

            return totalValorProjetos;
        }

        public float ObterTotalValorProjetos(GrauEnum grau)
        {
            float totalValorProjetos = (from element in this
                                        where element.Grau == grau
                                        select element.Valor).Sum();

            return totalValorProjetos;
        }


        #endregion
    }
}
