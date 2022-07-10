using System;

namespace exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O computador sorteou um número entre 0 e 1.000!");
            Console.Write("Tente adivinhar o número: ");
            int num = int.Parse(Console.ReadLine());

            Draw draw = new Draw();

            Console.WriteLine();
            while (!draw.EvaluateGuess(num))
            {
                Console.WriteLine($"Não foi dessa vez...");

                if (draw.IsGreater(num))
                {
                    Console.Write($"Seu palpite foi MENOR do que o número sorteado. Tente novamente: ");
                }
                else
                {
                    Console.Write($"Seu palpite foi MAIOR do que o número sorteado. Tente novamente: ");
                }
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine($"Parabéns, você acertou! O número sorteado foi {draw.Number}.");
            Console.WriteLine($"Você fez {draw.Counter} tentativas até acertar o número sorteado.");
        }
    }
}
