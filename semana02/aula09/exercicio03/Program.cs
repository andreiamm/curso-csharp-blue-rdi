using exercicio03.Entities;
using System;

namespace exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car vehicle1 = new Car();
            Console.WriteLine($"Velocidade de partida do carro: {vehicle1.Speed}");
            vehicle1.Accelerate();
            vehicle1.Accelerate();
            vehicle1.Accelerate();
            Console.WriteLine($"Velocidade do carro depois de acelerar três vezes: {vehicle1.Speed}");
            vehicle1.Brake();
            Console.WriteLine($"Velocidade do carro depois de frear: {vehicle1.Speed}");
            Console.WriteLine(vehicle1.ChangeOil());

            Bike vehicle2 = new Bike();
            Console.WriteLine($"Velocidade de partida da bicicleta: {vehicle2.Speed}");
            vehicle2.Accelerate();
            vehicle2.Accelerate();
            vehicle2.Accelerate();
            Console.WriteLine($"Velocidade da bicicleta depois de acelerar três vezes: {vehicle2.Speed}");
            vehicle2.Brake();
            Console.WriteLine($"Velocidade da bicicleta depois de frear: {vehicle2.Speed}");
            Console.WriteLine(vehicle2.AdjustChain());
        }
    }
}
