using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _05_Euro2020.ClassFuncoesGlobais;

namespace _05_Euro2020
{
    public partial class FormEuro2020 : Form
    {
        public FormEuro2020()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {

            foreach (registoEstadio item in ListaEstadios)
            {
                if (item.NumeroEstadio == int.Parse(textBoxNumeroEstadio.Text))
                {
                    MessageBox.Show("O numero de estadio ja existe", "Euro 2020 - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (item.NomeEstadio == textBoxNomeEstadio.Text)
                {
                    MessageBox.Show("O nome de estadio ja existe", "Euro 2020 - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (textBoxCapacidade.Text == "") textBoxCapacidade.Text = "0";
            if (textBoxTotalJogos.Text == "") textBoxTotalJogos.Text = "0";
            if (textBoxTotalAssistencias.Text == "") textBoxTotalAssistencias.Text = "0";

            if (CamposValidos())
            {
                //List<registoEstadio> NovoEstadio = new List<registoEstadio>();

                Random Aleatorio = new Random();

                int valor = Aleatorio.Next(1, 5);
                string estado = "";
                switch (valor)
                {
                    case 1:
                        estado = "Mau";
                        break;
                    case 2:
                        estado = "Razoavel";
                        break;
                    case 3:
                        estado = "Bom";
                        break;
                    case 4:
                        estado = "Excelente";
                        break;
                    default:
                        break;
                }

                ListaEstadios.Add(new registoEstadio()
                {
                    NumeroEstadio = int.Parse(textBoxNumeroEstadio.Text),
                    NomeEstadio = textBoxNomeEstadio.Text,
                    NomePais = textBoxPais.Text,
                    NomeCidade = textBoxCidade.Text,
                    Capacidade = textBoxCapacidade.Text,
                    TotalJogos = int.Parse(textBoxTotalJogos.Text),
                    TotalAssistencias = int.Parse(textBoxTotalAssistencias.Text),
                    Estado = estado
                });
                PreencherGrid();
                LimparCampos();
            }
        }
        void PreencherGrid()
        {
            dataGridView1.Rows.Clear();
            int linha = 0;
            foreach (var item in ListaEstadios)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[linha].Cells[0].Value = item.NumeroEstadio;
                dataGridView1.Rows[linha].Cells[1].Value = item.NomeEstadio;
                dataGridView1.Rows[linha].Cells[2].Value = item.NomePais;
                dataGridView1.Rows[linha].Cells[3].Value = item.NomeCidade;
                dataGridView1.Rows[linha].Cells[4].Value = item.Capacidade;
                dataGridView1.Rows[linha].Cells[5].Value = item.TotalJogos;
                dataGridView1.Rows[linha].Cells[6].Value = item.TotalAssistencias;
                dataGridView1.Rows[linha].Cells[7].Value = item.Estado;



                linha++;
            }
            {

            }
        }

        void LimparCampos()
        {
            foreach (Control x in this.Controls) if (x is TextBox) ((TextBox)x).Text = "";
        }

        bool CamposValidos()
        {
            bool temErro = false;
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    if (((TextBox)x).Text == "")
                    {
                        temErro = true;
                        ((TextBox)x).BackColor = Color.IndianRed;
                        ((TextBox)x).ForeColor = Color.White;
                    }
                    else
                    {
                        ((TextBox)x).BackColor = Color.White;
                        ((TextBox)x).ForeColor = Color.Black;
                    }
                }
            }
            return temErro ? false : true;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            FormEuro2020.ActiveForm.Close();
        }

        private void textBoxNumeroEstadio_Leave(object sender, EventArgs e)
        {
            foreach (registoEstadio item in ListaEstadios)
            {
                if (item.NumeroEstadio == int.Parse(textBoxNumeroEstadio.Text))
                {
                    //buttonAlterar.Enabled = true;
                    //buttonEliminar.Enabled = true;
                    //buttonInserir.Enabled = false;

                    textBoxNumeroEstadio.Text = item.NumeroEstadio.ToString();
                    textBoxNomeEstadio.Text = item.NomeEstadio;
                    textBoxPais.Text = item.NomePais;
                    textBoxCidade.Text = item.NomeCidade;
                    textBoxCapacidade.Text = item.Capacidade;
                    textBoxTotalJogos.Text = item.TotalJogos.ToString();
                    textBoxTotalAssistencias.Text = item.TotalAssistencias.ToString();
                    return;

                }

            }
        }

        private void FormEuro2020_Load(object sender, EventArgs e)
        {
            //buttonAlterar.Enabled = false;
            //buttonEliminar.Enabled = false;
            //buttonInserir.Enabled = true;
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            var estadio = ListaEstadios.FirstOrDefault(i => i.NumeroEstadio == int.Parse(textBoxNumeroEstadio.Text));
            estadio.NumeroEstadio = int.Parse(textBoxNumeroEstadio.Text);
            estadio.NomeEstadio = textBoxNomeEstadio.Text;
            estadio.NomePais = textBoxPais.Text;
            estadio.NomeCidade = textBoxCidade.Text;
            estadio.Capacidade = textBoxCapacidade.Text;
            estadio.TotalJogos = int.Parse(textBoxTotalJogos.Text);
            estadio.TotalAssistencias = int.Parse(textBoxTotalAssistencias.Text);
        }
    }
}
