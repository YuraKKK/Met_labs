//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Met_Lab1
//{
//    public class CookRoomService : ICookRoomService
//    {
//        private List<Kitchener> _kitcheners;
//        /// <summary>
//        /// Список страв які готуються
//        /// </summary>
//        private List<Food> _foodCooking;
//        /// <summary>
//        /// Починає працювати кухня
//        /// </summary>
//        /// <param name="kitcheners">Список кухарів</param>
//        public CookRoomService(List<Kitchener> kitcheners)
//        {
//            _kitcheners = kitcheners;
//            _foodCooking = new List<Food>();
//        }
//        public int Cooking(Food food)
//        {
//            int time = food.Time;
//            _foodCooking.Add(food);
//            var kitcheners = _kitcheners.Where(x => x.Specialize == food.Specialize);
//            if (kitcheners.Count() == 0)
//            {
//                return -1;
//            }
//            else
//            {
//                var listFood = _foodCooking.Where(x => x.Specialize == food.Specialize);
//                time = 0;
//                foreach (var item in listFood)
//                {
//                    time += item.Time;
//                }
//            }
//            return time;
//        }
//    }
//}
