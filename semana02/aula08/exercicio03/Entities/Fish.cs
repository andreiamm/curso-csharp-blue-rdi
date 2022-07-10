namespace exercicio03.Entities
{
    internal class Fish : Animal
    {
        public string Characteristics { get; set; }
        public Fish(string name, int pawsNumber, string color, string environment, int averageSpeed, string characteristics)
            : base(name, pawsNumber, color, environment, averageSpeed)
        {
            Characteristics = characteristics;
        }

        public override string AnimalData()
        {
            return base.AnimalData()
                   + "Cacterísticas: "
                   + Characteristics + "\n";
        }
    }
}
