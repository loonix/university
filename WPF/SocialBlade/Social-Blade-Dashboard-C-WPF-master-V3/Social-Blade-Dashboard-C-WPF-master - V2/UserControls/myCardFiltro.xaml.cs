using BusinessLayer;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Social_Blade_Dashboard.UserControls
{
    /// <summary>
    /// Interaction logic for myCardFiltro.xaml
    /// </summary>
    public partial class myCardFiltro : UserControl
    {
        public myCardFiltro()
        {
            InitializeComponent();

            this.nomePV = string.Empty;

            PreVendaCollection preVendas = PreVenda.ObterListaSimples();

            this.comboBoxPreVenda.DisplayMemberPath = "NomePV";
            this.comboBoxPreVenda.SelectedValuePath = "NomePV";
            this.comboBoxPreVenda.ItemsSource = preVendas;


        }

        #region Propriedades  

        private string nomePV;

        public string NomePV
        {
            get { return nomePV; }
            set { nomePV = value; }
        }

        private PackIconKind cardIcon;

        public PackIconKind CardIcon
        {
            get { return cardIcon; }
            set { cardIcon = value; }
        }

        #endregion

        #region Metodos  

        #endregion

        #region Eventos
        

        private void comboBoxPreVenda_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.comboBoxPreVenda.SelectedItem != null)
            {
                PreVenda preVenda  = ( PreVenda ) this.comboBoxPreVenda.SelectedItem;
                if (preVenda != null)
                {
                    this.NomePV = preVenda.NomePV;
                    this.OnPreVendaChange();
                }
               
            }
           
        }

        private void OnPreVendaChange()
        {
            if (this.PreVendaChange != null)
            {
                this.PreVendaChange(this, new EventArgs());
            }
  
        }

        public event EventHandler PreVendaChange;

        #endregion

  


    }

}
