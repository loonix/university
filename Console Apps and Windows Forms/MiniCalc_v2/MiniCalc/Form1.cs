using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Codigo executado quando o Form abre
            labelMensagem.Text = "";

        }

        private void textBoxOp1_TextChanged(object sender, EventArgs e)
        {
            //verificar se é numero o valor introduzido
            if (textBoxOp1.Text != "")
            {
                if (double.TryParse(textBoxOp1.Text, out double numero) == false)
                {
                    MessageBox.Show("Introduza um valor númerico!", "Calc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //textBoxOp1.Text = "";

                    textBoxOp1.Text = textBoxOp1.Text.Substring(0, textBoxOp1.Text.Length - 1);
                    //ou..
                    //textBoxOp1.Clear();
                }
            }

        }

        private void textBoxOp1_Enter(object sender, EventArgs e)
        {
            labelMensagem.Text = "Introduza o Operador 1";
        }

        private void textBoxOp2_Enter(object sender, EventArgs e)
        {
            labelMensagem.Text = "Introduza o Operador 2";
        }

        private void textBoxOp2_TextChanged(object sender, EventArgs e)
        {

            //verificar se é numero o valor introduzido
            if (textBoxOp2.Text != "")
            {
                if (double.TryParse(textBoxOp2.Text, out double numero) == false)
                {
                    MessageBox.Show("Introduza um valor númerico!", "Calc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //textBoxOp2.Text = "";

                    textBoxOp2.Text = textBoxOp2.Text.Substring(0, textBoxOp2.Text.Length - 1);
                    //ou..
                    //textBoxOp2.Clear();
                }
            }

        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            Calcular("Soma");
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            Calcular("Subtração");
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            Calcular("Multiplicação");
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            Calcular("Divisão");
        }

        private void textBoxOp1_Leave(object sender, EventArgs e)
        {

            if (textBoxOp1.Text == "")
            {
                textBoxOp1.Text = "0";
            }
        }

        private void textBoxOp2_Leave(object sender, EventArgs e)
        {
            if (textBoxOp2.Text == "")
            {
                textBoxOp2.Text = "0";
            }
        }
               
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxOp1.Clear();
            textBoxOp2.Clear();

            textBoxResultado.Clear();

            labelMensagem.Text = "";

            textBoxOp1.Focus();

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //procedimento para fazer os calculos
        void Calcular(string operacao)
        {
            double numero1, numero2, resultado = 0;

            if (textBoxOp1.Text == "")
            {
                textBoxOp1.Text = "0";
            }
            if (textBoxOp2.Text == "")
            {
                textBoxOp2.Text = "0";
            }

            numero1 = double.Parse(textBoxOp1.Text);
            numero2 = double.Parse(textBoxOp2.Text);

            switch (operacao)
            {
                case "Soma":
                    resultado = numero1 + numero2;
                    break;
                case "Subtração":
                    resultado = numero1 - numero2;
                    break;
                case "Multiplicação":
                    resultado = numero1 * numero2;
                    break;
                case "Divisão":
                    if (numero2 == 0)
                    {
                        MessageBox.Show("Divisor não pode ser zero!", "Calc", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        resultado = numero1 / numero2;
                        textBoxResultado.Text = resultado.ToString();
                    }
                    break;
            }

            textBoxResultado.Text = resultado.ToString();
            labelMensagem.Text = operacao;

        }
    }
}
