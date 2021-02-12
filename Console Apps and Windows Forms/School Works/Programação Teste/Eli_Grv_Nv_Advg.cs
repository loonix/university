  private void Novo()
        {
            ConsultaAdvogado consultaAdvogado = new ConsultaAdvogado();
            consultaAdvogado.Novo();
            this.MostrarConsultaAdvogado(consultaAdvogado);
        }

        private void MostrarConsultaAdvogado(ConsultaAdvogado consultaAdvogado)
        {
            this.consultaAdvogadoTextBox.Text = consultaAdvogado.CodigoConsultaAdvogado;
            this.dataInicioDateTimePicker.Value = consultaAdvogado.DataConsulta;
            this.idadeClienteTextBox.Text = consultaAdvogado.IdadeCliente.ToString();
            this.duracaoConsultaMinutostextBox.Text = consultaAdvogado.DuracaoConsultaMinutos.ToString();
        }

 private void Sair()
        {
            this.Close();
            Application.Exit();
        }
	//#############################################################	
	//FormConsultaAdvogado
		 private ConsultaAdvogado GetConsultaAdvogado(bool soChave)
        {
             ConsultaAdvogado consultaAdvogado = new CamadaNegocio.ConsultaAdvogado();

            string codigoConsultaAdvogado = this.consultaAdvogadoTextBox.Text;
            consultaAdvogado.CodigoConsultaAdvogado = codigoConsultaAdvogado;
			
            if (!soChave)
            {
                int idadeCliente = 0;
                int duracaoConsultaMinutos = 0;

                consultaAdvogado.DataConsulta = this.dataInicioDateTimePicker.Value;
                if (int.TryParse(this.idadeClienteTextBox.Text, out idadeCliente))
                {
                    consultaAdvogado.IdadeCliente = idadeCliente;
                }
                if (int.TryParse(this.duracaoConsultaMinutostextBox.Text, out duracaoConsultaMinutos))
                {
                    consultaAdvogado.DuracaoConsultaMinutos = duracaoConsultaMinutos;
                }
            }
            return consultaAdvogado;

 //##############################################################################
 private void Gravar()
        {
            string mensagemErro = string.Empty;
            string caminhoErro = string.Empty;

            if (this.ValoresValidos(false) == true)
            {
                ConsultaAdvogado consultaAdvogado = this.GetConsultaAdvogado(false);

                if (consultaAdvogado != null)
                {
                    bool ok = consultaAdvogado.Gravar(out mensagemErro, out caminhoErro);
                    if (!ok)
                    {
                        MessageBox.Show(string.Format(Properties.Resources.GLOBAL_ERROR,
                                                        mensagemErro,
                                                        caminhoErro));
                    }
                    else
                    {
                        MessageBox.Show(Properties.Resources.GLOBAL_GRAVADO_COM_SUCESSO);
                    }
                }
                else
                {
                    MessageBox.Show("Registo não definido!");
                }
            }
        }
 
 
 
 private void Eliminar()
        {
            string mensagemErro = string.Empty;
            string caminhoErro = string.Empty;

            if (this.ValoresValidos(false))
            {
                ConsultaAdvogado consultaAdvogado = this.GetConsultaAdvogado(true);

                if (consultaAdvogado != null)
                {
                    bool ok = consultaAdvogado.Eliminar(out mensagemErro, out caminhoErro);
                    if (!ok)
                    {
                        MessageBox.Show("Erro:" + mensagemErro + "\n" +
                            " Caminho:" + caminhoErro);
                    }
                    else
                    {
                        MessageBox.Show("Registo eliminado.");
                        this.Novo();
                    }
                }
                else
                {
                    MessageBox.Show("Registo não definido!");
                }
            }
        }
		
		