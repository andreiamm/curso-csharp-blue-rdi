using System;

namespace exercicio01.Entities
{
    internal class Circle : Shape
    {
        public double radius { get; set; }

        public Circle()
        {
        }
        
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return radius * Math.PI;
        }
    }
}
