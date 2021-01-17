using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class ProjetoVdfCollection : List<ProjetoVdf>
    {

        #region Contrutor

        public ProjetoVdfCollection(DataTable dataTable)
        {
            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.AsEnumerable())
                {
                    ProjetoVdf projetovdf = new ProjetoVdf();

                    projetovdf.IdWo = dataRow.Field<long>("IdWo");
                    projetovdf.Cliente = dataRow.Field<string>("Cliente");
                    projetovdf.NomePV = dataRow.Field<string>("NomePV");
                    projetovdf.DataInicioPedido = dataRow.Field<DateTime>("DataInicioPedido");
                    projetovdf.DataDaProposta = dataRow.Field<DateTime>("DataDaProposta");
                    projetovdf.DuracaoContrato = dataRow.Field<string>("DuracaoContrato");
                    projetovdf.Latitude = dataRow.Field<string>("Latitude");
                    projetovdf.Longitude = dataRow.Field<string>("Longitude");

                    projetovdf.TipoNegocio = dataRow.Field<TipoNegocioEnum>("TipoNegocio");
                    projetovdf.EstadoNegocio = dataRow.Field<EstadoNegocioEnum>("EstadoNegocio");

                    this.Add(projetovdf);
                }   
            }
        }

        ProjetoVdf projetoVdf = new ProjetoVdf();
        public int ContarProjetosPropostaApresentadaSuperior2Semanas()
        {
            DateTime dataInicio = projetoVdf.DataInicioPedido.AddDays(-14);
            DateTime dataFim = DateTime.Today;

            //V1
            //int count = this.Count(k => k.DataEdicao >= dataInicio && k.DataEdicao <= dataFim);

            //V2
            int count = this.ContarProjetosEntreDatas(dataInicio, dataFim);

            return count;
        }

        private int ContarProjetosEntreDatas(DateTime dataInicio, DateTime dataFim)
        {
            int count = (from element in this
                         where element.DataInicioPedido >= dataInicio && element.DataInicioPedido <= dataFim
                         select element).Count();
              return count;
        }

        public string SelecionarPV()
        {
            string nomePV = projetoVdf.NomePV;
            string nome = FiltrarPV(nomePV);

            return nome;
        }
        public string FiltrarPV(string nomePV)
        {
            //V1
            //int count = this.Count(k => k.DataEdicao >= dataInicio && k.DataEdicao <= dataFim);

            //V2
            string nome = (from element in this
                           where element.NomePV  == nomePV
                           select element).ToString();

            return nome;
        }



        #endregion

        #region Metodos



        #endregion
    }
}
