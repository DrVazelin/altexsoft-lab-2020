using System;
using System.IO;
using Task1_File.Assistant;

namespace Task1_File.Servises
{
    class FileExplorer
    {
        string path = @"D:\";
        string[] dirs;
        string[] files;
        int choice;

        public void ProcessDirectory()
        {
            int i = 0;
            try
            {
                dirs = Directory.GetDirectories(path);

                //Сортировка по алфавиту
                Sort dirsSort = new Sort();
                dirs=dirsSort.AlphabetSortMass(dirs);

                Console.WriteLine("The number of files in directory {0} is {1}.",path, dirs.Length);
                foreach (string dir in dirs)
                {
                    Console.WriteLine(i +" : "+dir);
                    i++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        public void SeeDirectories()
        {  

            while (true)
            {
                Console.WriteLine("If you want to see files in a directory, just enter this number");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice < 0 || choice > dirs.Length) Console.WriteLine("Invalide data");
                else
                {
                    Console.WriteLine(dirs[choice]+" :");
                    Console.WriteLine();

                    files = Directory.GetFiles(dirs[choice]);

                    //Сортировка по алфавиту
                    Sort dirsSort = new Sort();
                    files = dirsSort.AlphabetSortMass(files);

                    foreach (string file in files)
                    {
                        Console.WriteLine(file);
                    }                  
                    break;
                }
            }
        }
    }
}
