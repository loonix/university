using System;

namespace Quem_Quer_Ser_Fixe.service
{
    public static class Service
    {
        public static void Pausa(string texto)
        {
            Console.WriteLine();
            Console.Write("ENTER p/ " + texto + "...");
            Console.ReadKey();
        }

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

    }
}
