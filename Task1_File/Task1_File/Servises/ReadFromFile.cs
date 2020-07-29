using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_File.Servises
{
    public class ReadFromFile
    {       
        public string FromFile()
        {
            string line;

            string path = @"C:\Users\vladb\source\repos\Alex_Soft\Task1_File\File.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = sr.ReadLine();
                    }
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
