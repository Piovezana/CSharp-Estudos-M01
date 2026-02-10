using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A02E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red; // Faz alteração na COR da LETRA
            Console.BackgroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(50, 3); // Muda a posição do cursor (50) Horizontal | (3) Vertical 
            Console.WriteLine("Ola");
            Console.ReadKey();

            Console.ResetColor();
            Console.Clear();  //depois de rodar o CONSOLE.READKEY - Ele vai remover tudo do CONSOLE.CLEAR para cima ↑

            Console.BackgroundColor = ConsoleColor.Magenta; // Faz alteração na COR de FUNDO 
            Console.WriteLine("Tudo bem?");
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
