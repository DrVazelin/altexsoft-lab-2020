using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Json.Services
{
    public abstract class Categories
    {
        public abstract string patch { get; set; }
        public void Сonfirm(string name, string category)
        {
            Console.WriteLine("Hellow "+name+", your choise "+ category+ "category. ");
        }
        public abstract void ShowRecipes();
    }
}
