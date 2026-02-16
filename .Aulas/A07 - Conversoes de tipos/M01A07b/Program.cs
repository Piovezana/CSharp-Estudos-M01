using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A07b
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Conversão Explicita

            /* float x = 7.5F;
            int z = x; */ //Formato errado de se fazer

            float v = 22.1F;
            int r = (int) v; //Formato correto de se fazer

            Console.WriteLine("valor de V é: " +v + " Seu tipo é: " +v.GetType());
            Console.WriteLine("valor de V é: " +r + " Seu tipo é: " +r.GetType());
            Console.ReadKey();

        }
    }
}
