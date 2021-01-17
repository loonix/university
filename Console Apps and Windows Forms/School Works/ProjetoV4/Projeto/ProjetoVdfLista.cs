using CamadaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploProjeto
{
    public partial class ProjetoVdfLista : Form
    {
        public ProjetoVdfLista()
        {
            InitializeComponent();
        }
        #region Propriedades

        private long idWo;
        internal long IdWo
        {
            get { return idWo; }
            private set { idWo = value; }
        }

        public ProjetoVdfCollection projetosVdf;




        #endregion

        #region Metodos

        private void CarregarGrelha()
        {
            ProjetoVdfCollection projetoVdfCollection = ProjetoVdf.ObterListaSimples();

            this.dataGridView.DataSource = projetoVdfCollection;
        }

        private void FormatarGrelha()
        {
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ReadOnly = true;

            this.AddColuna(100, "WorkOrder", "IdWo", DataGridViewAutoSizeColumnMode.None);
            this.AddColuna(100, "Cliente", "Cliente", DataGridViewAutoSizeColumnMode.Fill);
            this.AddColuna(100, "Nome PV", "NomePV", DataGridViewAutoSizeColumnMode.Fill);
            this.AddColuna(100, "Data Pedido", "DataInicioPedido", DataGridViewAutoSizeColumnMode.Fill);
            this.AddColuna(100, "Data da Proposta", "DataDaProposta", DataGridViewAutoSizeColumnMode.Fill);
            this.AddColuna(100, "Duração Contrato", "DuracaoContrato", DataGridViewAutoSizeColumnMode.Fill);
            this.AddColuna(100, "Tipo ", "TipoNegocio", DataGridViewAutoSizeColumnMode.Fill);
            this.AddColuna(100, "Estado", "EstadoNegocio", DataGridViewAutoSizeColumnMode.Fill);

            this.AddColuna(100, "Latitude", "Latitude", DataGridViewAutoSizeColumnMode.Fill);
            this.AddColuna(100, "Longitude", "Longitude", DataGridViewAutoSizeColumnMode.Fill);
        }

        private void AddColuna(int tamanho, string header, string campo, DataGridViewAutoSizeColumnMode modo)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();

            column.Width = tamanho;
            column.HeaderText = header;
            column.DataPropertyName = campo;
            column.AutoSizeMode = modo;

            this.dataGridView.Columns.Add(column);
        }

        private void SelecionarRegisto()
        {
           
            if (this.dataGridView.SelectedRows != null &&
                this.dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dataGridView.SelectedRows[0];
                if (row != null)
                {
                    this.IdWo = (long)row.Cells[0].Value;
                    this.Close();
                }
            }
        }

        private void ContarProjetosTotais()
        {
            //Quantos Projetos estão a decorrer ?
            int count = 0;

            foreach (ProjetoVdf projetoVdf in ProjetoVdf.ObterListaSimples())
            {
                count++;
            }

            this.totalPedidosLabel.Text = count.ToString();
        }

        private void ContarProjetosInProgress()
        {
            //Totais Globais nº projetos em progresso ?
            int count = 0;


            foreach (ProjetoVdf projetoVdf in ProjetoVdf.ObterListaSimples())
            {
                if (projetoVdf.NomePV == this.nomePreVendaComboBox.Text)
                {

                }
                if (projetoVdf.EstadoNegocio == EstadoNegocioEnum.Inprogress)
                {
                    count++;
                }
                this.totalInProgressLabel.Text = count.ToString();

            }

        }
        private void ContarProjetosOnHold()
        {
            //Totais Globais nº projetos em espera?
            int count = 0;

            foreach (ProjetoVdf projetoVdf in ProjetoVdf.ObterListaSimples())
            {
                if (projetoVdf.EstadoNegocio == EstadoNegocioEnum.OnHold)
                {
                    count++;
                }
                this.totalOnHoldLabel.Text = count.ToString();

            }

        }

        private void ContarProjetosInfoPend()
        {
            //Totais Globais nº projetos a aguardar informação complementar ?
            int count = 0;

            foreach (ProjetoVdf projetoVdf in ProjetoVdf.ObterListaSimples())
            {
                if (projetoVdf.EstadoNegocio == EstadoNegocioEnum.InformationPend)
                {
                    count++;
                }
                this.totalInfoPendLabel.Text = count.ToString();

            }

        }

        private void ContarProjetosSubCasePend()
        {
            //Totais Globais nº projetos com sub pedido pendente?
            int count = 0;

            foreach (ProjetoVdf projetoVdf in ProjetoVdf.ObterListaSimples())
            {
                if (projetoVdf.EstadoNegocio == EstadoNegocioEnum.SubCasePend)
                {
                    count++;
                }
                this.totalSubCasePendLabel.Text = count.ToString();

            }

        }


        private void ContarProjetosFechados()
        {
            //Totais Globais nº projetos Fechados?
            int count = 0;

            foreach (ProjetoVdf projetoVdf in ProjetoVdf.ObterListaSimples())
            {
                if (projetoVdf.EstadoNegocio == EstadoNegocioEnum.ClosePend)
                {
                    count++;
                }
                this.totalClosedLabel.Text = count.ToString();

            }

        }

        private void ContarProjetosPropostaApresentada()
        {
            //Totais Globais nº projetos com proposta apresentada ao cliente?
            int count = 0;

            foreach (ProjetoVdf projetoVdf in ProjetoVdf.ObterListaSimples())
            {
                if (projetoVdf.EstadoNegocio == EstadoNegocioEnum.Proposal)
                {
                    count++;
                }
                this.totalProposalLabel.Text = count.ToString();

            }

        }

        private void ContarProjetosEsperaSuperior2Semanas()
        {
            ProjetoVdfCollection projetoVdfCollection = ProjetoVdf.ObterListaSimples();
            //Quantos Projetos em curso à mais de 2 semanas ?
            int count = projetoVdfCollection.ContarProjetosPropostaApresentadaSuperior2Semanas();

            this.pedidosPorFecharSuperior2SemanasLabel.Text = count.ToString();

        }

        private void CarregarDados()
        {
            this.nomePreVendaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            //Elimina todos os registos da ComboBox
            this.nomePreVendaComboBox.Items.Clear();

            this.nomePreVendaComboBox.Items.Add("Bruno Faria");
            this.nomePreVendaComboBox.Items.Add("Ricardo Oliveira");
            this.nomePreVendaComboBox.Items.Add("Nuno Sousa");

            this.mesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            //Elimina todos os registos da ComboBox
            this.mesComboBox.Items.Clear();

            this.mesComboBox.Items.Add("Janeiro");
            this.mesComboBox.Items.Add("Fevereiro");
            this.mesComboBox.Items.Add("Março");
            this.mesComboBox.Items.Add("Abril");
            this.mesComboBox.Items.Add("Maio");
            this.mesComboBox.Items.Add("Junho");
            this.mesComboBox.Items.Add("Julho");
            this.mesComboBox.Items.Add("Agosto");
            this.mesComboBox.Items.Add("Setembro");
            this.mesComboBox.Items.Add("Outubro");
            this.mesComboBox.Items.Add("Novembro");
            this.mesComboBox.Items.Add("Dezembro");

            this.anoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.anoComboBox.Items.Clear();
           

            //Ciclo for para preencher Ano na comboBox 
            for (int ano = 2000; ano < 2050; ano++)
            {
                //Adiciona o item na ComboBox
                this.anoComboBox.Items.Add( ano.ToString());
            }

            //Seleciona o primeiro elemento da lista
            this.anoComboBox.SelectedIndex = 0;
        }

        private void FiltrarPV()
        {
            ProjetoVdfCollection projetoVdfCollection = ProjetoVdf.ObterListaSimples();
            //Quantos Projetos em curso à mais de 2 semanas ?
           string nome = projetoVdfCollection.SelecionarPV();

            this.nomePreVendaComboBox.Text = nome.ToString();

        }







        //    this.duracaoContratoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        //    //Elimina todos os registos da ComboBox
        //    this.duracaoContratoComboBox.Items.Clear();

        //    this.duracaoContratoComboBox.Items.Add("12 Meses");
        //    this.duracaoContratoComboBox.Items.Add("24 Meses");



        ////V2
        //count = this.livros.Count(k => k.GeneroLivro == GeneroLivroEnum.Aventura);

        ////V3
        //count = this.livros.ContarLivrosDeAventura();



        //private void PreencherListaProjetoVdf()
        //{
        //    //Obter Lista de Livros
        //    IEnumerable<ProjetoVdf> novaLista = this.pr.Obter();

        //    //Preencher a ListBox com a lista de Livros
        //    this.PreencherListBox(novaLista);
        //}


        #endregion

        #region Eventos


        protected override void OnResize(EventArgs e)
        {
            if (this.Width < 400)
            {
                this.Width = 400;
            }
            if (this.Height < 250)
            {
                this.Height = 250;
            }

            int width = this.Width;
            int height = this.Height;
            int margem = 40;

            int widthGrid = width - margem;
            int heightGrid = height - margem;

            this.dataGridView.Width = widthGrid - this.dataGridView.Left;
            this.dataGridView.Height = heightGrid - this.dataGridView.Top;

            base.OnResize(e);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelecionarRegisto();
        }

        private void ProjetoVdfLista_Load(object sender, EventArgs e)
        {
            this.FormatarGrelha();
            this.CarregarGrelha();
            this.ContarProjetosTotais();
            this.ContarProjetosInProgress();
            this.ContarProjetosInfoPend();
            this.ContarProjetosOnHold();
            this.ContarProjetosSubCasePend();
            this.ContarProjetosFechados();
            this.ContarProjetosPropostaApresentada();
            this.ContarProjetosEsperaSuperior2Semanas();
            this.CarregarDados();
     

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void nomePreVendaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FiltrarPV();
          
            this.ContarProjetosTotais();
            this.ContarProjetosInProgress();
            this.ContarProjetosInfoPend();
            this.ContarProjetosOnHold();
            this.ContarProjetosSubCasePend();
            this.ContarProjetosFechados();
            this.ContarProjetosPropostaApresentada();
            this.ContarProjetosEsperaSuperior2Semanas();
           
        }
    }
    #endregion




}
