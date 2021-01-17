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
    public partial class ProjetoListaForm : Form
    {

        #region Construtor

        public ProjetoListaForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void ProjetoListaForm_Load(object sender, EventArgs e)
        {
            this.CarregarDados();
        }

        #endregion

        #region Metodos

        private void CarregarDados()
        {
            ProjetoCollection projetos = Projeto.ObterListaProjetos();

            this.MostrarProjetos(projetos);
        }

        private void MostrarProjetos(ProjetoCollection projetos)
        {
            if (projetos != null)
            {
                this.listProjetosListBox.Items.Clear();

                foreach (Projeto projeto in projetos)
                {
                    this.listProjetosListBox.Items.Add(projeto.Descricao);
                }
            }
        }

        #endregion

    }
}
