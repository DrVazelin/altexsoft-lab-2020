using System;
using Task2_Json.BL;
using Task2_Json.Structures;

namespace Task2_Json.PL
{
    class UserChoise
    {
        public UserChoise(string name, string category)
        {
            Console.WriteLine(name+", now your are in "+ category+" category");
            Choice(name, category);
        }

        void Choice(string name, string category)
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
                        Console.WriteLine("Your decided exit from " + category);
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                if (choice == "q") break;
            }
        }
        protected void ShowAll(string name, string category)
        {

            CollectionRecipe dishes = new CollectionRecipe();

            Dishes dishesBL = new Dishes(category);
            dishes = dishesBL.ShowAllName();

            Console.WriteLine(name + ", plase write number of " + category + " to see all information");
            Console.WriteLine();

            for (int i = 0; i < dishes.ListRecipe.Count; i++)
            {
                Console.WriteLine(i + " : " + dishes.ListRecipe[i].Name);
            }
            int choice = Convert.ToInt32(Console.ReadLine());


            if (choice < 0 || choice > dishes.ListRecipe.Count) Console.WriteLine("incorrect input");
            else ShowRecipe(name, category, choice);

        }

        protected void ShowRecipe(string name, string category, int choice)
        {
            Console.WriteLine(name+ ", you decided to see "+choice+" in "+category);
            Console.WriteLine();

            Dishes dishesDAL = new Dishes(category);
            Recipe userRecipe = new Recipe();

            userRecipe = dishesDAL.ShowOneRecipe(choice);

            Console.WriteLine("Name :");
            Console.WriteLine(userRecipe.Name);
            Console.WriteLine();

            Console.WriteLine("Description :");
            Console.WriteLine(userRecipe.Description);
            Console.WriteLine();

            Console.WriteLine("Cooking :");
            Console.WriteLine(userRecipe.Cooking);
            Console.WriteLine();

            Console.ReadLine();

        }

        protected void AddRecipe(string name, string category)
        {
            string dishName, description, cooking;
            Dishes addDish = new Dishes(category);

            Console.WriteLine(name + " , you dicided to add new recipe in "+category);
            Console.WriteLine();
            Console.WriteLine("write name of your new " + category);
            dishName = Console.ReadLine();
            Console.WriteLine("write description of your new " + category);
            description = Console.ReadLine();
            Console.WriteLine("Describe step by step how to prepare your " + category);
            cooking = Console.ReadLine();
            Console.WriteLine();

            Recipe dish = new Recipe()
            {
                Categories = category,
                Name = dishName,
                Description = description,
                Cooking = cooking
            };

            if (addDish.AddRecipe(dish) == true)
            {
                Console.WriteLine("we added your dish to "+ category);
            }
            else Console.WriteLine("Something went wrong");
            Console.ReadLine();
        }
    }
}
