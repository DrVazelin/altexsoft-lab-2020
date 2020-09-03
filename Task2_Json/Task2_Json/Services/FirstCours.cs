using System;

namespace Task2_Json.Services
{
    class FirstCours:MainCategori
    {
        public FirstCours(string name, string category)
        {
            path = Environment.CurrentDirectory + @"\Json\Categories\FirstCourses.json";

            Choice(name, category);
        }
    }
}
