using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Json.Services
{
    class Beverage:MainCategori
    {
        public Beverage(string name, string category)
        {
            patch = Environment.CurrentDirectory + @"\Json\Categories\Beverages.json";

            Choice(name, category);
        }
    }
}

