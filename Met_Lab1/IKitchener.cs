using System;
using System.Collections.Generic;
using System.Text;

namespace Met_Lab1
{
    public interface IKitchener
    {
        void AddFood(BaseFood food);
        bool IsCooking(BaseFood food);
        int CountFoods();
    }
}
