using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resultadoImc.Text = "";
            resultadoDiagonostico.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textBoxPeso.Text, out double peso) == false)
            {
                MessageBox.Show("Peso Invalido!", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (double.TryParse(textBoxAltura.Text, out double altura) == false)
            {
                MessageBox.Show("Altura Invalida!", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                calcularImc();
            }
        }

        private void calcularImc()
        {
            double peso, altura, imc;

            peso = double.Parse(textBoxPeso.Text);
            altura = double.Parse(textBoxAltura.Text);

            imc = peso / (altura * altura);

            resultadoImc.Text = imc.ToString("N2");

            string resultadoDiag;
            if (imc < 20)
            {
                resultadoDiag = "Baixo Peso";
            }
            else if (imc < 25)
            {
                resultadoDiag = "Normal";
            }
            else if (imc < 30)
            {
                resultadoDiag = "Excesso de Peso";
            }
            else if (imc < 35)
            {
                resultadoDiag = "Obesidade";
            }
            else
            {
                resultadoDiag = "Obesidade Mórbida";
            }
            resultadoDiagonostico.Text = resultadoDiag;
        }
    }
}
