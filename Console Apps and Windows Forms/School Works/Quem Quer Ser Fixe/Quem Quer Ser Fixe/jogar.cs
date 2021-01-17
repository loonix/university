using Quem_Quer_Ser_Fixe.service;
using System;
using static Quem_Quer_Ser_Fixe.structs.structs;
namespace Quem_Quer_Ser_Fixe.jogar
{
    public static class Jogar
    {
        /// <summary>
        /// Abre o menu de gestao de perguntas
        /// </summary>
        /// <param name="questoes"></param>
        public static void MenuPerguntas(ref questoes[] questoes)
        {
            Console.Clear();
            Service.Header("           M E N U            \n      P E R G U N T A S       ");
            Console.WriteLine("    1. Criar                  ");
            Console.WriteLine("    2. Listar/Editar          ");
            Console.WriteLine("    3. Eliminar               ");
            Console.WriteLine("    4. Sair                   ");
            Console.WriteLine("______________________________");
            Console.WriteLine("");
            Console.Write("Selecione uma Opcao > ");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    Crud.CriarPergunta();
                    Service.Pausa("continuar");
                    Console.Clear();
                    Program.MainMenu();
                    break;
                case 2:
                    Crud.VerPerguntas();
                    Crud.EditarPerguntas();
                    Service.Pausa("continuar");
                    Console.Clear();
                    Program.MainMenu();
                    break;
                case 3:
                    Console.Clear();
                    Crud.eliminar();
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();
                    Program.MainMenu();
                    break;
                default:
                    Console.WriteLine("Opcao seleccionada nao esta disponivel, prima enter para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    Program.MainMenu();
                    break;
            }
        }

        /// <summary>
        /// Mostra os resultados de todas as perguntas respondidas pelo user
        /// </summary>
        public static void mostrarResultados()
        {
            int pontos = 0;
            Service.Header("     R E S U L T A D O S      ");
            for (int i = 0; i < Program.quiz.Length; i++)
            {
                string respostaUser = obterResposta(Program.quiz[i]);
                if (Program.quiz[i].resposta.respostaUser == Program.quiz[i].resposta.respostaCorrectaId)
                {
                    Console.WriteLine(" _____________________________");
                    Console.WriteLine("|     |                       | ");
                    Console.WriteLine("|   / | QUESTAO             > | " + Program.quiz[i].questao);
                    Console.WriteLine("|  /  | RESPOSTA CORRECTA   > | " + Program.quiz[i].resposta.respostaCorrectaNome);
                    Console.WriteLine("| V   | RESPOSTA UTILIZADOR > | " + respostaUser);
                    Console.WriteLine("|_____|_______________________| ");
                    pontos = pontos + 1;
                }
                else
                {
                    Console.WriteLine(" _____________________________");
                    Console.WriteLine("|     |                       | ");
                    Console.WriteLine("| \\ / | QUESTAO             > | " + Program.quiz[i].questao);
                    Console.WriteLine("|  X  | RESPOSTA CORRECTA   > | " + Program.quiz[i].resposta.respostaCorrectaNome);
                    Console.WriteLine("| / \\ | RESPOSTA UTILIZADOR > | " + respostaUser);
                    Console.WriteLine("|_____|_______________________| ");
                }
            }
            Console.Write("Introduza o seu nome > ");
            string userName = Console.ReadLine();
            Console.WriteLine("PONTOS: " + (pontos * Program.quiz.Length));
            ler_guardar_service.guardarPontuacao(pontos * Program.quiz.Length, userName);
        }

        /// <summary>
        /// Recebe uma pergunta e retorna resposta do user
        /// </summary>
        /// <param name="questoes"></param>
        /// <returns></returns>
        public static string obterResposta(questoes questao)
        {
            string resposta;
            switch (questao.resposta.respostaUser)
            {
                case "1":
                    resposta = questao.resposta.resposta1;
                    break;
                case "2":
                    resposta = questao.resposta.resposta2;
                    break;
                case "3":
                    resposta = questao.resposta.resposta3;
                    break;
                case "4":
                    resposta = questao.resposta.resposta4;
                    break;
                default:
                    resposta = "Resposta Invalida";
                    break;
            }
            return resposta;
        }

        /// <summary>
        /// Função que mostra a pergunta e todas as respostas
        /// </summary>
        /// <param name="questao"></param>
        public static void FazerPergunta(questoes questao)
        {
            Service.Header(questao.questao);
            //respostas
            Console.WriteLine("    1. " + questao.resposta.resposta1);
            Console.WriteLine("    2. " + questao.resposta.resposta2);
            Console.WriteLine("    3. " + questao.resposta.resposta3);
            Console.WriteLine("    4. " + questao.resposta.resposta4);
            Console.WriteLine();
            Console.Write("Selecione uma Opcao > ");

        }
    }
}
