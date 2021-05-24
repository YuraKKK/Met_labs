using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    public class Order
    {
        public Guid Id { get; set; }
        public string Status { get; set; }
        public User user;
        public List<Food> Foods { get; set; }
    }
}
    

