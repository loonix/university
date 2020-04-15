using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_USA
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ChamaFormPresidentes();
        }

        private void presidentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamaFormPresidentes();
        }

        void ChamaFormPresidentes()
        {
            //Criar uma estancia (copia) do FormPresidentes
            FormPresidentes novoForm = new FormPresidentes();
            //criar relação pai/filho
            novoForm.MdiParent = this; //this-> representa o formMenu
            novoForm.Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ChamaFormVisualizar();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamaFormVisualizar();
        }

        void ChamaFormVisualizar()
        {
            //Criar uma estancia (copia) do FormVisualiza
            FormVisualiza novoForm = new FormVisualiza();
            //criar relação pai/filho
            novoForm.MdiParent = this; //this-> representa o formMenu
            novoForm.Show();

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormAboutBox novoForm = new FormAboutBox();
            novoForm.ShowDialog();

        }
    }//class
}
