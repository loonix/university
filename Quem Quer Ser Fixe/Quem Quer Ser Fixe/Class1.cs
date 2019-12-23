//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace lista7_exercicio_Global
//{
//    class Program
//    {
//        //Definir estrutura com nome Registo
//        struct Registo
//        {
//            public int Numero;
//            public string Nome;
//            public double Nota;
//        }
//        //variavel global
//        static int numRegistos = 0;
//        static void Main(string[] args)
//        {
//            int opcao;
//            int numero = 0;
//            //definir vetor vecNotas do tipo da estrutura Registo com dimensão zero (0)
//            Registo[] VecNotas = new Registo[0];
//            do
//            {
//                Cabecalho("MENU");
//                Console.WriteLine();
//                Console.WriteLine(" 1. Introduzir dados");
//                Console.WriteLine(" 2. Ver notas");
//                Console.WriteLine(" 3. Media notas");
//                Console.WriteLine(" 4. Nota maxima");
//                Console.WriteLine(" 5. Guardar em ficheiro");
//                Console.WriteLine(" 6. Abrir ficheiro");
//                Console.WriteLine(" 7. Sair");
//                Console.WriteLine();
//                Console.Write("Escolha a opcao: ");
//                opcao = int.Parse(Console.ReadLine());
//                if (opcao < 1 || opcao > 7)
//                {
//                    Console.WriteLine("Opcao errada! Pressione enter para continuar..");
//                    Console.ReadKey();
//                }
//                switch (opcao)
//                {
//                    case 1:
//                        Cabecalho("LER DADOS");
//                        LerDados(ref VecNotas);
//                        break;
//                    case 2:
//                        Cabecalho("VER DADOS");
//                        VerDados(VecNotas);
//                        Pausa();
//                        break;

