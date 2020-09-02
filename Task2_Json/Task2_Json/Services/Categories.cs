using System;
using Task2_Json.Structures;

namespace Task2_Json.Services
{
    public abstract class Categories
    {
        public abstract string patch { get; set; }
        public void Сonfirm(string name, string category)
        {
            Console.WriteLine("Hellow "+name+", your choise "+ category+ " category. ");
        }
        public abstract void Choice(string name, string category);
        protected abstract void ShowAll(string name, string category);
        protected abstract void ShowRecipe(string name, string category, int choice, ColectionRecipe dishes);
        protected abstract void AddRecipe(string name, string category);
        
    }
}
