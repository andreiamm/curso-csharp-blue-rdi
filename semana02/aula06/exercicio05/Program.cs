using System;

namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe seu nome completo: ");
            string nome = Console.ReadLine();

            Strings str = new Strings();

            Console.WriteLine($"\nSeu nome abreviado é: {str.Abbreviate(nome)}");
            Console.WriteLine($"Seu nome ao contrário é: {str.RevertString(nome)}");
            Console.WriteLine(str.CountVowelsAndConsonants(nome));
        }
    }
}
