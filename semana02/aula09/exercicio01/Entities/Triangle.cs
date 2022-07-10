namespace exercicio01.Entities
{
    internal class Triangle : Rectangle
    {
        public Triangle()
        {
        }

        public Triangle(double @base, double height)
            : base(@base, height)
        {
        }

        public override double Area()
        {
            return base.Area() / 2.0;
        }
    }
}
