using Quem_Quer_Ser_Fixe.service;
using System;
using static Quem_Quer_Ser_Fixe.structs.structs;
using Quem_Quer_Ser_Fixe;
namespace Quem_Quer_Ser_Fixe.jogar
{
    public static class Jogar
    {
        public static void MenuPerguntas(ref questoes[] questoes)
        {
            Console.Clear();
            Service.Header("           M E N U            \n      P E R G U N T A S       ");
            Console.WriteLine("    1. Criar                  ");
            Console.WriteLine("    2. Editar                 ");
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
                    Program.MainMenu();
                    break;
            }
        }


        public static void Quiz()
        {

            for (int i = 0; i < Program.quiz.Length; i++)
            {
                FazerPergunta(Program.quiz[i]);
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
            Service.Pausa("terminar");
        }

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
            Program.guardarPontuacao(pontos * Program.quiz.Length, userName);
    }

        public static string obterResposta(questoes questoes)
        {
            string resposta;
            switch (questoes.resposta.respostaUser)
            {
                case "1":
                    resposta = questoes.resposta.resposta1;
                    break;
                case "2":
                    resposta = questoes.resposta.resposta2;
                    break;
                case "3":
                    resposta = questoes.resposta.resposta3;
                    break;
                case "4":
                    resposta = questoes.resposta.resposta4;
                    break;
                default:
                    resposta = "Resposta Invalida";
                    break;
            }
            return resposta;
        }

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
