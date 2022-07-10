using System;

namespace exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, meses, dias;
            
            Console.Write("Informe a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nVocê já viveu {idade} anos = {idade * 12} meses = {idade * 365} dias!");
        }
    }
}
