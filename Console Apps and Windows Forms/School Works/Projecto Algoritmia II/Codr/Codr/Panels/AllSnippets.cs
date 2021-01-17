using Codr.Core;
using Codr.Core.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CodrApp
{
    public partial class AllSnippets : Form
    {
        public AllSnippets()
        {
            InitializeComponent();
        }

        private void buttonNovaTarefa_Click(object sender, EventArgs e)
        {
            string filename = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (*.csv)|*.csv";
            saveFileDialog.FileName = "Output.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message, "CODr", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                int columnCount = dataGridView1.ColumnCount;
                string columnNames = "";
                string[] output = new string[dataGridView1.RowCount + 1];
                for (int i = 0; i < columnCount; i++)
                {
                    columnNames += dataGridView1.Columns[i].Name.ToString() + ",";
                }
                output[0] += columnNames;
                for (int i = 1; (i - 1) < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        output[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                    }
                }
                System.IO.File.WriteAllLines(saveFileDialog.FileName, output, System.Text.Encoding.UTF8);
            }
        }

        private void AllSnippets_Load(object sender, EventArgs e)
        {
            string comandoSQL = "SELECT snippets.id, snippets.title, snippets.description, snippets.path, extensions.name AS Extension " +
                                "FROM snippets INNER JOIN " +
                                "extensions ON snippets.id_extension = extensions.id";

            DataTable table = ClassBD.GetData(comandoSQL); // recebe os dados
            dataGridView1.DataSource = table; // Mostra valores na grid
        }
        
    }
}
