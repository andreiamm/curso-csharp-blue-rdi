using System;

namespace exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vect = new int[10];
            int numEvens, numOdds, j, k;

            numEvens = numOdds = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Informe o {i + 1}o número: ");
                vect[i] = int.Parse(Console.ReadLine());

                if (vect[i] % 2 == 0)
                {
                    numEvens++;
                } else
                {
                    numOdds++;
                }
            }

            int[] evens = new int[numEvens];
            int[] odds = new int[numOdds];

            j = k = 0;
            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] % 2 == 0)
                {
                    evens[j] = vect[i];
                    j++;
                } else
                {
                    odds[k] = vect[i];
                    k++;
                }
            }

            if (evens.Length == 0)
            {
                Console.Write("\nNenhum número par foi digitado");
            } else
            {
                Console.Write("\nVetor de pares: ");
                for (int i = 0; i < evens.Length; i++)
                {
                    Console.Write($"{evens[i]} ");
                }
            }

            if (odds.Length == 0)
            {
                Console.Write("\nNenhum número ímpar foi digitado");
            }
            else
            {
                Console.Write("\nVetor de impares: ");
                for (int i = 0; i < odds.Length; i++)
                {
                    Console.Write($"{odds[i]} ");
                }
            }

            Console.WriteLine();
        }
    }
}
