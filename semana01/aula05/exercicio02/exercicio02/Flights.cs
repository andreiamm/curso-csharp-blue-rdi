using System;

namespace exercicio02
{
    internal class Flights
    {

        private int[,] _seatsMap = new int[18, 4];
        public string FlightNumber { get; set; }
        public DateTime FlightDay { get; set; }
        public DateTime FlightTime { get; set; }
        
        public Flights(string flightNumber, DateTime flightDay, DateTime flightTime)
        {
            FlightNumber = flightNumber;
            FlightDay = flightDay;
            FlightTime = flightTime;

            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    _seatsMap[i, j] = 0;
                }
            }
        }

        public bool OccupySeat(string seat)
        {
            int line = seat[0] - '0';
            char strColumn = seat[1];
            int column = 0;

            switch (strColumn)
            {
                case 'B':
                    column = 1;
                    break;
                case 'C':
                    column = 2;
                    break;
                case 'D':
                    column = 3;
                    break;
            }

            if (_seatsMap[line, column] == 0)
            {
                _seatsMap[line, column] = 1;
                return true;
            } else
            {
                return false;
            }
        }

        public int CheckFreeSeats()
        {
            int count = 0;
            
            for (int i = 0; i < 18; i++)
            {
                for (int j =0; j < 4; j++)
                {
                    if (_seatsMap[i, j] == 0)
                    {
                        count++;
                    }
                }
            }
            
            return count;
        }
        public string CheckFirstFreeSeat()
        {
            int line = 0;
            int column = 0;
            string seat = "";
            
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (_seatsMap[i, j] == 0)
                    {
                        line = i;
                        column = j;
                        i = 18;
                        j = 4;
                    }
                }
            }

            switch (column)
            {
                case 0:
                    seat = line + "A";
                    break;
                case 1:
                    seat = line + "B";
                    break;
                case 2:
                    seat = line + "C";
                    break;
                case 3:
                    seat = line + "D";
                    break;
            }

            return seat;
        }
        public string CheckSeat(string seat)
        {
            seat = seat.ToUpper();
            
            if (OccupySeat(seat))
            {
                return $"A reserva do assento {seat} foi realizada";
            } else
            {
                return $"O assento {seat} já está ocupado.";
            }
        }

        public override string ToString()
        {
            return "Voo: " + FlightNumber 
                   + ", Data: " + FlightDay.ToShortDateString()
                   + ", Horário: " + FlightTime.ToString("HH:mm")
                   + ", Assentos disponíveis: " + CheckFreeSeats() 
                   + ".";
        }

    }
}
