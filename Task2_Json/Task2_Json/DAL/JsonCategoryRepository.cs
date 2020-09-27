using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Task2_Json.Structures;
using System;

namespace Task2_Json.DAL
{
    class JsonCategoryRepository : IRepository<CollectionCategories>
    {
        public void Create(string path, string fileName, CollectionCategories collectionCategories)
        {
            try
            {
                if (File.Exists(path)) { throw new Exception("File is all ready create"); }
            }
            catch (DirectoryNotFoundException) { }

            Save(collectionCategories, path + @"\" + fileName);
        }


        public CollectionCategories Read(string path)
        {
            try
            {
                File.ReadAllText(path);
            }
            catch (DirectoryNotFoundException) { }

            catch (FileNotFoundException) { }

            string jsonString = File.ReadAllText(path);

            CollectionCategories collectionCategories = new CollectionCategories();

            collectionCategories.Сategories = JsonSerializer.Deserialize<List<Сategories>>(jsonString);

            return collectionCategories;
        }

        public void Update(string path, CollectionCategories item)
        {
            throw new NotImplementedException();
        }

        public void Delete(string path, int id)
        {
            throw new NotImplementedException();
        }

        private void Save(CollectionCategories collectionCategories, string path)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(collectionCategories.Сategories, options);
            File.WriteAllText(path, jsonString);
        }
    }
}
