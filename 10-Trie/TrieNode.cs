using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DSA.Trie
{
    public class TrieNode
    {
        [JsonPropertyName("*")]
        public bool IsEndOfWord { get; set; }

        [JsonPropertyName("-")]
        public Dictionary<char, TrieNode> Children { get; set; }

        public TrieNode()
        {
            IsEndOfWord = false;
            Children = new Dictionary<char, TrieNode>();
        }
    }
}
