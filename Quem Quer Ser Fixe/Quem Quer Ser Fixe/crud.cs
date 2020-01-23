using Quem_Quer_Ser_Fixe.jogar;
using Quem_Quer_Ser_Fixe.service;
using System;
using System.IO;
using static Quem_Quer_Ser_Fixe.structs.structs;

namespace Quem_Quer_Ser_Fixe
{
    public static class Crud
    {
        public static void CriarPergunta()
        {
            Service.Header("          C R I A R          \n       P E R G U N T A       ");

            Console.WriteLine();

            questoes[] novaQuestao = new questoes[1];

            //ler dados até que o utilizador introduza o numero 0
            int num;

            num = Program.quiz.Length + 1;
            Console.WriteLine(" Id Pergunta: " + num);
            novaQuestao[0].id = num;
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

            Console.WriteLine(novaQuestao[0].id);
            Console.WriteLine(novaQuestao[0].questao);
            Console.WriteLine(novaQuestao[0].resposta.resposta1);
            Console.WriteLine(novaQuestao[0].resposta.resposta2);
            Console.WriteLine(novaQuestao[0].resposta.resposta3);
            Console.WriteLine(novaQuestao[0].resposta.resposta4);
            Console.WriteLine(novaQuestao[0].resposta.respostaCorrectaId);
            Console.WriteLine(novaQuestao[0].resposta.respostaCorrectaNome);

            guardarPergunta(novaQuestao);


            Console.WriteLine("Pergunta criada!");
            // adicionar opcao para voltar ao menu das perguntas
            // adicionar opcao para continuar a adicionar perguntas
            Console.WriteLine();
            Service.Pausa("voltar ao menu principal...");
            Program.MainMenu();
        }

        public static void guardarPergunta(questoes[] novaQuestao)
        {
            int index = novaQuestao[0].id;
            Array.Resize(ref Program.quiz, index);

            StreamWriter FicheiroEscrita = new StreamWriter(Program.ficheiroPerguntas);

            Program.quiz[index - 1].id = index;
            Program.quiz[index - 1].questao = novaQuestao[0].questao;
            Program.quiz[index - 1].resposta.resposta1 = novaQuestao[0].resposta.resposta1;
            Program.quiz[index - 1].resposta.resposta2 = novaQuestao[0].resposta.resposta2;
            Program.quiz[index - 1].resposta.resposta3 = novaQuestao[0].resposta.resposta3;
            Program.quiz[index - 1].resposta.resposta4 = novaQuestao[0].resposta.resposta4;
            Program.quiz[index - 1].resposta.respostaCorrectaId = novaQuestao[0].resposta.respostaCorrectaId;
            Program.quiz[index - 1].resposta.respostaCorrectaNome = novaQuestao[0].resposta.respostaCorrectaNome;

            FicheiroEscrita.WriteLine("id;Questao;respostaCorrectaId;respostaCorretaNome;resposta1;resposta2;resposta3;resposta4");

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
                    Program.quiz[i].resposta.resposta4 + ";"
                    );
            }

            FicheiroEscrita.Close();
        }
    }
}
