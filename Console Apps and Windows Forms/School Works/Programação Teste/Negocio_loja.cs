  public class Loja
    {

        #region Construtor

        public Loja()
        {
            this.codigoLoja = 0;
            this.descricao = string.Empty;
            this.morada = string.Empty;
            this.area = 0;
            this.dataInicioAtividade = DateTime.Today;
        }

        #endregion

        #region Propriedades

        private int codigoLoja;
        public int CodigoLoja
        {
            get { return codigoLoja; }
            set { codigoLoja = value; }
        }

        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private string morada;
        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }

        private float area;
        public float Area
        {
            get { return area; }
            set { area = value; }
        }

        private DateTime dataInicioAtividade;
        public DateTime DataInicioAtividade
        {
            get { return dataInicioAtividade; }
            set { dataInicioAtividade = value; }
        }

        #endregion

        #region Metodos

        public void Novo()
        {
            DateTime data = DateTime.Today;

            this.CodigoLoja = 0;
            this.Descricao = string.Empty;
            this.Morada = string.Empty;
            this.Area = 0;
            this.DataInicioAtividade = new DateTime(data.Year, data.Month, 1);
        }

        public bool Gravar(out string erro)
        {
            erro = string.Empty;

            bool ok = CamadaDados.Loja.Gravar(this.CodigoLoja, this.Descricao, 
                                              this.Morada, this.Area, this.DataInicioAtividade, 
                                              out erro);

            return ok;
        }

        public bool Eliminar(out string erro)
        {
            erro = string.Empty;

            bool ok = CamadaDados.Loja.Eliminar(this.CodigoLoja, out erro);

            return ok;
        }

        public static Loja Obter(int codigoLoja, out string erro)
        {
            Loja loja = null;
            erro = string.Empty;
            
            string descricao = string.Empty;
            string morada = string.Empty;
            float area = 0;
            DateTime dataInicioAtividade = DateTime.Today;

            bool ok = CamadaDados.Loja.Obter(codigoLoja, ref descricao, ref morada, ref area, 
                        ref dataInicioAtividade, out erro);
            if (ok)
            {
                loja = new Loja();
                loja.CodigoLoja = codigoLoja;
                loja.Descricao = descricao;
                loja.Morada = morada;
                loja.Area = area;
                loja.DataInicioAtividade = dataInicioAtividade;
            }

            return loja;
        }

        public static LojaCollection ObterLista()
        {
            DataTable dataTable = CamadaDados.Loja.ObterLista();

            LojaCollection lojas = new LojaCollection(dataTable);

            return lojas;
        }

        public static LojaCollection ObterListaSimples()
        {
            DataTable dataTable = CamadaDados.Loja.ObterListaSimples();

            LojaCollection lojas = new LojaCollection(dataTable);

            return lojas;
        }

        #endregion

    }