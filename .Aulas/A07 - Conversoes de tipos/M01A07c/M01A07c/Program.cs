using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A07c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float w = 1.5F;
            int s = Convert.ToInt16(w);

            Console.WriteLine("Valor de S é: " + w);
            Console.WriteLine("Valor \"arredondado\" é: " + s);
            Console.ReadKey(); 

        }
    }
}
