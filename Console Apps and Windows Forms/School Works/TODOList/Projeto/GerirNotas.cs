using Notas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CamadaNegocio
{
    public partial class GerirNotas : Form
    {
        public GerirNotas()
        {
            InitializeComponent();
        }

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
            List<Nota> notasFlitradas = notas.ObterNotas(destaque: this.mostrarEmDestaqueCheckBox.Checked, expirados: this.mostrarExpiradosCheckBox.Checked, pesquisaTextBox.Text);
            this.dataGridView.DataSource = notasFlitradas;
            VerificarTabela();
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
            this.AddColuna(100, "Destaque", "Destaque", DataGridViewAutoSizeColumnMode.Fill);

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

        private void VerificarTabela()
        {
            int numeroDeLinhas = this.dataGridView.Rows.Count;
            if (numeroDeLinhas == 0)
            {
                this.editarBtn.Enabled = false;
                this.removerBtn.Enabled = false;
            }
            else
            {
                this.editarBtn.Enabled = true;
                this.removerBtn.Enabled = true;
            }
        }
        private void Eliminar(string idNota)
        {
            string erro = string.Empty;
            Nota nota = new Nota();

            nota.IDNota = idNota;

            bool ok = nota.Eliminar(out erro);

            if (ok)
            {
                MessageBox.Show("Removido com sucesso");
                CarregarGrelha();
            }
            else
            {
                MessageBox.Show(string.Format("Erro a remover [{0}]", erro));
            }
        }
        #endregion

        #region Eventos

        private void GerirNotas_Load(object sender, EventArgs e)
        {
            this.FormatarGrelha();
            this.CarregarGrelha();
        }

        private void adicionarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            using (FormAdicionarNota adicionarNotaForm = new FormAdicionarNota())
            {
                adicionarNotaForm.ShowDialog();
            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mostrarExpiradosCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrelha();
        }

        private void mostrarEmDestaqueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrelha();
        }
        private void removerBtn_Click(object sender, EventArgs e)
        {
            Nota notaSelecionada = (Nota)dataGridView.CurrentRow.DataBoundItem;
            this.Eliminar(notaSelecionada.IDNota);
            CarregarGrelha();
            // atualiza a datagrid do form principal
            FormMain formMain = (FormMain)Application.OpenForms["FormMain"];
            formMain.CarregarGrelha();
        }

        private void pesquisa_TextChanged(object sender, EventArgs e)
        {
            this.CarregarGrelha();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.editarBtn_Click(sender, e);
        }
        private void editarBtn_Click(object sender, EventArgs e)
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
            else
            {
                MessageBox.Show(Notas.Properties.Resources.MESSAGE_EDITAR_NOTA_NAO_SELECIONADO);
            }

        }
        #endregion

    }
}
