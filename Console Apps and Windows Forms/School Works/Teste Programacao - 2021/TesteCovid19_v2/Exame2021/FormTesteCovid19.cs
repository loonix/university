using CamadaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exame2019
{
    public partial class FormTesteCovid19 : Form
    {
        public FormTesteCovid19()
        {
            InitializeComponent();
        }

        #region Metodos

        /// <summary>
        /// Envia o enum correspondente a opcao selectionada nos resultados
        /// </summary>
        /// <returns></returns>
        private EnumResultado GetResultado()
        {
            if (negativoRadioButton.Checked) return EnumResultado.Negativo;
            return EnumResultado.Positivo;
        }

        /// <summary>
        /// Carrega o valor selecionado para os radio btns (resultado)
        /// </summary>
        /// <param name="resultado"></param>
        private void SetResultado(int resultado)
        {
            if (resultado == (int)EnumResultado.Negativo) negativoRadioButton.Checked = true;
            positivoRadioButton.Checked = true;
        }

        private void SetResultadoLabel()
        {
            TesteCovid19Collection testesCollection = TesteCovid19Collection.ObterListaSimples();

            int total = testesCollection.TotalTestesPositivosEmJaneiroAnoCorrente();
            resultadoLabel.Text = total.ToString();
        }

        private void Gravar()
        {
            string erro = string.Empty;

            if (this.DadosValidos())
            {
                TesteCovid19 teste = this.ObterTeste();

                bool ok = teste.Gravar(out erro);

                if (ok)
                {
                    MessageBox.Show(Properties.Resources.GLOBAL_GRAVADO_COM_SUCESSO);
                }
                else
                {
                    MessageBox.Show("Erro a gravar");
                }
            }
        }

        private bool DadosValidos()
        {
            bool ok = true;
            string codTeste = this.codigoTesteCovid19TextBox.Text;
            string nome = this.nomeTextBox.Text;
            DateTime dataTeste = this.dataTesteDateTimePicker.Value;
            int idadeCidadao = int.Parse(this.idadeTextBox.Text);
            int resultadoTeste = (int)this.GetResultado();
            DateTime dataEm16DiasAtras = DateTime.Today.AddDays(-16);


            this.testeCovid19ErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(codTeste))
            {
                this.testeCovid19ErrorProvider.SetError(this.codigoTesteCovid19TextBox, Properties.Resources.ERRO_CODIGO_VAZIO);
                ok = false;
            }
            if (string.IsNullOrWhiteSpace(nome) || nome.Length < 3)
            {
                this.testeCovid19ErrorProvider.SetError(this.nomeTextBox, Properties.Resources.ERRO_NOME_3DIGITOS);
                ok = false;
            }
            if (idadeCidadao <= 0)
            {
                this.testeCovid19ErrorProvider.SetError(this.nomeTextBox, Properties.Resources.ERRO_NOME_3DIGITOS);
                ok = false;
            }
            if (dataTeste < dataEm16DiasAtras)
            {
                this.testeCovid19ErrorProvider.SetError(this.dataTesteDateTimePicker, Properties.Resources.ERRO_DATA_SUPERIOR_HOJE);
                this.dataTesteDateTimePicker.Focus();
                ok = false;
            }

            return ok;
        }

        private void CarregarTeste()
        {
            string codTeste = this.codigoTesteCovid19TextBox.Text;
            string erro = string.Empty;

            TesteCovid19 teste = TesteCovid19.ObterTeste(codTeste, out erro);
            if (teste != null) this.MostrarTeste(teste);
        }

        private void MostrarTeste(TesteCovid19 teste)
        {
            if (teste == null)
            {
                return;
            }
            this.codigoTesteCovid19TextBox.Text = teste.CodTest;
            this.nomeTextBox.Text = teste.Nome;
            this.dataTesteDateTimePicker.Value = teste.DataTeste;
            this.idadeTextBox.Text = teste.IdadeCidadao.ToString();
            this.SetResultado((int)teste.ResultadoTeste);
        }

        private TesteCovid19 ObterTeste()
        {
            TesteCovid19 teste = new TesteCovid19();

            teste.CodTest = this.codigoTesteCovid19TextBox.Text;
            teste.Nome = this.nomeTextBox.Text;
            teste.DataTeste = this.dataTesteDateTimePicker.Value;
            teste.IdadeCidadao = int.Parse(this.idadeTextBox.Text);
            teste.ResultadoTeste = this.GetResultado();

            return teste;
        }

        #endregion

        #region Eventos

        private void codigoTesteCovid19TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CarregarTeste();
            }
        }

        private void FormTesteCovid19_Load(object sender, EventArgs e)
        {
            /// Carrega os nomes para o menu
            this.novoToolStripMenuItem.Text = Properties.Resources.GLOBAL_MENU_NOVO;
            this.gravarToolStripMenuItem.Text = Properties.Resources.GLOBAL_MENU_GRAVAR;
            this.eliminarToolStripMenuItem.Text = Properties.Resources.GLOBAL_MENU_ELIMINAR;
            this.sairToolStripMenuItem.Text = Properties.Resources.GLOBAL_MENU_SAIR;

            this.CarregarLista();

        }

        private void CarregarLista()
        {
            TesteCovid19Collection testes = TesteCovid19.ObterListaTestes();
            if (testes != null)
            {
                this.testeCovid19ListBox.Items.Clear();

                foreach (TesteCovid19 teste in testes)
                {
                    // Formato (Nome + Ano mês do exame + Resultado) 
                    string anoMes = teste.DataTeste.Year.ToString() + " " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(teste.DataTeste.Month);
                    string resultado = teste.ResultadoTeste == EnumResultado.Positivo ? "Positive" : "Negativo";
                    string textoFormatado = teste.Nome + " - " + anoMes + " - " + resultado;
                    this.testeCovid19ListBox.Items.Add(textoFormatado);
                }
            }
        }

        private void Eliminar()
        {
            string erro = string.Empty;
            TesteCovid19 teste = new TesteCovid19();

            teste.CodTest = this.codigoTesteCovid19TextBox.Text;

            bool ok = teste.Eliminar(out erro);

            if (ok)
            {
                MessageBox.Show("Eliminado com sucesso");
            }
            else
            {
                MessageBox.Show(string.Format("Erro a Eliminado [{0}]", erro));
            }
        }

        private void Novo()
        {
            TesteCovid19 teste = new TesteCovid19();

            teste.Novo();

            this.MostrarTeste(teste);
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            this.Novo();
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            this.Gravar();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            SetResultadoLabel();
        }




        #endregion

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Novo();
        }

        private void gravarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Gravar();
        }
    }
}
