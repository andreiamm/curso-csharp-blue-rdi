using System;

namespace exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, greater;

            Console.WriteLine("Digite três números:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                greater = n1;
            }
            else if (n2 > n3)
            {
                greater = n2;
            }
            else
            {
                greater = n3;
            }

            Console.WriteLine($"O maior número é {greater}");
        }
    }
}
