using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_File.Servises
{
    public class FileWork
    {       
        public string ReadFromFile()
        {
            string line;

            string path = @"D:\File.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    line = sr.ReadToEnd();
                    return line;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return "File not found";
            }

        }
    }
}
