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
            questoes[] VecNotas = new questoes[0];

            Seed(VecNotas);
            LerFicheiro(VecNotas);

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
            public string respostaCorrecta;
            public string resposta1;
            public string resposta2;
            public string resposta3;
            public string resposta4;
        }

        static void Pausa()
        {
            Console.WriteLine();
            Console.Write("ENTER p/ terminar...");
            Console.ReadKey();
        }// Fim pausa

        static void Seed(questoes[] vetor)
        {
            string NomeFic = "perguntas.txt";
            StreamWriter FicheiroEscrita = new StreamWriter(NomeFic);
            FicheiroEscrita.WriteLine("Questao;respostaCorrecta;resposta1;resposta2;resposta3;resposta4");
            FicheiroEscrita.WriteLine("Qual e a cor do cavalo branco de napoleao?;Branco;Verde;Branco;Azul;Roxo");
            FicheiroEscrita.WriteLine("Quem e o aluno mais fixe do ISLA?;Daniel;Bruno;Hugo;Daniel;Joao");
            FicheiroEscrita.WriteLine("Quem e o professor mais fixe do ISLA?;Jose Moreira;Jose Moreira;Manuel Teixeira;Cristina;Ana");

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
                FicheiroEscrita.WriteLine();
            }
            FicheiroEscrita.Close();
            Console.WriteLine("Questoes iniciais criadas!");
            Pausa();
        }

        static int LerFicheiro(questoes[] vetor)
        {
            string NomeFic = "perguntas.txt";
            StreamReader FicheiroLeitura = new StreamReader(NomeFic);
            string linha;
            //ignora a 1ª linha
            linha = FicheiroLeitura.ReadLine();
            int i = 0;
            while (!FicheiroLeitura.EndOfStream)
            {
                linha = FicheiroLeitura.ReadLine();
                Console.WriteLine(linha);
                string[] palavras = linha.Split(';'); //colocar em vetor cada "campo" separado por ;
                                                      //foreach (string pal in palavras)
                                                      //{
                                                      //Console.Write(pal);
                                                      //}
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
            Console.WriteLine("Ficheiro aberto com sucesso!");
            Pausa();
            return i;
        }//Fim lerFicheiro

        static void jogo()
        {

        }
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
                    // menu jogo
                    break;
                case 2:
                    // Gerir Perguntas
                    break;
                case 3:
                    // sair
                    break;
                default:
                    Console.WriteLine("Opcao seleccionada nao esta disponivel, prima enter para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu();
                    break;
            }

        }
        //static void Quiz()
        //{

        //}

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
