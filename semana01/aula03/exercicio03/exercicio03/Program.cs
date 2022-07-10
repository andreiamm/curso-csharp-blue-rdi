using System;
using System.Globalization;

namespace exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            float score1, score2, score3, average;

            Console.Write("Informe a 1a nota: ");
            score1 = float.Parse(Console.ReadLine(), CI);
            while (score1 < 0.0f || score1 > 10.0f)
            {
                Console.Write("Valor inválido. A nota deve estar entre 0 e 10.0. Informe a 1a nota: ");
                score1 = float.Parse(Console.ReadLine(), CI);
            }

            Console.Write("Informe a 2a nota: ");
            score2 = float.Parse(Console.ReadLine(), CI);
            while (score2 < 0.0f || score2 > 10.0f)
            {
                Console.Write("Valor inválido. A nota deve estar entre 0 e 10.0. Informe a 2a nota: ");
                score2 = float.Parse(Console.ReadLine(), CI);
            }

            Console.Write("Informe a 3a nota: ");
            score3 = float.Parse(Console.ReadLine(), CI);
            while (score3 < 0.0f || score3 > 10.0f)
            {
                Console.Write("Valor inválido. A nota deve estar entre 0 e 10.0. Informe a 3a nota: ");
                score3 = float.Parse(Console.ReadLine(), CI);
            }

            average = (score1 + score2 + score3) / 3;

            Console.Write($"\nO aluno teve média final {average.ToString("F1", CI)} e foi ");
            Console.WriteLine((average < 7.0f) ? "reprovado." : "aprovado.");
        }
    }
}
