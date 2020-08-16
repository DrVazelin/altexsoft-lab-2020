using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_File.Servises
{
    public class WordCount
    {
        string path = @"C:\Users\vladb\source\enCore\altexsoft-lab-2020\Task1_File\File.txt";

        string str;
        public WordCount()
        {
            FileWork File = new FileWork();
            str = File.ReadFromFile(path);
        }

        // Перед первым и после последнего слова нет пробелов - поэтому +2, по хорошему надо было делать Trim ?
        internal int Count()
        {
            string[] textMass;
            textMass= str.Split(' ');

            Console.WriteLine(textMass.Length+2);
            return textMass.Length+2;
        }
        internal void ShowIndexWords(int index)
        {
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
