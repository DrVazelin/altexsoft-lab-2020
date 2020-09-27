using System;
using System.Collections.Generic;
using Task2_Json.DAL;
using Task2_Json.Structures;

namespace Task2_Json.BL
{
    class Dishes
    {
        public Dishes(string category)
        {
            string buf = category.ToUpper() + ".json";
            string path = Environment.CurrentDirectory + @"\Json\Categories\" + buf;

            this.path = path;
        }

        public string path { get; set; }

        public CollectionRecipe ShowAllName()
        {
            JsonDishRepository fileWork = new JsonDishRepository();
            CollectionRecipe collectionBuf = new CollectionRecipe();
            CollectionRecipe allName = new CollectionRecipe();

            collectionBuf = fileWork.Read(path);
            allName.ListRecipe = new List<Recipe>();

            for(int i = 0; i < collectionBuf.ListRecipe.Count; i++)
            {
                Recipe test = new Recipe();
                test.Name = collectionBuf.ListRecipe[i].Name;
                allName.ListRecipe.Add(test);
            }
            return allName;
        }

        public Recipe ShowOneRecipe(int choise)
        {
            JsonDishRepository fileWork = new JsonDishRepository();
            CollectionRecipe collectionBuf = new CollectionRecipe();

            collectionBuf = fileWork.Read(path);

            if (choise < 0 || choise > collectionBuf.ListRecipe.Count) { throw new Exception("invalid input in ShowOneRecipe.BL"); }
            else return collectionBuf.ListRecipe[choise];
        }

        public bool AddRecipe(Recipe recipe)
        {
            //возможность добавить проверки в будущем
            if (true)
            {
                CollectionRecipe dishes = new CollectionRecipe();
                JsonDishRepository jsonRepository = new JsonDishRepository();
                dishes = jsonRepository.Read(path);
                dishes.ListRecipe.Add(recipe);

                jsonRepository.Update(path, dishes);

                return true;
            }  
        }
    }
}
