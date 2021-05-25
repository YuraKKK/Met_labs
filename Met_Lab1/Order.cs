using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    public class Order
    {
        private Guid _id { get; set; }
        private string _status { get; set; }
        private User _user;
        private List<Food> _foods { get; set; }
        public Order(string status, User user, List<Food> foods)
        {
            _id = Guid.NewGuid();
            _status = status;
            _user = user;
            _foods = foods;
        }
        public void AddFood(Food food)
        {
            _foods.Add(food);
        }
        public int GetCompletedTime()
        {
            int time = 0;
            foreach (var food in _foods)
            {
                time += food.Time;
            }
            return time;
        }
    }
}
    

