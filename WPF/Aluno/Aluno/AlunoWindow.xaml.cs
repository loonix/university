using CamadaNegocio;
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
using System.Windows.Shapes;

namespace ProjetoAluno
{
    /// <summary>
    /// Interaction logic for AlunoWindow.xaml
    /// </summary>
    public partial class AlunoWindow : Window
    {
        public AlunoWindow()
        {
            InitializeComponent();

            Aluno aluno = new Aluno();

            this.DataContext = aluno;
        }

        private void gravarButton_Click(object sender, RoutedEventArgs e)
        {
            Aluno aluno = this.DataContext as Aluno;
            string errorMessage = string.Empty;

            if (aluno != null)
            {
                aluno.Gravar(out errorMessage);
            }

        }
    }
}
