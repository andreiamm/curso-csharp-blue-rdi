namespace aula10.Entities
{
    internal class Mimitchi : Species
    {
        public Mimitchi(string name)
            : base(name)
        {
            Color = "branco";
            FavoriteFood = new Vegetarian("Charutinho de repolho", "Folha de uva, repolho roxo, cebola roxa");
            FavoriteSnack = "Gelatina de abacaxi";
            FavoriteItem = "Kit de papelaria";
            FavoriteAccessory = "Laço brilhante";
        }
    }
}