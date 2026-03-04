using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nSORTEADOR DE NÚMEROS");
            Console.WriteLine("------------------------------");

            Console.Write("Início: ");
            int inicio;
            int.TryParse(Console.ReadLine(), out inicio);

            Console.Write("Fim: ");
            int fim;
            int.TryParse(Console.ReadLine(), out fim);

            Console.WriteLine("------------------------------");

            Console.SetCursorPosition(0, 7);
            Console.Write("Sorteando...");
            Thread.Sleep(2000);

            Random aleatorio = new Random();
            int randomic = aleatorio.Next(inicio , fim + 1);

            Console.SetCursorPosition(0,7);
            Console.WriteLine($"O número sorteado entre {inicio} e {fim} é: {randomic}.");

            Console.ReadKey();



        }
    }
}
