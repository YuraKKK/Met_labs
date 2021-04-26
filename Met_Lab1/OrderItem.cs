using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    public class OrderItem
    {
        public Guid Id  { get; set; }
        //public Guid FoodId { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public BaseFood Food { get; set; }
    }
}
