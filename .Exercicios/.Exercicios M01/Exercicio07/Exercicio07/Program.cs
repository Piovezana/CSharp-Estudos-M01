using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variavel
            var produto = "Produto";
            var preco = "Preço";

            //Produto 1 e Valor

            Console.Write($"\n{produto} 1: ");
            string produto1 = Console.ReadLine();

            Console.Write($"{preco}: R$");
            float valor1 = 0;
            float.TryParse(Console.ReadLine(), out valor1);


            //Produto 2 e Valor

            Console.Write($"\n{produto}: ");
            string produto2 = Console.ReadLine();

            Console.Write($"{preco}: R$");
            float valor2 = 0;
            float.TryParse(Console.ReadLine(), out valor2);

            //Configuração de cor & TITULO
            Console.SetCursorPosition(0,10);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{produto, -20} {"Preço", 13} ");

            //Configuração de cor & Produto 1
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{produto1, -20} {valor1, 13:C} ");
            Console.WriteLine($"{produto2, -20} {valor2, 13:C} ");

            //FINAL
            Console.ResetColor();
            Console.ReadKey();

        }
    }
}
