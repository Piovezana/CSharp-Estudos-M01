 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 7; //Podemos criar variaveis em apenas uma linha

            Console.WriteLine("A variavel N é: " + x);
            Console.WriteLine("O tipo da variavél N é:" + x.GetType());
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            sbyte y; //Ou Escrevendo em duas linhas de comando
            y = -17;

            Console.WriteLine("A variavel Y é: " + y + "\nO Tipo da variavél é: " + y.GetType());
            Console.ReadKey();
        }
    }
}
