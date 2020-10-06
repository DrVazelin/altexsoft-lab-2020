using System;
using System.Collections.Generic;

namespace Task2_Json.Structures
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Categories { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Cooking { get; set; }
        public Dictionary<string, int> Ingredients { get; set; }
    }
}
