//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Met_Lab1
//{
//    class ApplicationService : Program, IApplicationService
//    {
//        private List<Kitchener> _kitcheners;
//        private List<BaseFood> _foods;
//        private ICookRoomService _cookRoomService;

//        public void Initialize()
//        {
//            _kitcheners = GetKitcheners();
//            _cookRoomService = new CookRoomService(_kitcheners);
//            _foods = GetFoods();
//            //var inrgedients = GetIngredients();
//            //foreach (var item in list)
//            //{
//            //    Console.WriteLine("Id: " + item.Id);
//            //    Console.WriteLine("Ім'я: " + item.Name);
//            //    Console.WriteLine("Спеціальність: " + item.Specialize);
//            //}

//            //CookRoomService cookRoomService = new CookRoomService(kitcheners);
//            //int time = cookRoomService.Cooking(foods.SingleOrDefault(x => x.Name == "Хачапурі"));
//            //Console.WriteLine("Час для приготування хачапурі: " + time);
//            //time = cookRoomService.Cooking(foods.SingleOrDefault(x => x.Name == "Чебурек"));
//            //Console.WriteLine("Час для приготування чебуреку: " + time);
//            //time = cookRoomService.Cooking(foods.SingleOrDefault(x => x.Name == "Чебурек"));
//            //Console.WriteLine("Час для приготування чебуреку 2: " + time);
//            //time = cookRoomService.Cooking(foods.SingleOrDefault(x => x.Name == "Хотдог"));
//            //Console.WriteLine("Час для приготування хотдогу: " + time);

//        }

//        public void ShowListFoods()
//        {
//            foreach (var item in _foods)
//            {
//                Console.WriteLine(item);
//            }
//        }
//        private List<Ingredient> GetIngredientsCheburek()
//        {
//            List<Ingredient> ingredients = new List<Ingredient>();

//            ingredients.Add(new Ingredient
//            {
//                Name = "М'ясо",
//                Units = "Грами"
//            });
//            return ingredients;

//        }
//        private List<Ingredient> GetIngredientsHachapuri()
//        {
//            List<Ingredient> ingredients = new List<Ingredient>();
//            ingredients.Add(new Ingredient
//            {
//                Name = "Мясо",
//                Units = "Грами"

//            });
//            ingredients.Add(new Ingredient
//            {
//                Name = "Сир",
//                Units = "Грами"

//            });
//            ingredients.Add(new Ingredient
//            {
//                Name = "Соус",
//                Units = "Грами"

//            });
//            return ingredients;
//        }
//        private List<Ingredient> GetIngredientsHotdog()
//        {
//            List<Ingredient> ingredients = new List<Ingredient>();
//            ingredients.Add(new Ingredient
//            {
//                Name = "Сир",
//                Units = "Грами"

//            });
//            ingredients.Add(new Ingredient
//            {
//                Name = "Соус",
//                Units = "Грами"

//            });
//            ingredients.Add(new Ingredient
//            {
//                Name = "Сосиска",
//                Units = "Грами"

//            });
//            return ingredients;
//        }
//        private List<Ingredient> GetIngredientsSirop()
//        {
//            List<Ingredient> ingredients = new List<Ingredient>();

//            ingredients.Add(new Ingredient
//            {
//                Name = "Цукор",
//                Units = "Грами"
//            });
//            ingredients.Add(new Ingredient
//            {
//                Name = "Вода",
//                Units = "Літри"
//            });


//            return ingredients;

//        }
//        private List<Kitchener> GetKitcheners()
//        {
//            List<Kitchener> list = new List<Kitchener>();
//            list.Add(new Kitchener
//            {
//                Id = Guid.NewGuid(),
//                Name = "Світлана Іванівна",
//                Specialize = Specialize.Confectioner
//            });
//            list.Add(new Kitchener
//            {
//                Id = Guid.NewGuid(),
//                Name = "Василь Петрович",
//                Specialize = Specialize.Chef
//            });
//            return list;
//        }
//        private List<Food> GetFoods()
//        {
//            List<Food> foods = new List<Food>();
//            Food sirop = new Food
//            {
//                Id = 1,
//                Name = "Сироп",
//                Specialize = Specialize.Confectioner,
//                Time = 30,
//                Weight = 350,
//                Price = 40,
//                Ingredients = new List<Ingredient>()

//            };
//            sirop.Ingredients.AddRange(GetIngredientsSirop());
//            foods.Add(sirop);
//            Food hachapuri = new Food
//            {
//                Id = 2,
//                Name = "Хачапурі",
//                Specialize = Specialize.Hachapuri,
//                Time = 20,
//                Weight = 250,
//                Price = 50,
//                Ingredients = new List<Ingredient>()

//            };
//            hachapuri.Ingredients.AddRange(GetIngredientsHachapuri());
//            foods.Add(hachapuri);
//            Food cheburek = new Food
//            {
//                Id = 3,
//                Name = "Чебурек",
//                Specialize = Specialize.Chef,
//                Time = 10,
//                Weight = 250,
//                Price = 30,
//                Ingredients = new List<Ingredient>()
//            };
//            cheburek.Ingredients.AddRange(GetIngredientsCheburek());
//            foods.Add(cheburek);
//            Food hotdog = new Food
//            {
//                Id = 4,
//                Name = "Хотдог",
//                Specialize = Specialize.Confectioner,
//                Time = 15,
//                Weight = 250,
//                Price = 40,
//                Ingredients = new List<Ingredient>()

//            };
//            hotdog.Ingredients.AddRange(GetIngredientsHotdog());
//            foods.Add(hotdog);
//            return foods;
//        }

//        public void CreateOrder()
//        {
//            Order order = new Order();

//            order.User = GetUserInfo();
//            //2.Оберає страви
//            order.OrderItems = new List<OrderItem>();
//            int action = 0;
//            do
//            {
//                OrderItem orderItem = new OrderItem();
//                Console.WriteLine("Оберіть страву(0 - вихід): ");
//                this.ShowListFoods();
//                Console.Write("->_");
//                action = int.Parse(Console.ReadLine());
//                if (action == 0)
//                {
//                    break;
//                }
//                //3.По кожній страві вказує кількість
//                Console.WriteLine("Оберіть кількість страв: ");
//                orderItem.Count = int.Parse(Console.ReadLine());
//                orderItem.Food = _foods.SingleOrDefault(x => x.Id == action);
//                orderItem.Price = orderItem.Food.Price;
//                order.OrderItems.Add(orderItem);
//                //4.Обчислюємо час приготування замовлення
//                //Console.WriteLine("Час приготування замовлення: ");
//                order.TimeCooking += _cookRoomService.Cooking(orderItem.Food) * orderItem.Count;

//            } while (action != 0);

//            //5.Видача замовдення
//            Console.WriteLine("Ваше замовлення");
//            Console.WriteLine("Час приготування: ");
//            Console.WriteLine(order.TimeCooking);
//        }
//        private User GetUserInfo()
//        {
//            User user = new User();
//            //1.Ввід даних людиною
//            Console.WriteLine("Введіть ім'я: ");
//            user.Name = Console.ReadLine();
//            Console.WriteLine("Введіть номер телефону: ");
//            user.PhoneNumber = Console.ReadLine();
//            Console.WriteLine("Введіть адресу: ");
//            user.Address = Console.ReadLine();
//            Console.WriteLine("Вкажіть вашу пошту: ");
//            user.Email = Console.ReadLine();
//            return user;
//        }
//    }
//}
