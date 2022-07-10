using exercicio02.Util;
using System;
using System.Globalization;

namespace exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Console.Write("Primeiro número: ");
                double n1 = int.Parse(Console.ReadLine(), CI);
                Console.Write("Segundo número: ");
                double n2 = int.Parse(Console.ReadLine(), CI);

                ScientificCalculator sc = new ScientificCalculator();
                
                Console.WriteLine();
                Console.WriteLine("1. Soma | 2. Subtração | 3. Multiplicação | 4. Divisão | 5. Raíz Quadrada | 6. Potenciação | 0. Sair");
                Console.Write("Escolha uma operação: ");
                int operation = int.Parse(Console.ReadLine());

                while (operation != 0)
                {
                    switch (operation)
                    {
                        case 1:
                            Console.WriteLine($"{n1} + {n2} = {sc.Sum((int)n1, (int)n2)}");
                            break;
                        case 2:
                            Console.WriteLine($"{n1} - {n2} = {sc.Subtraction((int)n1, (int)n2)}");
                            break;
                        case 3:
                            Console.WriteLine($"{n1} x {n2} = {sc.Multiplication((int)n1, (int)n2)}");
                            break;
                        case 4:
                            Console.WriteLine($"{n1} ÷ {n2} = {sc.Division((int)n1, (int)n2).ToString("F1", CI)}");
                            break;
                        case 5:
                            Console.WriteLine($"√{n1} = {sc.SquareRoot(n1).ToString("F1", CI)}");
                            break;
                        case 6:
                            Console.WriteLine($"{n1} ^ {n2} = {sc.Exponent(n1, n2).ToString("F1", CI)}");
                            break;
                        default:
                            Console.WriteLine("Operação inválida.");
                            break;
                    }

                    Console.WriteLine();
                    Console.WriteLine("1. Soma | 2. Subtração | 3. Multiplicação | 4. Divisão | 5. Raíz Quadrada | 6. Potenciação | 0. Sair");
                    Console.Write("Escolha uma operação: ");
                    operation = int.Parse(Console.ReadLine());
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro! " + e.Message);
            }
        }
    }
}
