using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A05b
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte idade = 22;
            short cadastro = 2531;
            float media = 9.4F;
            decimal pi = 3.1415926553M;
            bool aprovado = true; 

            Console.WriteLine("A variavel Idade está usando o tipo: " + idade.GetType());
           // Console.ReadKey();
           // Console.Clear();
            Console.WriteLine("A variavel cadastro está usando o tipo: " + cadastro.GetType());
           // Console.ReadKey();
           // Console.Clear();
            Console.WriteLine("A variavel media está usando o tipo: " + media.GetType());
           // Console.ReadKey();
           // Console.Clear();
            Console.WriteLine("A variavel pi está usando o tipo: " + pi.GetType());
           // Console.ReadKey();
           // Console.Clear();
            Console.WriteLine("A variavel aprovado está usando o tipo: " + aprovado.GetType());
        }
    }
}
