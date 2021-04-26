using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    public class HotdogFood:BaseFood
    {
        public HotdogFood():base("Hotdog")
        {
            Ingredients = new List<Ingredient>()
            {
                new Ingredient
                {
                    Id = Guid.NewGuid(),
                    Name = "Sausage",
                    Units = "20gram"
                },

                 new Ingredient
                {
                    Id = Guid.NewGuid(),
                    Name = "Сheese",
                    Units = "20gram"
                },
                  new Ingredient
                {
                    Id = Guid.NewGuid(),
                    Name = "Bread",
                    Units = "20gram"
                },
                   new Ingredient
                {
                    Id = Guid.NewGuid(),
                    Name = "Sauce",
                    Units = "20gram"
                }
            };
        }
    }
}
