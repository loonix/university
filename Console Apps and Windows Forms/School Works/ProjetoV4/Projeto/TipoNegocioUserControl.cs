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
    public partial class TipoNegocioUserControl : UserControl
    {
        public TipoNegocioUserControl()
        {
            InitializeComponent();
        }

        #region Propriedades

        private TipoNegocioEnum tipoNegocio;

        [Category("Novos")]
        [Description("Tipo de Negócio do projeto.")]
        public TipoNegocioEnum TipoNegocio
        {
            get
            {
                this.tipoNegocio = TipoNegocioEnum.Ataque;

                if (this.ataqueRadioButton.Checked)
                {
                    this.tipoNegocio = TipoNegocioEnum.Ataque;
                }
                else if (this.defesaRadioButton.Checked)
                {
                    this.tipoNegocio = TipoNegocioEnum.Defesa;
                }
                else if (this.cicloVidaradioButton.Checked)
                {
                    this.tipoNegocio = TipoNegocioEnum.CicloVida;
                }

                else if (this.modificaçõesRadioButton.Checked)
                {
                    this.tipoNegocio = TipoNegocioEnum.Modificacoes;
                }
                else if (this.vdfEspanhaRadioButton.Checked)
                {
                    this.tipoNegocio = TipoNegocioEnum.VdfEspanha;
                }
                else if (this.cicloVidaradioButton.Checked)
                {
                    this.tipoNegocio = TipoNegocioEnum.CicloVida;
                }
                else if (this.wholesaleRadioButton.Checked)
                {
                    this.tipoNegocio = TipoNegocioEnum.Wholesale;
                }
                else if (this.renovacaoContratoRadioButton.Checked)
                {
                    this.tipoNegocio = TipoNegocioEnum.RenovacaoContrato;
                }

                return this.tipoNegocio;
            }
            set
            {
                this.tipoNegocio = value;

                if (this.tipoNegocio == TipoNegocioEnum.Ataque)
                {
                    this.ataqueRadioButton.Checked = true;
                }
                else if (this.tipoNegocio == TipoNegocioEnum.Defesa)
                {
                    this.defesaRadioButton.Checked = true;
                }
                else if (this.tipoNegocio == TipoNegocioEnum.CicloVida)
                {
                    this.cicloVidaradioButton.Checked = true;
                }
                else if (this.tipoNegocio == TipoNegocioEnum.Modificacoes)
                {
                    this.modificaçõesRadioButton.Checked = true;
                }
                else if (this.tipoNegocio == TipoNegocioEnum.VdfEspanha)
                {
                    this.vdfEspanhaRadioButton.Checked = true;
                }
                else if (this.tipoNegocio == TipoNegocioEnum.CicloVida)
                {
                    this.cicloVidaradioButton.Checked = true;
                }
                else if (this.tipoNegocio == TipoNegocioEnum.Wholesale)
                {
                    this.wholesaleRadioButton.Checked = true;
                }
                else if (this.tipoNegocio == TipoNegocioEnum.RenovacaoContrato)
                {
                    this.renovacaoContratoRadioButton.Checked = true;
                }
                else
                {
                    this.ataqueRadioButton.Checked = true;
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

        //private void atributoCheckBox_Click(object sender, EventArgs e)
        //{
        //    if (this.pagoCheckBox.Checked && this.finalizadoCheckBox.Checked && this.comFinanciamentoCheckBox.Checked)
        //    {
        //        this.OnTodasAsOpcoes();
        //    }
        //}

        #endregion
    }
}
