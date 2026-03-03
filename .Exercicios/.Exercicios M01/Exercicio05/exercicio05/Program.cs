using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var anoAtual = DateTime.Now.Year;
            Console.Write("Em que ano você nasceu? ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------");

            Console.WriteLine($"O ano atual é: {anoAtual}");
            int idade = anoAtual - ano;

            Console.WriteLine($"Se você nasceu em {ano}, você tem {idade} anos em {anoAtual}");
            Console.ReadKey();


        }
    }
}
