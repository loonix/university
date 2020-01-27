using Quem_Quer_Ser_Fixe.service;
using System;
using System.IO;
using static Quem_Quer_Ser_Fixe.structs.structs;

namespace Quem_Quer_Ser_Fixe
{
    public static class Crud
    {
        public static void VerPerguntas()
        {
            var space = "";

            for (int i = 0; i < Program.quiz.Length; i++)
            {
                Console.WriteLine("+-------+---------------------------------------------------------------------------------------------------------+");
                Console.WriteLine("|" + space.PadRight(7) + "| Pergunta   > " + Program.quiz[i].questao);
                Console.WriteLine("|" + space.PadRight(3) + Program.quiz[i].id + space.PadRight(3) + "|            > " + "[1] - " + Program.quiz[i].resposta.resposta1.PadRight(10) + "[2] - " + Program.quiz[i].resposta.resposta2);
                Console.WriteLine("|" + space.PadRight(7) + "|            > " + "[3] - " + Program.quiz[i].resposta.resposta3.PadRight(10) + "[4] - " + Program.quiz[i].resposta.resposta4);
                if(Program.quiz.Length == i + 1)
                {
                    Console.WriteLine("+-------+---------------------------------------------------------------------------------------------------------+");
                }

            }
        }
        public static void EditarPerguntas()
        {
            Console.WriteLine("| MENU  |   1. Editar    |   2. Voltar ao Menu Principal   |                                                      +");
            Console.WriteLine("+-------+---------------------------------------------------------------------------------------------------------+");

            Console.WriteLine("");
            Console.Write("Selecione uma Opcao > ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Editar();
                    break;
                case 2:
                    Console.Clear();
                    Program.MainMenu();
                    break;
                default:
                    Console.Clear();
                    Program.MainMenu();
                    break;
            }
        }

        private static void Editar()
        {
            Console.Write("Selecione um id para editar > ");
            int questaoId = int.Parse(Console.ReadLine());

            Boolean encontrado;
            for (int i = 0; i < Program.quiz.Length; i++)
            {
                if(Program.quiz[i].id == questaoId)
                {
                    encontrado = true;

                    Console.WriteLine(" Id Pergunta: " + Program.quiz[i].id);
                    Program.quiz[i].id = Program.quiz[i].id;
                    Console.Write(" Pergunta: ");
                    Program.quiz[i].questao = Console.ReadLine();
                    Console.Write(" Resposta 1: ");
                    Program.quiz[i].resposta.resposta1 = Console.ReadLine();
                    Console.Write(" Resposta 2: ");
                    Program.quiz[i].resposta.resposta2 = Console.ReadLine();
                    Console.Write(" Resposta 3: ");
                    Program.quiz[i].resposta.resposta3 = Console.ReadLine();
                    Console.Write(" Resposta 4: ");
                    Program.quiz[i].resposta.resposta4 = Console.ReadLine();

                    Console.WriteLine("Escolha a resposta correcta:");
                    Console.WriteLine(Program.quiz[i].questao);
                    Console.WriteLine("    1. " + Program.quiz[i].resposta.resposta1);
                    Console.WriteLine("    2. " + Program.quiz[i].resposta.resposta2);
                    Console.WriteLine("    3. " + Program.quiz[i].resposta.resposta3);
                    Console.WriteLine("    4. " + Program.quiz[i].resposta.resposta4);
                    int respostaCorrecta = 0;
                    do
                    {
                        Console.Write(" > ");
                        respostaCorrecta = int.Parse(Console.ReadLine());

                        switch (respostaCorrecta)
                        {
                            case 1:
                                Program.quiz[i].resposta.respostaCorrectaNome = Program.quiz[i].resposta.resposta1;
                                Program.quiz[i].resposta.respostaCorrectaId = "1";
                                break;
                            case 2:
                                Program.quiz[i].resposta.respostaCorrectaNome = Program.quiz[i].resposta.resposta2;
                                Program.quiz[i].resposta.respostaCorrectaId = "2";
                                break;
                            case 3:
                                Program.quiz[i].resposta.respostaCorrectaNome = Program.quiz[i].resposta.resposta3;
                                Program.quiz[i].resposta.respostaCorrectaId = "3";
                                break;
                            case 4:
                                Program.quiz[i].resposta.respostaCorrectaNome = Program.quiz[i].resposta.resposta4;
                                Program.quiz[i].resposta.respostaCorrectaId = "4";
                                break;
                        }

                    } while (respostaCorrecta > 4 || respostaCorrecta <= 0);

                    if (!encontrado)
                    {
                        Console.WriteLine("Id Nao encontrado, tente novamente...");
                        EditarPerguntas();
                        return;
                    }

                    Guardar();

                }
            }

            ;
        }


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

