using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Notas
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //criar uma intancia da classe FormSobre
            FormSobre novoForm = new FormSobre();

            //novoForm.Show();

            novoForm.ShowDialog();

        }
              

        private void gestãoNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chamaFormNotas();
        }              

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            chamaFormNotas();
        }


        void chamaFormNotas()
        {
            FormNotasBD novoForm = new FormNotasBD();

            //definir o pai do form
            novoForm.MdiParent = this; //this, neste caso formMenu
            novoForm.Show();

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
