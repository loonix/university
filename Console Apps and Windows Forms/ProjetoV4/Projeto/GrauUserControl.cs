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
    public partial class GrauUserControl : UserControl
    {
        public GrauUserControl()
        {
            InitializeComponent();
        }

        #region Propriedades

        private GrauEnum grau;

        public GrauEnum Grau
        {
            get 
            {
                this.grau = GrauEnum.NaoDefinido;
                if (this.simplesRadioButton.Checked)
                {
                    this.grau = GrauEnum.Simples;
                }
                else if (this.idealRadioButton.Checked)
                {
                    this.grau = GrauEnum.Ideal;
                }
                else if (this.elevadoRadioButton.Checked)
                {
                    this.grau = GrauEnum.Elevado;
                }

                return this.grau; 
            }
            set 
            { 
                this.grau = value;

                if (this.grau == GrauEnum.Simples)
                {
                    this.simplesRadioButton.Checked = true;
                }
                else if (this.grau == GrauEnum.Ideal)
                {
                    this.idealRadioButton.Checked = true;
                }
                else if (this.grau == GrauEnum.Elevado)
                {
                    this.elevadoRadioButton.Checked = true;
                }
                else
                {
                    this.naoDefinidoRadioButton.Checked = true;
                }
            }
        }

        #endregion

        #region Metodos

        public void Limpar()
        {
            this.naoDefinidoRadioButton.Checked = true;
        }

        internal void Selecionar(NivelEnum nivel)
        {
            Color color = Color.Black;
            RadioButton radioButton = null;

            //this.naoDefinidoRadioButton.ForeColor = Color.Black;
            //this.simplesRadioButton.ForeColor = Color.Black;
            //this.idealRadioButton.ForeColor = Color.Black;
            //this.elevadoRadioButton.ForeColor = Color.Black;
            //IGUAL
            foreach (Control control in this.grauPanel.Controls)
            {
                if (control is RadioButton)
                {
                    control.ForeColor = Color.Black;
                }
            }

            if (nivel == NivelEnum.Normal)
            {
                radioButton = this.simplesRadioButton;
                color = Color.Green;
            }
            else if (nivel == NivelEnum.Avancado)
            {
                radioButton = this.elevadoRadioButton;
                color = Color.Red;
            }

            if (radioButton != null)
            {
                radioButton.Checked = true;
                radioButton.ForeColor = color;
            }
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Ocorre quando se faz click sobre a opção Ideal
        /// </summary>
        public event EventHandler SelecionouIdeal;

        public void OnSelecionouIdeal()
        {
            if (this.SelecionouIdeal != null)
            {
                this.SelecionouIdeal(this, new EventArgs());
            }
        }

        private void idealRadioButton_Click(object sender, EventArgs e)
        {
            this.OnSelecionouIdeal();
        }

        #endregion

    }
}
