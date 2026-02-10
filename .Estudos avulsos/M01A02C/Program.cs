using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A02C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Curso \tde C#"); /// Escreve: Curso   de C#
            Console.WriteLine("G\buanabara"); /// Escreve: uanabara
            Console.WriteLine("Estudonauta\a"); /// Realiza um som no sistema
            Console.WriteLine("Duc\rk"); /// Escreve: kuc - Ele pega a ultimaas letras e substitui a Primeira letra
            Console.WriteLine("Crista\\"); /// Escreve uma "\"
            Console.WriteLine(@"\ola\"); /// Remove a formatação da linha podendo usar caracteres especiais
            Console.WriteLine("\"C#\""); /// Deixa a linha entre  " ... "

            Console.ReadKey();
        }
    }
}
