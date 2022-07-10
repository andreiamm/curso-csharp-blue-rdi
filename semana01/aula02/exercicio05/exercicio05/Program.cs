using System;
using System.Globalization;

namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Console.OutputEncoding = System.Text.Encoding.UTF8; // possibilita usar símbolos
            
            float reais;
            
            Console.Write("Valor em reais: R$ ");
            reais = float.Parse(Console.ReadLine(), CI);

            Console.WriteLine("\nCONVERSÕES:");
            Console.WriteLine($" R$ {reais.ToString("F2", CI)} equivalem a:");
            Console.WriteLine($"Dólar americano: $ {(reais / 4.919f).ToString("F2", CI)}");
            Console.WriteLine($"Euro: € {(reais / 5.263f).ToString("F2", CI)}");
            Console.WriteLine($"Libra esterlina: £ {(reais / 6.173f).ToString("F2", CI)}");
            Console.WriteLine($"Dólar canadense: C$ {(reais / 3.912f).ToString("F2", CI)}");
            Console.WriteLine($"Peso argentino: $ {(reais / 0.040f).ToString("F2", CI)} ARS");
            Console.WriteLine($"Peso chileno: {(reais / 0.006f).ToString("F2", CI)} CLP");
        }
    }
}