//                        Página 16 de 21
//                case 3:
//                        Cabecalho("MÈDIA NOTAS");
//                        double med;
//                        med = MediaNotas(VecNotas);
//                        Console.WriteLine("Media: " + med);
//                        Pausa();
//                        break;
//                    case 4:
//                        Cabecalho("NOTA MAXIMA");
//                        double max;
//                        max = MaximaNota(VecNotas);
//                        Console.WriteLine("Nota maxima: " + max);
//                        Pausa();
//                        break;
//                    case 5:
//                        Cabecalho("GUARDAR DADOS EM FICHEIRO");
//                        GuardaFicheiro(VecNotas);
//                        break;
//                    case 6:
//                        Cabecalho("LER DADOS DE FICHEIRO");
//                        numero = LerFicheiro(ref VecNotas);
//                        numRegistos = numero;
//                        break;
//                    case 7:
//                        AlterarDados(vecNotas);
//                        break;
//                    case 8:
//                        EliminarDados(vecNotas);
//                        break;
//                }
//            } while (opcao != 9);
//        }//Fim main
//        static void Cabecalho(string texto)
//        {
//            Console.BackgroundColor = ConsoleColor.Blue;
//            Console.Clear();
//            Console.WriteLine("**********************************");
//            Console.ForegroundColor = ConsoleColor.White;
//            Console.WriteLine(" " + texto);
//            Console.WriteLine("**********************************");
//        } //Cabecalho
//        Página 17 de 21
// static void LerDados(ref Registo[] vetor)
//        {
//            int numero;
//            do
//            {
//                Console.WriteLine("Registo nº " + (numRegistos + 1));
//                Console.Write(" Numero (0 p/ terminar...): ");
//                numero = int.Parse(Console.ReadLine());
//                if (numero != 0)
//                {
//                    //redimensionar o vetor para ter mais uma celula
//                    Array.Resize(ref vetor, numRegistos + 1);
//                    vetor[numRegistos].Numero = numero;
//                    Console.Write(" Nome: ");
//                    vetor[numRegistos].Nome = Console.ReadLine();
//                    Console.Write(" Nota: ");
//                    vetor[numRegistos].Nota = double.Parse(Console.ReadLine());
//                    numRegistos++; // numRegistos = numRegistos + 1;
//                }
//                Console.WriteLine();
//            } while (numero != 0);
//        }//Fim LerDados
//        static void VerDados(Registo[] vetor)
//        {
//            Console.WriteLine("Numero Nome Nota");
//            Console.WriteLine("==================================");
//            for (int i = 0; i < vetor.Length; i++)
//            {
//                if (vetor[i].Numero != 0)
//                {
//                    Console.Write(vetor[i].Numero.ToString().PadRight(10) +
//                    vetor[i].Nome.PadRight(20) + vetor[i].Nota);
//                    Console.WriteLine();
//                }
//            }
//        }//Fim VerDados
//        static double MediaNotas(Registo[] vetor)
//        {
//            double media;
//            double soma = 0;
//            for (int i = 0; i < vetor.Length; i++)
//            {
//                soma = soma + vetor[i].Nota;
//            }
//            media = soma / vetor.Length;
//            return media;
//        }//Fim mediaNotas
//        Página 18 de 21
// static int PosicaoMaximaNota(Registo[] vetor)
//        {
//            double max;
//            int posicao = 0;
//            max = vetor[0].Nota;
//            for (int i = 0; i < vetor.Length; i++)
//            {
//                if (vetor[i].Nota > max)
//                {
//                    max = vetor[i].Nota;
//                    posicao = i;
//                }
//            }
//            return posicao;
//        }//Fim PosicaoMaximaNota
//        static double MaximaNota(Registo[] vetor)
//        {
//            double max;
//            max = vetor[0].Nota;
//            for (int i = 0; i < vetor.Length; i++)
//            {
//                if (vetor[i].Nota > max)
//                {
//                    max = vetor[i].Nota;
//                }
//            }
//            return max;
//        }//Fim maximaNota
//        static void GuardaFicheiro(Registo[] vetor)
//        {
//            string NomeFic = "Notas.txt";
//            StreamWriter FicheiroEscrita = new StreamWriter(NomeFic);
//            FicheiroEscrita.WriteLine("Numero;Nome;Nota");
//            for (int i = 0; i < vetor.Length; i++)
//            {
//                FicheiroEscrita.Write(vetor[i].Numero + ";" +
//                vetor[i].Nome + ";" + vetor[i].Nota);
//                FicheiroEscrita.WriteLine();
//            }
//            FicheiroEscrita.Close();
//            Console.WriteLine("Ficheiro guardao com sucesso!");
//            Pausa();
//        }//Fim guardaFicheiro
//        Página 19 de 21
// static int LerFicheiro(ref Registo[] vetor)
//        {
//            string NomeFic = "Notas.txt";
//            StreamReader FicheiroLeitura = new StreamReader(NomeFic);
//            string linha;
//            //ignora a 1ª linha
//            linha = FicheiroLeitura.ReadLine();
//            int i = 0;
//            while (!FicheiroLeitura.EndOfStream)
//            {
//                linha = FicheiroLeitura.ReadLine();
//                Console.WriteLine(linha);
//                string[] palavras = linha.Split(';'); //colocar em vetor cada "campo" separado por ;
//                                                      //foreach (string pal in palavras)
//                                                      //{
//                                                      //Console.Write(pal);
//                                                      //}
//                Array.Resize(ref vetor, i + 1);
//                vetor[i].Numero = int.Parse(palavras[0]);
//                vetor[i].Nome = palavras[1];
//                vetor[i].Nota = int.Parse(palavras[2]);
//                i++;
//            }
//            FicheiroLeitura.Close();
//            Console.WriteLine("Ficheiro aberto com sucesso!");
//            Pausa();
//            return i;
//        }//Fim lerFicheiro
//        static void AlterarDados(Registo[] vetor)
//        {
//            Cabecalho("A L T E R A R D A D O S");
//            //Mostrar todos os registos
//            Console.WriteLine("Numero Nome Nota");
//            Console.WriteLine("===================================");
//            //percorrer todo o vetor: de 0 a NumRegistos
//            for (int i = 0; i < NumRegistos; i++) //ou.. em vez de NumRegistos -> vetor.Lenght
//            {
//                Console.WriteLine(vetor[i].numero.ToString().PadRight(10) +
//                vetor[i].nome.PadRight(20) + vetor[i].nota);
//            }
//            Console.WriteLine();
//            int numeroEstudante;
//            Console.Write("Numero de estudante a alterar: ");
//            numeroEstudante = int.Parse(Console.ReadLine());
//            //Procurar o numero no vetor
//            //percorrer todo o vetor: de 0 a NumRegistos
//            int posicao = -1;
//            for (int i = 0; i < NumRegistos; i++)
//            {
//                if (vetor[i].numero == numeroEstudante)
//                {
//                    posicao = i;
//                }
//            }
//            Página 20 de 21
//        //verificar se encontrou...
// if (posicao == -1) // não encontrou
//            {
//                Console.WriteLine("Estudante não existe!");
//                Console.ReadKey();
//            }
//            else
//            {
//                Console.WriteLine(" Numero.: " + vetor[posicao].numero);
//                Console.WriteLine(" Nome...: " + vetor[posicao].nome);
//                Console.WriteLine(" Nota...: " + vetor[posicao].nota);
//                Console.WriteLine();
//                //pedir dados p/ alterar
//                Console.Write(" Novo Nome: ");
//                vetor[posicao].nome = Console.ReadLine();
//                Console.Write(" Nova Nota: ");
//                vetor[posicao].nota = double.Parse(Console.ReadLine());
//                Console.WriteLine("Dados alterados...");
//                Console.ReadKey();
//            }
//        }//AlterarDados
//        static void EliminarDados(Registo[] vetor)
//        {
//            Cabecalho("E L I M I N A R D A D O S");
//            //Mostrar todos os registos
//            Console.WriteLine("Numero Nome Nota");
//            Console.WriteLine("===================================");
//            //percorrer todo o vetor: de 0 a NumRegistos
//            for (int i = 0; i < NumRegistos; i++) //ou.. em vez de NumRegistos -> vetor.Lenght
//            {
//                Console.WriteLine(vetor[i].numero.ToString().PadRight(10) +
//                vetor[i].nome.PadRight(20) + vetor[i].nota);
//            }
//            Console.WriteLine();
//            int numeroEstudante;
//            Console.Write("Numero de estudante a eliminar: ");
//            numeroEstudante = int.Parse(Console.ReadLine());
//            //Procurar o numero no vetor
//            //percorrer todo o vetor: de 0 a NumRegistos
//            int posicao = -1;
//            for (int i = 0; i < NumRegistos; i++)
//            {
//                if (vetor[i].numero == numeroEstudante)
//                {
//                    posicao = i;
//                }
//            }
//            //verificar se encontrou...
//            if (posicao == -1) // não encontrou
//            {
//                Console.WriteLine("Estudante não existe!");
//                Console.ReadKey();
//            }
//            else
//            {
//                Console.WriteLine(" Numero.: " + vetor[posicao].numero);
//                Console.WriteLine(" Nome...: " + vetor[posicao].nome);
//                Console.WriteLine(" Nota...: " + vetor[posicao].nota);
//                Console.WriteLine();
//                Página 21 de 21
//            //Eliminar
//            //percorrer o vetor desde a celula atual (variavel posicao)
//            //até ao final e substituir os dados da celula pelos dados celula seguinte
//                for (int i = posicao; i < vetor.Length - 1; i++)
//                {
//                    vetor[i].numero = vetor[i + 1].numero;
//                    vetor[i].nome = vetor[i + 1].nome;
//                    vetor[i].nota = vetor[i + 1].nota;
//                }
//                //apagar os dados da ultima célula
//                //Podemos tambem redimensionar o vetor para ter menos uma celula
//                vetor[vetor.Length - 1].numero = 0;
//                vetor[vetor.Length - 1].nome = "";
//                vetor[vetor.Length - 1].nota = 0;
//                Console.WriteLine("Dados eliminados...");
//                Console.ReadKey();
//            }
//        }//AlterarDados
//        static void Pausa()
//        {
//            Console.WriteLine();
//            Console.Write("ENTER p/ terminar...");
//            Console.ReadKey();
//        }// Fim pausa
//    }//Fim Class
//}//Fim namespace