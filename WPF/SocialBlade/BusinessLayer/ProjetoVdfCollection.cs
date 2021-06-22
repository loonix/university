using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProjetoVdfCollection : List<ProjetoVdf>
    {

        #region Contrutor

        public ProjetoVdfCollection()
        {
                
        }

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
            DateTime dataPedido = projetoVdf.DataInicioPedido.AddDays(-14);
            DateTime dataFim = DateTime.Today;
            ///string nomePV = "Bruno Faria";
            //EstadoNegocioEnum Proposal = EstadoNegocioEnum.Proposal;


            int count = this.PedidossEntreDatas(dataPedido, dataFim);

            return count;
        }
        
        private int PedidossEntreDatas(DateTime dataPedido, DateTime dataFim)
        {
            int count = (from element in this
                         where element.DataInicioPedido >= dataPedido && element.DataInicioPedido <= dataFim &&
                         element.EstadoNegocio != EstadoNegocioEnum.Proposal
                         select element).Count();
            return count;
        }

        public IEnumerable<ProjetoVdf> ObterListaProjetosPorAno()
        {
            int ano = DateTime.Today.Year;
                                
            IEnumerable<ProjetoVdf> Projetos = from element in this
                                        where element.DataDaProposta.Year == ano
                                        orderby element.DataDaProposta, element.Cliente descending
                                        select element;

            return Projetos;
        }

        //public float ObterMediaProjetosMes()
        //{
        //    float media = (float)(from element in this
        //                          where element.MesCorrente()
        //                          select element.IdWo).Average();
        //    return media;
        //}
        /// <summary>
        /// /##########################################################################################################
        /// </summary>
        /// <returns></returns>
        public float SelecionarMediaporPV()
        {
            string nomePV1 = "Bruno Faria";
            //string nomePV2 = "Nuno Sousa";       
            //string nomePV3 = "Ricardo Oliveira";




            float count = ObterMediaProjetosPorPV(nomePV1);
            return count;
        }

        public float ObterMediaProjetosPorPV(string nomePV1)
        {
            float mediaProjetosPV = 0;

            IEnumerable<long> listafiltrada = from element in this
                                     where element.NomePV == nomePV1 && element.MesCorrente()
                                             select element.IdWo;
            if (listafiltrada.Count()>0)
            {
                 mediaProjetosPV = (float)listafiltrada.Average();
            }
            

            return mediaProjetosPV;
        }

        //public float ObterMediaProjetosMes (EnumTipoMesdoAno grau)
        //{
        //    float totalValorProjetos = (from element in this
        //                                where element.DataInicioPedido >= grau
        //                                select element.Valor).Sum();

        //    return totalValorProjetos;
        //}
        //public string Mesdoano()
        //{
        //    string janeiro = 
        //    DateTime dataFim = DateTime.Today;
        //    //string nomePV = "Bruno Faria";


        //    int count = this.PedidossEntreDatas(dataPedido, dataFim);

        //    return count;
        //}
        //public float ObterMediaProjetosMes1()
        //{
        //    float media = (float)(from element in this
        //                          where element.DataDaProposta.Month == 
        //                          select element.IdWo).Average();
        //    return media;
        //}




        public string SelecionarPV()
        {
            string nomePV = projetoVdf.NomePV;
            string nome = FiltrarPV(nomePV);


            return nome;
        }
        public string FiltrarPV(string nomePV)
        {
            
            string nome = (from element in this
                           where element.NomePV == nomePV
                           select element).ToString();

            return nome;
        }



        #endregion

        #region Metodos



        #endregion
    }
}
