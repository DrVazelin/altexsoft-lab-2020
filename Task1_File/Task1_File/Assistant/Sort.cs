using System;


namespace Task1_File.Assistant
{
    public class Sort
    {
        public string[] AlphabetSortMass(string[] mas)
        {
            string temp;

            for(int i = 0; i < mas.Length-1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i][0] > mas[j][0])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
    }
}
