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

            Food hotdog = new Food();
            hotdog.Name = "Hotdog";
            hotdog.Price = 50;
            hotdog.Time = 15;
            hotdog.ingredients = new List<string>
            {
                "Sausage",
                //...
            };
            Food panini = new Food();
            panini.Name = "Panini";
            panini.Price = 40;
            panini.Time = 10;
            Qualification level4 = new Qualification();
            Qualification level3 = new Qualification();
            level4.Name = "Level4";
            level4.qualificationFoods = new List<QualificationFood>
            {
                new QualificationFood
                {
                    food = hotdog,
                    QualificationTime = 30
                }
            };
            new QualificationFood
            {
                food = panini,
                QualificationTime = 25
            };
            Specialize average = new Specialize();
            average.Name = "Average";
            average.Foods = new List<Food>
            {

            };

            Kitchener kitchener = new Kitchener();
            kitchener.Name = "Andriy";
            kitchener.qualification = level4;
            kitchener.specialize = average;


            //BaseFood food;
            //int action = 0;
            //do
            //{
            //    Console.WriteLine("Який продукт ви хочете створити? ");
            //    Console.WriteLine("0-вихід");
            //    Console.WriteLine("1-HOTDOG");
            //    Console.WriteLine("2-PANINI");
            //    action = int.Parse(Console.ReadLine());
            //    BaseFood food;
            //    if (action == 1)
            //    {
            //        food = new HotdogFood("Cheder", "Globino", "Chumak");
            //        Console.WriteLine("Введіть ціну хотдога");
            //        food.Price = decimal.Parse(Console.ReadLine());
            //        Console.WriteLine("Введіть час приготування: ");
            //        food.Time = int.Parse(Console.ReadLine());
            //        //kitchener.AddFood(food);
            //        Console.WriteLine(food);
            //    }
            //    if (action == 2)
            //    {
            //        food = new PaniniFood("Parmezan", "MrBik", "Torchin");
            //        Console.WriteLine("Введіть ціну паніні");
            //        food.Price = decimal.Parse(Console.ReadLine());
            //        Console.WriteLine("Введіть час приготування: ");
            //        food.Time = int.Parse(Console.ReadLine());
            //        //kitchener.AddFood(food);
            //        Console.WriteLine(food);
            //    }
            //} while (action != 0);
            //Console.WriteLine("Введіть назву кухаря: ");
            //string name = Console.ReadLine();
            //IKitchener kitchener = new Kitchener(name, Specialize.Confectioner);
            //int action = 0;
            //do
            //{
            //    Console.WriteLine("Який продукт ви хочете створити? ");
            //    Console.WriteLine("0-вихід");
            //    Console.WriteLine("1-HOTDOG");
            //    Console.WriteLine("2-PANINI");
            //    action = int.Parse(Console.ReadLine());
            //    BaseFood food;
            //    if (action == 1)
            //    {
            //        food = new HotdogFood("Cheder", "Globino", "Chumak");
            //        Console.WriteLine("Введіть ціну хотдога");
            //        food.Price = decimal.Parse(Console.ReadLine());
            //        Console.WriteLine("Введіть час приготування: ");
            //        food.Time = int.Parse(Console.ReadLine());
            //        kitchener.AddFood(food);
            //    }
            //    if (action == 2)
            //    {
            //        food = new PaniniFood("Parmezan", "MrBik", "Torchin");
            //        Console.WriteLine("Введіть ціну паніні");
            //        food.Price = decimal.Parse(Console.ReadLine());
            //        Console.WriteLine("Введіть час приготування: ");
            //        food.Time = int.Parse(Console.ReadLine());
            //        kitchener.AddFood(food);
            //    }
            //} while (action != 0);

            //Console.WriteLine("К-ть продуктів які може готувати кухар: " + kitchener.CountFoods());
            //Order order = new Order();
            //Person person = new User();
            //Console.WriteLine("Введіть ім'я");
            //person.Name = Console.ReadLine();
            //Console.WriteLine("Введіть номер телефону");
            //person.PhoneNumber = Console.ReadLine();
            //Console.WriteLine("Введіть пошту");
            //person.Email = Console.ReadLine();
            //Console.WriteLine("Введіть адресу");
            //person.Address = Console.ReadLine();
            //order.User = person;
            //List<OrderItem> orderItems = new List<OrderItem>();
            //do
            //{
            //    Console.WriteLine("0-вийти: ");
            //    Console.WriteLine("1-додати страву в заказ: ");
            //    action = int.Parse(Console.ReadLine());
            //    if (action == 1)
            //    {
            //        int i = 0;
            //        Console.WriteLine("Оберіть страву: ");
            //        foreach (var food in kitchener.Getfoods())
            //        {
            //            Console.WriteLine($"---------{++i}----------");
            //            Console.WriteLine(food);
            //        }
            //        Console.WriteLine("Введіть номер страви: ");
            //        int orderSelect = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Кількість страв: ");
            //        int count = int.Parse(Console.ReadLine());
            //        orderItems.Add(new OrderItem
            //        {
            //            Id = Guid.NewGuid(),
            //            Food = kitchener.Getfoods()[orderSelect - 1],
            //            Count = count,
            //            Price = kitchener.Getfoods()[orderSelect - 1].Price * count

            //        });

            //    }

            //} while (action != 0);

            //order.OrderItems = orderItems;
            //order.GetShowInfo();

            //IApplicationService chilintano = new ApplicationService();
            //chilintano.Initialize();
            //chilintano.ShowListFoods();

            //chilintano.CreateOrder();
        }

    }
}
