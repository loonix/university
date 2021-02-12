using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exame2019
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void covidButton_Click(object sender, EventArgs e)
        {
            FormTesteCovid19 form = new FormTesteCovid19();
            form.ShowDialog();
        }

        private void testarBDButton_Click(object sender, EventArgs e)
        {
            bool ok = CamadaNegocio.Funcoes.CheckDatabase();

            if (ok)
            {
                MessageBox.Show("Ligação à BD OK");
            }
            else
            {
                MessageBox.Show("Ligação à BD NOT OK");
            }
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userControlButton_Click(object sender, EventArgs e)
        {
            FormUserControl form = new FormUserControl();

            form.ShowDialog();

        }
    }
}
