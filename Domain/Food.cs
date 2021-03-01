using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Їжа
    /// </summary>
    public class Food
    {
        public string Name { get; set; }
        public Specialize Specialize { get; set; }
        public int Weight { get; set; }
        public int Time { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}
