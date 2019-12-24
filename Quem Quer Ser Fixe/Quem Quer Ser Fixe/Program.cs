using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quem_Quer_Ser_Fixe
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        struct questoes
        {
            public int id;
            public string questao;
            public respostas resposta;
        }

        struct respostas
        {
            public string respostaUser;
            public string respostaCorrecta;
            public string resposta1;
            public string resposta2;
            public string resposta3;
            public string resposta4;
        }

        static void Pausa(string texto)
        {
            Console.WriteLine();
            Console.Write("ENTER p/ "+ texto + "...");
            Console.ReadKey();
        }

        static void Seed(questoes[] vetor)
        {
            string NomeFic = "perguntas.txt";
            StreamWriter FicheiroEscrita = new StreamWriter(NomeFic);
            FicheiroEscrita.WriteLine("Questao;respostaCorrecta;resposta1;resposta2;resposta3;resposta4");
            FicheiroEscrita.WriteLine("Qual e a cor do cavalo branco de napoleao?;2;Verde;Branco;Azul;Roxo");
            FicheiroEscrita.WriteLine("Quem e o aluno mais fixe do ISLA?;3;Bruno;Hugo;Daniel;Joao");
            FicheiroEscrita.WriteLine("Quem e o professor mais fixe do ISLA?;1;Jose Moreira;Manuel Teixeira;Cristina;Ana");

            for (int i = 0; i < vetor.Length; i++)
            {
                FicheiroEscrita.Write(
                    vetor[i].questao + ";" +
                    vetor[i].resposta.respostaCorrecta + ";" +
                    vetor[i].resposta.resposta1 + ";" +
                    vetor[i].resposta.resposta2 + ";" +
                    vetor[i].resposta.resposta3 + ";" +
                    vetor[i].resposta.resposta4 + ";"
                    );
            }
            FicheiroEscrita.Close();
        }

        static questoes[] LerFicheiro(questoes[] vetor)
        {
            string NomeFic = "perguntas.txt";
            StreamReader FicheiroLeitura = new StreamReader(NomeFic);
            string linha;
            linha = FicheiroLeitura.ReadLine();
            int i = 0;
            while (!FicheiroLeitura.EndOfStream)
            {
                linha = FicheiroLeitura.ReadLine();
                string[] palavras = linha.Split(';');

                Array.Resize(ref vetor, i + 1);
                vetor[i].questao = palavras[0];
                vetor[i].resposta.respostaCorrecta = palavras[1];
                vetor[i].resposta.resposta1 = palavras[2];
                vetor[i].resposta.resposta2 = palavras[3];
                vetor[i].resposta.resposta3 = palavras[4];
                vetor[i].resposta.resposta4 = palavras[5];
                i++;
            }
            FicheiroLeitura.Close();
            return vetor;
        }//Fim lerFicheiro

        static void MainMenu()
        {
            Header("           M E N U            ");
            Console.WriteLine("    1. Jogar                  ");
            Console.WriteLine("    2. Gerir Perguntas        ");
            Console.WriteLine("    3. Sair                   ");
            Console.WriteLine("______________________________");
            Console.WriteLine("");
            Console.Write("Selecione uma Opcao > ");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    Quiz();
                    break;
                case 2:
                    // Gerir Perguntas
                    Console.Clear();
                    break;
                case 3:
                    // sair
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Opcao seleccionada nao esta disponivel, prima enter para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu();
                    break;
            }

        }
        static void Quiz()
        {
            questoes[] allQuestoes = new questoes[0];
            Seed(allQuestoes);

            allQuestoes = LerFicheiro(allQuestoes);
            for (int i = 0; i < allQuestoes.Length; i++)
            {
                FazerPergunta(allQuestoes[i]);
                string respostaUser = Console.ReadLine();
                allQuestoes[i].resposta.respostaUser = respostaUser;
                if(allQuestoes[i].resposta.respostaUser == allQuestoes[i].resposta.respostaCorrecta)
                {
                    Console.WriteLine("A resposta esta correcta!");
                }
                else
                {
                    Console.WriteLine("A resposta esta incorrecta!");
                }
                Pausa("continuar");
                Console.Clear();
            }



            Pausa("terminar");
        }

        static void FazerPergunta(questoes questao)
        {
            Header(questao.questao);
            //respostas
            Console.WriteLine("    1. " + questao.resposta.resposta1);
            Console.WriteLine("    2. " + questao.resposta.resposta2);
            Console.WriteLine("    3. " + questao.resposta.resposta3);
            Console.WriteLine("    4. " + questao.resposta.resposta4);
            Console.WriteLine();
            Console.Write("Selecione uma Opcao > ");

        }

        static void Header(string titulo)
        {
            Console.WriteLine("______________________________");
            Console.WriteLine("                              ");
            Console.WriteLine("      QUEM QUER SER FIXE      ");
            Console.WriteLine("       Jogo de Perguntas      ");
            Console.WriteLine("                              ");
            Console.WriteLine(titulo);
            Console.WriteLine("______________________________");
            Console.WriteLine("                              ");
        }

    }


}
