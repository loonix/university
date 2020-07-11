using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10_Gestao_de_notas
{
    class ClassNotas
    {
        #region "Propriedades"

        private static int objetoNumero;
        public int Numero { get; set; }
        public string Nome { get; set; }
        public double NotaTrab { get; set; }
        public double NotaTeste { get; set; }
        public string Estado //propriedade publica APENAS DE LEITURA
        {
            get { return campoEstado; }
        }
        private string campoEstado;

        #endregion

        #region "Métodos" 

        public double Media()
        {
            double med;
            med = (this.NotaTeste + this.NotaTrab) / 2;
            if (med < 9.5) campoEstado = "Aprovado";
            else campoEstado = "Reprovado";
            return med;
        }

        public double Media(int percTest)
        {
            double med;
            med = ((this.NotaTeste * percTest / 100) + (this.NotaTrab * (100 - percTest) / 100));
            if (med < 9.5) campoEstado = "Aprovado";
            else campoEstado = "Reprovado";
            return med;
        }

        public ClassNotas()
        {
            //Codigo base da classe - codigo executado sempre que criamos
            //uma instância da classe
            campoEstado = "Sem Classificação";
        }
        //Construtor 2 da classe sobrecarregado
        public ClassNotas(int propNumero, string propNome,
         double propNotaTrab, double propNotaTeste)
        {
            Numero = propNumero;
            Nome = propNome;
            NotaTrab = propNotaTrab;
            NotaTeste = propNotaTeste;
            Media();
        }
        public ClassNotas(int propNumero, string propNome)
        {
            Numero = propNumero;
            Nome = propNome;
        }

        #endregion

    }
}
