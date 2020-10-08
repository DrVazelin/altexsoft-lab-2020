using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Task2_Json.Structures;
using System;

namespace Task2_Json.DAL
{
    public class JsonDishRepository : IRepository<CollectionRecipe>
    {
        public void Create(string path, string fileName, CollectionRecipe recipes)
        {
            try
            {
                if (File.Exists(path)) { throw new Exception("File is all ready create"); }
            }
            catch (DirectoryNotFoundException) { }


            Save(recipes, path + @"\" + fileName);

        }

        public CollectionRecipe Read(string path)
        {
            try
            {
                File.ReadAllText(path);
            }
            catch (DirectoryNotFoundException) { }

            catch (FileNotFoundException) { }

            string jsonString = File.ReadAllText(path);

            CollectionRecipe listDishes = new CollectionRecipe();

            listDishes.ListRecipe = JsonSerializer.Deserialize<List<Recipe>>(jsonString);

            return listDishes;

        }

        public void Update(string path, CollectionRecipe add)
        {
            CollectionRecipe dishes = new CollectionRecipe();
            dishes = Read(path);

            for (int i = dishes.ListRecipe.Count; i < add.ListRecipe.Count; i++)
            {
                dishes.ListRecipe.Add(add.ListRecipe[i]);
            }

            Save(dishes, path);
        }

        public void Delete(string path, int id)
        {

            CollectionRecipe dishes, buf = new CollectionRecipe();

            dishes = Read(path);

            buf.ListRecipe[0] = dishes.ListRecipe[0];

            if (id > 1 || id <= dishes.ListRecipe.Count)
            {
                for (int i = 0; i < dishes.ListRecipe.Count; i++)
                {
                    if (i == id) { }
                    else { buf.ListRecipe.Add(dishes.ListRecipe[i]); }
                }
            }
            else { throw new Exception("Incorect id"); }

            Save(buf, path);
        }


        private void Save(CollectionRecipe dishes, string path)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(dishes.ListRecipe, options);
            File.WriteAllText(path, jsonString);
        }

    }
}
