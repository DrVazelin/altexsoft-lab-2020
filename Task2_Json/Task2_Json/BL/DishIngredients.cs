using System;
using System.Collections.Generic;
using System.Text;
using Task2_Json.DAL;
using Task2_Json.Structures;

namespace Task2_Json.BL
{
    class DishIngredients
    {
        string path = Environment.CurrentDirectory + @"\Json\Ingredients.json";
        public Dictionary<string, int> AddNewIngredients(Dictionary<string, int> newIngredient)
        {
            CollectionIngredients collectionIngredients = new CollectionIngredients();
            JsonIngredientRepository ingredientRepository = new JsonIngredientRepository();
            Ingredients ingredients = new Ingredients();

            collectionIngredients = ingredientRepository.Read(path);


            //GetLastIdIngredients()
            Id id = new Id();
            int bufId = id.id+1;

            int dictionaryId=0, dictionaryValue=0;
            var dishIngredients = new Dictionary<string, int>();
            bool flag;

            foreach (var IngredientName in newIngredient.Keys)
            {
                // сравнение
                //не нашел, как сделать производительние(         
                flag = true;
                for (int i=0; i < collectionIngredients.ListIngredients.Count; i++)
                {
                    if (collectionIngredients.ListIngredients[i].Name.ToString() == IngredientName.ToString())
                    {
                        dictionaryId = collectionIngredients.ListIngredients[i].Id;
                        dictionaryValue = newIngredient[IngredientName];

                        dishIngredients.Add(dictionaryId.ToString(), dictionaryValue);

                        flag = false;
                    }
                }
                if (flag == false)
                {
                    continue;
                }
                else
                {
                    ingredients.Name = IngredientName;
                    ingredients.Id = bufId;
                    collectionIngredients.ListIngredients.Add(ingredients);

                    dictionaryId = bufId;
                    dictionaryValue = newIngredient[IngredientName];

                    dishIngredients.Add(dictionaryId.ToString(), dictionaryValue);

                    bufId++;
                }

            }
            ingredientRepository.Update(path, collectionIngredients);

            return dishIngredients;
        }
    }
}
