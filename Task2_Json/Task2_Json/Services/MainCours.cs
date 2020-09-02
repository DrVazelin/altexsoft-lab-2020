using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Json.Services
{
    class MainCours:MainCategori
    {
        public MainCours(string name, string category)
        {
            patch = Environment.CurrentDirectory + @"\Json\Categories\MainCourses.json";

            Choice(name, category);
        }
    }
}
