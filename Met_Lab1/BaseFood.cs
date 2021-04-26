using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    public abstract class BaseFood
    {
        public int Id { get; set; }
        private string _name { get; set; }
        public int Weight { get; set; }
        public int Time { get; set; }
        public decimal Price { get; set; }
        protected List<Ingredient> Ingredients { get; set; }
        public BaseFood(String name)
        {
            _name = name;
        }
        public string Name { get { return _name; } }
        public override string ToString()
        {
            string str = "";
            str = "Name: " + _name;
            str += "\nId: " + Id.ToString();
            str += "\nPrice: " + Price.ToString();
            str += "\n\tingredients: ";
            foreach (var item in Ingredients)
            {
                str += item.Name + " ";
            }
            return str;
        }
    }

}
