using System;

namespace Task2_Json.Services
{
    class MainCours:MainCategori
    {
        public MainCours(string name, string category)
        {
            path = Environment.CurrentDirectory + @"\Json\Categories\MainCourses.json";

            Choice(name, category);
        }
    }
}
