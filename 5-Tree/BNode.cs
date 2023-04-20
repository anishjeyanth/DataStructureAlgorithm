using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class BNode
    {
        [JsonPropertyName("R")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public BNode Right { get; set; }

        [JsonPropertyName("L")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public BNode Left { get; set; }

        [JsonPropertyName("*")]
        public int Value { get; set; }

        public BNode(int data) 
        {
            Value = data;
        }
    }
}
