using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    public class Order
    {
        public Guid Id { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public DateTime DateCreated { get; set; }
        public Person User { get; set; }
        public int TimeCooking { get; set; }
        public void GetShowInfo()
        {
            Console.WriteLine("Список срав");
            foreach (var item in OrderItems)
            {
                Console.WriteLine(item.Food);
                Console.WriteLine(item.Price);
            }
        }
    }
    
}
