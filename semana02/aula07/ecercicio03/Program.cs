using System;
using System.Globalization;

namespace exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Número da conta: ");
            int account = int.Parse(Console.ReadLine());
            Console.Write("Correntista: ");
            string name = Console.ReadLine();
            Console.Write("Haverá um depósito inicial (S/N)? ");
            char deposit = char.Parse(Console.ReadLine());

            Account acc;

            if (deposit == 's' || deposit == 'S')
            {
                Console.Write("valor do depósito inicial: R$ ");
                double initialBalance = double.Parse(Console.ReadLine(), CI);
                acc = new Account(account, name, initialBalance);
            } 
            else
            {
                acc = new Account(account, name);
            }

            Console.WriteLine();
            Console.WriteLine(acc);
                        
            Console.Write("\nIndique se você deseja: 1 - fazer um depósito | 2 - fazer um saque | 3 - Alterar o nome do correntista | 0 - Sair: ");
            int answer = int.Parse(Console.ReadLine());

            while (answer != 0)
            {
                
                switch (answer)
                {
                    case 1:
                        Console.Write("\nValor do depósito: ");
                        double value = double.Parse(Console.ReadLine(), CI);

                        acc.Deposit(value);
                        Console.WriteLine(acc);
                        break;
                    case 2:
                        Console.Write("\nValor do saque: ");
                        value = double.Parse(Console.ReadLine(), CI);

                        acc.Withdraw(value);
                        Console.WriteLine(acc);
                        break;
                    case 3:
                        Console.Write("\nNome atualizado do correntista: ");
                        string newHolder = Console.ReadLine();

                        acc.UpdateHolderName(newHolder);
                        Console.WriteLine(acc);
                        break;
                    case 0:
                        break; 
                    default:
                        Console.WriteLine("\nOpção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
                Console.Write("\nIndique se você deseja: 1 - fazer um depósito | 2 - fazer um saque | 3 - Alterar o nome do correntista | 0 - Sair: ");
                answer = int.Parse(Console.ReadLine());
            }



        }
    }
}
