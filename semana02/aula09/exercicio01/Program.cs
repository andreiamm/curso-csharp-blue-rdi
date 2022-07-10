using exercicio01.Entities;
using System;
using System.Globalization;

namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            try
            {
                // Square
                Console.WriteLine("Cálculo da Área do Quadrado");
                Console.Write("Lado: ");
                double side = double.Parse(Console.ReadLine(), CI);

                Square square = new Square(side);
                Console.WriteLine($"Área = {square.Area().ToString("F1", CI)}");

                // Rectangle
                Console.WriteLine();
                Console.WriteLine("Cálculo da Área do Retângulo");
                Console.Write("Base: ");
                double base1 = double.Parse(Console.ReadLine(), CI);
                Console.Write("Altura: ");
                double height = double.Parse(Console.ReadLine(), CI);

                Rectangle rectangle = new Rectangle(base1, height);
                Console.WriteLine($"Área = {rectangle.Area().ToString("F1", CI)}");

                // Triangle
                Console.WriteLine();
                Console.WriteLine("Cálculo da Área do Triângulo");
                Console.Write("Base: ");
                base1 = double.Parse(Console.ReadLine(), CI);
                Console.Write("Altura: ");
                height = double.Parse(Console.ReadLine(), CI);

                Triangle triangle = new Triangle(base1, height);
                Console.WriteLine($"Área = {triangle.Area().ToString("F1", CI)}");

                // Circle
                Console.WriteLine();
                Console.WriteLine("Cálculo da Área do Círculo");
                Console.Write("Raio: ");
                double radius = double.Parse(Console.ReadLine(), CI);

                Circle circle = new Circle(radius);
                Console.WriteLine($"Área = {circle.Area().ToString("F1", CI)}");

                // Rhombus
                Console.WriteLine();
                Console.WriteLine("Cálculo da Área do Losango");
                Console.Write("Diagonal menor: ");
                double diagonal1 = double.Parse(Console.ReadLine(), CI);
                Console.Write("Diagonal maior: ");
                double diagonal2 = double.Parse(Console.ReadLine(), CI);

                Rhombus rhombus = new Rhombus(diagonal1, diagonal2);
                Console.WriteLine($"Área = {rhombus.Area().ToString("F1", CI)}");

                // Trapezoid
                Console.WriteLine();
                Console.WriteLine("Cálculo da Área do Trapézio");
                Console.Write("Base menor: ");
                base1 = double.Parse(Console.ReadLine(), CI);
                Console.Write("Base maior: ");
                double base2 = double.Parse(Console.ReadLine(), CI);
                Console.Write("Altura: ");
                height = double.Parse(Console.ReadLine(), CI);

                Trapezoid trapezoid = new Trapezoid(base1, base2, height);
                Console.WriteLine($"Área = {trapezoid.Area().ToString("F1", CI)}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
