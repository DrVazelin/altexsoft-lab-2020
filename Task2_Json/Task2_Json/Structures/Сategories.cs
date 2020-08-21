using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Task2_Json.Structures
{
    public class Сategories
    {
        public string Salate { get; set; }
        [JsonPropertyName("first_courses")]
        public string first { get; set; }
        [JsonPropertyName("main_courses")]
        public string main { get; set; }

        public string dessert { get; set; }

        public string beverage { get; set; }
    }
}
