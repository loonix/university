using Quem_Quer_Ser_Fixe.service;
using System;
using static Quem_Quer_Ser_Fixe.structs.structs;
namespace Quem_Quer_Ser_Fixe.jogar
{
    public static class Jogar
    {
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
                    eliminar();
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

        private static questoes[] RemoverDoArray(questoes[] IndicesArray, int IndiceARemover)
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

        private static void eliminar()
        {
            Crud.VerPerguntas();
            Console.WriteLine("| MENU  |   1. Eliminar    |   2. Voltar ao Menu Principal   |                                                    +");
            Console.WriteLine("+-------+---------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("");
            Console.Write("Selecione uma Opcao > ");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.Write("Selecione um id para remover > ");
                    int idQuestao = int.Parse(Console.ReadLine());
                    for (int i = 0; i < Program.quiz.Length; i++)
                    {
                        if (Program.quiz[i].id == idQuestao)
                        {
                            Program.quiz = RemoverDoArray(Program.quiz, i);
                        }
                    }
                    Crud.Guardar();
                    Program.MainMenu();
                    break;
                case 2:
                    Program.MainMenu();
                    break;
                default:
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
