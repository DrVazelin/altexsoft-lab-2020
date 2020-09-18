using System;

namespace Task2_Json.Services
{
    class Salad : MainCategori
    {
        public Salad(string name, string category)
        {
            path = Environment.CurrentDirectory + @"\Json\Categories\Salate.json";

            Choice(name, category);
        }
    }
}
