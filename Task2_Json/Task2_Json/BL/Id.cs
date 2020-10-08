using System;
using System.Collections.Generic;
using System.Text;
using Task2_Json.DAL;
using Task2_Json.Structures;

namespace Task2_Json.BL
{
    class Id
    {
        public int id { get; set; }
        public Id()
        {
            id = GetLastIdIngredients();
        }
        public Id(string path)
        {
            id = GetLastIdCategory(path);
        }
        private int GetLastIdCategory(string path)
        {
            JsonDishRepository dishRepository = new JsonDishRepository();
            CollectionRecipe collectionRecipe = new CollectionRecipe();

            collectionRecipe=dishRepository.Read(path);

            int buf = collectionRecipe.ListRecipe.Count-1;

            return collectionRecipe.ListRecipe[buf].Id;
        }
        private int GetLastIdIngredients()
        {
            string path = Environment.CurrentDirectory + @"\Json\Ingredients.json";

            JsonIngredientRepository ingredientRepository = new JsonIngredientRepository();
            CollectionIngredients collectionIngredients = new CollectionIngredients();

            collectionIngredients = ingredientRepository.Read(path);

            int buf = collectionIngredients.ListIngredients.Count - 1;

            return collectionIngredients.ListIngredients[buf].Id;
        }
    }
}
