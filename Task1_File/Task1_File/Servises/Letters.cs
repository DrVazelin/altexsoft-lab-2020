using System;

namespace Task1_File.Servises
{
    public class Letters
    {
        string str;
        string path = Environment.CurrentDirectory;
        string[] textMass;

        public Letters()
        {
            Console.WriteLine("You decide to swap letters");

            File file = new File();
            str = file.ReadUserFile(path);

            if(str == null) { Console.WriteLine("File not found"); }
            else
            {
                BreakIntoWords();
                WrapInSentence(3);
            }
        }

        public void BreakIntoWords()
        {
            textMass = str.Split('.','?','!');

            Console.WriteLine(textMass[2]);
            Console.WriteLine("");
            Console.WriteLine("");
        }
        public void WrapInSentence(int index)
        {
            Console.WriteLine("Your decide swap letters in {0} sentence", index);
            string[] words;
            textMass[index-1] = textMass[index-1].Trim();
            words = textMass[index-1].Split(' ');

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
