using System;
using System.Globalization;

namespace exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Número da fatura: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Descrição do produto: ");
            string desc = Console.ReadLine();
            Console.Write("Quantidade comprada: ");
            int quant = int.Parse(Console.ReadLine());
            Console.Write("Preço do produto: R$ ");
            double price = double.Parse(Console.ReadLine(), CI);

            Invoice invoice = new Invoice(num, desc, quant, price);

            Console.WriteLine("\nINFORMAÇÕES DA FATURA: ");
            Console.WriteLine(invoice);
        }
    }
}
