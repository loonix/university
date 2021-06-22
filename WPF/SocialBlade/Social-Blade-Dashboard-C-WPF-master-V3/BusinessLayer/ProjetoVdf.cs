using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
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
            this.nomePV = string.Empty;

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
        /// Método publico void não estatico, inicializa o formulario e os seus objectos para novo preenchimento
        /// </summary>
        public void Novo()

        {
            DateTime data = DateTime.Today;

            this.IdWo = 0;
            this.DuracaoContrato = string.Empty;
            this.Cliente = string.Empty;
            this.DataInicioPedido = DateTime.Today;
            this.DataDaProposta = DateTime.Today;
            this.Latitude = string.Empty;
            this.Longitude = string.Empty;
            this.TipoNegocio = TipoNegocioEnum.Ataque;
            this.EstadoNegocio = EstadoNegocioEnum.Inprogress;
            this.NomePV = string.Empty;
        }

        /// <summary>
        /// Função boleana, inicia como falsa, 2 variaveis com propriedades da classe DateTime que indicam ano e mes 
        /// do dia de hoje. Método usado na função Linq para calculo das médias dos projetos por mês realizados
        /// </summary>
        /// <returns>retorna ok</returns>

        internal bool MesCorrente()
        {
            bool ok = false;

            int ano = DateTime.Today.Year;
            int mes = DateTime.Today.Month;

            if (this.DataDaProposta.Year == ano &&
                this.dataDaProposta.Month == mes)
            {
                ok = true;
            }

            return ok;
        }

      

        /// <summary>
        ///Metodo publico Boleano Gravar que devolve o Método gravar da camada de dados. 
        ///Usadas propriedades publicas definidas na camada de negocio.
        /// </summary>
        /// <returns>retorna Metodo eliminar  +  out string Erro  </returns>
        public bool Gravar(out string erro)
        {
            erro = string.Empty;

            bool ok = DataLayer.ProjetoVdf.Gravar(this.IdWo, this.Cliente, this.DataInicioPedido, this.DataDaProposta, this.DuracaoContrato,
                                               this.Latitude, this.Longitude, (int)this.TipoNegocio, (int)this.EstadoNegocio, this.NomePV,
                                              out erro);

            return ok;
        }

        /// <summary>
        ///Metodo publico Boleano Eliminar que devolve o Método eliminar da camada de dados. 
        ///Usada propriedade publica do IdWo para obter dados.     
        /// </summary>
        /// <returns>retorna metodo eliminar canada de dados atraves da propriedade IdWo </returns>
        public bool Eliminar(out string erro)
        {
            erro = string.Empty;

            bool ok = DataLayer.ProjetoVdf.Eliminar(this.IdWo, out erro);

            return ok;
        }

        /// <summary>
        /// Método publico void não estatico que limpa todos os objetos
        /// </summary>
        public void Limpar()
        {
          
            string cliente = string.Empty;
            string nomePV = string.Empty;
            DateTime dataInicioPedido = DateTime.Today;
            DateTime dataDaProposta = DateTime.Today;
            string duracaoContrato = string.Empty;
            string latitude = string.Empty;
            string longitude = string.Empty;
            int tipoNegocio = 0;
            int estadoNegocio = 0;


        }
        /// <summary>
        /// Método publico estatico que inicialmente inicializa os objetos e utiliza um boleano 
        /// para obter por referencia os dados do método Obter da camada de Dados. 
        /// Definida nova instancia ProjetoVdf que coloca os dados obtidos por referencia 
        /// nas propriedades publicas definidas. Boleano devolve a instancia com a estrutura.
        /// </summary>
        public static ProjetoVdf Obter(long idWo, out string erro)
        {
            ProjetoVdf projetoVdf = null;
            erro = string.Empty;

            string cliente = string.Empty;
            string nomePV = string.Empty;
            DateTime dataInicioPedido = DateTime.Today;
            DateTime dataDaProposta = DateTime.Today;
            string duracaoContrato = string.Empty;
            string latitude = string.Empty;
            string longitude = string.Empty;
            int tipoNegocio = 0;
            int estadoNegocio = 0;


            bool ok = DataLayer.ProjetoVdf.Obter(idWo, ref cliente, ref dataInicioPedido, ref dataDaProposta, ref duracaoContrato,
                        ref latitude, ref longitude, ref tipoNegocio, ref estadoNegocio, ref nomePV, out erro);
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

        
        /// <summary>
        /// Metodo publico estatico da class ProjetoVdfCollection para obter lista de Projetos.
        /// Definida nova instancia / objeto da classe DataTable que obtem metodo 
        /// ObterLista no formato DataTable do namespace camada de dados.
        /// Definida instancia do ProjetoVdfCollection que coloca a DataTable na class collection List ProjetoVdf
        /// </summary>
        /// <returns></returns>
        public static ProjetoVdfCollection ObterListaSimples()
        {
            //DataLayer.ProjetoVdf.ObterLista();   
            
            DataTable dataTable = DataLayer.ProjetoVdf.ObterLista();

            ProjetoVdfCollection projetos = new ProjetoVdfCollection(dataTable);

            return projetos;
        }

        
        #endregion

    }
}
