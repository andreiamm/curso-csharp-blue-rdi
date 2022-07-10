namespace exercicio03.Entities
{
    internal abstract class Vehicle
    {
        public int Speed { get; set; }

        protected Vehicle()
        {
            Speed = 0;
        }

        public abstract void Accelerate();
        public abstract void Brake();
    }
}
