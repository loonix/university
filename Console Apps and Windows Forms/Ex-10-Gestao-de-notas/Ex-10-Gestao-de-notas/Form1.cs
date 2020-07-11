using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_10_Gestao_de_notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            chamaFormGerirNotas();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre novoForm = new Sobre();
            novoForm.ShowDialog();
        }

        private void gestaoNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chamaFormGerirNotas();
        }

        private void chamaFormGerirNotas()
        {
            GerirNotas novoForm = new GerirNotas();
            novoForm.MdiParent = this;
            novoForm.Show();
        }
    }
}
