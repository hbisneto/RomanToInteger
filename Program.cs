using System;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(">> Escreva um número (Romano): ");
            string RomanNumber = Console.ReadLine().ToUpper();

            var Core = new RomanCore();
            Console.WriteLine(">> Algarismos Arábicos: " + Core.RomanToInteger(RomanNumber));

            Console.WriteLine("\n\n>> Press any key to exit...");
            Console.ReadKey();
        }
    }
}
