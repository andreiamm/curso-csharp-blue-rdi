namespace exercicio03.Entities
{
    internal class Mammal : Animal
    {
        public string Diet { get; set; }
        public Mammal(string name, int pawsNumber, string color, string environment, int averageSpeed, string diet)
            : base(name, pawsNumber, color, environment, averageSpeed)
        {
            Diet = diet;
        }

        public override string AnimalData()
        {
            return base.AnimalData()
                   + "Alimentação: "
                   + Diet + "\n";
        }
    }
}
