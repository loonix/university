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

namespace ExemploProjeto
{
    public partial class FormComboio : Form
    {
        #region Construtores

        public FormComboio()
        {
            InitializeComponent();
        }

        #endregion

        #region Propriedades

        #endregion

        #region Metodos

        private void Gravar()
        {
            string erro = string.Empty;

            if (this.DadosValidos())
            {
                Comboio comboio = this.ObterComboio();

                bool ok = comboio.Gravar(out erro);

                if (ok)
                {
                    MessageBox.Show(Properties.Resources.MESSAGE_GRAVADO_COM_SUCESSO);
                }
                else
                {
                    MessageBox.Show(GlobalDLL.GlobalTexto.Format(Properties.Resources.MESSAGE_ERRO_A_GRAVAR, erro));
                }
            }
        }

        private bool DadosValidos()
        {
            bool ok = true;
            //string idProjeto = this.idProjetoTextBox.Text;
            //string descricao = this.descricaoTextBox.Text;
            //DateTime dataInicio = this.dataInicioDateTimePicker.Value;
            //DateTime dataFim = this.dataFimDateTimePicker.Value;

            //this.errorProviderProjeto.Clear();

            //if (string.IsNullOrWhiteSpace(idProjeto))
            //{
            //    //MessageBox.Show(Properties.Resources.MESSAGE_ID_PROJETO_INVALIDO);
            //    this.errorProviderProjeto.SetError(this.idProjetoTextBox, Properties.Resources.MESSAGE_ID_PROJETO_INVALIDO);
            //    ok = false;
            //}
            //if (string.IsNullOrWhiteSpace(descricao))
            //{
            //    //MessageBox.Show(Properties.Resources.MESSAGE_ID_PROJETO_INVALIDO);
            //    this.errorProviderProjeto.SetError(this.descricaoTextBox, Properties.Resources.MESSAGE_DESCRICAO_PROJETO_INVALIDO);
            //    ok = false;
            //}
            //if (dataInicio > dataFim)
            //{
            //    this.errorProviderProjeto.SetError(this.dataInicioDateTimePicker, Properties.Resources.MESSAGE_DATA_INICIO_SUPERIOR_DATAFIM);
            //    this.dataInicioDateTimePicker.Focus();
            //    ok = false;
            //}

            return ok;
        }

        private Comboio ObterComboio()
        {
            Comboio comboio = new Comboio();

            string codigoComboioTexto = this.codigoComboioTextBox.Text;
            string numeroLugaresTexto = this.numeroLugaresTextBox.Text;

            comboio.CodigoComboio = long.Parse(codigoComboioTexto);
            comboio.DataFabrico = this.dataFabricoDateTimePicker.Value;
            comboio.Modelo = this.modeloTextBox.Text;
            comboio.NumeroLugares = int.Parse(numeroLugaresTexto);

            return comboio;
        }

        private void Eliminar()
        {
            string erro = string.Empty;
            Comboio comboio = new Comboio();

            string codigoComboioTexto = this.codigoComboioTextBox.Text;

            long codigoComboio = 0;


            if (long.TryParse(codigoComboioTexto, out codigoComboio))
            {
                comboio.CodigoComboio = codigoComboio;

                bool ok = comboio.Eliminar(out erro);

                if (ok)
                {
                    MessageBox.Show("Eliminado com sucesso");
                }
                else
                {
                    MessageBox.Show(string.Format("Erro a Eliminado [{0}]", erro));
                }
            }
            else
            {
                MessageBox.Show("Código do comboio não definido");
            }
        }

        private void CarregarComboio()
        {
            string codigoComboioTexto = this.codigoComboioTextBox.Text;

            long codigoComboio = 0;

            if (long.TryParse(codigoComboioTexto, out codigoComboio))
            {
                string erro = string.Empty;

                Comboio comboio = Comboio.Obter(codigoComboio, out erro);
                if (comboio == null)
                {
                    //MessageBox.Show(string.Format("Comboio [{0}] não existe na BD. Erro[{1}]", codigoComboio, erro));
                    //IGUAL
                    MessageBox.Show(GlobalDLL.GlobalTexto.Format(Properties.Resources.MESSAGE_COMBOIO_NAO_EXISTE, codigoComboio, erro));
                }
                else
                {
                    this.MostrarComboio(comboio);
                }
            }
        }

        private void MostrarComboio(Comboio comboio)
        {
            if (comboio == null)
            {
                return;
            }

            this.codigoComboioTextBox.Text = comboio.CodigoComboio.ToString();
            this.dataFabricoDateTimePicker.Value = comboio.DataFabrico;
            this.modeloTextBox.Text = comboio.Modelo;
            this.numeroLugaresTextBox.Text = comboio.NumeroLugares.ToString();
        }

        private void MostarListaComboios()
        {
            //ProjetoListaForm projetoListaForm = new ProjetoListaForm();

            //projetoListaForm.ShowDialog();
        }

        private void Sair()
        {
            this.Close();
            Application.Exit();
        }

        private void Novo()
        {
            Comboio comboio = new Comboio();

            comboio.Novo();

            this.MostrarComboio(comboio);
        }

        #endregion

        #region Eventos

        private void gravarButton_Click(object sender, EventArgs e)
        {
            this.Gravar();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }


        private void codigoComboioTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CarregarComboio();
            }
        }
        
        private void listaButton_Click(object sender, EventArgs e)
        {
            this.MostarListaComboios();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Sair();
        }

        private void novo_Click(object sender, EventArgs e)
        {
            this.Novo();
        }


        #endregion

    }
}
