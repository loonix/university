using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Presidenciais.registo;

namespace Presidenciais
{
    public class Service
    {
        /// <summary>
        /// Loads all resultados and displays a message box in case there is no file
        /// </summary>
        public static void loadResultados()
        {
            string NomeFic = "resultados.txt";
            if (File.Exists(NomeFic))
            {
                StreamReader FicheiroLer = new StreamReader(NomeFic);
                RegistoResultado resultado = new RegistoResultado();
                string linha;

                ListaResultados = new List<RegistoResultado>();

                while (!FicheiroLer.EndOfStream)
                {
                    linha = FicheiroLer.ReadLine();
                    //separar a linha atraves da virgula e colocar cada campo num vetor
                    string[] campos = linha.Split(',');
                    resultado.Distrito = campos[0];
                    resultado.votacaoMRS = int.Parse(campos[1]);
                    resultado.votacaoSN = int.Parse(campos[2]);
                    resultado.votacaoMM = int.Parse(campos[3]);
                    resultado.votacaoVS = int.Parse(campos[4]);
                    resultado.votacaoMB = int.Parse(campos[5]);
                    resultado.votacaoPM = int.Parse(campos[6]);
                    resultado.votacaoES = int.Parse(campos[7]);
                    resultado.votacaoHN = int.Parse(campos[8]);
                    resultado.votacaoJS = int.Parse(campos[9]);
                    resultado.votacaoCF = int.Parse(campos[10]);
                    resultado.votacaoBranco = int.Parse(campos[11]);
                    resultado.votacaoNulos = int.Parse(campos[12]);
                    ListaResultados.Add(resultado);
                }
                FicheiroLer.Close();
            }
            else
            {
                MessageBox.Show("O ficheiro resultados.txt nao existe", "Abrir Ficheiro", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Clears the text file
        /// </summary>
        /// <param name="fileName"></param>
        public static void clearTextFile(string fileName)
        {
            File.WriteAllText(fileName, String.Empty);
            TextWriter tw = new StreamWriter(fileName, true);
            tw.WriteLine("Your String!");
            tw.Close();
        }
    }
}
