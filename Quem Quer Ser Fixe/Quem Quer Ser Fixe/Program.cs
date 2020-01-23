using System;
using System.IO;
using static Quem_Quer_Ser_Fixe.structs.structs;
using Quem_Quer_Ser_Fixe.service;
using Quem_Quer_Ser_Fixe.jogar;

namespace Quem_Quer_Ser_Fixe
{
    public class Program
    {
        public static int numRegisto = 0;
        public static string ficheiroPerguntas = "perguntas.txt";
        public static string ficheiroPontuacoes = "pontuacoes.txt";
        public static questoes[] quiz = new questoes[0];
        public static pontuacoes[] pontuacao = new pontuacoes[0];

        static void Main(string[] args)
        {
            LerFicheiro(ficheiroPerguntas);
            LerFicheiro(ficheiroPontuacoes);
            MainMenu();
        }

        public static void MainMenu()
        {
            Service.Header("           M E N U            ");
            Console.WriteLine("    1. Jogar                  ");
            Console.WriteLine("    2. Gerir Perguntas        ");
            Console.WriteLine("    3. Pontuações             ");
            Console.WriteLine("    4. Sair                   ");
            Console.WriteLine("______________________________");
            Console.WriteLine("");
            Console.Write("Selecione uma Opcao > ");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    jogar();
                    break;
                case 2:
                    gerirPerguntas();
                    break;
                case 3:
                    pontuacoes();
                    MainMenu();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Opcao seleccionada nao esta disponivel, prima enter para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu();
                    break;
            }
        }

        private static void pontuacoes()
        {
            Console.Clear();

            for (int i = 0; i < pontuacao.Length; i++)
            {
                Console.WriteLine(pontuacao[i].userName + " - " + pontuacao[i].pontos);
            }

            Service.Pausa("voltar ao menu anterior...");
            Console.Clear();
        }

        private static void gerirPerguntas()
        {
            questoes[] questoes = new questoes[0];
            Jogar.MenuPerguntas(ref questoes);
            Console.Clear();
        }

        private static void jogar()
        {
            Console.Clear();
            Jogar.Quiz();
            Jogar.mostrarResultados();
            Service.Pausa("continuar");
            MainMenu();
        }

        public static void guardarPontuacao(int pontos, string userName)
        {
            pontuacao = new pontuacoes[0];
            StreamReader FicheiroLeitura = new StreamReader(ficheiroPontuacoes);
            string linha = FicheiroLeitura.ReadLine();
            int i = 0;
            while (!FicheiroLeitura.EndOfStream)
            {
                linha = FicheiroLeitura.ReadLine();
                string[] palavras = linha.Split(';');

                Array.Resize(ref pontuacao, i + 1);
                pontuacao[i].userName = palavras[0];
                pontuacao[i].pontos = palavras[1];
                i++;
            }
            FicheiroLeitura.Close();

            int index = pontuacao.Length + 1;
            StreamWriter FicheiroEscrita = new StreamWriter(ficheiroPontuacoes);
            Array.Resize(ref pontuacao, index);

            pontuacao[index - 1].userName = userName;
            pontuacao[index - 1].pontos = "" + pontos + "";

            FicheiroEscrita.WriteLine("nome;pontos");
            for (int a = 0; a < pontuacao.Length; a++)
            {
                FicheiroEscrita.WriteLine(pontuacao[a].userName + ";" + pontuacao[a].pontos);
            }

            FicheiroEscrita.Close();

        }

        public static void LerFicheiro(string nomeFicheiro)
        {
            string NomeFic = nomeFicheiro;
            StreamReader FicheiroLeitura = new StreamReader(NomeFic);
            string linha = FicheiroLeitura.ReadLine();
            int i = 0;

            if(nomeFicheiro == ficheiroPerguntas)
            {
                while (!FicheiroLeitura.EndOfStream)
                {
                    linha = FicheiroLeitura.ReadLine();
                    string[] palavras = linha.Split(';');

                    Array.Resize(ref quiz, i + 1);
                    quiz[i].questao = palavras[0];
                    quiz[i].resposta.respostaCorrectaId = palavras[1];
                    quiz[i].resposta.respostaCorrectaNome = palavras[2];
                    quiz[i].resposta.resposta1 = palavras[3];
                    quiz[i].resposta.resposta2 = palavras[4];
                    quiz[i].resposta.resposta3 = palavras[5];
                    quiz[i].resposta.resposta4 = palavras[6];
                    i++;
                }
            }
            if(nomeFicheiro == ficheiroPontuacoes)
            {
                while (!FicheiroLeitura.EndOfStream)
                {
                    linha = FicheiroLeitura.ReadLine();
                    string[] palavras = linha.Split(';');

                    Array.Resize(ref pontuacao, i + 1);
                    pontuacao[i].userName = palavras[0];
                    pontuacao[i].pontos = palavras[1];
                    i++;
                }
            }
           
            FicheiroLeitura.Close();
           
        }
    }
}
