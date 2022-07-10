using System;

namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet1 = new int[10];
            int[] vet2 = new int[10];

            for (int i = 0; i < vet1.Length; i++)
            {
                Console.Write($"Informe o {i + 1}o número: ");
                vet1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vet2.Length; i++)
            {
                vet2[i] = vet1[i] * 5;
            }

            Console.Write("\nPrimeiro vetor: ");
            for (int i = 0; i < vet1.Length; i++)
            {
                Console.Write($"{vet1[i]} ");
            }

            Console.Write("\nSegundo vetor: ");
            for (int i = 0; i < vet2.Length; i++)
            {
                Console.Write($"{vet2[i]} ");
            }
        }
    }
}
