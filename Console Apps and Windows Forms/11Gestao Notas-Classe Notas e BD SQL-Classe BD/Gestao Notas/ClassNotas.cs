using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Notas
{
    class ClassNotas
    {

        //criar propriedades autoimplementadas: prop tab tab
        public string Numero { get; set; }
        public string Nome { get; set; }
        public double NotaTrabalho { get; set; }
        public double NotaTeste { get; set; }

        //criar propriedades "completas": propfull tab tab
        private string campoEstado;
        public string Estado //propriedade apenas de leitura
        {
            get { return campoEstado; }            
        }


        //Construtor 1 da classse
        public ClassNotas()
        {
            //Codigo base da classe - codigo executado sempre que criamos
            //uma instância da classe
            campoEstado = "Sem Classificação";

        }

        //Construtor 2 da classse
        public ClassNotas(string campoNumero, string campoNome, double campoTeste, 
                          double campoTrab)
        {
            Numero = campoNumero;
            Nome = campoNome;
            NotaTeste = campoTeste;
            NotaTrabalho = campoTrab; 
        }

        //Construtor 3 da classse
        public ClassNotas(string campoNumero, string campoNome)
        {
            Numero = campoNumero;
            Nome = campoNome;          
        }


        //Métodos ou funções
        public double Media()
        {
            double med;
            med = (NotaTeste + NotaTrabalho) / 2;

            if (med >= 9.5)
                campoEstado = "Aprovado";
            else
                campoEstado = "Reprovado";
            return med;
        }

        public double Media(int percTeste)
        {
            double med;
            med = ((NotaTeste * percTeste / 100) + NotaTrabalho * (100 - percTeste) / 100);

            if (med >= 9.5)
                campoEstado = "Aprovado";
            else
                campoEstado = "Reprovado";
            return med;
        }

    }
}
