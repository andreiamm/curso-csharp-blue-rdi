using System;

namespace exercicio01.Entities
{
    internal class Square : Shape
    {
        public double Side { get; set; }

        public Square()
        {
        }
        public Square(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return Math.Pow(Side, 2.0);
        }
    }
}
