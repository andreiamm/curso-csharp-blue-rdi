using System;
using System.Globalization;

namespace exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Registro de Empregado:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Cargo: ");
            string position = Console.ReadLine();
            Console.Write("Salário mensal: R$");
            double salary = double.Parse(Console.ReadLine(), CI);

            Employees emp = new Employees(name, position, salary);

            Console.WriteLine(emp);
            Console.WriteLine("\nConceder aumento (S/N)? ");
            char answer = char.Parse(Console.ReadLine());

            if (answer == 's' || answer == 'S')
            {
                emp.IncreaseSalary();
                Console.WriteLine("Aumento concedido.");
                Console.WriteLine(emp);
            }


        }
    }
}
