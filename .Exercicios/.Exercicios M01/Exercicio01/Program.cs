using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(10 , 10);

            Console.ForegroundColor = ConsoleColor.Black;

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("Meu");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Write(" ");
            Thread.Sleep(1000);

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Brasil");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("Brasileiro");
            Thread.Sleep(1000);

            Console.ResetColor();
            Console.ReadKey();

        }
    }
}
