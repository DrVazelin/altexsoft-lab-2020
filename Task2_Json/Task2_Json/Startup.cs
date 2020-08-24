using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_Json.Services;

namespace Task2_Json
{
    public class Startup
    {
        string choice;
        string name;
        public Startup()
        {
            Console.WriteLine("Welcome to the book of recipes !");
            Console.WriteLine("Please, write your name");
            name = Console.ReadLine();
        }
        public void ShowСategories()
        {
            while (true)
            {
                Console.WriteLine(name + ", please choise categories");

                Console.WriteLine();
                Console.WriteLine("\t If your wont to see salads write:");
                Console.WriteLine("salad");
                Console.WriteLine();

                Console.WriteLine("\t If your wont to see first courses write:");
                Console.WriteLine("first");
                Console.WriteLine();

                Console.WriteLine("\t If your wont to see main courses write:");
                Console.WriteLine("main");
                Console.WriteLine();

                Console.WriteLine("\t If your wont to see desserts write:");
                Console.WriteLine("dessert");
                Console.WriteLine();

                Console.WriteLine("\t If your wont to see beverages write:");
                Console.WriteLine("beverage");
                Console.WriteLine();

                Console.WriteLine("if your wont to exit push q");


                choice = Console.ReadLine();

                switch (choice)
                {
                    case "salad":
                        Salads salad = new Salads();
                        salad.ShowRecipes();
                        break;
                    case "first":

                        break;
                    case "main":

                        break;
                    case "dessert":

                        break;
                    case "beverage":

                        break;
                    case "q":
                        Console.WriteLine("Your decided exit");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

                if (choice == "q") break;
            }
        }
    }
}
