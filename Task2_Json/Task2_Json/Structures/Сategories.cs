using System.Text.Json.Serialization;

namespace Task2_Json.Structures
{
    public class Сategories
    {
        public string salate { get; set; }
        [JsonPropertyName("first_courses")]
        public string first { get; set; }
        [JsonPropertyName("main_courses")]
        public string main { get; set; }

        public string dessert { get; set; }

        public string beverage { get; set; }
    }
}
