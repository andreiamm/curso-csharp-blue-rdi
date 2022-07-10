
using System.Text;

namespace exercicio03.Entities
{
    internal class Animal
    {
        public string Name { get; set; }
        public int PawsNumber { get; set; }
        public string Color { get; set; }
        public string Environment { get; set; }
        public int AverageSpeed { get; set; }

        public Animal(string name, int pawsNumber, string color, string environment, int averageSpeed)
        {
            Name = name;
            PawsNumber = pawsNumber;
            Color = color;
            Environment = environment;
            AverageSpeed = averageSpeed;
        }

        public virtual string AnimalData()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Animal: {Name}");
            sb.AppendLine($"Quantidade de patas: {PawsNumber}");
            sb.AppendLine($"Cor: {Color}");
            sb.AppendLine($"Ambiente: {Environment}");
            sb.AppendLine($"Velocidade média: {AverageSpeed} km/h");

            return sb.ToString();
        }
    }
}
