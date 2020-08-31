using System;
using Task1_File.Servises;

namespace Task1_File
{
    internal class Start
    {
        protected string choise;

        internal void Hellow()
        {
            Console.WriteLine("\t Welcome to Task 1!");
            Console.WriteLine("\t this program presents the basic steps " +
                "of working with a file");
        }

        internal void UserChoise()
        {
            while (true)
            {
                Console.WriteLine("Choose your action and write in console");

                Console.WriteLine();
                Console.WriteLine("\t If your wont delete smt in file write:");
                Console.WriteLine("change");
                Console.WriteLine();

                Console.WriteLine("\t If your wont count words in file write:");
                Console.WriteLine("count");
                Console.WriteLine();

                Console.WriteLine("\t If your wont wrap smt in file write:");
                Console.WriteLine("wrap");
                Console.WriteLine();

                Console.WriteLine("\t If your wont to see files write:");
                Console.WriteLine("file");
                Console.WriteLine();

                Console.WriteLine("if your wont to exit push q");


                choise = Console.ReadLine();

                switch (choise)
                {
                    case "change":
                        FileCheges test = new FileCheges();
                        test.Delete(); 
                        break;
                    case "count":
                        Word test1 = new Word();
                        break;
                    case "wrap":
                        Letters test2 = new Letters();
                        break;
                    case "file":
                        FileExplorer test3 = new FileExplorer();
                        test3.ProcessDirectory();
                        test3.SeeDirectories();
                        break;
                    case "q":
                        Console.WriteLine("Your decided exit");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                Console.ReadLine();
                if (choise == "q") break;
            }

        }
    }
}
