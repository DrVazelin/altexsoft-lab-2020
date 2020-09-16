using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Task2_Json.interfaces;
using Task2_Json.Structures;
using System;

namespace Task2_Json.Unit_of_Work
{
    public class JsonDishRepository : IRepository<ColectionRecipe>
    {
        public void Create(string path, string fileName, ColectionRecipe recipes)
        {
            try
            {
                if (File.Exists(path)) { throw new Exception("File is all ready create"); }
            }
            catch (DirectoryNotFoundException) { }


            Save(recipes,path + @"\" + fileName);

        }

        public ColectionRecipe Read(string path)
        {
            try
            {
                File.ReadAllText(path);
            }
            catch (DirectoryNotFoundException) { }

            catch (FileNotFoundException) { }

            string jsonString = File.ReadAllText(path);

            ColectionRecipe listDishes = new ColectionRecipe();

            listDishes.ListRecipe = JsonSerializer.Deserialize<List<Recipe>>(jsonString);

            return listDishes;

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

        public void Delete(string path,int id)
        {

            ColectionRecipe dishes,buf = new ColectionRecipe();

            dishes = Read(path);

            buf.ListRecipe[0] = dishes.ListRecipe[0];

            if(id > 1 || id <= dishes.ListRecipe.Count)
            {
                for(int i = 0; i < dishes.ListRecipe.Count; i++)
                {
                    if (i == id) { }
                    else { buf.ListRecipe.Add(dishes.ListRecipe[i]); }
                }
            }
            else { throw new Exception("Incorect id"); }

            Save(buf, path);
        }


        private void Save(ColectionRecipe dishes, string path)
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
