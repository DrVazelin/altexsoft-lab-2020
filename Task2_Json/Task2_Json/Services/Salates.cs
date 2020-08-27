using System;
using Task2_Json.Structures;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace Task2_Json.Services
{
    class Salads : Categories
    {
        public override string patch { get; set; }
        public Salads(string nama,string category)
        {
            Сonfirm(nama,category);
            patch = @"C:\Users\vladb\source\enCore\altexsoft-lab-2020_V2\altexsoft-lab-2020\Task2_Json\Json_DB\Categories\salate.json";
        }
        
        public override void ShowRecipes()
        {            
            Console.WriteLine(patch);
            ColectionRecipe salates = new ColectionRecipe();
            string jsonString = File.ReadAllText(patch);
            salates = JsonSerializer.Deserialize<ColectionRecipe>(jsonString);
            Console.WriteLine(salates.ListRecipe[0].Name);
        }
    }
}
