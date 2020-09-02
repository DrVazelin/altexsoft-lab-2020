using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Json.Services
{
    class FirstCours:MainCategori
    {
        public FirstCours(string name, string category)
        {
            patch = Environment.CurrentDirectory + @"\Json\Categories\FirstCourses.json";

            Choice(name, category);
        }
    }
}
