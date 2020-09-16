using System;
using System.IO;
using Task2_Json.Services;

namespace Task2_Json
{
    public class Startup
    {
        string choice;
        string name;
        string path = Environment.CurrentDirectory + @"\Json\Dishes.txt";
        public Startup()
        {
            Console.WriteLine("Welcome to the book of recipes !");
            Console.WriteLine("Please, write your name");
            name = Console.ReadLine();
        }

        public bool IndexOf { get; private set; }

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
                Console.WriteLine("first courses");
                Console.WriteLine();

                Console.WriteLine("\t If your wont to see main courses write:");
                Console.WriteLine("main courses");
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
                        Salad salad = new Salad(name,choice);
                        break;
                    case "first course":
                        FirstCours first = new FirstCours(name, choice);
                        break;
                    case "main course":
                        MainCours main = new MainCours(name, choice);
                        break;
                    case "dessert":
                        Dessert dessert = new Dessert(name, choice);
                        break;
                    case "beverage":
                        Beverage beverage = new Beverage(name, choice);
                        break;
                    case "q":
                        Console.WriteLine("Your decided exit");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        Console.ReadLine();
                        break;
                }

                if (choice == "q") break;
            }
        }
        public void ShowСategoriesFromFile()
        {
            try
            {
                if (!File.Exists(path)) { throw new Exception("File does not exist"); }
            }
            catch (DirectoryNotFoundException) { }

            string[] readText = File.ReadAllLines(path);

            while (true)
            {
                // Вывод на экран 
                Console.WriteLine(name + ", please choise categories");

                Console.WriteLine();
                foreach (string s in readText)
                {
                    Console.WriteLine("\t If your wont to see " + s + " write:");
                    Console.WriteLine(s);
                    Console.WriteLine();
                }
                
                Console.WriteLine("if your wont to exit push q");

                choice = Console.ReadLine();

                if (choice == "q") break;
                else if (Array.IndexOf(readText, choice)==-1) { Console.WriteLine("invalide input"); }
                else
                {

                    UnknownDish salad = new UnknownDish(name, choice, Environment.CurrentDirectory + @"\Json\Categories\"+choice+".json");
                }

            }

        }
    }
}
