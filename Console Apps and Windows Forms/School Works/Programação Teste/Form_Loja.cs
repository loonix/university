  public partial class FormLoja : Form
    {
        #region Construtores

        public FormLoja()
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
                Loja loja = this.ObterLoja();

                bool ok = loja.Gravar(out erro);

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
            //string idLoja = this.idLojaTextBox.Text;
            //string descricao = this.descricaoTextBox.Text;
            //DateTime dataInicio = this.dataInicioDateTimePicker.Value;
            //DateTime dataFim = this.dataFimDateTimePicker.Value;

            //this.errorProviderLoja.Clear();

            //if (string.IsNullOrWhiteSpace(idLoja))
            //{
            //    //MessageBox.Show(Properties.Resources.MESSAGE_ID_PROJETO_INVALIDO);
            //    this.errorProviderLoja.SetError(this.idLojaTextBox, Properties.Resources.MESSAGE_CODIGO_COMBOIO_INVALIDO);
            //    ok = false;
            //}
            //if (string.IsNullOrWhiteSpace(descricao))
            //{
            //    //MessageBox.Show(Properties.Resources.MESSAGE_ID_PROJETO_INVALIDO);
            //    this.errorProviderLoja.SetError(this.descricaoTextBox, Properties.Resources.MESSAGE_DESCRICAO_PROJETO_INVALIDO);
            //    ok = false;
            //}
            //if (dataInicio > dataFim)
            //{
            //    this.errorProviderLoja.SetError(this.dataInicioDateTimePicker, Properties.Resources.MESSAGE_DATA_INICIO_SUPERIOR_DATAFIM);
            //    this.dataInicioDateTimePicker.Focus();
            //    ok = false;
            //}

            return ok;
        }

        private Loja ObterLoja()
        {
            Loja loja = new Loja();

            string codigoLojaTexto = this.codigoLojaTextBox.Text;
            string areaTexto = this.areaTextBox.Text;

            loja.CodigoLoja = int.Parse(codigoLojaTexto);
            loja.Descricao = this.descricaoTextBox.Text;
            loja.Morada = this.moradaTextBox.Text;
            loja.DataInicioAtividade = this.dataInicioAtividadeDateTimePicker.Value;
            loja.Area = float.Parse(areaTexto);

            return loja;
        }

        private void Eliminar()
        {
            string erro = string.Empty;
            Loja loja = new Loja();

            string codigoLojaTexto = this.codigoLojaTextBox.Text;
            int codigoLoja = 0;

            if (int.TryParse(codigoLojaTexto, out codigoLoja))
            {
                loja.CodigoLoja = codigoLoja;

                bool ok = loja.Eliminar(out erro);

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
                MessageBox.Show("Codigo da loja inválido");
            }
        }

        private void CarregarLoja()
        {            
            string erro = string.Empty;
            string codigoLojaTexto = this.codigoLojaTextBox.Text;
            int codigoLoja = 0;

            if (int.TryParse(codigoLojaTexto, out codigoLoja))
            {
                Loja loja = Loja.Obter(codigoLoja, out erro);
                if (loja == null)
                {
                    //MessageBox.Show(string.Format("Projecto[{0}] não existe na BD. Erro[{1}]", idLoja, erro));
                    //IGUAL
                    MessageBox.Show(GlobalDLL.GlobalTexto.Format(Properties.Resources.MESSAGE_LOJA_NAO_EXISTE, codigoLoja, erro));
                }
                else
                {
                    this.MostrarLoja(loja);
                }
            }
        }

        private void MostrarLoja(Loja loja)
        {
            if (loja == null)
            {
                return;
            }

            this.codigoLojaTextBox.Text = loja.CodigoLoja.ToString();
            this.descricaoTextBox.Text = loja.Descricao;
            this.moradaTextBox.Text = loja.Morada;
            this.dataInicioAtividadeDateTimePicker.Value = loja.DataInicioAtividade;
            this.areaTextBox.Text = loja.Area.ToString();
        }

        private void MostarListaLojas()
        {
            FormListaLoja formListaLoja = new FormListaLoja();

            formListaLoja.ShowDialog();

            if (formListaLoja.CodigoLoja > 0)
            {
                string erro = string.Empty;
                Loja loja = Loja.Obter(formListaLoja.CodigoLoja, out erro);
                if (loja != null)
                {
                    this.MostrarLoja(loja);
                }
            }
        }

        private void Sair()
        {
            this.Close();
            Application.Exit();
        }

        private void Novo()
        {
            Loja loja = new Loja();

            loja.Novo();

            this.MostrarLoja(loja);
        }

        #endregion

        #region Eventos

        private void gravar_Click(object sender, EventArgs e)
        {
            this.Gravar();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }

        private void codigoLojaTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CarregarLoja();
            }
        }

        private void listaButton_Click(object sender, EventArgs e)
        {
            this.MostarListaLojas();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Sair();
        }

        private void novo_Click(object sender, EventArgs e)
        {
            this.Novo();
        }

        #endregion

    }