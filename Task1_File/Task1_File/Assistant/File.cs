using System;
using System.IO;
using System.Text;

namespace Task1_File.Servises
{
    class File
    {
        internal string CheckUserFile(string path)
        {
            string fileName;
            string[] fileDirectory=Directory.GetFiles(path);
            bool flag=false;

            //проверка, на существование файла в директории

            //на реальном проекте мне бы руки отрвали за такое ))
            while (true)
            {
                Console.WriteLine("Write your file");
                fileName = Console.ReadLine();
                
                for(int i = 0; i < fileDirectory.Length; i++)
                {
                    if (path+@"\"+fileName == fileDirectory[i]) flag = true;
                }

                if (flag) break;
                else Console.WriteLine("invalide file");
            }


            return path + @"\" + fileName;

        }
        internal string ReadUserFile(string path)
        {
            string userPath = CheckUserFile(path);
            
            return ReadFromFile(userPath);
        }

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
            string path = Environment.CurrentDirectory;

            // Append text to an existing file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, "WriteLines.txt"), true))
            {
                outputFile.WriteLine(str);
            }
        }
    }
}
