using aula10.Entities.Exceptions;
using System.Text;

namespace aula10.Entities
{
    internal class Species
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public Food FavoriteFood  { get; set; }
        public string FavoriteSnack { get; set; }
        public string FavoriteItem { get; set; }
        public string FavoriteAccessory { get; set; }

        public int Age { get; set; }

        public int Satiety { get; set; }

        public Owner Owner { get; set; }

        public Species()
        {
        }

        public Species(string name)
        {
            Name = name;
            Age = 0;
            Satiety = 0;
        }

        public void Grow()
        {
            Age++;
        }

        public void Feed(Food food)
        {
            if (food == FavoriteFood)
                Satiety += 2;
            else
                Satiety++;

            if (Satiety >= 15)
            {
                throw new DomainException("Ah não! " + Name + " morreu empanturrado!");
            }
        }

        public void Starve()
        {
            Satiety--;

            if (Satiety <= 0)
            {
                throw new DomainException("Ah não! " + Name + " morreu de fome...");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome: {Name}");
            sb.AppendLine($"Cor: {Color}");
            sb.AppendLine($"Comida favorita: {FavoriteFood.Name} ({FavoriteFood.Ingredients})");
            sb.AppendLine($"Lanche favorito: {FavoriteSnack}");
            sb.AppendLine($"Item favorito: {FavoriteItem}");
            sb.AppendLine($"Acessório favorito: {FavoriteAccessory}");
            sb.AppendLine($"Idade: {Age}");
            sb.Append(Owner.ToString());
            sb.AppendLine($"Nível de Saciedade: {Satiety}");

            return sb.ToString();
        }
    }
}
