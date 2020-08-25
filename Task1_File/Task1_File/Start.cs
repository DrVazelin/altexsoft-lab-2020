using System;
using Task1_File.Servises;

namespace Task1_File
{
    internal class Start
    {
        string path = @"C:\Users\vladb\source";
        protected string Choise;

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


                Choise = Console.ReadLine();

                switch (Choise)
                {
                    case "change":
                        ChangeFile test = new ChangeFile();
                        test.Delete(); 
                        break;
                    case "count":
                        WordCount test1 = new WordCount();
                        test1.Count();
                        test1.ShowIndexWords(10);
                        break;
                    case "wrap":
                        WrapLetters test2 = new WrapLetters();
                        test2.BreakIntoWords();
                        test2.WrapInSentence();
                        break;
                    case "file":
                        ShowFile test3 = new ShowFile();
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
                if (Choise == "q") break;
            }

        }
    }
}
