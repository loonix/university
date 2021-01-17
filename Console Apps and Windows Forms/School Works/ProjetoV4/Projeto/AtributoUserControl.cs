using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocio;

namespace ExemploProjeto
{
    public partial class AtributoUserControl : System.Windows.Forms.UserControl
    {
        public AtributoUserControl()
        {
            InitializeComponent();
        }

        #region Propriedades

        private AtributoProjetoEnum atributo;

        [Category("Novos")]
        [Description("Atributos do projeto.")]
        public AtributoProjetoEnum Atributo
        {
            get 
            {
                this.atributo = AtributoProjetoEnum.Nada;

                if (this.pagoCheckBox.Checked)
                {
                    this.atributo |= AtributoProjetoEnum.Pago;
                }
                if (this.finalizadoCheckBox.Checked)
                {
                    //atributo = atributo | AtributoProjetoEnum.Finalizado;
                    //Significado Igual
                    this.atributo |= AtributoProjetoEnum.Finalizado;
                }
                if (this.comFinanciamentoCheckBox.Checked)
                {
                    this.atributo |= AtributoProjetoEnum.ComFinanciamento;
                }

                return atributo; 
            }
            set 
            { 
                this.atributo = value;
                //  projeto.Atributo = 5
                // 5 & 1 == 1
                // 0101 & 0001 == 0001
                //
                //   0101
                // & 0001
                // ______
                //   0001

                this.pagoCheckBox.Checked = ((this.atributo & AtributoProjetoEnum.Pago) == AtributoProjetoEnum.Pago);

                //  projeto.Atributo = 5
                // 5 & 1 == 1
                // 0101 & 0010 == 0010
                //
                //   0101
                // & 0010
                // ______
                //   0000
                this.finalizadoCheckBox.Checked = ((this.atributo & AtributoProjetoEnum.Finalizado) == AtributoProjetoEnum.Finalizado);

                //  projeto.Atributo = 5
                // 5 & 1 == 1
                // 0101 & 0100 == 0100
                //
                //   0101
                // & 0100
                // ______
                //   0100
                this.comFinanciamentoCheckBox.Checked = ((this.atributo & AtributoProjetoEnum.ComFinanciamento) == AtributoProjetoEnum.ComFinanciamento);

                if (this.atributo == (AtributoProjetoEnum.Pago | AtributoProjetoEnum.Finalizado | AtributoProjetoEnum.ComFinanciamento))
                {
                    this.OnTodasAsOpcoes();
                }

            }
        }


        #endregion

        #region Eventos

        [Category("Novos")]
        [Description("Ocorre quando todas as opções estiverem activas.")]
        public event EventHandler TodasAsOpcoes;

        public void OnTodasAsOpcoes()
        {
            if (this.TodasAsOpcoes != null)
            {
                this.TodasAsOpcoes(this, new EventArgs());
            }
        }

        private void atributoCheckBox_Click(object sender, EventArgs e)
        {
            if (this.pagoCheckBox.Checked && this.finalizadoCheckBox.Checked && this.comFinanciamentoCheckBox.Checked)
            {
                this.OnTodasAsOpcoes();
            }
        }

        #endregion

    }
}
