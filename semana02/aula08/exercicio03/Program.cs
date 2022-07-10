using exercicio03.Entities;
using System;

namespace exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalKingdom animal = new AnimalKingdom();
            animal.AddAnimal(new Fish("Peixinho Dourado", 0, "Dourado", "Mar", 1, "Gosta de pular"));
            animal.AddAnimal(new Mammal("Gato", 4, "Preto e branco", "Doméstico", 5, "Ração"));
            animal.AddAnimal(new Mammal("Porquinho", 4, "Rosa", "Chiqueiro", 3, "Mistura"));

            foreach (Animal anim in animal.Animal)
                Console.WriteLine(animal.ShowAnimal(anim));
        }
    }
}
