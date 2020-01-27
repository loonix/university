using System;
using System.IO;
using static Quem_Quer_Ser_Fixe.structs.structs;

namespace Quem_Quer_Ser_Fixe
{
    public static class ler_guardar_service
    {
        /// <summary>
        /// Função que recebe o nome do ficheiro e guarda ou em pontuações ou em perguntas
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        public static void LerFicheiro(string nomeFicheiro)
        {
            string NomeFic = nomeFicheiro;
            StreamReader FicheiroLeitura = new StreamReader(NomeFic);
            string linha;
            int i = 0;

            if (nomeFicheiro == Program.ficheiroPerguntas)
            {
                while (!FicheiroLeitura.EndOfStream)
                {
                    linha = FicheiroLeitura.ReadLine();
                    string[] palavras = linha.Split(';');

                    Array.Resize(ref Program.quiz, i + 1);
                    Program.quiz[i].id = int.Parse(palavras[0]);
                    Program.quiz[i].questao = palavras[1];
                    Program.quiz[i].resposta.respostaCorrectaId = palavras[2];
                    Program.quiz[i].resposta.respostaCorrectaNome = palavras[3];
                    Program.quiz[i].resposta.resposta1 = palavras[4];
                    Program.quiz[i].resposta.resposta2 = palavras[5];
                    Program.quiz[i].resposta.resposta3 = palavras[6];
                    Program.quiz[i].resposta.resposta4 = palavras[7];
                    i++;
                }
            }
            if (nomeFicheiro == Program.ficheiroPontuacoes)
            {
                while (!FicheiroLeitura.EndOfStream)
                {
                    linha = FicheiroLeitura.ReadLine();
                    string[] palavras = linha.Split(';');

                    Array.Resize(ref Program.pontuacao, i + 1);
                    Program.pontuacao[i].userName = palavras[0];
                    Program.pontuacao[i].pontos = palavras[1];
                    i++;
                }
            }

            FicheiroLeitura.Close();

        }

        /// <summary>
        /// Guarda a pontuação no ficheiro e no array pontuacoes
        /// </summary>
        /// <param name="pontos"></param>
        /// <param name="userName"></param>
        public static void guardarPontuacao(int pontos, string userName)
        {
            Program.pontuacao = new pontuacoes[0];
            StreamReader FicheiroLeitura = new StreamReader(Program.ficheiroPontuacoes);
            string linha = FicheiroLeitura.ReadLine();
            int i = 0;
            while (!FicheiroLeitura.EndOfStream)
            {
                linha = FicheiroLeitura.ReadLine();
                string[] palavras = linha.Split(';');

                Array.Resize(ref Program.pontuacao, i + 1);
                Program.pontuacao[i].userName = palavras[0];
                Program.pontuacao[i].pontos = palavras[1];
                i++;
            }
            FicheiroLeitura.Close();

            int index = Program.pontuacao.Length + 1;
            StreamWriter FicheiroEscrita = new StreamWriter(Program.ficheiroPontuacoes);
            Array.Resize(ref Program.pontuacao, index);

            Program.pontuacao[index - 1].userName = userName;
            Program.pontuacao[index - 1].pontos = "" + pontos + "";

            FicheiroEscrita.WriteLine("nome;pontos");
            for (int a = 0; a < Program.pontuacao.Length; a++)
            {
                FicheiroEscrita.WriteLine(Program.pontuacao[a].userName + ";" + Program.pontuacao[a].pontos);
            }

            FicheiroEscrita.Close();

        }

        /// <summary>
        /// Função que guarda as perguntas existentes no array para o ficheiro txt
        /// </summary>
        public static void Guardar()
        {
            StreamWriter FicheiroEscrita = new StreamWriter(Program.ficheiroPerguntas);
            for (int i = 0; i < Program.quiz.Length; i++)
            {
                FicheiroEscrita.Write(
                    Program.quiz[i].id + ";" +
                    Program.quiz[i].questao + ";" +
                    Program.quiz[i].resposta.respostaCorrectaId + ";" +
                    Program.quiz[i].resposta.respostaCorrectaNome + ";" +
                    Program.quiz[i].resposta.resposta1 + ";" +
                    Program.quiz[i].resposta.resposta2 + ";" +
                    Program.quiz[i].resposta.resposta3 + ";" +
                    Program.quiz[i].resposta.resposta4 + ";" + "\n"
                    );
            }

            FicheiroEscrita.Close();
        }

    }
}
