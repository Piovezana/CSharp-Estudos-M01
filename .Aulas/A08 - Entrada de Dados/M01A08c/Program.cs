using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A08c
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero = 0;
           

            Console.Write("Digite um valor: ");
            int.TryParse(Console.ReadLine(), out numero);
            int dobro = numero * 2;
            Console.Clear();

            Console.WriteLine($"O numero digitado é: {numero}. E seu dobro é: {dobro}.");
            Console.ReadKey();

        }
    }
}
