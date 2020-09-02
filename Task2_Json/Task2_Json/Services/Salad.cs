using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Json.Services
{
    class Salad:MainCategori
    {
        public Salad(string name, string category)
        {
            patch = Environment.CurrentDirectory + @"\Json\Categories\Salate.json";

            Choice(name, category);
        }
    }
}
