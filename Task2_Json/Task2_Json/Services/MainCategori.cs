using System;
using Task2_Json.Structures;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace Task2_Json.Services
{
    class MainCategori : Categories
    {
        public override string patch { get; set; }

        public override void Choice(string name, string category)
        {
            string choice;

            while (true)
            {
                Console.WriteLine(name + ", now your can choise action in " + category);
                Console.WriteLine();
                Console.WriteLine("If your wont to see recipes write:");
                Console.WriteLine("show");
                Console.WriteLine();
                Console.WriteLine("If your wont to add recipe write:");
                Console.WriteLine("add");
                Console.WriteLine("if your wont exit push q");
                Console.WriteLine();

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "show":
                        ShowAll(name, category);
                        break;
                    case "add":
                        AddRecipe(name, category);
                        break;
                    case "q":
                        Console.WriteLine("Your decided exit from "+category);
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                if (choice == "q") break;
            }

        }

        protected override void ShowAll(string name, string category)
        {
            string jsonString = File.ReadAllText(patch);

            var dishes = new List<Recipe>();

            dishes = JsonSerializer.Deserialize<List<Recipe>>(jsonString);

            Console.WriteLine(name + ", plase write number of " +category+ " to see all information");
            Console.WriteLine();

            for(int i = 0; i < dishes.Count; i++)
            {
                Console.WriteLine(i+" : "+dishes[i].Name);
            }
            int choice = Convert.ToInt32(Console.ReadLine());

            ColectionRecipe dishesList = new ColectionRecipe();
            dishesList.ListRecipe = dishes;

            if (choice < 0 || choice > dishes.Count) Console.WriteLine("incorrect input");
            else ShowRecipe(name, category, choice, dishesList);

        }

        protected override void ShowRecipe(string name, string category,int choice,ColectionRecipe dishes)
        {
            Console.WriteLine("Name :");
            Console.WriteLine(dishes.ListRecipe[choice].Name);
            Console.WriteLine();

            Console.WriteLine("Description :");
            Console.WriteLine(dishes.ListRecipe[choice].Description);
            Console.WriteLine();

            Console.WriteLine("Cooking :");
            Console.WriteLine(dishes.ListRecipe[choice].Cooking);
            Console.WriteLine();

            Console.ReadLine();

        }

        protected override void AddRecipe(string name, string category)
        {
            string dishName;
            string description;
            string cooking;

            Console.WriteLine(name + ", you decided to add a recipe");
            Console.WriteLine();

            string jsonString = File.ReadAllText(patch);

            var dishes = new List<Recipe>();

            dishes = JsonSerializer.Deserialize<List<Recipe>>(jsonString);

            while (true)
            {

                Console.WriteLine("write name of your new " + category);
                dishName = Console.ReadLine();
                Console.WriteLine("write description of your new " + category);
                description = Console.ReadLine();
                Console.WriteLine("Describe step by step how to prepare your "+category);
                cooking = Console.ReadLine();
                Console.WriteLine();

                Recipe dish = new Recipe()
                {
                    Categories =category,
                    Name = dishName,
                    Description = description,
                    Cooking = cooking
                };

                dishes.Add(dish);

                Console.WriteLine("Ok, we added your "+category);
                Console.WriteLine("if your wont to exit write q");

                if ("q" == Console.ReadLine()) { break; }
            }

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            jsonString = JsonSerializer.Serialize(dishes, options);
            File.WriteAllText(patch, jsonString);
        }
    }
}
