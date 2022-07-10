using System;

namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Marca da TV: ");
            string brand = Console.ReadLine();
            Console.Write("Número de série da TV: ");
            int serial = int.Parse(Console.ReadLine());

            TV tv = new TV(brand, serial);

            Console.WriteLine();
            Console.WriteLine(tv);

            Console.WriteLine("AUMENTA O VOLUME COM A TV DESLIGADA");
            Console.WriteLine(tv.IncreaseVolume());
            Console.WriteLine();

            Console.WriteLine("DIMINUI O VOLUME COM A TV DESLIGADA");
            Console.WriteLine(tv.DecreaseVolume());
            Console.WriteLine();

            Console.WriteLine("TROCA O CANAL COM A TV DESLIGADA");
            Console.WriteLine(tv.SwapChannel((Channels)3));
            Console.WriteLine();

            Console.WriteLine("LIGA A TV");
            Console.WriteLine(tv.TurnOn());
            Console.WriteLine();

            Console.WriteLine("AUMENTA O VOLUME");
            Console.WriteLine(tv.IncreaseVolume());
            Console.WriteLine();

            Console.WriteLine("DIMINUI O VOLUME");
            Console.WriteLine(tv.DecreaseVolume());
            Console.WriteLine();

            Console.WriteLine("TROCA O CANAL");
            Console.WriteLine(tv.SwapChannel((Channels)4));
            Console.WriteLine();

            Console.WriteLine("AUMENTA O VOLUME COM O VOLUME NO MÁXIMO");
            tv.Volume = 100;
            Console.WriteLine(tv.IncreaseVolume());
            Console.WriteLine();

            Console.WriteLine("DIMINUI O VOLUME COM O VOLUME NO MÍNIMO");
            tv.Volume = 0;
            Console.WriteLine(tv.DecreaseVolume());
            Console.WriteLine();

            Console.WriteLine("DESLIGA A TV");
            Console.WriteLine(tv.TurnOff());
            Console.WriteLine();

        }
    }
}
