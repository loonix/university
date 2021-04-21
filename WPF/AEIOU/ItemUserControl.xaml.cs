using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AEIOU
{
    /// <summary>
    /// Interaction logic for ItemUserControl.xaml
    /// </summary>
    public partial class ItemUserControl : UserControl
    {

        public string Title
        {
            get { return (string)GetValue(title); }
            set { SetValue(title, value); }
        }

        public static readonly DependencyProperty title =
            DependencyProperty.Register("Title", typeof(string), typeof(ItemUserControl), new UIPropertyMetadata(null));

        public string SubTitle
        {
            get { return (string)GetValue(subTitle); }
            set { SetValue(subTitle, value); }
        }

        public static readonly DependencyProperty subTitle =
            DependencyProperty.Register("SubTitle", typeof(string), typeof(ItemUserControl), new UIPropertyMetadata(null));


        public ItemUserControl()
        {
            InitializeComponent();
            this.DataContext = this;

        }


    }
}
