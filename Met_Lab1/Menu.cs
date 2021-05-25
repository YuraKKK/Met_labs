using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
     public class Menu
    {
        private Guid _id { get; set; }
        private string _name { get; set; }
        private List<Food> _foods { get; set; }
        public Menu(string name, List<Food> foods)
        {
            _name = name;
            _id = Guid.NewGuid();
            _foods = foods;
        }
        public int CountFoods()
        {
            return _foods.Count;
        }
    }
}
