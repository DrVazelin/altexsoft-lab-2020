using System;

namespace Task1_File.Servises
{
    public class ChangeFile
    {
        string str;
        string delete;
        string path = @"C:\Users\vladb\source\enCore\altexsoft-lab-2020\Task1_File\File.txt";

        public void Delete()
        {
            
            FileWork File = new FileWork();
            str=File.ReadFromFile(path);

            Console.WriteLine("You decide to delete something in file");
            Console.WriteLine("Write what you want to delete");

            delete = Console.ReadLine();

            while (true)
            {
                if (str.Contains(delete))
                {
                    str = str.Replace(delete,"");
                    Console.WriteLine(str);
                    File.SaveInFile(str);
                    break;
                }
                else
                {
                    Console.WriteLine(delete+" not found in the file");
                    break;
                }
            }
            
        }
    }
}
