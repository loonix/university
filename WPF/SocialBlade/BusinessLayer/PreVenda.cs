using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BusinessLayer
{
   public class PreVenda
    {

        public PreVenda()
        {
            this.nomePV = string.Empty;

        }

        private string nomePV;

        public string NomePV
        {
            get { return nomePV; }
            set { nomePV = value; }
        }



        public static PreVendaCollection ObterListaSimples()
        {
            //DataLayer.ProjetoVdf.ObterLista();   

            DataTable dataTable = DataLayer.PreVenda.ObterLista();

            PreVendaCollection preVendas = new PreVendaCollection(dataTable);

            return preVendas;
        }


    }
}
