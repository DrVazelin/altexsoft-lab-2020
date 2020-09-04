using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Task2_Json.interfaces;
using Task2_Json.Structures;

namespace Task2_Json.Unit_of_Work
{
    public class JsonRepository : IRepository<ColectionRecipe>
    {
        public void Create(ColectionRecipe item)
        {
            throw new System.NotImplementedException();
        }

        public void Update(string path, ColectionRecipe add)
        {
            ColectionRecipe dishes = new ColectionRecipe();
            dishes = Read(path);

            for(int i = dishes.ListRecipe.Count; i < add.ListRecipe.Count; i++)
            {
                dishes.ListRecipe.Add(add.ListRecipe[i]);
            }

            Save(dishes, path);
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public ColectionRecipe Read(string path)
        {
            string jsonString = File.ReadAllText(path);
            var dishes = new List<Recipe>();
            dishes = JsonSerializer.Deserialize<List<Recipe>>(jsonString);
            ColectionRecipe listDishes = new ColectionRecipe();
            listDishes.ListRecipe = dishes;
            return listDishes;

        }
        private void Save(ColectionRecipe dishes, string path)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(dishes, options);
            File.WriteAllText(path, jsonString);
        }
    }
}
