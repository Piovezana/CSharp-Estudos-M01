using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace M01A11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Thread.Sleep(2000);
            Console.WriteLine("World");
            Console.ReadKey();
        }
    }
}

