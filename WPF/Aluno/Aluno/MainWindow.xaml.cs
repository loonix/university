﻿using System;
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

namespace ProjetoAluno
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void alunoWindowButton_Click(object sender, RoutedEventArgs e)
        {
            AlunoWindow alunoWindow = new AlunoWindow();
            alunoWindow.ShowDialog();
        }

        private void listaAlunoWindowButton_click(object sender, RoutedEventArgs e)
        {
            ListaAlunoWindow listaAlunoWindow = new ListaAlunoWindow();
            

            bool? dialogResult = listaAlunoWindow.ShowDialog();
            if (dialogResult.HasValue && dialogResult.Value) this.DataContext = listaAlunoWindow.AlunoSelecionado;
        }

        
    }
}
