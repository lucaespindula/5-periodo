using System.Collections.Generic;
using Newtonsoft.Json;

namespace TBL2_exercicio1._1.Models
{
    public class Pokemon
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("base_experience")]
        public int BaseExperience { get; set; }

        [JsonProperty("types")]
        public List<TypeSlot> Types { get; set; }
    }

    public class TypeSlot
    {
        [JsonProperty("type")]
        public TypeInfo Type { get; set; }
    }

    public class TypeInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}