using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O tipo BYTE vai de " + byte.MinValue + " até " + byte.MaxValue);
            Console.WriteLine("O tipo SBYTE vai de " + sbyte.MinValue + " até " + sbyte.MaxValue);
            Console.WriteLine("O tipo SHORT vai de " + short.MinValue + " até " + short.MaxValue);
            Console.WriteLine("O tipo ushort vai de " + ushort.MinValue + " até " + ushort.MaxValue);
            Console.WriteLine("O tipo int vai de " + int.MinValue + " até " + int.MaxValue);
            Console.WriteLine("O tipo uint vai de " + uint.MinValue + " até " + uint.MaxValue);
            Console.WriteLine("O tipo long vai de " + long.MinValue + " até " + long.MaxValue);
            Console.WriteLine("O tipo ulong vai de " + ulong.MinValue + " até " + ulong.MaxValue);

            Console.ReadKey();

            
        }
    }
}
 