namespace exercicio01.Entities
{
    internal class Rhombus : Shape
    {
        public double Diagonal1 { get; set; }
        public double Diagonal2 { get; set; }

        public Rhombus()
        {
        }
        
        public Rhombus(double diagonal1, double diagonal2)
        {
            Diagonal1 = diagonal1;
            Diagonal2 = diagonal2;
        }

        public override double Area()
        {
            return Diagonal1 * Diagonal2 / 2.0;
        }
    }
}
