using Quem_Quer_Ser_Fixe.jogar;
using System;
using static Quem_Quer_Ser_Fixe.structs.structs;

namespace Quem_Quer_Ser_Fixe.service
{
    public static class Service
    {
        /// <summary>
        /// Para o programa até uma proxima interacção do user
        /// </summary>
        /// <param name="texto"></param>
        public static void Pausa(string texto)
        {
            Console.WriteLine();
            Console.Write("ENTER p/ " + texto + "...");
            Console.ReadKey();
        }

        /// <summary>
        /// função cria o cabeçalho a partir de um titulo recebido
        /// </summary>
        /// <param name="titulo"></param>
        public static void Header(string titulo)
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


        /// <summary>
        ///  Recebe o array e o indice que deseja remover. Remove o id selecionado e retorna o array sem esse id
        /// </summary>
        /// <param name="IndicesArray"></param>
        /// <param name="IndiceARemover"></param>
        /// <returns></returns>
        public static questoes[] RemoverDoArray(questoes[] IndicesArray, int IndiceARemover)
        {
            questoes[] novoArrayIndices = new questoes[IndicesArray.Length - 1];

            int i = 0;
            int a = 0;
            while (i < IndicesArray.Length)
            {
                if (i != IndiceARemover)
                {
                    novoArrayIndices[a] = IndicesArray[i];
                    a++;
                }

                i++;
            }

            return novoArrayIndices;
        }

        /// <summary>
        /// Função que mostra as perguntas quando o user inicia o jogo
        /// </summary>
        public static void Quiz()
        {

            for (int i = 0; i < Program.quiz.Length; i++)
            {
                Jogar.FazerPergunta(Program.quiz[i]);
                string respostaUser = Console.ReadLine();
                Program.quiz[i].resposta.respostaUser = respostaUser;
                if (Program.quiz[i].resposta.respostaUser == Program.quiz[i].resposta.respostaCorrectaId)
                {
                    Console.WriteLine("A resposta " + Program.quiz[i].resposta.respostaUser + " esta correcta!");
                }
                else
                {
                    Console.WriteLine("A resposta esta incorrecta!");
                }
                Service.Pausa("continuar");
                Console.Clear();
            }
        }
    }
}
