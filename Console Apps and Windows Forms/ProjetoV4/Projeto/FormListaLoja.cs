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
    public partial class FormListaLoja : Form
    {

        #region Contrutor

        public FormListaLoja()
        {
            InitializeComponent();
        }

        #endregion

        #region Propriedades

        private int codigoLoja;
        internal int CodigoLoja
        {
            get { return codigoLoja; }
            private set { codigoLoja = value; }
        }

        #endregion

        #region Metodos

        private void CarregarGrelha()
        {
            LojaCollection lojas = Loja.ObterListaSimples();

            this.dataGridView.DataSource = lojas;
        }

        private void FormatarGrelha()
        {
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ReadOnly = true;

            this.AddColuna(100, "Código", "CodigoLoja", DataGridViewAutoSizeColumnMode.None);
            this.AddColuna(100, "Descrição", "Descricao", DataGridViewAutoSizeColumnMode.Fill);
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
                    this.CodigoLoja = (int)row.Cells[0].Value;
                    this.Close();
                }
            }
        }

        #endregion

        #region Eventos

        private void FormListaLoja_Load(object sender, EventArgs e)
        {
            this.FormatarGrelha();
            this.CarregarGrelha();
        }

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

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelecionarRegisto();
        }

        #endregion

    }
}
