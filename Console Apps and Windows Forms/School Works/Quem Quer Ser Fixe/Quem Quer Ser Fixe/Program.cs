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

        /// <summary>
        /// Função principal do projecto
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ler_guardar_service.LerFicheiro(ficheiroPerguntas);
            ler_guardar_service.LerFicheiro(ficheiroPontuacoes);
            MainMenu();
        }

        /// <summary>
        /// Função que mostra o menu principal do projecto
        /// </summary>
        public static void MainMenu()
        {
            Console.Clear();
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
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Opcao seleccionada nao esta disponivel, prima enter para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu();
                    break;
            }
        }

        /// <summary>
        /// Mostra todas as pontuações dos users
        /// </summary>
        private static void pontuacoes()
        {
            Console.Clear();
            Service.Header("       P O N T U A C A O      ");

            for (int i = 1; i < pontuacao.Length; i++)
            {
                Console.WriteLine("    " + pontuacao[i].userName + " - " + pontuacao[i].pontos.PadLeft(5));
            }

            Service.Pausa("voltar ao menu anterior...");
            Console.Clear();
        }

        /// <summary>
        /// Mostra o menu das perguntas
        /// </summary>
        private static void gerirPerguntas()
        {
            questoes[] questoes = new questoes[0];
            Jogar.MenuPerguntas(ref questoes);
            Console.Clear();
        }

        /// <summary>
        /// Função que mostra o quiz e depois os resultados
        /// </summary>
        private static void jogar()
        {
            Console.Clear();
            Service.Quiz();
            Jogar.mostrarResultados();
            Service.Pausa("continuar");
            MainMenu();
        }
     
    }
}
