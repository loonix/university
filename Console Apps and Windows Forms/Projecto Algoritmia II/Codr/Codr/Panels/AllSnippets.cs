using Codr.Core;
using Codr.Core.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Notas_Load(object sender, EventArgs e)
        {
            string comandoSQL = "SELECT snippets.id, snippets.title, snippets.description, snippets.path, extensions.name AS Extension " +
                                "FROM snippets INNER JOIN " +
                                "extensions ON snippets.id_extension = extensions.id";

            DataTable table = ClassBD.ObterDados(comandoSQL); // recebe os dados
            dataGridView1.DataSource = table; // Mostra valores na grid
        }

        
    }
}
