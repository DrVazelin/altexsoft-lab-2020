using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Json.Services
{
    class Dessert:MainCategori
    {
        public Dessert(string name, string category)
        {
            patch = Environment.CurrentDirectory + @"\Json\Categories\Desserts.json";

            Choice(name, category);
        }
    }
}


