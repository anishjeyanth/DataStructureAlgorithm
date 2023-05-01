using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Trie
{
    public class TrieNode
    {
        public bool IsEndOfWord { get; set; }
        public Dictionary<char, TrieNode> Children { get; set; }

        public TrieNode()
        {
            IsEndOfWord = false;
            Children = new Dictionary<char, TrieNode>();
        }
    }
}
