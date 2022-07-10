using System;

namespace exercicio02.Util
{
    internal class ScientificCalculator : Calculator
    {
        public double SquareRoot(int n1)
        {
            return Math.Sqrt(n1);
        }
        public double SquareRoot(double n1)
        {
            return Math.Sqrt(n1);
        }

        public double Exponent(int n1, int n2)
        {
            return Math.Pow(n1, n2);
        }

        public double Exponent(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }
        public override int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        public override int Subtraction(int n1, int n2)
        {
            return n1 - n2;
        }
        public override int Multiplication(int n1, int n2)
        {
            return n1 * n2;
        }
        public override double Division(int n1, int n2)
        {
            return (double)n1 / n2;
        }
    }
}
