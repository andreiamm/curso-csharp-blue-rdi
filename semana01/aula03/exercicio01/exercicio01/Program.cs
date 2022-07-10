using System;
using System.Globalization;

namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            float value;
            int hundred, fifty, twenty, ten, five, two;

            Console.Write("Informe o valor monetário com 2 casas decimais: ");
            value = float.Parse(Console.ReadLine(), CI);

            hundred = (int)value / 100;
            value %= 100.0f;
            fifty = (int)value / 50;
            value %= 50.0f;
            twenty = (int)value / 20;
            value %= 20.0f;
            ten = (int)value / 10;
            value %= 10.0f;
            five = (int)value / 5;
            value %= 5.0f;
            two = (int)value / 2;

            Console.WriteLine("\nNOTAS");
            Console.WriteLine($"{hundred} nota(s) de R$ 100.00");
            Console.WriteLine($"{fifty} nota(s) de R$ 50.00");
            Console.WriteLine($"{twenty} nota(s) de R$ 20.00");
            Console.WriteLine($"{ten} nota(s) de R$ 10.00");
            Console.WriteLine($"{five} nota(s) de R$ 5.00");
            Console.WriteLine($"{two} nota(s) de R$ 2.00\n");
        }
    }
}
