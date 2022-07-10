
namespace exercicio03.Entities
{
    internal class Car : Vehicle
    {
        public Car()
        {
        }

        public override void Accelerate()
        {
            Speed += 10;
        }

        public override void Brake()
        {
            Speed = 0;
        }

        public string ChangeOil()
        {
            return "Óleo do carro trocado";
        }
    }
}
