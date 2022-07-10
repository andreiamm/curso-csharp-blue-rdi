using exercicio05.Entities;
using System;
using System.Collections.Generic;

namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Client> list = new List<Client>();

            Console.Write("Quantos clientes você irá cadastrar? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do {i}o Cliente: ");
                Console.Write("Pessoa Física ou Jurídica (F/J)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Número de registro (CPF ou CNPJ): ");
                string id = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Endereço: ");
                string address = Console.ReadLine();
                Console.Write("Telefone: ");
                string phone = Console.ReadLine();
                Console.WriteLine();

                if (type == 'F' || type == 'f')
                    list.Add(new Individual(id, name, email, address, phone));
                else
                    list.Add(new Company(id, name, email, address, phone));
            }

            Console.WriteLine();
            Console.WriteLine("Listagem de Clientes:");

            foreach (Client client in list)
                Console.WriteLine(client);
        }
    }
}
