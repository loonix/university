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
using static Presidenciais.Service;

namespace Presidenciais
{
    public partial class FormResultados : Form
    {

        public FormResultados() { InitializeComponent(); }
        
        /// <summary>
        /// loads all regioes and resultados when the app starts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                }
                FicheiroLer.Close();
            }
            else MessageBox.Show("O ficheiro regioes.txt nao existe", "Abrir Ficheiro", MessageBoxButtons.OK);
        }

        /// <summary>
        /// triggers the selected item from comboBoxRegioes and sets the values if found
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxRegioes_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool flag = false;
            var selectedRegiao = comboBoxRegioes.Text;
            foreach (var item in ListaResultados)
            {
                if (item.Distrito == selectedRegiao)
                {
                    flag = true;
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
                }
            }
            if (!flag) clearCampos();
        }

        /// <summary>
        /// Sets the required fields with the background red and the valid with normal white color
        /// </summary>
        /// <returns></returns>
        private bool CamposValidos()
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

        /// <summary>
        /// Clears all textboxes
        /// </summary>
        private void clearCampos()
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox) ((TextBox)x).Text = "";
            }
        }

        /// <summary>
        /// saves the edited or the new on the resultados.txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                var selectedRegiao = comboBoxRegioes.Text;
                int index = ListaResultados.FindIndex(result => result.Distrito == selectedRegiao);
                // if it has found a result

                RegistoResultado resultToSave = new RegistoResultado();
                resultToSave.Distrito = selectedRegiao;
                resultToSave.votacaoMRS = int.Parse(textBox1.Text);
                resultToSave.votacaoSN = int.Parse(textBox2.Text);
                resultToSave.votacaoMM = int.Parse(textBox3.Text);
                resultToSave.votacaoVS = int.Parse(textBox4.Text);
                resultToSave.votacaoMB = int.Parse(textBox5.Text);
                resultToSave.votacaoPM = int.Parse(textBox6.Text);
                resultToSave.votacaoES = int.Parse(textBox7.Text);
                resultToSave.votacaoHN = int.Parse(textBox8.Text);
                resultToSave.votacaoJS = int.Parse(textBox9.Text);
                resultToSave.votacaoCF = int.Parse(textBox10.Text);
                resultToSave.votacaoBranco = int.Parse(textBox11.Text);
                resultToSave.votacaoNulos = int.Parse(textBox12.Text);

                if (index >= 0) ListaResultados[index] = resultToSave;
                else ListaResultados.Add(resultToSave);
                
                saveToTextFile();
            }
        }

        /// <summary>
        /// clears resultados and saves the results to resultados.txt
        /// </summary>
        private void saveToTextFile()
        {
            string NomeFic = "resultados.txt";
            if (File.Exists(NomeFic))
            {
                clearTextFile(NomeFic);

                StreamWriter writeFile = new StreamWriter(NomeFic);
                foreach (var resultado in ListaResultados)
                {
                    writeFile.WriteLine(
                        resultado.Distrito + "," +
                        resultado.votacaoMRS + "," +
                        resultado.votacaoSN + "," +
                        resultado.votacaoMM + "," +
                        resultado.votacaoVS + "," +
                        resultado.votacaoMB + "," +
                        resultado.votacaoPM + "," +
                        resultado.votacaoES + "," +
                        resultado.votacaoHN + "," +
                        resultado.votacaoJS + "," +
                        resultado.votacaoCF + "," +
                        resultado.votacaoBranco + "," +
                        resultado.votacaoNulos
                    );
                }
                writeFile.Close();
            }
            else MessageBox.Show("O ficheiro regioes.txt nao existe", "Abrir Ficheiro", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormVisualiza novoForm = new FormVisualiza();
            novoForm.MdiParent = this.MdiParent;
            novoForm.ShowDialog();
        }
    }
}
