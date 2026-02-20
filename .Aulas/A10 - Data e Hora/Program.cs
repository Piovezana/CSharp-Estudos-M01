using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;


            Console.WriteLine($"Hoje é: {dia} de {mes} de {ano}\n");

            int hora = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int seg = DateTime.Now.Second;

            Console.WriteLine($"E sua hora é de: {hora}:{min}:{seg}");
            Console.ReadKey();

        }
    }
}
