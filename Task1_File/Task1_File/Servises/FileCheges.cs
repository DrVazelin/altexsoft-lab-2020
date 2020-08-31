using System;

namespace Task1_File.Servises
{
    public class FileCheges
    {
        string str;
        string delete;
        string path = Environment.CurrentDirectory + @"\File.txt";

        public void Delete()
        {
            
            File File = new File();
            str=File.ReadFromFile(path);

            if (str == null) { Console.WriteLine("File not found"); }
            else
            {
                Console.WriteLine("You decide to delete something in file");
                Console.WriteLine("Write what you want to delete");

                delete = Console.ReadLine();

                while (true)
                {
                    if (str.Contains(delete))
                    {
                        str = str.Replace(delete, "");
                        Console.WriteLine(str);
                        File.SaveInFile(str);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(delete + " not found in the file");
                        break;
                    }
                }
            }
            
        }
    }
}
