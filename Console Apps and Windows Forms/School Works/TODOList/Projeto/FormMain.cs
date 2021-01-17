using CamadaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Notas
{
    public partial class FormMain : Form
    {
        #region Construtor

        public FormMain()
        {
            InitializeComponent();
        }

        #endregion

        #region Propriedades

        private string idNota;
        internal string IDNota
        {
            get { return idNota; }
            private set { idNota = value; }
        }

        #endregion

        #region Metodos

        public void CarregarGrelha()
        {
            NotaCollection notas = Nota.ObterListaNotas();
            List<Nota> notasFiltradas = notas.ObterNotasEmDestaque();
            this.dataGridView.DataSource = notasFiltradas;
        }

        private void FormatarGrelha()
        {
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ReadOnly = true;
            this.dataGridView.MultiSelect = false;

            this.AddColuna(100, "Titulo", "Titulo", DataGridViewAutoSizeColumnMode.Fill);
            this.AddColuna(100, "Criado Em", "DataCriacao", DataGridViewAutoSizeColumnMode.Fill);
            this.AddColuna(100, "Expira Em", "DataExpiracao", DataGridViewAutoSizeColumnMode.Fill);
            this.AddColuna(100, "Conteudo", "Conteudo", DataGridViewAutoSizeColumnMode.Fill);
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
                    this.IDNota = (string)row.Cells[0].Value;
                }
            }
        }
        #endregion

        #region Eventos
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.FormatarGrelha();
            this.CarregarGrelha();
        }

        private void adicionarNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormAdicionarNota adicionarNotaForm = new FormAdicionarNota())
            {
                adicionarNotaForm.ShowDialog();
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelecionarRegisto();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Sobre sobreForm = new Sobre())
            {
                sobreForm.ShowDialog();
            }
        }
        private void gerirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (GerirNotas gerirNotasForm = new GerirNotas())
            {
                gerirNotasForm.ShowDialog();
            }
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var linhaSelecionada = dataGridView.CurrentRow;
            if (linhaSelecionada != null)
            {
                Nota notaSelecionada = (Nota)linhaSelecionada.DataBoundItem;
                using (FormAdicionarNota adicionarNotaForm = new FormAdicionarNota(notaSelecionada))
                {
                    adicionarNotaForm.ShowDialog();
                }
            }
        }
        #endregion
    }
}
