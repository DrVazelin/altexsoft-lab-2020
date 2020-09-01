using System;

namespace Task1_File.Servises
{
    public class FileChanger
    {
        string str;
        string delete;
        string path = Environment.CurrentDirectory;

        public void Delete()
        {
            
            File file = new File();
            str = file.ReadUserFile(path);

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
                        file.SaveInFile(str);
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
