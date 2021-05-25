using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    public class Ingredients
    {
        private Guid _id { get; set; }
        private string _name { get; set; }
        public Ingredients(string name)
        {
            _id = Guid.NewGuid();
            _name = name;
        }
    }
}
