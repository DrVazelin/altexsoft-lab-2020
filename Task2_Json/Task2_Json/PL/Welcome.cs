using System;
using Task2_Json.BL;
using Task2_Json.Structures;

namespace Task2_Json.PL
{
    class Welcome
    {
        string choice;
        string name;
        public Welcome()
        {
            Console.WriteLine("Welcome to the book of recipes !");
            Console.WriteLine("Please, write your name");
            name = Console.ReadLine();
            ShowСategoriesFromFile();
        }

        public void ShowСategoriesFromFile()
        {
            CategoriesWork categories = new CategoriesWork();
            CollectionCategories categoriesName = new CollectionCategories();

            categoriesName = categories.ShowAllCategories();

            while (true)
            {
                bool flag = false;
                // Вывод на экран 
                Console.WriteLine(name + ", please choise categories");

                Console.WriteLine();
                foreach (Сategories s in categoriesName.Сategories)
                {
                    Console.WriteLine("\t If your wont to see " + s.Name + " write:");
                    Console.WriteLine(s.Name);
                    Console.WriteLine();
                }

                Console.WriteLine("if your wont to exit push q");

                choice = Console.ReadLine();

                if (choice == "q") break;

                Console.WriteLine();

                for(int i = 0; i < categoriesName.Сategories.Count; i++)
                {
                    if (categoriesName.Сategories[i].Name == choice)
                    {
                        flag = true;
                        UserChoise session = new UserChoise(name, choice);
                        break;
                    }
                }
                if (flag==false) { Console.WriteLine(name + ", tray again"); }
            }

        }
    }
}
