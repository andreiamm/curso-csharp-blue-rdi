namespace exercicio01.Entities
{
    internal class Rectangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public override double Area()
        {
            return Height * Base;
        }
    }
}
