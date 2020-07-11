using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Objectos_Classes
{
    public partial class Form1 : Form
    {

        // OBjectos Globais
        // Criar Objecto (instancia)
        // nomeClasse nomeObjecto = new nomeClasse();
        ClassProdutos classProdutos = new ClassProdutos();
        ClassProdutos novoProduto1 = new ClassProdutos();

        public Form1()
        {
            // Contructor
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            classProdutos.Codigo = "C0001";
            classProdutos.Preco = 500;
            classProdutos.Imagem = "C0001.jpg";

            novoProduto1.Codigo = "C0002";
            novoProduto1.Preco = 500;
            novoProduto1.Imagem = "C0002.jpg";



        }
    }
}
