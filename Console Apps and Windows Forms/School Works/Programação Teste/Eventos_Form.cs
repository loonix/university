   #region Eventos

        private void Form1_Load(object sender, EventArgs e)
        {
            //[3.1]
            this.novoButton.Text = Properties.Resources.GLOBAL_MENU_NOVO;
            this.gravarButton.Text = Properties.Resources.GLOBAL_MENU_GRAVAR;
            this.eliminarButton.Text = Properties.Resources.GLOBAL_MENU_ELIMINAR;
            this.sairButton.Text = Properties.Resources.GLOBAL_MENU_SAIR;
        }

        //[3.2]
        private void novo_Click(object sender, EventArgs e)
        {
            this.Novo();
        }

        //[3.2]
        private void gravar_Click(object sender, EventArgs e)
        {
            this.Gravar();
        }

        //[3.2]
        private void eliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }

        //[3.2]
        private void sair_Click(object sender, EventArgs e)
        {
            this.Sair();
        }

        //[3.3]
        private void consultaAdvogadoTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.VerificarMostrarConsultaAdvogado();
            }
        }

        //[3.4]
        private void obterListaButton_Click(object sender, EventArgs e)
        {
            this.EventoObterListaConsultaAdvogado();
        }

        //[3.5]
        private void totalButton_Click(object sender, EventArgs e)
        {
            this.CalcularTempoConsultaMesCorrente();
        }

        //[4.2]
        private void exemplificarFuncaoButton_Click(object sender, EventArgs e)
        {
            string texto = this.autorLabel.Text;
            string resultado = CamadaNegocio.Funcoes.FormatarNome(texto);
            this.autorLabel.Text = resultado;
        }

        #endregion


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