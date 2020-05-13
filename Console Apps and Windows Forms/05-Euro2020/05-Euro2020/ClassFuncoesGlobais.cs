using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Euro2020
{
    public class ClassFuncoesGlobais
    {
        public struct registoEstadio
        {
            public int NumeroEstadio;
            public string NomeEstadio;
            public string NomePais;
            public string NomeCidade;
            public string Capacidade;
            public int TotalJogos;
            public int TotalAssistencias;
            public string Estado;
        }

        public static List<registoEstadio> ListaEstadios = new List<registoEstadio>();
    }
}
