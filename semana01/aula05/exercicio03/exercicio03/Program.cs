using System;

namespace exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Calculator calc = new Calculator(n1, n2);

            Console.Write("\nEscolha uma operação (1: soma | 2: subtração | 3: multiplicação | 4: divisão): ");
            int operation = int.Parse(Console.ReadLine());

            while (operation < 1 || operation > 4)
            {
                Console.WriteLine("\nOpção inválida!");
                Console.Write("Escolha uma operação (1: soma | 2: subtração | 3: multiplicação | 4: divisão): ");
                operation = int.Parse(Console.ReadLine());
            }

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"{calc.FirstNumber} + {calc.SecondNumber} = {calc.Sum()}");
                    break;
                case 2:
                    Console.WriteLine($"{calc.FirstNumber} - {calc.SecondNumber} = {calc.Subtraction()}");
                    break;
                case 3:
                    Console.WriteLine($"{calc.FirstNumber} x {calc.SecondNumber} = {calc.Multiplication()}");
                    break;
                case 4:
                    Console.WriteLine($"{calc.FirstNumber} ÷ {calc.SecondNumber} = {calc.Division()}");
                    break;
            }

        }
    }
}
