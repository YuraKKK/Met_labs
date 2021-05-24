using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    public class CookRoom
    {
        private Guid _id { get; set; }
        private string _name { get; set; }
        private List<Kitchener> _kitchebers { get; set; }
        private List<Order> _orders { get; set; }
        public CookRoom(string name)
        {
            _id = Guid.NewGuid();
            _name = name;
            _kitchebers = new List<Kitchener>();
            _orders = new List<Order>();
        }
        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }
        public void AddKitchener(Kitchener kitchener)
        {
            _kitchebers.Add(kitchener);
        }
    }
}
