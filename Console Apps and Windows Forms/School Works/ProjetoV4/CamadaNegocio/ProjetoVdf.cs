using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{
    public class ProjetoVdf
    {

        #region Construtor

        public ProjetoVdf()
        {
            this.idWo = 0;
            this.cliente = string.Empty;
            this.dataInicioPedido = DateTime.Today;
            this.dataDaProposta = DateTime.Today;
            this.duracaoContrato = string.Empty;
            this.latitude = string.Empty;
            this.longitude = string.Empty;
            this.nomePV= string.Empty;

        }

        #endregion

        #region Propriedades

        private long idWo;
        public long IdWo
        {
            get { return idWo; }
            set { idWo = value; }
        }

        private string cliente;
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private DateTime dataInicioPedido;
        public DateTime DataInicioPedido
        {
            get { return dataInicioPedido; }
            set { dataInicioPedido = value; }
        }

        private DateTime dataDaProposta;

        public DateTime DataDaProposta
        {
            get { return dataDaProposta; }
            set { dataDaProposta = value; }
        }


        private string duracaoContrato;
        public string DuracaoContrato
        {
            get { return duracaoContrato; }
            set { duracaoContrato = value; }
        }
        private string latitude;
        public string Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        private string longitude;
        public string Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        private TipoNegocioEnum tiponegocio;

        public TipoNegocioEnum TipoNegocio
        {
            get { return tiponegocio; }
            set { tiponegocio = value; }
        }
      
        private EstadoNegocioEnum estadonegocio;
        public EstadoNegocioEnum EstadoNegocio
        {
            get { return estadonegocio; }
            set { estadonegocio = value; }
        }
        private string nomePV;

        public string NomePV
        {
            get { return nomePV; }
            set { nomePV = value; }
        }


        #endregion


        #region Metodos
        /// <summary>
        /// ksalkhjaslkjdaslkjdalkadsjlkadsj
        /// </summary>
        public void Novo()

        {

            DateTime data = DateTime.Today;

            this.IdWo = 0;
            this.DuracaoContrato = string.Empty;
            this.Cliente = string.Empty;
            this.DataInicioPedido = new DateTime(data.Year, data.Month, 1);
            this.DataDaProposta = new DateTime(data.Year, data.Month, 30);
            this.Latitude = string.Empty;
            this.Longitude = string.Empty;
            this.TipoNegocio = TipoNegocioEnum.Ataque;
            this.EstadoNegocio = EstadoNegocioEnum.Inprogress;
            this.NomePV = string.Empty;
        }
        /// <summary>
        /// ksalkhjaslkjdaslkjdalkadsjlkadsj
        /// </summary>
        public bool Gravar(out string erro)
        {
            erro = string.Empty;

            bool ok = CamadaDados.ProjetoVdf.Gravar(this.IdWo, this.Cliente, this.DataInicioPedido, this.DataDaProposta, this.DuracaoContrato, 
                                               this.Latitude, this.Longitude, (int)this.TipoNegocio,(int)this.EstadoNegocio, this.NomePV,
                                              out erro);

            return ok;
        }

        public bool Eliminar(out string erro)
        {
            erro = string.Empty;

            bool ok = CamadaDados.ProjetoVdf.Eliminar(this.IdWo, out erro);

            return ok;
        }

        public static ProjetoVdf Obter(long idWo, out string erro)
        {
            ProjetoVdf projetoVdf = null;
            erro = string.Empty;
            
            string cliente = string.Empty;
            string nomePV = string.Empty;
            DateTime dataInicioPedido = DateTime.Today;
            DateTime dataDaProposta = DateTime.Today;
            string duracaoContrato = string.Empty;
            string latitude  = string.Empty;
            string longitude = string.Empty;
            int tipoNegocio = 0;
            int estadoNegocio = 0;
           

            bool ok = CamadaDados.ProjetoVdf.Obter(idWo, ref cliente, ref dataInicioPedido, ref dataDaProposta, ref duracaoContrato, 
                        ref latitude, ref longitude, ref tipoNegocio, ref estadoNegocio, ref nomePV,  out erro);
            if (ok)
            {
                projetoVdf = new ProjetoVdf();
                projetoVdf.IdWo = idWo;
                projetoVdf.Cliente = cliente;
                projetoVdf.NomePV = nomePV;
                projetoVdf.DataInicioPedido = dataInicioPedido;
                projetoVdf.DataDaProposta = dataDaProposta;
                projetoVdf.DuracaoContrato = duracaoContrato;
                projetoVdf.Latitude = latitude;
                projetoVdf.Longitude = longitude;
                projetoVdf.TipoNegocio = (TipoNegocioEnum)tipoNegocio; 
                projetoVdf.EstadoNegocio = (EstadoNegocioEnum)estadoNegocio;

            }

            return projetoVdf;
        }

        public static ProjetoVdfCollection ObterListaProjetos()
        {
            DataTable dataTable = CamadaDados.ProjetoVdf.ObterLista();

            ProjetoVdfCollection projetos = new ProjetoVdfCollection(dataTable);

            return projetos;
        }

        public static ProjetoVdfCollection ObterListaSimples()
        {
            DataTable dataTable = CamadaDados.ProjetoVdf.ObterLista();

            ProjetoVdfCollection projetos = new ProjetoVdfCollection(dataTable);

            return projetos;
        }

        #endregion

    }
}
