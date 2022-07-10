using System;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime hoje = DateTime.Today;
            int anoCorrente = hoje.Year;
            int anoNascimento;

            Console.Write("Informe seu ano de nascimento: ");
            anoNascimento = int.Parse(Console.ReadLine());          

            Console.WriteLine($"Você tem {anoCorrente - anoNascimento} anos");
        }
    }
}
