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
    /// Interaction logic for myCard.xaml
    /// </summary>
    public partial class myCard : UserControl
    {

        #region construtor
        public myCard()
        {
            InitializeComponent();
            this.cardValue = string.Empty;
            this.cardText = string.Empty;

            this.cardIcon = PackIconKind.AbjadArabic;

        }

        #endregion 

        #region Propriedades

        private string cardValue;

        public string CardValue
        {
            get { return cardValue; }
            set { cardValue = value; }
        }

        private string cardText;

        public string CardText
        {
            get { return cardText; }
            set { cardText = value; }
        }



        private PackIconKind cardIcon;

        public PackIconKind CardIcon
        {
            get { return cardIcon; }
            set { cardIcon = value; }
        }
        #endregion
    }
}
