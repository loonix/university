 public partial class FormComboio : Form
    {
        #region Construtores

        public FormComboio()
        {
            InitializeComponent();
        }

        #endregion

        #region Propriedades

        #endregion

        #region Metodos

        private void Gravar()
        {
            string erro = string.Empty;

            if (this.DadosValidos())
            {
                Comboio comboio = this.ObterComboio();

                bool ok = comboio.Gravar(out erro);

                if (ok)
                {
                    MessageBox.Show(Properties.Resources.MESSAGE_GRAVADO_COM_SUCESSO);
                }
                else
                {
                    MessageBox.Show(GlobalDLL.GlobalTexto.Format(Properties.Resources.MESSAGE_ERRO_A_GRAVAR, erro));
                }
            }
        }

        private bool DadosValidos()
        {
            bool ok = true;

            string codigoComboioTexto = this.codigoComboioTextBox.Text;
            string numeroLugaresTexto = this.numeroLugaresTextBox.Text;
            DateTime dataFabrico = this.dataFabricoDateTimePicker.Value;
            string modeloTexto = this.modeloTextBox.Text;

            int numeroLugares = 0;

            this.comboioErrorProvider.Clear();

            //Os objetos texto não podem estar vazios

            if (string.IsNullOrWhiteSpace(codigoComboioTexto))
            {
                this.comboioErrorProvider.SetError(this.codigoComboioTextBox, "Código não definido");
                ok = false;
            }
            else if (string.IsNullOrWhiteSpace(modeloTexto))
            {
                this.comboioErrorProvider.SetError(this.modeloTextBox, Properties.Resources.MESSAGE_MODELO_NAO_DEFINIDO);
                ok = false;
            }

            //NumeroLugares tem de estar entre [1 - 9]
            else if (!int.TryParse(numeroLugaresTexto, out numeroLugares))
            {
                this.comboioErrorProvider.SetError(this.numeroLugaresTextBox, "Nº de lugares não definido");
                ok = false;
            }
            //V1
            //else if (numeroLugares < 1 || numeroLugares > 9)
            //V2
            //else if (!(numeroLugares >= 1 && numeroLugares <= 9))
            //V3
            else if ((numeroLugares >= 1 && numeroLugares <= 9) == false)
            {
                this.comboioErrorProvider.SetError(this.numeroLugaresTextBox, "Nº de lugares tem de estar entre [1-9]");
                ok = false;
            }

            //Data tem de ser >= que hoje
            else if (dataFabrico < DateTime.Today)
            {
                this.comboioErrorProvider.SetError(this.dataFabricoDateTimePicker, "Date de fabrico tem de ser >= que hoje");
                ok = false;
            }

            //Data tem de ser do ano corrente
            else if (dataFabrico.Year != DateTime.Today.Year)
            {
                this.comboioErrorProvider.SetError(this.dataFabricoDateTimePicker, "Data de fabrico tem de ser do ano corrente");
                ok = false;
            }

            //Data de fabrico não pode ser superior à data de hoje mais de 20 dias 
            else if (dataFabrico > DateTime.Today.AddDays(20))
            {
                this.comboioErrorProvider.SetError(this.dataFabricoDateTimePicker, "Data de fabrico não pode ser superior à data de hoje mais de 20 dias");
                ok = false;
            }

            //O Modelo tem de ter pelo menos 5 caracteres
            //V1
            //else if (modeloTexto.Length < 5)
            //V2
            else if (GlobalTexto.ObterNumeroCaracteres(modeloTexto) < 5)
            {
                this.comboioErrorProvider.SetError(this.modeloTextBox, "O Modelo tem de ter pelo menos 5 caracteres");
                ok = false;
            }

            //O Modelo tem de ter pelo menos 2 palavras
            else if (GlobalTexto.ObterNumeroPalavras(modeloTexto) < 2)
            {
                this.comboioErrorProvider.SetError(this.modeloTextBox, "O Modelo tem de ter pelo menos 2 palavras");
                ok = false;
            }

            return ok;
        }


        private Comboio ObterComboio()
        {
            Comboio comboio = new Comboio();

            string codigoComboioTexto = this.codigoComboioTextBox.Text;
            string numeroLugaresTexto = this.numeroLugaresTextBox.Text;

            comboio.CodigoComboio = long.Parse(codigoComboioTexto);
            comboio.DataFabrico = this.dataFabricoDateTimePicker.Value;
            comboio.Modelo = this.modeloTextBox.Text;
            comboio.NumeroLugares = int.Parse(numeroLugaresTexto);

            return comboio;
        }

        private void Eliminar()
        {
            string erro = string.Empty;
            Comboio comboio = new Comboio();

            string codigoComboioTexto = this.codigoComboioTextBox.Text;

            long codigoComboio = 0;


            if (long.TryParse(codigoComboioTexto, out codigoComboio))
            {
                comboio.CodigoComboio = codigoComboio;

                bool ok = comboio.Eliminar(out erro);

                if (ok)
                {
                    MessageBox.Show("Eliminado com sucesso");
                }
                else
                {
                    MessageBox.Show(string.Format("Erro a Eliminado [{0}]", erro));
                }
            }
            else
            {
                MessageBox.Show("Código do comboio não definido");
            }
        }

        private void CarregarComboio()
        {
            string codigoComboioTexto = this.codigoComboioTextBox.Text;

            long codigoComboio = 0;

            if (long.TryParse(codigoComboioTexto, out codigoComboio))
            {
                string erro = string.Empty;

                Comboio comboio = Comboio.Obter(codigoComboio, out erro);
                if (comboio == null)
                {
                    //MessageBox.Show(string.Format("Comboio [{0}] não existe na BD. Erro[{1}]", codigoComboio, erro));
                    //IGUAL
                    MessageBox.Show(GlobalDLL.GlobalTexto.Format(Properties.Resources.MESSAGE_COMBOIO_NAO_EXISTE, codigoComboio, erro));
                }
                else
                {
                    this.MostrarComboio(comboio);
                }
            }
        }

        private void MostrarComboio(Comboio comboio)
        {
            if (comboio == null)
            {
                return;
            }

            this.codigoComboioTextBox.Text = comboio.CodigoComboio.ToString();
            this.dataFabricoDateTimePicker.Value = comboio.DataFabrico;
            this.modeloTextBox.Text = comboio.Modelo;
            this.numeroLugaresTextBox.Text = comboio.NumeroLugares.ToString();
        }

        private void MostarListaComboios()
        {
            //ProjetoListaForm projetoListaForm = new ProjetoListaForm();

            //projetoListaForm.ShowDialog();
        }

        private void Sair()
        {
            this.Close();
            Application.Exit();
        }

        private void Novo()
        {
            Comboio comboio = new Comboio();

            comboio.Novo();

            this.MostrarComboio(comboio);
        }

        private void CarregarResources()
        {
            this.gravarButton.Text = Properties.Resources.GRAVAR_BUTTON;
        }

        #endregion

        #region Eventos

        private void gravarButton_Click(object sender, EventArgs e)
        {
            this.Gravar();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }


        private void codigoComboioTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CarregarComboio();
            }
        }
        
        private void listaButton_Click(object sender, EventArgs e)
        {
            this.MostarListaComboios();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Sair();
        }

        private void novo_Click(object sender, EventArgs e)
        {
            this.Novo();
        }

        private void FormComboio_Load(object sender, EventArgs e)
        {
            this.CarregarResources();
        }

        #endregion

    }