using CamadaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploProjeto
{
    public partial class ProjetoForm : Form
    {
        #region Construtores


        public ProjetoForm()
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
                Projeto projeto = this.ObterProjeto();

                bool ok = projeto.Gravar(out erro);

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
            string idProjeto = this.idProjetoTextBox.Text;
            string descricao = this.descricaoTextBox.Text;
            DateTime dataInicio = this.dataInicioDateTimePicker.Value;
            DateTime dataFim = this.dataFimDateTimePicker.Value;

            this.errorProviderProjeto.Clear();

            if (string.IsNullOrWhiteSpace(idProjeto))
            {
                //MessageBox.Show(Properties.Resources.MESSAGE_ID_PROJETO_INVALIDO);
                this.errorProviderProjeto.SetError(this.idProjetoTextBox, Properties.Resources.MESSAGE_ID_PROJETO_INVALIDO);
                ok = false;
            }
            if (string.IsNullOrWhiteSpace(descricao))
            {
                //MessageBox.Show(Properties.Resources.MESSAGE_ID_PROJETO_INVALIDO);
                this.errorProviderProjeto.SetError(this.descricaoTextBox, Properties.Resources.MESSAGE_DESCRICAO_PROJETO_INVALIDO);
                ok = false;
            }
            if (dataInicio > dataFim)
            {
                this.errorProviderProjeto.SetError(this.dataInicioDateTimePicker, Properties.Resources.MESSAGE_DATA_INICIO_SUPERIOR_DATAFIM);
                this.dataInicioDateTimePicker.Focus();
                ok = false;
            }

            return ok;
        }

        private Projeto ObterProjeto()
        {
            Projeto projeto = new Projeto();

            projeto.IDProjeto = this.idProjetoTextBox.Text;
            projeto.Descricao = this.descricaoTextBox.Text;
            projeto.DataInicio = this.dataInicioDateTimePicker.Value;
            projeto.DataFim = this.dataFimDateTimePicker.Value;
            
            string valorTexto = this.valorTextBox.Text;
            float valor = 0;

            if (float.TryParse(valorTexto, out valor))
            {
                projeto.Valor = valor;
            }

            return projeto;
        }

        private void Eliminar()
        {
            string erro = string.Empty;
            Projeto projeto = new Projeto();

            projeto.IDProjeto = this.idProjetoTextBox.Text;

            bool ok = projeto.Eliminar(out erro);

            if (ok)
            {
                MessageBox.Show("Eliminado com sucesso");
            }
            else
            {
                MessageBox.Show(string.Format("Erro a Eliminado [{0}]", erro));
            }
        }

        private void CarregarProjeto()
        {
            string idProjeto = this.idProjetoTextBox.Text;

            Projeto projeto = Projeto.ObterProjeto(idProjeto);
            if (projeto == null)
            {
                MessageBox.Show(GlobalDLL.GlobalTexto.Format(Properties.Resources.MESSAGE_PROJETO_NAO_EXISTE, idProjeto));
            }
            else
            {
                this.MostrarProjeto(projeto);
            }
        }

        private void MostrarProjeto(Projeto projeto)
        {
            if (projeto == null)
            {
                return;
            }

            this.idProjetoTextBox.Text = projeto.IDProjeto;
            this.descricaoTextBox.Text = projeto.Descricao;
            this.dataInicioDateTimePicker.Value = projeto.DataInicio;
            this.dataFimDateTimePicker.Value = projeto.DataFim;
            this.valorTextBox.Text = projeto.Valor.ToString();
        }

        private void MostarListaProjetos()
        {
            ProjetoListaForm projetoListaForm = new ProjetoListaForm();

            projetoListaForm.ShowDialog();
        }

        private void Sair()
        {
            this.Close();
            Application.Exit();
        }

        private void Novo()
        {
            Projeto projeto = new Projeto();

            projeto.Novo();

            this.MostrarProjeto(projeto);
        }

        #endregion

        #region Eventos

        private void gravar_Click(object sender, EventArgs e)
        {
            this.Gravar();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }

        private void idProjetoTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CarregarProjeto();
            }
        }

        private void listaButton_Click(object sender, EventArgs e)
        {
            this.MostarListaProjetos();
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
