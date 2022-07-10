namespace exercicio01.Entities
{
    internal class Trapezoid : Shape
    {
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Height { get; set; }

        public Trapezoid()
        {
        }
        
        public Trapezoid(double base1, double base2, double height)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }

        public override double Area()
        {
            return (Base1 + Base2) * Height / 2.0;
        }
    }
}
