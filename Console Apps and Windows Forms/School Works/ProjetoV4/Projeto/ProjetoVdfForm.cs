using CamadaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploProjeto
{
    public partial class ProjetoVdfForm : Form
    {
        #region Contrutores
        public ProjetoVdfForm()
        {
            InitializeComponent();
        }
        #endregion Costrutores


        #region Propriedades

        #endregion

        #region Metodos

        private void Gravar()
        {
            string erro = string.Empty;

            if (this.DadosValidos())
            {
                ProjetoVdf projetoVdf = this.ObterProjetoVdf();

                bool ok = projetoVdf.Gravar(out erro);

                if (ok)
                {
                    MessageBox.Show(GlobalDLL.GlobalTexto.Format(Properties.Resources.MESSAGE_GRAVADO_COM_SUCESSO));
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

            string idWo= this.idWoTextBox.Text;
            //long idwo = 0;

            //long.TryParse(idWoTexto, out idwo);
            ////{
            ////    projetoVdf.IdWo = idwo;
            ////}

            string cliente = this.clienteTextBox.Text;
            DateTime dataInicioPedido = this.dataInicioPedidoDateTimePicker.Value;
            string duracaoContrato = this.duracaoContratoComboBox.Text;
            string latitude = this.latitudeTextBox.Text;
            string longitude = this.longitudeTextBox.Text;
            string nomePV = this.nomePVComboBox.Text;



            this.errorProviderProjetoVdf.Clear();

            if (string.IsNullOrWhiteSpace(idWo))
            {
                //MessageBox.Show(Properties.Resources.MESSAGE_ID_PROJETO_INVALIDO);
                this.errorProviderProjetoVdf.SetError(this.idWoTextBox, Properties.Resources.MESSAGE_ID_PROJETO_INVALIDO);
                ok = false;
            }
            if (string.IsNullOrWhiteSpace(cliente))
            {
                //MessageBox.Show(Properties.Resources.MESSAGE_ID_PROJETO_INVALIDO);
                this.errorProviderProjetoVdf.SetError(this.clienteTextBox, Properties.Resources.MESSAGE_CLIENTE_INVALIDO);
                ok = false;
            }
            if (dataInicioPedido <= DateTime.Today)
            {
                this.errorProviderProjetoVdf.SetError(this.dataInicioPedidoDateTimePicker, "Deve Inserir uma data válida");
                this.dataInicioPedidoDateTimePicker.Focus();
                ok = false;
            }

            return ok;
        }

        private ProjetoVdf ObterProjetoVdf()
        {
            ProjetoVdf projetoVdf = new ProjetoVdf();

            string idWoTexto = this.idWoTextBox.Text;

            //long idwo = 0;

            //if (long.TryParse(idWoTexto, out idwo))
            //{
            //    projetoVdf.IdWo = idwo;
            //}
            projetoVdf.IdWo = long.Parse(idWoTexto);
            projetoVdf.Cliente = this.clienteTextBox.Text;
            projetoVdf.DataInicioPedido = this.dataInicioPedidoDateTimePicker.Value;
            projetoVdf.DuracaoContrato = this.duracaoContratoComboBox.Text;
            projetoVdf.Latitude = this.latitudeTextBox.Text;
            projetoVdf.Longitude = this.longitudeTextBox.Text;
            projetoVdf.NomePV = this.nomePVComboBox.Text;

            projetoVdf.TipoNegocio = this.tipoNegocioUserControl.TipoNegocio;

           
            return projetoVdf;
        }

        private void Eliminar()
        {
            string erro = string.Empty;
            ProjetoVdf projetoVdf = new ProjetoVdf();

            string idWoTexto = this.idWoTextBox.Text;

            long idWo = 0;


            if (long.TryParse(idWoTexto, out idWo))
            {
                projetoVdf.IdWo = idWo;

                bool ok = projetoVdf.Eliminar(out erro);

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
                MessageBox.Show("Id da Work Order não definido");
            }
        }

        private void CarregarProjetoVdf()
        {
            string idWoTexto = this.idWoTextBox.Text;

            long idWo = 0;

            if (long.TryParse(idWoTexto, out idWo))
            {
                string erro = string.Empty;

                ProjetoVdf projetoVdf = ProjetoVdf.Obter(idWo, out erro);
                if (projetoVdf == null)
                {
                    //MessageBox.Show(string.Format("ProjetoVdf [{0}] não existe na BD. Erro[{1}]", idWo, erro));
                    //IGUAL
                    MessageBox.Show(GlobalDLL.GlobalTexto.Format(Properties.Resources.MESSAGE_WO_NAO_EXISTE, idWo, erro));
                }
                else
                {
                    this.MostrarProjetoVdf(projetoVdf);
                }
            }
        }

        private void MostrarProjetoVdf(ProjetoVdf projetoVdf)
        {
            if (projetoVdf == null)
            {
                return;
            }

            this.idWoTextBox.Text = projetoVdf.IdWo.ToString();
            this.clienteTextBox.Text = projetoVdf.Cliente;
            this.dataInicioPedidoDateTimePicker.Value = projetoVdf.DataInicioPedido;
            this.duracaoContratoComboBox.Text = projetoVdf.DuracaoContrato;
            this.latitudeTextBox.Text = projetoVdf.Latitude.ToString();
            this.longitudeTextBox.Text = projetoVdf.Longitude.ToString();
        }

        private void MostarListaProjetosVdf()
        {
            //ProjetoListaForm projetoListaForm = new ProjetoListaForm();

            //projetoListaForm.ShowDialog();
        }

        private void Novo()
        {
            ProjetoVdf projetoVdf = new ProjetoVdf();

            projetoVdf.Novo();

            this.MostrarProjetoVdf(projetoVdf);
        }


        #endregion

        #region Eventos

        private void Sair()
        {
            this.Close();
            Application.Exit();
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            this.Gravar();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }


        private void idWoTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CarregarProjetoVdf();
            }
        }

        private void listaButton_Click(object sender, EventArgs e)
        {
            this.MostarListaProjetosVdf();
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

        
        private void gravar_Click(object sender, EventArgs e)
        {
            this.Gravar();
        }

     

        //private void idProjetoTextBox_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        this.CarregarProjetoVdf();
        //    }
        //}


        //private void novo_Click(object sender, EventArgs e)
        //{
        //    this.Novo();
        //}

        //private void ProjetoForm_Load(object sender, EventArgs e)
        //{
        //    this.CarregarDados();
        //}

        //private void nivelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (this.nivelComboBox.Enabled)
        //    {
        //        this.SelecionaNivel();
        //    }
        //}

        //private void grauUserControl_SelecionouIdeal(object sender, EventArgs e)
        //{
        //    this.grauUserControl.BackColor = Color.Yellow;
        //}

        private void atributoUserControl_TodasAsOpcoes(object sender, EventArgs e)
        {
            MessageBox.Show("Finalizou o projeto");
        }

        private void dataInicioPedidoLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProjetoVdfForm_Load(object sender, EventArgs e)
        {
            //this.CarregarDados();
            //this.CarregarResources();
        }

       

        //private void totalValorButtonV1_Click(object sender, EventArgs e)
        //{
        //    ProjetoCollection projetos = Projeto.ObterListaProjetos();
        //    float totalValorProjetos = 0;

        //    foreach (ProjetoVdf projetoVdf in projetos)
        //    {
        //        totalValorProjetos += projetoVdf.Valor;
        //    }

        //    this.totalValorLabel.Text = totalValorProjetos.ToString();
        //}

        //private void totalValorV2Button_Click(object sender, EventArgs e)
        //{
        //    ProjetoCollection projetos = Projeto.ObterListaProjetos();

        //    float totalValorProjetos = projetos.ObterTotalValor();

        //    this.totalValorLabel.Text = totalValorProjetos.ToString();
        //}

        //private void totalValorV3Button_Click(object sender, EventArgs e)
        //{
        //    ProjetoCollection projetos = Projeto.ObterListaProjetos();

        //    float totalValorProjetos = projetos.ObterTotalValorV2();

        //    this.totalValorLabel.Text = totalValorProjetos.ToString();
        //}

    }
}
