using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                Console.WriteLine($"Tabuada do {multiplicador}:");

                for (int multiplicando = 1; multiplicando <= 10; multiplicando++)
                {
                    int resultado = multiplicador * multiplicando;
                    Console.WriteLine($"{multiplicador} x {multiplicando} = {resultado}");
                }

                Console.WriteLine();
            }
        }
    }
}
