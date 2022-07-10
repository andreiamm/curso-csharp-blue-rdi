using exercicio04.Entities;
using exercicio04.Entities.Enums;
using System;
using System.Collections.Generic;

namespace exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Catalog> catalog = new List<Catalog>();
            List<Loans> loans = new List<Loans>();

            try
            {
                Console.Write("Quantas obras você irá cadastrar? ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Dados do item {i}:");
                    Console.Write("Livro ou Periódico (L/P): ");
                    char type = char.Parse(Console.ReadLine());
                    Console.Write("Número de identificação: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Título: ");
                    string title = Console.ReadLine();
                    Console.Write("Autor: ");
                    string author = Console.ReadLine();
                    Console.Write("Categoria: ");
                    string subject = Console.ReadLine();

                    if (type == 'l' || type == 'L')
                    {
                        Console.Write("Ano: ");
                        int year = int.Parse(Console.ReadLine());

                        catalog.Add(new Books(id, title, author, subject, year));
                    }
                    else
                    {
                        Console.Write("Data de publicação (MM/AAAA): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());

                        catalog.Add(new Journals(id, title, author, subject, date));
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Acervo cadastrado:");
                foreach (Catalog cat in catalog)
                {
                    Console.WriteLine(cat);
                }

                Console.WriteLine();
                Console.WriteLine("Empréstimo de Livro:");
                Console.Write("Nome do usuário: ");
                string name = Console.ReadLine();
                Console.Write("E-mail do usuário: ");
                string email = Console.ReadLine();
                Console.Write("Número de identificação do livro para empréstimo: ");
                int bookId = int.Parse(Console.ReadLine());
                Catalog book = catalog.Find(x => x.Id == bookId);
                loans.Add(new Loans(new Client(name, email), book, ItemStatus.CheckedOut));

                Console.WriteLine();
                Console.WriteLine("Leitura de obra na biblioteca");
                Console.Write("Nome do usuário: ");
                name = Console.ReadLine();
                Console.Write("E-mail do usuário: ");
                email = Console.ReadLine();
                Console.Write("Número de identificação do livro para leitura: ");
                int itemID = int.Parse(Console.ReadLine());
                Catalog item = catalog.Find(x => x.Id == itemID);
                loans.Add(new Loans(new Client(name, email), item, ItemStatus.InUse));

                Console.WriteLine();
                Console.WriteLine("Livros emprestados:");
                foreach (Loans loan in loans)
                {
                    if (loan.Status != ItemStatus.Available)
                        Console.WriteLine(loan);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro! " + e.Message);
            }
        }
    }
}
