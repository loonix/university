3.	Form ”FormConsultaAdvogado”.
3.1.	Altere o texto dos botões para resources.
3.2.	Utilize o mesmo evento nos menus e botões equivalentes.
3.3.	Ao fazer “enter” na ”codigoAdvogadoTextBox”, deve validar/obter o conteúdo da textbox e mostrar o registo da consulta do advogado no form.
3.4.	Preencha a ListBox ”consultaAdvogadoListBox” do form ”FormConsultaAdvogado” com a lista de códigos e duração em minutos das consultas.
3.5.	Preencha o label ”resultadoLabel”, com o resultado do total do tempo em minutos das consultas 

        
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
        }
		
		//[3.3]
        private void VerificarMostrarConsultaAdvogado()
        {
            string mensagemErro = string.Empty;
            string caminhoErro = string.Empty;

            if (this.ValoresValidos(true))
            {
                ConsultaAdvogado consultaAdvogado = this.GetConsultaAdvogado(true);
                if (consultaAdvogado != null)
                {
                    consultaAdvogado.ObterConsultaAdvogado(out mensagemErro, out caminhoErro);

                    this.MostrarConsultaAdvogado(consultaAdvogado);
                }
            }
        }

        //[3.4]
        private void EventoObterListaConsultaAdvogado()
        {
            ConsultaAdvogadoCollection consultaAdvogados = ConsultaAdvogado.ObterListaConsultaAdvogado();
            this.PreencherListaConsultaAdvogado(consultaAdvogados);
        }

        //[3.4]
        private void PreencherListaConsultaAdvogado(ConsultaAdvogadoCollection consultaAdvogados)
        {
            if (consultaAdvogados == null)
            {
                return;
            }
            this.consultaAdvogadoListBox.Items.Clear();
            foreach (ConsultaAdvogado consultaAdvogado in consultaAdvogados)
            {
                string registo = consultaAdvogado.CodigoConsultaAdvogado + " Duração=" + consultaAdvogado.DuracaoConsultaMinutos.ToString(); 
                this.consultaAdvogadoListBox.Items.Add(registo);
            }
        }

        //[3.5]
        private void CalcularTempoConsultaMesCorrente()
        {
            int totaltempoConsulta = 0;

            ConsultaAdvogadoCollection consultaAdvogados = ConsultaAdvogado.ObterListaConsultaAdvogado();
            totaltempoConsulta = consultaAdvogados.GetTempoTotalMesCorrente();

            this.resultadoLabel.Text = totaltempoConsulta.ToString();
        }
//#####################################################################################################################
		namespace CamadaNegocio
{
    public class ConsultaAdvogadoCollection : Collection<ConsultaAdvogado>
    {

        #region Construtores

        public ConsultaAdvogadoCollection()
        {
        }

        public ConsultaAdvogadoCollection(DataTable dataTable)
        {
            if (dataTable == null)
                return;

            foreach (DataRow item in dataTable.AsEnumerable())
            {
                ConsultaAdvogado consultaAdvogado = new ConsultaAdvogado();

                consultaAdvogado.CodigoConsultaAdvogado = item.Field<string>("CodigoConsultaAdvogado");
                consultaAdvogado.DataConsulta = item.Field<DateTime>("DataConsulta");
                consultaAdvogado.IdadeCliente = item.Field<int>("IdadeCliente");
                consultaAdvogado.DuracaoConsultaMinutos = item.Field<int>("DuracaoConsultaMinutos");

                this.Add(consultaAdvogado);
            }
        }

        #endregion

        #region Metodos

        //[3.5]
        public int GetTempoTotalMesCorrente()
        {
            int tempo = (from ConsultaAdvogado consultaAdvogado in this
                         where consultaAdvogado.IsMesCorrente()
                         select consultaAdvogado.DuracaoConsultaMinutos).Sum();

            return tempo;
        }

        //public float ObterTotal()
        //{
        //    float total = (from Tarefa tarefa in this
        //                   where tarefa.DataInicio.Year == DateTime.Today.Year && 
        //                         tarefa.DataInicio.Month == DateTime.Today.Month
        //                   select tarefa.Custo).Sum();
        //    return total;
        //}

        #endregion

    }
}
//########################################################################################################################################
        #endregion

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
