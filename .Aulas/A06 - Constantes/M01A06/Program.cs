using System;

namespace M01A06
{
    class Program
    {
        static void Main(string[] args)
        {

            const string nome = "Victor";
            var pi = Math.PI;
            float PI = 3.1415F;

            Console.WriteLine("Eu me chamo " + nome); //Usando o comando Const a vatiavel "nunca" poderá ser trocada
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("O valor de pi na biblioteca Math é: " + pi); //podemos usar neste formato ou
            Console.WriteLine("O valor de pi é: " + Math.PI); // ambos os jeitos estão corretos, porem eles usam o dobro de memória
                                                              //pois é um comando extenso, caso queira apenas o valor, podemos usar ele como float
            Console.WriteLine("O valor de pi em float é: " + PI); //Valor de pi em FLOAT
            
            Console.ReadKey();
        }
    }
}