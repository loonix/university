using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Objectos_Classes
{
    /// <summary>
    /// Definição da classe ClassProdutos -> Modelo de dados
    /// Criar uma instância: ClassProdutos novoProd = new ClassProdutos();
    /// </summary>

    class ClassProdutos
    {
        /// <summary>
        /// MEMBROS DA CLASSE
        /// PROPRIEDADES
        /// Campo numeroProduto estatico
        /// Este campo é partilhado por todos os objetos criados
        /// </summary>
        static private int numeroProduto;
        public int NumeroProduto
        {
            get
            {
                return numeroProduto;
            }
        }

        /// <summary>
        /// Propriedade Codigo
        /// Para criar esta propriedade automaticamente, escrever: prop tab tab
        /// Propriedade para Alterar e Visualizar o Codigo do produto.
        /// Exemplo set: novoProd.Codigo = "101010"
        /// Exemplo get: Codigo = novoProd.Codigo
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// Propriedade Nome
        /// Para criar esta propriedade automaticamente, escrever: propfull tab tab
        /// Propriedade para Alterar e Visualizar o Nome do produto.
        /// Exemplo SET: novoProd.Nome = "Novo nome"
        /// Exemplo GET: Nome = novoProd.Nome
        /// </summary>
        private string campoNome;
        public string Nome
        {
            get
            {
                //codigo adicional....
                return campoNome;
            }
            set
            {
                //codigo adicional....
                campoNome = value;
            }
        }
        /// <summary>
        /// Propriedade Preço
        /// Propriedade para Alterar e Visualizar o preco do produto.
        /// Exemplo SET: novoProd.Preco = Novopreco
        /// Exemplo GET: Preco = novoProd.Preco
        /// </summary>
        public double Preco { get; set; }

        private string imagem;

        public string Imagem
        {
            get { return imagem; }
            set { imagem = value; }
        }


        /// <summary>
        /// Propriedade apenas de leitura (get)
        /// Não pode ser alterado pelo obejeto (instancia)
        /// </summary>
        public double Desconto { get; }
        //METODOS (Funções)
        /// <summary>
        /// Metódo Constructor - codigo invocado sempre que criamos um obejcto desta classe
        /// </summary>
        public ClassProdutos()
        {
            //Codigo inicial da classe
            Random rnd = new Random();
            this.Desconto = rnd.Next(0, 81); //aleatorio até 0..80
        }
        /// <summary>
        /// Metódo Constructor que recebe os valores definidos para o Codigo, Nome e Preco
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nome"></param>
        /// <param name="preco"></param>
        public ClassProdutos(string codigo, string nome, double preco)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
            Random rnd = new Random();
            this.Desconto = rnd.Next(0, 81); //aleatorio até 0..80
        }
        public void AumentaPreco(float percentagem)
        {
            this.Preco = this.Preco + this.Preco * (percentagem / 100);
        }

    }
}
