using aula10.Entities;
using aula10.Entities.Exceptions;
using System;

namespace aula10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Species momotchi = new Momotchi("Momotchi");
                momotchi.Owner = new Owner("Julie", 10);
                momotchi.Grow();
                momotchi.Feed(momotchi.FavoriteFood);
                Console.WriteLine(momotchi);

                Species mimitchi = new Mimitchi("Mimitchi");
                mimitchi.Owner = new Owner("Pedro", 7);
                mimitchi.Grow();
                mimitchi.Grow();
                Food food = new Vegetarian("Fondue de Queijo", "Pão, queijo");
                mimitchi.Feed(food);
                Console.WriteLine(mimitchi);

                mimitchi.Starve();
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
