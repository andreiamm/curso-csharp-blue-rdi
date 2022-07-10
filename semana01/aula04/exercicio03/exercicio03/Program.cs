using System;

namespace exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[5];
            string swap;

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write($"Informe a {i + 1}a palavra: ");
                words[i] = Console.ReadLine();
            }

            for (int i = 0; i < words.Length -1 ; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[j].Length < words[i].Length)
                    {
                        swap = words[i];
                        words[i] = words[j];
                        words[j] = swap;
                    } 
                }
            }

            Console.Write("\nVetor em ordem crescente:");
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write($" {words[i]}");
            }

            Console.WriteLine();
        }
    }
}
