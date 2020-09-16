using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Json.Services
{
    class UnknownDish:MainCategori
    {
        public UnknownDish(string name, string category, string path)
        {
            this.path = path;

            Choice(name, category);
        }
    }
}
