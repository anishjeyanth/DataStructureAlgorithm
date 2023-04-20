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
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public BNode Right { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public BNode Left { get; set; }
        public int Value { get; set; }

        public BNode(int data) 
        {
            Value = data;
        }
    }
}
