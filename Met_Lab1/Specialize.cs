using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    public class Specialize
    {
        private Guid _id { get; set; }
        private string _name { get; set; }
        private List<Food> _foods { get; set; }
        public Specialize(string name, List<Food> foods)
        {
            _id = Guid.NewGuid();
            _name = name;
            _foods = foods;
        }
    }
}
