using System;
using System.Globalization;

namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            float salary;
            int percentage;

            Console.Write("Salário atual: R$ ");
            salary = float.Parse(Console.ReadLine(), CI);

            switch (salary)
            {
                case <= 400.0f:
                    percentage = 15;
                    break;
                case <= 800.0f:
                    percentage = 12;
                    break;
                case <= 1200.0f:
                    percentage = 10;
                    break;
                case <= 2000.0f:
                    percentage = 7;
                    break;
                default:
                    percentage = 4;
                    break;
            }

            Console.WriteLine($"Novo salário: R$ {(salary + salary * percentage / 100.0f).ToString("F2", CI)}");
            Console.WriteLine($"Reajuste ganho: R$ {(salary * percentage / 100.0f).ToString("F2", CI)}");
            Console.WriteLine($"Percentual de aumento: {percentage}%\n");
        }
    }
}
