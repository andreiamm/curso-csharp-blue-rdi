namespace exercicio03.Entities
{
    internal class Bike : Vehicle
    {
        public Bike()
        {
        }

        public override void Accelerate()
        {
            Speed += 2;
        }

        public override void Brake()
        {
            Speed = 0;
        }

        public string AdjustChain()
        {
            return "Corrente ajustada";
        }
    }
}
