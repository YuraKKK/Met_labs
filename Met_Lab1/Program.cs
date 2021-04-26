using Core.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Met_Lab1
{
    class Program
    {

        static void Main(string[] args)
        {

            //ApplyConfig.Init();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            BaseFood food = new HotdogFood();
            food.Price = 50;
            IKitchener kitchener = new Kitchener();
            kitchener.AddFood(food);
            BaseFood myfood = new PaniniFood();
            myfood.Price = 25;
            bool q = kitchener.IsCooking(myfood);
            BaseFood qwe = new HotdogFood();
            kitchener.AddFood(qwe);
            Console.WriteLine(food);
            Console.WriteLine(myfood); 
            Console.WriteLine("Кухар готує:"+ q);
            Console.WriteLine("К-ть продуктів які може готувати кухар: "+ kitchener.CountFoods());
            Order order = new Order();
            Person person = new User();
            person.Name = "Yura";
            person.PhoneNumber = "0687602022";
            person.Email = "yurkis02@gmail.com";
            person.Address = "Shidna7";
            order.User = person;
            List<OrderItem> orderItems = new List<OrderItem>()
            {
                new OrderItem
                {
                    Id=Guid.NewGuid(),
                    Food=food,
                    Count=2,
                    Price=food.Price*2
                },
                new OrderItem
                {
                     Id=Guid.NewGuid(),
                    Food=myfood,
                    Count=2,
                    Price=myfood.Price*2
                }
            };
            order.OrderItems = orderItems;
            order.GetShowInfo();

            //IApplicationService chilintano = new ApplicationService();
            // chilintano.Initialize();
            //chilintano.ShowListFoods();

            // chilintano.CreateOrder();
        }
       
    }
}
