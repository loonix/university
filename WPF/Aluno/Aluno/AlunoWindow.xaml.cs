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
            this.Novo();
        }

        #region Metodos

        private void Gravar()
        {
            Aluno aluno = this.DataContext as Aluno;
            string errorMessage = string.Empty;

            if (aluno != null)
            {
                aluno.Gravar(out errorMessage);
            }
        }

        private void Novo()
        {
            Aluno aluno = new Aluno();
            aluno.Novo();
            this.DataContext = aluno;
        }
        private void Eliminar()
        {
            Aluno aluno = this.DataContext as Aluno;
            string errorMessage = string.Empty;

            if (aluno != null)
            {
                aluno.Gravar(out errorMessage);
            }
        }

        private void Sair()
        {
            this.Close();
        }

        private void ObterAluno()
        {
            Aluno aluno = this.DataContext as Aluno;
            Aluno novoAluno = Aluno.ObterAluno(aluno.CodigoAluno);
            if (novoAluno != null) this.DataContext = novoAluno;
        }

        #endregion

        #region Eventos



        private void Novo_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Novo();
        }

        private void Gravar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Gravar();
        }

        private void Sair_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Sair();
        }

        private void Eliminar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Eliminar();
        }
        #endregion

        private void textBoxCodAluno_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void codAlunoTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) {
                //this.nomeTextBox.Focus();
                this.ObterAluno(); 
            }
        }

        private void listaAlunoButton_Click(object sender, RoutedEventArgs e)
        {
            ListaAlunoWindow listaAlunoWindow = new ListaAlunoWindow();
            listaAlunoWindow.ShowDialog();
        }
    }
}
