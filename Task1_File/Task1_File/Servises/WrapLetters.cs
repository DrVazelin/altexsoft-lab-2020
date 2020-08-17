using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1_File.Servises
{
    public class WrapLetters
    {
        string str;
        string path= @"C:\Users\vladb\source\enCore\altexsoft-lab-2020\Task1_File\File.txt";
        string[] textMass;

        public WrapLetters()
        {
            FileWork File = new FileWork();
            str = File.ReadFromFile(path);

            Console.WriteLine("You decide to swap letters in file");
        }

        public void BreakIntoWords()
        {
            textMass = str.Split('.','?','!');

            //Console.WriteLine(str);
            Console.WriteLine(textMass[2]);
            Console.WriteLine("");
            Console.WriteLine("");
        }
        public void WrapInSentence()
        {
            string[] words;
            textMass[2] = textMass[2].Trim();
            words = textMass[2].Split(' ');

            for(int i = 0; i < words.Length; i++)
            {
                for(int j = words[i].Length; j>=1; j--)
                {
                    Console.Write(words[i][j-1]);
                }
                Console.Write(' ');
            }
        }
    }
}
