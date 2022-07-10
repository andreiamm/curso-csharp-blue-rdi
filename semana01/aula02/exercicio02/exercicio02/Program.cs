using System;

namespace exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[10];
            int soma, numero;

            soma = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write($"Informe o {i+1}o número inteiro: ");
                numero = int.Parse(Console.ReadLine());

                soma += numero;
            }

            Console.WriteLine($"\nA soma dos números digitados é: {soma}");
        }
    }
}
