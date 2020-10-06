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

        public void Update(string path, CollectionCategories add)
        {
            CollectionCategories collectionCategories = new CollectionCategories();
            collectionCategories = Read(path);

            for (int i = collectionCategories.Сategories.Count; i < add.Сategories.Count; i++)
            {
                collectionCategories.Сategories.Add(add.Сategories[i]);
            }

            Save(collectionCategories, path);
        }

        public void Delete(string path, int id)
        {
            CollectionCategories collectionCategories, buf = new CollectionCategories();

            collectionCategories = Read(path);

            buf.Сategories[0] = collectionCategories.Сategories[0];

            if (id > 1 || id <= collectionCategories.Сategories.Count)
            {
                for (int i = 0; i < collectionCategories.Сategories.Count; i++)
                {
                    if (i == id) { }
                    else { buf.Сategories.Add(collectionCategories.Сategories[i]); }
                }
            }
            else { throw new Exception("Incorect id"); }

            Save(buf, path);
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
