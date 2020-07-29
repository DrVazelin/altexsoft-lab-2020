using System;

namespace Task1_File.Servises
{
    public class ChangeFile
    {
        public void Delete()
        {
            FileWork File = new FileWork();
            Console.WriteLine(File.ReadFromFile());
            Console.WriteLine();
        }
    }
}
