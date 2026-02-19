using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Quando gerado numeros, ele sempre perde uma unidade, limitando em 10 unidade ele gera do 0 ao 9.
            

            Random aleatorio = new Random();

            int numero = aleatorio.Next(); // Ele gera números sem limitação

            int numero2 = aleatorio.Next(100); // Ele vai se limitar aos números de 0 até 99

            int numero3 = aleatorio.Next(10 , 21); //Ele vai gerar numeros entre 10 até 20

            Console.WriteLine($"O número aleatório SEM Limite gerado é: {numero}\n");

            Console.WriteLine($"O número aleatório COM Limite gerado é: {numero2}\n");

            Console.WriteLine($"O número aleatório Limitado gerado é: {numero3}");

            Console.ReadKey();


        }
    }
}