        public static void CriarPergunta()
        {
            Service.Header("          C R I A R          \n       P E R G U N T A       ");

            Console.WriteLine();

            questoes[] novaQuestao = new questoes[1];

            //ler dados até que o utilizador introduza o numero 0
            int num;

            num = Program.quiz.Length + 1;
            Console.WriteLine(" Id Pergunta: " + num);
            novaQuestao[0].id = num - 1;
            Console.Write(" Pergunta: ");
            novaQuestao[0].questao = Console.ReadLine();
            Console.Write(" Resposta 1: ");
            novaQuestao[0].resposta.resposta1 = Console.ReadLine();
            Console.Write(" Resposta 2: ");
            novaQuestao[0].resposta.resposta2 = Console.ReadLine();
            Console.Write(" Resposta 3: ");
            novaQuestao[0].resposta.resposta3 = Console.ReadLine();
            Console.Write(" Resposta 4: ");
            novaQuestao[0].resposta.resposta4 = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Escolha a resposta correcta:");
            Console.WriteLine(novaQuestao[0].questao);
            Console.WriteLine("    1. " + novaQuestao[0].resposta.resposta1);
            Console.WriteLine("    2. " + novaQuestao[0].resposta.resposta2);
            Console.WriteLine("    3. " + novaQuestao[0].resposta.resposta3);
            Console.WriteLine("    4. " + novaQuestao[0].resposta.resposta4);
            int respostaCorrecta = 0;
            do
            {
                respostaCorrecta = int.Parse(Console.ReadLine());

                switch (respostaCorrecta)
                {
                    case 1:
                        novaQuestao[0].resposta.respostaCorrectaNome = novaQuestao[0].resposta.resposta1;
                        novaQuestao[0].resposta.respostaCorrectaId = "1";
                        break;
                    case 2:
                        novaQuestao[0].resposta.respostaCorrectaNome = novaQuestao[0].resposta.resposta2;
                        novaQuestao[0].resposta.respostaCorrectaId = "2";
                        break;
                    case 3:
                        novaQuestao[0].resposta.respostaCorrectaNome = novaQuestao[0].resposta.resposta3;
                        novaQuestao[0].resposta.respostaCorrectaId = "3";
                        break;
                    case 4:
                        novaQuestao[0].resposta.respostaCorrectaNome = novaQuestao[0].resposta.resposta4;
                        novaQuestao[0].resposta.respostaCorrectaId = "4";
                        break;
                }

            } while (respostaCorrecta > 4 || respostaCorrecta <= 0);

            guardarPergunta(novaQuestao);


            Console.WriteLine("Pergunta criada!");
            // adicionar opcao para voltar ao menu das perguntas
            // adicionar opcao para continuar a adicionar perguntas
            Console.WriteLine();
            Service.Pausa("voltar ao menu principal...");
            Console.Clear();
            Program.MainMenu();
        }

        public static void guardarPergunta(questoes[] novaQuestao)
        {
            int index = novaQuestao[0].id;
            Array.Resize(ref Program.quiz, index + 1);

            StreamWriter FicheiroEscrita = new StreamWriter(Program.ficheiroPerguntas);

            Program.quiz[index].id = index;
            Program.quiz[index].questao = novaQuestao[0].questao;
            Program.quiz[index].resposta.resposta1 = novaQuestao[0].resposta.resposta1;
            Program.quiz[index].resposta.resposta2 = novaQuestao[0].resposta.resposta2;
            Program.quiz[index].resposta.resposta3 = novaQuestao[0].resposta.resposta3;
            Program.quiz[index].resposta.resposta4 = novaQuestao[0].resposta.resposta4;
            Program.quiz[index].resposta.respostaCorrectaId = novaQuestao[0].resposta.respostaCorrectaId;
            Program.quiz[index].resposta.respostaCorrectaNome = novaQuestao[0].resposta.respostaCorrectaNome;

            //FicheiroEscrita.WriteLine("id;Questao;respostaCorrectaId;respostaCorretaNome;resposta1;resposta2;resposta3;resposta4");

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
                    Program.quiz[i].resposta.resposta4 + "\n"
                    );
            }

            FicheiroEscrita.Close();
        }
    }
}
