using System;

namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, endereco, cep, telefone;
            
            Console.WriteLine("DADOS CADASTRAIS:");
            Console.Write("Nome completo: ");
            nome = Console.ReadLine();
            Console.Write("Endereço: ");
            endereco = Console.ReadLine();
            Console.Write("CEP: ");
            cep = Console.ReadLine();
            Console.Write("Telefone: ");
            telefone = Console.ReadLine();

            Console.WriteLine("\nINFORMAÇÕES CADASTRADAS: ");
            Console.WriteLine($"Nome completo: {nome}");
            Console.WriteLine($"Endereço: {endereco}");
            Console.WriteLine($"CEP: {cep}");
            Console.WriteLine($"Telefone: {telefone}");
        }
    }
}
