using Codr.Core.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Codr
{
    public partial class Extensions : Form
    {
        public Extensions()
        {
            InitializeComponent();
        }

        private void Extensions_Load(object sender, EventArgs e)
        {
            FillDatagrid();
            ShowHideControls();
        }

        private void FillDatagrid()
        {
            string comandoSQL = "SELECT id, name from extensions ";

            DataTable table = ClassBD.GetData(comandoSQL); // recebe os dados
            dataGridView1.DataSource = table; // Mostra valores na grid
        }

        private void ShowHideControls(bool visible = false)
        {
            buttonDelete.Visible = visible ? true : false;
            buttonEdit.Visible = visible ? true : false;
            panel1.Visible = visible ? true : false;
            if (!visible) dataGridView1.ClearSelection();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            Int32 selectedRowCount =
       dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                ShowHideControls(true);
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["id"].Value);
                string name = Convert.ToString(selectedRow.Cells["name"].Value);

                textBox1.Text = name;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string id = Convert.ToString(selectedRow.Cells["id"].Value);
            ClassExtensions.EditExtension(int.Parse(id), textBox1.Text);
            FillDatagrid();
            ShowHideControls();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string id = Convert.ToString(selectedRow.Cells["id"].Value);
            ClassExtensions.DeleteExtension(int.Parse(id));
            FillDatagrid();
            ShowHideControls();
        }
    }
}
