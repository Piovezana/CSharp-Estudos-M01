using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número Real: ");
            float numero;

            float.TryParse (Console.ReadLine(), out numero);
           
            Console.WriteLine("-------------------------------------");

            int n1 = (int)numero;
            int n2 = Convert.ToInt16(numero);

            Console.WriteLine($"O número digitado é: {numero:N}");
            Console.WriteLine($"A Parte inteira de {numero} é: {n1:D}");
            Console.WriteLine($"Arredondadndo temos o número {n2}");
        }
    }
}
