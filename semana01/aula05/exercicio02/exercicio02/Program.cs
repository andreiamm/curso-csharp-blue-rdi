using System;

namespace exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ABERTURA DE VOO:");
            Console.Write("Número do voo: ");
            string number = Console.ReadLine();
            Console.Write("Data do voo (dd/MM/aaaa): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Horário do voo (HH:mm): ");
            DateTime time = DateTime.Parse(Console.ReadLine());

            Flights flight = new Flights(number, date, time);

            Console.WriteLine(flight);
            Console.Write($"O primeiro assento disponível é o {flight.CheckFirstFreeSeat()}. Deseja reservá-lo? (S/N)");
            char reserve = char.Parse(Console.ReadLine());

            if (reserve == 's' || reserve == 'S')
            {
                Console.WriteLine(flight.CheckSeat(flight.CheckFirstFreeSeat()));
            }
            else
            {
                Console.Write("Qual assento você deseja reservar? ");
                string seat = Console.ReadLine();

                Console.WriteLine(flight.CheckSeat(seat));
            }

            Console.WriteLine(flight);
        }
    }
}
