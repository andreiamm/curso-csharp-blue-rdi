namespace exercicio05
{
    enum Channels : int
    {
        Welcome = 0,
        Discovery = 1,
        History = 2,
        Smithsonian = 3,
        TV5 = 4,
        Rai = 5
    }

    internal class TV
    {
        public string Brand { get; set; }
        public int SerialNumber { get; set; }
        public int Volume { get; set; }
        public bool Status { get; set; }
        public Channels Channel { get; set; }

        public TV(string brand, int serialNumber)
        {
            Brand = brand;
            SerialNumber = serialNumber;
            Volume = 50;
            Status = false;
            Channel = Channels.Welcome;
        }

        public string TurnOn()
        {
            Status = true;
            return "TV ligada com sucesso.";
        }

        public string TurnOff()
        {
            Status = false;
            return "TV desligada com sucesso.";
        }

        public string IncreaseVolume()
        {
            if (Status == false)
            {
                return "Impossível aumentar o volume com a TV desligada.";
            }
            
            if (Volume == 100)
            {
                return "O volume já está no máximo.";
            }

            Volume += 5;
            return "Novo volume: " + Volume;
        }

        public string DecreaseVolume()
        {
            if (Status == false)
            {
                return "Impossível diminuir o volume com a TV desligada.";
            }

            if (Volume == 0)
            {
                return "A TV já está no modo mute.";
            }

            Volume -= 5;
            return "Novo volume: " + Volume;
        }

        public string SwapChannel(Channels c)
        {
           if (Status == false)
            {
                return "Impossível trocar de canal com a TV desligada.";
            }
           
            if ( c <= 0 || (int) c > 5)
            {
                return "O canal informado não existe.";
            }

            return "Novo canal: " + c.ToString();
        }

        public override string ToString()
        {
            return "TV " + Brand + "\n"
                + "Número de série: " + SerialNumber + "\n"
                + "TV ligada: " + Status + "\n"
                + "Volume: " + Volume + "\n"
                + "Canal: " + Channel + "\n";
        }
    }
}
