using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Seeder
    {
        public static void SeedDatabase()
        {
            EFContext context = new EFContext();
            SeedIngredients(context);
        }
        private static void SeedIngredients(EFContext context)
        {
            if (context.Ingredients.Count() == 0)
            {
                List<Ingredient> ingredients = new List<Ingredient>();

                ingredients.Add(new Ingredient
                {
                    Name = "Цукор",
                    Units = "Грами"
                });
                ingredients.Add(new Ingredient
                {
                    Name = "Вода",
                    Units = "Літри"
                });
                context.Ingredients.AddRange(ingredients);
                context.SaveChanges();
            }
        }
    }
}
