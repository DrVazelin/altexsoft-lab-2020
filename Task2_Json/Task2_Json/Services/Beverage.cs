using System;

namespace Task2_Json.Services
{
    class Beverage:MainCategori
    {
        public Beverage(string name, string category)
        {
            path = Environment.CurrentDirectory + @"\Json\Categories\Beverages.json";

            Choice(name, category);
        }
    }
}

