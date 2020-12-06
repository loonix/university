using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class Comboio
    {

        #region Construtor

        public Comboio()
        {
            this.codigoComboio = 0;
            this.numeroLugares = 0;
            this.dataFabrico = DateTime.Today;
            this.modelo = string.Empty;
        }

        #endregion

        #region Propriedades

        private long codigoComboio;
        public long CodigoComboio
        {
            get { return codigoComboio; }
            set { codigoComboio = value; }
        }

        private int numeroLugares;
        public int NumeroLugares
        {
            get { return numeroLugares; }
            set { numeroLugares = value; }
        }

        private DateTime dataFabrico;
        public DateTime DataFabrico
        {
            get { return dataFabrico; }
            set { dataFabrico = value; }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        #endregion

        #region Metodos

        public void Novo()
        {
            DateTime data = DateTime.Today;

            this.CodigoComboio = 0;
            this.NumeroLugares = 0;
            this.DataFabrico = new DateTime(data.Year, data.Month, 1);
            this.Modelo = string.Empty;
        }

        public bool Gravar(out string erro)
        {
            erro = string.Empty;

            bool ok = CamadaDados.Comboio.Gravar(this.CodigoComboio, this.NumeroLugares, 
                                              this.DataFabrico, this.Modelo, 
                                              out erro);

            return ok;
        }

        public bool Eliminar(out string erro)
        {
            erro = string.Empty;

            bool ok = CamadaDados.Comboio.Eliminar(this.CodigoComboio, out erro);

            return ok;
        }

        public static Comboio Obter(long codigoComboio, out string erro)
        {
            Comboio comboio = null;
            erro = string.Empty;
            
            string modelo = string.Empty;
            int numeroLugares = 0;
            DateTime dataFabrico = DateTime.Today;

            bool ok = CamadaDados.Comboio.Obter(codigoComboio, ref numeroLugares, ref dataFabrico, ref modelo, out erro);
            if (ok)
            {
                comboio = new Comboio();
                comboio.CodigoComboio = codigoComboio;
                comboio.NumeroLugares = numeroLugares;
                comboio.DataFabrico = dataFabrico;
                comboio.Modelo = modelo;
            }

            return comboio;
        }

        public static ComboioCollection ObterLista()
        {
            DataTable dataTable = CamadaDados.Comboio.ObterLista();

            ComboioCollection comboios = new ComboioCollection(dataTable);

            return comboios;
        }

        #endregion

    }
}
