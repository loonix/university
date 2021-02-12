5.	No user control ”UserControlData”.
5.1.	Crie a propriedade “Texto” que mostra o seu conteúdo no label “textoLabel”.
5.2.	Crie o método “ObterInformacao”, com um parâmetro string “texto” e altere o label “informacaoLabel” com o valor do parâmetro.
5.3.	Crie um evento “TextoClick”, que atua sempre que se faz click sobre o label “textoLabel
5.4.	Exemplifique no Form ”FormConsultaAdvogado” a propriedade, método e evento do UserControlData. 


//User Control class

 public partial class UserControlData : UserControl
    {
        #region Contrutores

        public UserControlData()
        {
            InitializeComponent();
            this.MostrarData();
        }

        #endregion

        #region Propriedades

        //[5.1]
        private string texto;
        public string Texto
        {
            get { return texto; }
            set
            {
                this.texto = value;
                this.textoLabel.Text = value;
            }
        }

        private Color corFundoTexto;

        public Color CorFundoTexto
        {
            get { return corFundoTexto; }
            set
            {
                corFundoTexto = value;
                this.textoLabel.BackColor = value;
            }
        }

        private bool dataComHora;

        public bool DataComHora
        {
            get { return dataComHora; }
            set
            {
                dataComHora = value;
                this.MostrarData();
            }
        }

        #endregion

        #region Eventos

        //[5.2]
        public event EventHandler TextoClick;
        
        //[5.2]
        public void OnTextoClick()
        {
            if (this.TextoClick != null)
            {
                this.TextoClick(this, new EventArgs());
            }
        }

        //[5.2]
        private void textoLabel_Click(object sender, EventArgs e)
        {
            this.OnTextoClick();
        }

        private void UserControlRodape_Resize(object sender, EventArgs e)
        {
            this.textoLabel.Left = 0;
            this.textoLabel.Height = this.Height;
            this.textoLabel.Top = 0;
            this.textoLabel.Width = this.Width / 2;

            this.textoLabel.Left = this.textoLabel.Width;
            this.textoLabel.Height = this.Height;
            this.textoLabel.Top = 0;
            this.textoLabel.Width = this.Width / 2;
        }

        #endregion

        #region Metodos

        //[5.2]
        public void ObterInformacao(string texto)
        {
            this.informacaoLabel.Text = texto;
        }

        private void MostrarData()
        {
            string data = string.Empty;
            if (this.DataComHora)
            {
                data = DateTime.Today.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            }
            else
            {
                data = DateTime.Today.ToLongDateString();
            }

            this.informacaoLabel.Text = data;
        }

        public void LimparTexto()
        {
            this.textoLabel.Text = string.Empty;
        }


        #endregion

    }
 
 
// formconsultaAdvogado
 private void userControlData_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Ocorreu o evento up");
        }

        private void exemplificarUserControlButton_Click(object sender, EventArgs e)
        {
            this.userControlData.LimparTexto();
            this.userControlData.CorFundoTexto = Color.Red;
            this.userControlData.Texto = "Exemplo";
            this.userControlData.DataComHora = true;
        }