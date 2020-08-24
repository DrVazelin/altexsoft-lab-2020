using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Json.Services
{
    abstract class Categories
    {
        public abstract string patch { get; set; }
        public abstract void ShowRecipes();
    }
}
