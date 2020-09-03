using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Task2_Json.interfaces;
using Task2_Json.Structures;

namespace Task2_Json.Unit_of_Work
{
    public class DishRepository : IRepository<ColectionRecipe>
    {
        public void Create(ColectionRecipe item)
        {
            throw new System.NotImplementedException();
        }
        public void Update(ColectionRecipe item)
        {
            throw new System.NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public ColectionRecipe ShowAll(string path)
        {
            string jsonString = File.ReadAllText(path);
            var dishes = new List<Recipe>();
            dishes = JsonSerializer.Deserialize<List<Recipe>>(jsonString);
            ColectionRecipe listDishes = new ColectionRecipe();
            listDishes.ListRecipe = dishes;
            return listDishes;

        }
    }
}
