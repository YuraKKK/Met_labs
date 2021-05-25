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

            Food hotdog = new Food("Хотдог", 100, 10, 50, new List<Ingredients> {
                new Ingredients("Булка"),
                new Ingredients("Сосиска")
            });

            Food pizza = new Food("Піцца", 120, 40, 60, new List<Ingredients> {
                new Ingredients("Тісто"),
                new Ingredients("Ковбаса")
            });
            Console.WriteLine(hotdog.GetFoodInfo());

            Qualification level1 = new Qualification("Розряд 1", new List<QualificationFood> { 
                new QualificationFood(hotdog, 10)
            });
            Qualification level2 = new Qualification("Розряд 2", new List<QualificationFood> {
                new QualificationFood(hotdog, 5),
                new QualificationFood(pizza, 15)
            });
            Specialize kyhar = new Specialize("Кухар", new List<Food> { 
                pizza, hotdog
            });
            Kitchener yura = new Kitchener("Yura", level1, kyhar);
            Kitchener roman = new Kitchener("Roman", level2, kyhar);
            int romancookTime = roman.TimeCooking();
            int yuracookTime = yura.TimeCooking();


            Menu pizzaMenu = new Menu("Піцци", new List<Food> {
                pizza
            });
            Menu hotdogMenu = new Menu("Хотдоги", new List<Food> {
                hotdog
            });
            pizzaMenu.CountFoods();
            hotdogMenu.CountFoods();

            User userYura = new User();
            userYura.Id = Guid.NewGuid();
            userYura.Name = "Yura";
            userYura.PhoneNumber = "0687602022";
            userYura.Login = "yurkis02@gmail.com";
            userYura.Password = "0101";

            Order order = new Order("Нове замовлення", userYura, new List<Food>
            {
                pizza, hotdog
            });
            int item = order.GetCompletedTime();
            Console.WriteLine("Час приготування замовлення");


            CookRoom cookRoom = new CookRoom("Кухня", new List<Kitchener> { 
            yura, roman
            }, new List<Order> { 
            order
            });
            cookRoom.AddKitchener(roman);
            cookRoom.AddOrder(order);

            
            
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
