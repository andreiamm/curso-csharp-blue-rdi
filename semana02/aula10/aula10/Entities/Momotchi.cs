namespace aula10.Entities
{
    internal class Momotchi : Species
    {
        public Momotchi(string name) 
            : base(name)
        {
            Color = "rosa";
            FavoriteFood = new Omnivorous("Sanduíche", "Pão, alface, ovo e tomate");
            FavoriteSnack = "Pêssego";
            FavoriteItem = "Kit de Mergulho";
            FavoriteAccessory = "Balões de fruta";
        }
    }
}
