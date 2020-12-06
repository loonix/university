using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void livroButton_Click(object sender, EventArgs e)
        {
            // limpa da memoria (igual a dispose();)
            using (FormLivro formLivro = new FormLivro())
            {
                formLivro.ShowDialog();
            }
        }
    }
}
