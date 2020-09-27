using System;
using Task2_Json.DAL;
using Task2_Json.Structures;

namespace Task2_Json.BL
{
    class CategoriesWork
    {
        public string Name { get; internal set; }

        public CollectionCategories ShowAllCategories()
        {
            string path = Environment.CurrentDirectory + @"\Json\Dishes.json";

            JsonCategoryRepository categoryRepository = new JsonCategoryRepository();

            return categoryRepository.Read(path);
        }
    }
}
