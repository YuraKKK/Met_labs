using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Time { get; set; }
        public decimal Price { get; set; }
        public List<String> ingredients { get; set; }
    }

}
