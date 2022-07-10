using System.Collections.Generic;

namespace exercicio03.Entities
{
    internal class AnimalKingdom
    {
        public List<Animal> Animal { get; set; } = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            Animal.Add(animal);
        }

        public string ShowAnimal(Animal animal)
        {
            return animal.AnimalData();
        }
    }
}
