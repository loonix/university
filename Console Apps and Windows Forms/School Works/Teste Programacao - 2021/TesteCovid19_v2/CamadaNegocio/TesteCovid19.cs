using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaNegocio
{

    public enum EnumResultado
    {
        Positivo = 0,
        Negativo = 1,
        NaoDefinido = 3,
    }

    public class TesteCovid19
    {
        #region Construtor
        public TesteCovid19()
        {
            this.codTeste = Guid.NewGuid().ToString();
            this.nome = string.Empty;
            this.dataTeste = DateTime.Today;
            this.idadeCidadao = 0;
            this.resultadoTeste = EnumResultado.NaoDefinido;
        }

        #endregion

        #region Propriedades

        private string codTeste;
        public string CodTest { get => codTeste; set => codTeste = value; }

        private string nome;
        public string Nome { get => nome; set => nome = value; }

        private DateTime dataTeste;
        public DateTime DataTeste { get => dataTeste; set => dataTeste = value; }

        private int idadeCidadao;
        public int IdadeCidadao { get => idadeCidadao; set => idadeCidadao = value; }

        private EnumResultado resultadoTeste;
        public EnumResultado ResultadoTeste { get => resultadoTeste; set => resultadoTeste = value; }
        #endregion

        #region Metodos

        /// <summary>
        /// Cria uma nova nota com valores por defeito
        /// </summary>
        public void Novo()
        {
            DateTime data = DateTime.Today;

            this.CodTest = Guid.NewGuid().ToString();
            this.Nome = string.Empty;
            this.DataTeste = DateTime.Today;
            this.IdadeCidadao = 0;
            this.ResultadoTeste = EnumResultado.NaoDefinido;
        }

        /// <summary>
        /// Funcao que guarda os valores
        /// </summary>
        /// <param name="erro"></param>
        /// <returns></returns>
        public bool Gravar(out string erro)
        {
            erro = string.Empty;
            bool ok = CamadaDados.TesteCovid19.Gravar((string)this.CodTest, (string)this.Nome, (DateTime)this.DataTeste,
                                              (Int32)this.IdadeCidadao, (Int32)this.ResultadoTeste, out erro);
            return ok;
        }

        /// <summary>
        /// Funcao que elimina a nota
        /// </summary>
        /// <param name="erro"></param>
        /// <returns></returns>
        public bool Eliminar(out string erro)
        {
            erro = string.Empty;
            bool ok = CamadaDados.TesteCovid19.Eliminar(this.CodTest, out erro);
            return ok;
        }

        /// <summary>
        /// Obtem uma nota especifica
        /// </summary>
        /// <param name="codTeste"></param>
        /// <param name="erro"></param>
        /// <returns></returns>
        public static TesteCovid19 ObterTeste(string codTeste, out string erro)
        {
            TesteCovid19 teste = null;
            erro = string.Empty;

            string nome = string.Empty;
            DateTime dataTeste = DateTime.Today;
            int idadeCidadao = 0;
            int resultadoTeste = 0;


            bool ok = CamadaDados.TesteCovid19.Obter(codTeste, ref nome, ref dataTeste, ref idadeCidadao, ref resultadoTeste, out erro);
            if (ok)
            {
                teste = new TesteCovid19();
                teste.Nome = nome;
                teste.DataTeste = dataTeste;
                teste.idadeCidadao = idadeCidadao;
                teste.ResultadoTeste = (EnumResultado)idadeCidadao;

            }
            return teste;
        }

        /// <summary>
        /// Funcao que obtem a lista total ou parcial de testes
        /// </summary>
        public static TesteCovid19Collection ObterListaNotas()
        {
            DataTable dataTable = CamadaDados.TesteCovid19.ObterLista();
            TesteCovid19Collection testes = new TesteCovid19Collection(dataTable);
            return testes;
        }
        #endregion
    }
}
