using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using Task2_Json.Structures;

namespace Task2_Json.DAL
{
    class JsonIngredientRepository : IRepository<CollectionIngredients>
    {
        public void Create(string path, string fileName, CollectionIngredients ingredients)
        {
            throw new NotImplementedException();
        }

        public CollectionIngredients Read(string path)
        {
            try
            {
                File.ReadAllText(path);
            }
            catch (DirectoryNotFoundException) { }

            catch (FileNotFoundException) { }

            string jsonString = File.ReadAllText(path);

            CollectionIngredients listIngredients = new CollectionIngredients();

            listIngredients.ListIngredients = JsonSerializer.Deserialize<List<Ingredients>>(jsonString);

            return listIngredients;
        }

        public void Update(string path, CollectionIngredients add)
        {
            CollectionIngredients ingredients = new CollectionIngredients();
            ingredients = Read(path);

            for (int i = ingredients.ListIngredients.Count; i < add.ListIngredients.Count; i++)
            {
                ingredients.ListIngredients.Add(add.ListIngredients[i]);
            }

            Save(ingredients, path);
        }

        public void Delete(string path, int id)
        {
            throw new NotImplementedException();
        }

        private void Save(CollectionIngredients collectionIngredients, string path)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(collectionIngredients.ListIngredients, options);
            File.WriteAllText(path, jsonString);
        }
    }
}
