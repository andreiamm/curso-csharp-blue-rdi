using System;

namespace exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do pet: ");
            string petName = Console.ReadLine();
            Console.Write("Tipo: ");
            string type = Console.ReadLine();
            Console.Write("Cor: ");
            string color = Console.ReadLine();
            Console.Write("Tutor: ");
            string owner = Console.ReadLine();
            Console.Write("Telefone de contato: ");
            string phone = Console.ReadLine();

            Pet pet = new Pet(petName, type, color, owner, phone);

            Console.WriteLine();
            Console.WriteLine(pet);
        }
    }
}
