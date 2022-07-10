using System;
using System.Globalization;

namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("INFORMAÇÕES DO ALUNO:");
            Console.Write("Matrícula: ");
            int register = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Nota da 1a prova: ");
            float score1 = float.Parse(Console.ReadLine(), CI);
            Console.Write("Nota da 2a prova: ");
            float score2 = float.Parse(Console.ReadLine(), CI);
            Console.Write("Nota do trabalho: ");
            float score3 = float.Parse(Console.ReadLine(), CI);

            Alunos alunos = new Alunos(register, name, score1, score2, score3);

            Console.WriteLine($"\nMédia das avaliações: {(alunos.MeanScore()).ToString("F1", CI)}");
            Console.WriteLine($"Nota mínima necessária para a avaliação final: {(alunos.FinalTestScore()).ToString("F1", CI)}");
        }
    }
}
