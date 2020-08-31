using System;
using System.IO;
using System.Text;

namespace Task1_File.Servises
{
    class File
    {
        string path = Environment.CurrentDirectory;

        internal string ReadFromFile(string path)
        {
            string line;

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
                Console.WriteLine("The file couldn't be read:");
                Console.WriteLine(e.Message);
                return null;
            }

        }

        internal void SaveInFile(string str)
        {

            // Append text to an existing file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, "WriteLines.txt"), true))
            {
                outputFile.WriteLine(str);
            }
        }
    }
}
