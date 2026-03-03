using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace M01A12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;
            int idade;
            Random maquina = new Random();
            int aleatorio;
            int aleatorioMaquina = maquina.Next(0 , 101);

            Console.Write("Escreva seu nome: ");
            nome = Console.ReadLine();
            Thread.Sleep(1000);
            Console.Clear();

            Console.Write($"{nome}, agora digite sua idade: ");
            int.TryParse(Console.ReadLine(), out idade);
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine($"Perfeito {nome}...\nVerifiquei que você possuí: {idade} anos.\n" +
                $"Para finalizar, preciso que você digite um número de 0 a 100, para testar seu teste de precisão!\nAguarde...");
            Thread.Sleep(10000);
            Console.Clear();

            Console.Write("Escreva um valor entre 0 à 100...\n");
            Console.Write("Digite: ");
            int.TryParse(Console.ReadLine(), out aleatorio);
            Console.Clear();

            Console.WriteLine($"O número digitado é: {aleatorio} ");
            Thread.Sleep(1000);
            Console.WriteLine("P E N S A N D O . . .");
            Thread.Sleep(5000);
            Console.WriteLine($"O número em que a máquina pensou é: {aleatorioMaquina}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("RESUMO");

            Console.WriteLine($"Você se chama: {nome}.\nSua idade é: {idade}.\nO numero escolhido foi: {aleatorio}.\nNumero escolhido pela máquina: {aleatorioMaquina}.\n");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Fim do programa");
            Console.ReadKey();




        }
    }
}
