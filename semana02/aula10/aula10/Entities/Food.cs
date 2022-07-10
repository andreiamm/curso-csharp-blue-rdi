namespace aula10.Entities
{
    internal class Food
    {
        public string Name { get; set; }
        public string Ingredients { get; set; }

        public Food(string name, string ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }
    }
}
