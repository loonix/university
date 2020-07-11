using Codr.Core;
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
            string comandoSQL = "SELECT codigos.Id, codigos.titulo, codigos.descricao, codigos.path, categorias.nome_categoria AS Categoria " +
                                "FROM codigos INNER JOIN " +
                                "categorias ON codigos.id_categoria = categorias.Id";

            DataTable table = ClassBD.ObterDados(comandoSQL); // recebe os dados
            dataGridView1.DataSource = table; // Mostra valores na grid
        }

        
    }
}
