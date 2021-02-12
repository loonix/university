using CamadaNegocio;
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
    public partial class FormTesteCovid19 : Form
    {
        public FormTesteCovid19()
        {
            InitializeComponent();
        }

        #region Metodos

        private void Gravar()
        {
            string erro = string.Empty;

            if (this.DadosValidos())
            {
                TesteCovid19 teste = this.ObterTeste();

                bool ok = teste.Gravar(out erro);

                if (ok)
                {
                    //MessageBox.Show(Properties.Resources.MESSAGE_GRAVADO_COM_SUCESSO);
                }
                else
                {
                    //MessageBox.Show(GlobalDLL.GlobalTexto.Format(Properties.Resources.MESSAGE_ERRO_A_GRAVAR, erro));
                }
            }
        }

        private bool DadosValidos()
        {
            bool ok = true;
            int valorVazio = 0;
            string codTeste = this.codigoTesteCovid19TextBox.Text;
            string nome = this.nomeTextBox.Text;
            DateTime dataTeste = this.dataTesteDateTimePicker.Value;
            int idadeCidadao = int.Parse(this.idadeTextBox.Text);
            int resultadoTeste = int.Parse(this.resultadoPanel.Text); /// TODO:
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
        #endregion

        #region Eventos

        private void codigoTesteCovid19TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CarregarProjeto();
            }
        }

        private void FormTesteCovid19_Load(object sender, EventArgs e)
        {

        }

        private void novoButton_Click(object sender, EventArgs e)
        {

        }

        private void gravarButton_Click(object sender, EventArgs e)
        {

        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {

        }

        private void sairButton_Click(object sender, EventArgs e)
        {

        }

        private void totalButton_Click(object sender, EventArgs e)
        {

        }

       

        #endregion


    }
}
