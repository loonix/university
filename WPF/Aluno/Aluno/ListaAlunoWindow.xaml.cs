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
    /// Interaction logic for ListaAlunoWindow.xaml
    /// </summary>
    public partial class ListaAlunoWindow : Window
    {
        public ListaAlunoWindow()
        {
            InitializeComponent();

            AlunoCollection alunos = Aluno.ObterListaAlunos();

            // this.alunoListbox.DataContext = alunos;
            // this.alunoListbox2.DataContext = alunos;
            // ou
            this.DataContext = alunos;

        }

        public Aluno AlunoSelecionado { get; set; }
        private void alunoListbox2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(this.alunoListbox2.SelectedItem != null)
            {
                Aluno aluno = this.alunoListbox2.SelectedItem as Aluno;
                if(aluno != null)
                {
                    this.AlunoSelecionado = aluno;
                    this.Close();
                }
                   
            }
        }
    }
}
