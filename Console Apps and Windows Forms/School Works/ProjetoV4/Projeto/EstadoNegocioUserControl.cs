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
    public partial class EstadoNegocioUserControl : System.Windows.Forms.UserControl
    {
        public EstadoNegocioUserControl()
        {
            InitializeComponent();
        }
        private EstadoNegocioEnum estadoNegocio;

        [Category("Novos")]
        [Description("Estado do Negócio do projeto.")]
        public EstadoNegocioEnum EstadoNegocio
        {
            get
            {
                this.estadoNegocio = EstadoNegocioEnum.Nada;


                if (this.inProgressRadioButton.Checked)
                {
                    this.estadoNegocio = EstadoNegocioEnum.Inprogress;
                }
                else if (this.onHoldRadioButton.Checked)
                {
                    this.estadoNegocio = EstadoNegocioEnum.OnHold;
                }
                else if (this.informationPendradioButton.Checked)
                {
                    this.estadoNegocio = EstadoNegocioEnum.InformationPend;
                }
                else if (this.subCasePendRadioButton.Checked)
                {
                    this.estadoNegocio = EstadoNegocioEnum.SubCasePend;
                }
                else if (this.closePendRadioButton.Checked)
                {
                    this.estadoNegocio = EstadoNegocioEnum.ClosePend;
                }
                else if (this.proposalRadioButton.Checked)
                {
                    this.estadoNegocio = EstadoNegocioEnum.Proposal;
                }


                return this.estadoNegocio;
            }
            set
            {
                this.estadoNegocio = value;

                if (this.estadoNegocio == EstadoNegocioEnum.Inprogress)
                {
                    this.inProgressRadioButton.Checked = true;
                }
                else if (this.estadoNegocio == EstadoNegocioEnum.OnHold)
                {
                    this.onHoldRadioButton.Checked = true;
                }
                else if (this.estadoNegocio == EstadoNegocioEnum.InformationPend)
                {
                    this.informationPendradioButton.Checked = true;
                }
                else if (this.estadoNegocio == EstadoNegocioEnum.SubCasePend)
                {
                    this.subCasePendRadioButton.Checked = true;
                }
                else if (this.estadoNegocio == EstadoNegocioEnum.ClosePend)
                {
                    this.closePendRadioButton.Checked = true;
                }
                else if (this.estadoNegocio == EstadoNegocioEnum.Proposal)
                {
                    this.proposalRadioButton.Checked = true;
                }

                else
                {
                    this.estadoNegocio = EstadoNegocioEnum.Nada;

                    //this.inProgressRadioButton.Checked = true;
                }
            }
        }
    }
}
