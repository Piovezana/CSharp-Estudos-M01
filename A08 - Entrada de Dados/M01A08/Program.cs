using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;

            Console.WriteLine("Infome seu nome abaixo. . .");
            Console.Write("Eu me chamo: ");
            nome = Console.ReadLine();

            Console.WriteLine("Feliz em te conhecer, " + nome);
            Console.ReadKey();
            
        }
    }
}
