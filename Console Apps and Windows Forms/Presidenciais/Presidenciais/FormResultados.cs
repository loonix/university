using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Presidenciais.registo;

namespace Presidenciais
{
    public partial class FormResultados : Form
    {
        public FormResultados()
        {
            InitializeComponent();
        }

        private void FormResultados_Load(object sender, EventArgs e)
        {
            loadRegioes();
            loadResultados();
        }

        /// <summary>
        /// opens regioes from a text file and fills the combobox
        /// </summary>
        private void loadRegioes()
        {
            string NomeFic = "regioes.txt";
            if (File.Exists(NomeFic))
            {
                StreamReader FicheiroLer = new StreamReader(NomeFic);
                while (!FicheiroLer.EndOfStream)
                {
                    comboBoxRegioes.Items.Add(FicheiroLer.ReadLine());
                    //    ListaRegioes.Add(FicheiroLer.ReadLine());

                }
                FicheiroLer.Close();
            }
            else
            {
                // show dialog
                return;
            }
        }

        private void loadResultados()
        {
            string NomeFic = "resultados.txt";
            if (File.Exists(NomeFic))
            {
                StreamReader FicheiroLer = new StreamReader(NomeFic);
                RegistoResultado resultado = new RegistoResultado();
                string linha;

                while (!FicheiroLer.EndOfStream)
                {
                    linha = FicheiroLer.ReadLine();
                    //separar a linha atraves da virgula e colocar cada campo num vetor
                    string[] campos = linha.Split(',');
                    resultado.Distrito = campos[0];
                    resultado.votacaoMRS = int.Parse(campos[1]);
                    resultado.votacaoSN = int.Parse(campos[2]);
                    resultado.votacaoMM = int.Parse(campos[3]);
                    resultado.votacaoVS = int.Parse(campos[4]);
                    resultado.votacaoMB = int.Parse(campos[5]);
                    resultado.votacaoPM = int.Parse(campos[6]);
                    resultado.votacaoES = int.Parse(campos[7]);
                    resultado.votacaoHN = int.Parse(campos[8]);
                    resultado.votacaoJS = int.Parse(campos[9]);
                    resultado.votacaoCF = int.Parse(campos[10]);
                    resultado.votacaoBranco = int.Parse(campos[11]);
                    resultado.votacaoNulos = int.Parse(campos[12]);
                    ListaResultados.Add(resultado);
                }
                FicheiroLer.Close();
            }
            else
            {
                // show dialog
                return;
            }
        }

        private void comboBoxRegioes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRegiao = comboBoxRegioes.Text;
            foreach (var item in ListaResultados)
            {
                if (item.Distrito == selectedRegiao)
                {
                    textBox1.Text = item.votacaoMRS.ToString();
                    textBox2.Text = item.votacaoSN.ToString();
                    textBox3.Text = item.votacaoMM.ToString();
                    textBox4.Text = item.votacaoVS.ToString();
                    textBox5.Text = item.votacaoMB.ToString();
                    textBox6.Text = item.votacaoPM.ToString();
                    textBox7.Text = item.votacaoES.ToString();
                    textBox8.Text = item.votacaoHN.ToString();
                    textBox9.Text = item.votacaoJS.ToString();
                    textBox10.Text = item.votacaoCF.ToString();
                    textBox11.Text = item.votacaoBranco.ToString();
                    textBox12.Text = item.votacaoNulos.ToString();
                } else
                {
                    CamposValidos();
                }
            }
            
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
    }
}
