  public partial class ProjetoForm : Form
    {
        #region Construtores

        public ProjetoForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Propriedades

        #endregion

        #region Metodos

        private void CarregarResources()
        {
            this.Text = Properties.Resources.TITULO_PROJETO;
            this.gravarButton.Text = Properties.Resources.GRAVAR_BUTTON;
            this.gravarToolStripMenuItem.Text = Properties.Resources.GRAVAR_BUTTON;
        }

        private void Gravar()
        {
            string erro = string.Empty;

            if (this.DadosValidos())
            {
                Projeto projeto = this.ObterProjeto();

                bool ok = projeto.Gravar(out erro);

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

            string idProjeto = this.idProjetoTextBox.Text;
            string descricao = this.descricaoTextBox.Text;
            string textoValor = this.valorTextBox.Text;
            float valor = 0;
            DateTime dataInicio = this.dataInicioDateTimePicker.Value;
            DateTime dataFim = this.dataFimDateTimePicker.Value;

            this.errorProviderProjeto.Clear();

            //O IDProjeto não pode ser vazio ou só espaços
            if (string.IsNullOrWhiteSpace(idProjeto))
            {
                //MessageBox.Show(Properties.Resources.MESSAGE_ID_PROJETO_INVALIDO);
                this.errorProviderProjeto.SetError(this.idProjetoTextBox, Properties.Resources.MESSAGE_CODIGO_COMBOIO_INVALIDO);
                ok = false;
            }
            //O Descrição não pode ser vazia ou só espaços
            if (string.IsNullOrWhiteSpace(descricao))
            {
                //MessageBox.Show(Properties.Resources.MESSAGE_ID_PROJETO_INVALIDO);
                this.errorProviderProjeto.SetError(this.descricaoTextBox, Properties.Resources.MESSAGE_DESCRICAO_PROJETO_INVALIDO);
                ok = false;
            }
            //A Descrição tem de ter pelo menos 5 caracteres
            if (descricao.Length < 5)
            {
                this.errorProviderProjeto.SetError(this.descricaoTextBox, "A descrição tem de ter mais de 5 caracteres");
                ok = false;
            }
            //A dataInicio não pode ser superior à data de fim
            if (dataInicio > dataFim)
            {
                this.errorProviderProjeto.SetError(this.dataInicioDateTimePicker, Properties.Resources.MESSAGE_DATA_INICIO_SUPERIOR_DATAFIM);
                this.dataInicioDateTimePicker.Focus();
                ok = false;
            }
            //O Ano da data de fim e da data de inicio tem de ser iguais
            //if (dataInicio.Year != dataFim.Year)
            //{
            //    this.errorProviderProjeto.SetError(this.dataInicioDateTimePicker, "A data de inicio não tem o mesmo ano da data de fim");
            //    this.dataInicioDateTimePicker.Focus();
            //    ok = false;
            //}
            //A data de inicio não pode ser inferior à data de hoje
            if (dataInicio > DateTime.Today)
            {
                this.errorProviderProjeto.SetError(this.dataInicioDateTimePicker, "A data de inicio não pode ser inferior à data de hoje");
                this.dataInicioDateTimePicker.Focus();
                ok = false;
            }
            //A data de fim tem de ser superior à data de hoje + 20 dias
            if (dataFim < DateTime.Today.AddDays(20))
            {
                this.errorProviderProjeto.SetError(this.dataInicioDateTimePicker, "A data de fim tem de ser superior à data de hoje + 20 dias");
                this.dataInicioDateTimePicker.Focus();
                ok = false;
            }
            //A diferença entre a data de inicio e a data de fim não pode ser superior a 80 dias
            TimeSpan timeSpan = dataFim.Subtract(dataInicio);
            if (timeSpan.TotalDays > 80)
            {
                this.errorProviderProjeto.SetError(this.dataInicioDateTimePicker, "A distância em dias entre data de inicio e a data de fim não pode ser superior a 80 dias");
                this.dataInicioDateTimePicker.Focus();
                ok = false;
            }

            //O Valor tem de ser válido
            if (!float.TryParse(textoValor, out valor))
            {
                //V1
                this.errorProviderProjeto.SetError(this.valorTextBox, "Valor Inválido [" + textoValor + "]");
                //V2
                this.errorProviderProjeto.SetError(this.valorTextBox, string.Format("Valor Inválido [{0}]", textoValor));
                //V3
                this.errorProviderProjeto.SetError(this.valorTextBox, string.Format(Properties.Resources.MESSAGE_VALOR_INVALIDO, textoValor));
                //V4
                this.errorProviderProjeto.SetError(this.valorTextBox, GlobalDLL.GlobalTexto.Format(Properties.Resources.MESSAGE_VALOR_INVALIDO, textoValor));

                this.valorTextBox.Focus();
                ok = false;
            }
            //O valor não pode ser negativo
            else if (valor < 0)
            {
                this.errorProviderProjeto.SetError(this.valorTextBox, "valor não pode ser negativo");
                this.valorTextBox.Focus();
                ok = false;
            }
            //O valor tem de estar entre [1 - 100]
            else if (valor < 1 || valor > 100)
            {
                this.errorProviderProjeto.SetError(this.valorTextBox, "valor tem de estar compreendido entre [1 e 100]");
                this.valorTextBox.Focus();
                ok = false;
            }

            return ok;
        }

        private Projeto ObterProjeto()
        {
            Projeto projeto = new Projeto();

            projeto.IDProjeto = this.idProjetoTextBox.Text;
            projeto.Descricao = this.descricaoTextBox.Text;
            projeto.DataInicio = this.dataInicioDateTimePicker.Value;
            projeto.DataFim = this.dataFimDateTimePicker.Value;
            
            string valorTexto = this.valorTextBox.Text;
            float valor = 0;

            if (float.TryParse(valorTexto, out valor))
            {
                projeto.Valor = valor;
            }

            //projeto.Grau = GrauEnum.NaoDefinido;
            //if (this.simplesRadioButton.Checked)
            //{
            //    projeto.Grau = GrauEnum.Simples;            
            //}
            //else if (this.idealRadioButton.Checked)
            //{
            //    projeto.Grau = GrauEnum.Ideal;
            //}
            //else if (this.elevadoRadioButton.Checked)
            //{
            //    projeto.Grau = GrauEnum.Elevado;
            //}

            projeto.Grau = this.grauUserControl.Grau;

            //AtributoProjetoEnum atributo = AtributoProjetoEnum.Nada; 

            //if (this.pagoCheckBox.Checked)
            //{
            //    atributo |= AtributoProjetoEnum.Pago;
            //}
            //if (this.finalizadoCheckBox.Checked)
            //{
            //    //atributo = atributo | AtributoProjetoEnum.Finalizado;
            //    //Significado Igual
            //    atributo |= AtributoProjetoEnum.Finalizado;
            //}
            //if (this.comFinanciamentoCheckBox.Checked)
            //{
            //    atributo |= AtributoProjetoEnum.ComFinanciamento;
            //}

            //projeto.Atributo = atributo;
            projeto.Atributo = this.atributoUserControl.Atributo;

            return projeto;
        }

        private void Eliminar()
        {
            string erro = string.Empty;
            Projeto projeto = new Projeto();

            projeto.IDProjeto = this.idProjetoTextBox.Text;

            bool ok = projeto.Eliminar(out erro);

            if (ok)
            {
                MessageBox.Show("Eliminado com sucesso");
            }
            else
            {
                MessageBox.Show(string.Format("Erro a Eliminado [{0}]", erro));
            }
        }

        private void CarregarProjeto()
        {
            string idProjeto = this.idProjetoTextBox.Text;
            string erro = string.Empty;

            Projeto projeto = Projeto.ObterProjeto(idProjeto, out erro);
            if (projeto == null)
            {
                //MessageBox.Show(string.Format("Projecto[{0}] não existe na BD. Erro[{1}]", idProjeto, erro));
                //IGUAL
                MessageBox.Show(GlobalDLL.GlobalTexto.Format(Properties.Resources.MESSAGE_COMBOIO_NAO_EXISTE, idProjeto, erro));
            }
            else
            {
                this.MostrarProjeto(projeto);
            }
        }

        private void MostrarProjeto(Projeto projeto)
        {
            if (projeto == null)
            {
                return;
            }

            this.idProjetoTextBox.Text = projeto.IDProjeto;
            this.descricaoTextBox.Text = projeto.Descricao;
            this.dataInicioDateTimePicker.Value = projeto.DataInicio;
            this.dataFimDateTimePicker.Value = projeto.DataFim;
            this.valorTextBox.Text = projeto.Valor.ToString();

            //if (projeto.Grau == GrauEnum.Simples)
            //{
            //    this.simplesRadioButton.Checked = true;
            //}
            //else if (projeto.Grau == GrauEnum.Ideal)
            //{
            //    this.idealRadioButton.Checked = true;
            //}
            //else if (projeto.Grau == GrauEnum.Elevado)
            //{
            //    this.elevadoRadioButton.Checked = true;
            //}
            //else
            //{
            //    this.naoDefinidoRadioButton.Checked = true;
            //}
            this.grauUserControl.Grau = projeto.Grau;

            ////  projeto.Atributo = 5
            //// 5 & 1 == 1
            //// 0101 & 0001 == 0001
            ////
            ////   0101
            //// & 0001
            //// ______
            ////   0001

            //this.pagoCheckBox.Checked = ((projeto.Atributo & AtributoProjetoEnum.Pago) == AtributoProjetoEnum.Pago);

            ////  projeto.Atributo = 5
            //// 5 & 1 == 1
            //// 0101 & 0010 == 0010
            ////
            ////   0101
            //// & 0010
            //// ______
            ////   0000
            //this.finalizadoCheckBox.Checked = ((projeto.Atributo & AtributoProjetoEnum.Finalizado) == AtributoProjetoEnum.Finalizado);

            ////  projeto.Atributo = 5
            //// 5 & 1 == 1
            //// 0101 & 0100 == 0100
            ////
            ////   0101
            //// & 0100
            //// ______
            ////   0100
            //this.comFinanciamentoCheckBox.Checked = ((projeto.Atributo & AtributoProjetoEnum.ComFinanciamento) == AtributoProjetoEnum.ComFinanciamento);

            this.atributoUserControl.Atributo = projeto.Atributo;

        }

        private void MostarListaProjetos()
        {
            ProjetoListaForm projetoListaForm = new ProjetoListaForm();

            projetoListaForm.ShowDialog();
        }

        private void Sair()
        {
            this.Close();
            Application.Exit();
        }

        private void Novo()
        {
            Projeto projeto = new Projeto();

            projeto.Novo();

            this.MostrarProjeto(projeto);
        }

        private void CarregarDados()
        {
            //Dictionary<key, value>
            Dictionary<NivelEnum, string> niveis = new Dictionary<NivelEnum, string>();

            niveis.Add(NivelEnum.NaoDefinido, "-");
            niveis.Add(NivelEnum.Normal, "Normal");
            niveis.Add(NivelEnum.Avancado, "Avançado");

            this.nivelComboBox.Enabled = false;

            this.nivelComboBox.DisplayMember = "Value";
            this.nivelComboBox.ValueMember = "Key";

            this.nivelComboBox.DataSource = niveis.ToList();

            this.nivelComboBox.Enabled = true;
        }
        private void SelecionaNivel()
        {
            NivelEnum nivel = NivelEnum.NaoDefinido;

            if (this.nivelComboBox.SelectedIndex > 0)
            {
                nivel = (NivelEnum)this.nivelComboBox.SelectedValue;
            }

            this.grauUserControl.Selecionar(nivel);

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

        private void idProjetoTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CarregarProjeto();
            }
        }

        private void listaButton_Click(object sender, EventArgs e)
        {
            this.MostarListaProjetos();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Sair();
        }

        private void novo_Click(object sender, EventArgs e)
        {
            this.Novo();
        }

        private void ProjetoForm_Load(object sender, EventArgs e)
        {
            this.CarregarDados();
            this.CarregarResources();
        }

        private void nivelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.nivelComboBox.Enabled)
            {
                this.SelecionaNivel();
            }
        }

        private void grauUserControl_SelecionouIdeal(object sender, EventArgs e)
        {
            this.grauUserControl.BackColor = Color.Yellow;
        }

        private void atributoUserControl_TodasAsOpcoes(object sender, EventArgs e)
        {
            MessageBox.Show("Finalizou o projeto");
        }

        private void totalValorButtonV1_Click(object sender, EventArgs e)
        {
            ProjetoCollection projetos = Projeto.ObterListaProjetos();
            float totalValorProjetos = 0;

            foreach (Projeto projeto in projetos)
            {
                totalValorProjetos += projeto.Valor;
            }

            this.totalValorLabel.Text = totalValorProjetos.ToString();
        }

        private void totalValorV2Button_Click(object sender, EventArgs e)
        {
            ProjetoCollection projetos = Projeto.ObterListaProjetos();

            float totalValorProjetos = projetos.ObterTotalValor();

            this.totalValorLabel.Text = totalValorProjetos.ToString();
        }

        private void totalValorV3Button_Click(object sender, EventArgs e)
        {
            ProjetoCollection projetos = Projeto.ObterListaProjetos();

            float totalValorProjetos = projetos.ObterTotalValorV2();

            this.totalValorLabel.Text = totalValorProjetos.ToString();
        }

        #endregion
    }