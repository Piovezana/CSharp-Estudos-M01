using System;

namespace M01A07
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Conversão Implícita
            
            int a = 7;
            float b = a;
            
            Console.WriteLine("O valor de A é: " + a + " Seu tipo primitivo é: " +a.GetType());
            Console.WriteLine("O Valor de B é: " + b + " Seu tipo primitivo é: " +b.GetType());
            Console.ReadKey();

        }
    }
}