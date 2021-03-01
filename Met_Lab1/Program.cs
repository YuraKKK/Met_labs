using Core.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Met_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ApplyConfig.Init();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            var kitcheners = GetKitcheners();
            var foods = GetFoods();
            //var inrgedients = GetIngredients();
            //foreach (var item in list)
            //{
            //    Console.WriteLine("Id: " + item.Id);
            //    Console.WriteLine("Ім'я: " + item.Name);
            //    Console.WriteLine("Спеціальність: " + item.Specialize);
            //}
            Food hachapuri = new Food
            {

                Name = "Хачапурі",
                Specialize = Specialize.Hachapuri,
                Time = 20,
                Weight = 250,
                Ingredients = new List<Ingredient>()

            };
            Food cheburek = new Food
            {

                Name = "Чебурек",
                Specialize = Specialize.Chef,
                Time = 10,
                Weight = 250,
                Ingredients = new List<Ingredient>()

            };
            Food hotdog = new Food
            {

                Name = "Хотдог",
                Specialize = Specialize.Confectioner,
                Time = 15,
                Weight = 250,
                Ingredients = new List<Ingredient>()

            };
            CookRoomService cookRoomService = new CookRoomService(kitcheners);
            int time = cookRoomService.Cooking(hachapuri);
            Console.WriteLine("Час для приготування хачапурі: " + time);
            time = cookRoomService.Cooking(cheburek);
            Console.WriteLine("Час для приготування чебуреку: " + time);
            time = cookRoomService.Cooking(cheburek);
            Console.WriteLine("Час для приготування чебуреку 2: " + time);
            time = cookRoomService.Cooking(hotdog);
            Console.WriteLine("Час для приготування хотдогу: " + time);

        }
        private static List<Ingredient> GetIngredients()
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            ingredients.Add(new Ingredient
            { 
                Name = "Цукор",
                Units = "Грами"
            });
            ingredients.Add(new Ingredient
            {
                Name = "Вода",
                Units = "Літри"
            });
            return ingredients;

        }
        private static List<Kitchener> GetKitcheners()
        {
            List<Kitchener> list = new List<Kitchener>();
            list.Add(new Kitchener
            {
                Id = Guid.NewGuid(),
                Name = "Світлана Іванівна",
                Specialize = Specialize.Confectioner
            });
            list.Add(new Kitchener
            {
                Id = Guid.NewGuid(),
                Name = "Василь Петрович",
                Specialize = Specialize.Chef
            });
            return list;
        }
        private static List<Food> GetFoods()
        {
            List<Food> foods = new List<Food>();
            Food sirop = new Food
            {

                Name = "Сироп",
                Specialize = Specialize.Confectioner,
                Time = 30,
                Weight = 350,
                Ingredients = new List<Ingredient>()
                
            };
            sirop.Ingredients.AddRange(GetIngredients());
            foods.Add(sirop) ;

            return foods;
        }
    }
}
