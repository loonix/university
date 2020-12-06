using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ExemploProjeto
{
    public partial class DiaSemanaUserControl : UserControl
    {
        #region Construtor

        public DiaSemanaUserControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Propriedades

        private EnumTipoDiaSemana tipoDiaSemana;
        public EnumTipoDiaSemana TipoDiaSemana
        {
            get 
            { 
                return this.tipoDiaSemana; 
            }
            set 
            { 
                this.tipoDiaSemana = value;
                this.CarregarDados();
            }
        }

        #endregion

        #region Metodos

        private void CarregarDados()
        {
            this.diaSemanaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            //Elimina todos os registos da ComboBox
            this.diaSemanaComboBox.Items.Clear();

            //V1
            //this.diaSemanaComboBox.Items.Add("Segunda-Feira");
            //this.diaSemanaComboBox.Items.Add("Terça-Feira");
            //this.diaSemanaComboBox.Items.Add("Quarta-Feira");
            //this.diaSemanaComboBox.Items.Add("Quinta-Feira");
            //this.diaSemanaComboBox.Items.Add("Sexta-Feira");
            //this.diaSemanaComboBox.Items.Add("Sabado");
            //this.diaSemanaComboBox.Items.Add("Domingo");

            //V2
            string[] nomes = this.ObterNomesDiaSemana();

            //Percorre todos os valores do vector "nomes"
            foreach (string item in nomes)
            {
                //Adiciona o item na ComboBox
                this.diaSemanaComboBox.Items.Add(item);
            }

            //Seleciona o primeiro elemento da lista
            this.diaSemanaComboBox.SelectedIndex = 0;
        }

        private string[] ObterNomesDiaSemana()
        {
            string[] nomes = CultureInfo.CurrentCulture.DateTimeFormat.DayNames;

            if (this.TipoDiaSemana == EnumTipoDiaSemana.AbbreviatedDayNames)
            {
                nomes = CultureInfo.CurrentCulture.DateTimeFormat.AbbreviatedDayNames;
            }
            else if (this.TipoDiaSemana == EnumTipoDiaSemana.ShortestDayNames)
            {
                nomes = CultureInfo.CurrentCulture.DateTimeFormat.ShortestDayNames;
            }

            return nomes;
        }

        #endregion

        #region Eventos

        private void DiaSemanaUserControl_Load(object sender, EventArgs e)
        {
            this.CarregarDados();
        }

        private void DiaSemanaUserControl_Resize(object sender, EventArgs e)
        {
            this.diaSemanaComboBox.Left = 0;
            this.diaSemanaComboBox.Top = 0;
            this.diaSemanaComboBox.Width = this.ClientSize.Width;
            this.Height = this.diaSemanaComboBox.Height;
        }

        #endregion

    }
}
