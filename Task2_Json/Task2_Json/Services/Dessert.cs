using System;

namespace Task2_Json.Services
{
    class Dessert:MainCategori
    {
        public Dessert(string name, string category)
        {
            path = Environment.CurrentDirectory + @"\Json\Categories\Desserts.json";

            Choice(name, category);
        }
    }
}


