using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Geometria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Aluno aluno = new Aluno();
            aluno.Codigo = 1;
            aluno.Nome = "Mike Terere";
            aluno.EstatutoTrabalhadorEstudante = true;

            Professor professor = new Professor();
            professor.Codigo = 1;
            professor.Nome = "Matias Xibanga";
            professor.DataInicioAulas = DateTime.Today;

            List<BaseEntity> entidades = new List<BaseEntity>();

            this.listBox1.DisplayMemberPath = "Nome";

            entidades.Add(aluno);
            entidades.Add(professor);

            this.listBox1.ItemsSource = entidades;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string figuraGeometrica = ((ComboBoxItem)this.comboBox1.SelectedItem).Content as string;

            if (figuraGeometrica == "Quadrado")
            {
                Quadrado quadrado = new Quadrado(5);
                Adicionar(quadrado);
            }
            else if (figuraGeometrica == "Triangulo")
            {
                Triangulo triangulo = new Triangulo(10, 5);
                Adicionar(triangulo);
            }
        }

        private void Adicionar(IFiguraGeometrica figuraGeometrica)
        {
            this.listBox1.Items.Add(figuraGeometrica);
            this.CalcularArea();
        }

        private void CalcularArea()
        {
            float totalArea = 0;
            foreach (IFiguraGeometrica item in this.listBox1.Items)
            {
                totalArea += item.Area();
            }
            this.resultadoAreaLabel.Content = totalArea.ToString();
        }
    }
}
