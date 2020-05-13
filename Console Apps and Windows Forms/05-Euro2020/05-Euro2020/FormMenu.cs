using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Euro2020
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void euroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamarFormEuro();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ChamarFormEuro();
        }

        void ChamarFormEuro()
        {
            FormEuro2020 form = new FormEuro2020();
            form.MdiParent = this; // Parent / Child
            form.Show();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSobre form = new FormSobre();
            form.MdiParent = this; // Parent / Child
            form.ShowDialog();
        }
    }
}
