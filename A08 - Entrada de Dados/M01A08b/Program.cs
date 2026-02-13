using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace M01A08b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");

            int numero = Convert.ToInt32(Console.ReadLine());
            int dobro = numero * 2;

            Console.WriteLine("O número que você digitou é: " + numero + "\nE o seu dobro é: " + dobro);
            Console.ReadKey();
        }
    }
}
