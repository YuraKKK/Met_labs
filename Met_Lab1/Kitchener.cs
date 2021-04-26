using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    public class Kitchener: BaseKitchener, IKitchener
    {
        public void AddFood(BaseFood food)
        {
            if(!IsCooking(food))
                _foods.Add(food);
        } 
        public bool IsCooking(BaseFood food)
        {
            foreach (var item in _foods)
            {
                if (food.Name == item.Name)
                {
                    return true;
                }
            }
            return false;
        }
        public int CountFoods()
        {
            return _foods.Count;
        }
    }
}