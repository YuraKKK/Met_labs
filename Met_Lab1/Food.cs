using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    public class Food
    {
        private Guid _id { get; set; }
        private string _name { get; set; }
        private int _weight { get; set; }
        private int _time { get; set; }
        private decimal _price { get; set; }
        private List<Ingredients> _ingredients { get; set; }
        public Food(string name, int weight, int time, decimal price, List<Ingredients> ingredients)    
        {
            _id = Guid.NewGuid();
            _name = name;
            _weight = weight;
            _time = time;
            _price = price;
            _ingredients = ingredients;
        }
        public string GetFoodInfo()
        {
            string result;
            result = $"Name: {_name}";
            result += $"\nWeight: {_weight}";
            result += $"\nTime: {_time}";
            result += $"\nPrice: {_price}";
            return result;
        }
        public int Time { get { return _time; } }
    }

}
