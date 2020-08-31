using System;

namespace Task1_File.Servises
{
    public class Word
    {
        string path = Environment.CurrentDirectory + @"\File.txt";

        string str;
        public Word()
        {
            Console.WriteLine("You decide to count words in file");

            File File = new File();
            str = File.ReadFromFile(path);
            if (str == null) { Console.WriteLine("File not found"); }
            else
            {
                Count();
                ShowWords(10);
            }

        }

        // Перед первым и после последнего слова нет пробелов - поэтому +2, по хорошему надо было делать Trim ?
        // или лучше проверять на наличие пробелов перед первым и после последнего слова ?

        internal int Count()
        {
            string[] textMass;
            textMass= str.Split(' ');

            Console.WriteLine("Words in file: {0}", textMass.Length+2);
            return textMass.Length+2;
        }

        internal void ShowWords(int index)
        {
            Console.WriteLine("You wont to see {0} words, is in't ?", index);
            string[] textMass;
            textMass = str.Split(' ');

            int buf = index;
            for(int i=0; i < textMass.Length; i++)
            {
                if (i == index)
                {
                    Console.Write(textMass[i]+',');
                    index=index+buf;
                }
            }
        }
    }
}
