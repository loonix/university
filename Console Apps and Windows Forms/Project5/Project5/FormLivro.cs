using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5
{
    public partial class FormLivro : Form
    {
        #region Construtores

        public FormLivro()
        {
            InitializeComponent();
        }
        #endregion


        #region Propriedades

        private LivroCollection livros;

        #endregion


        #region Metodos
        private void CarregarLivros()
        {
            this.livros = new LivroCollection();

            Livro livro = new Livro();
            livro.EAN = 3510000123;
            livro.Titulo = "Estudar Programacao";
            livro.DataEdicao = new DateTime(2020, 10, 3);
            livro.NumeroPaginas = 120;
            livro.GeneroLivro = GeneroLivroEnum.Drama;

            this.livros.Add(livro);

            livro = new Livro(3510000124, "Fazer o Trabalho", new DateTime(2020, 12, 3), 32, GeneroLivroEnum.Aventura);
            this.livros.Add(livro);

            livro = new Livro(3510000125, "Dormir", new DateTime(2020, 12, 26), 132, GeneroLivroEnum.Accao);
            this.livros.Add(livro);

            livro = new Livro(3510000125, "Acordar", new DateTime(2019, 1, 26), 320, GeneroLivroEnum.Aventura);
            this.livros.Add(livro);
        }

        #endregion


        #region Eventos
        private void FormLivro_Load(object sender, EventArgs e)
        {
            this.CarregarLivros();
        }

      
        #endregion

        private void FormLivro_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.livros = null;
        }
    }
}
