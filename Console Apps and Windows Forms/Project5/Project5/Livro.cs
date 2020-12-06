using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    public class Livro
    {
        #region Construtores
        public Livro() {
            this.ean = 0;
            this.titulo = string.Empty;
            this.dataEdicao = DateTime.Today;
            this.numeroPaginas = 0;
            this.generoLivro = GeneroLivroEnum.NaoDefinido;
        }

        public Livro(long ean, string titulo, DateTime dataEdicao, int numeroPaginas, GeneroLivroEnum generoLivro) : this()
        {
            this.ean = ean;
            this.titulo = titulo;
            this.dataEdicao = dataEdicao;
            this.numeroPaginas = numeroPaginas;
            this.generoLivro = generoLivro;
        }

        #endregion

        #region Propriedades

        private long ean;

        public long EAN
        {
            get { return ean; }
            set { ean = value; }
        }

        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private DateTime dataEdicao;

        public DateTime DataEdicao
        {
            get { return dataEdicao; }
            set { dataEdicao = value; }
        }

        private int numeroPaginas;

        public int NumeroPaginas
        {
            get { return numeroPaginas; }
            set { numeroPaginas = value; }
        }

        private GeneroLivroEnum generoLivro;


        public GeneroLivroEnum GeneroLivro
        {
            get { return generoLivro; }
            set { generoLivro = value; }
        }


        #endregion
    }
}
