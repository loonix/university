using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_USA
{
    class ClassFuncoesGlobais
    {

        //estrutura de campos
        public struct RegistoUSA
        {
            public string nome;
            public int anoInicio;
            public int anoFim;
            public string partido;
        }

        //definir a coleção de dados para armezenar em memória cada registo 
        public static List<RegistoUSA> listPresidentes = new List<RegistoUSA>(); 

    }
}
