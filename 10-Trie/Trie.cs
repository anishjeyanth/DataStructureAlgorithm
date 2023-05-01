using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Trie
{
    public class Trie
    {
        private TrieNode Root;

        public Trie() 
        { 
            Root =  new TrieNode();
        }

        public void Add(string word)
        {
            TrieNode current = Root;
            foreach(char ch in word)
            {
                if(!current.Children.ContainsKey(ch))
                {
                    current.Children[ch] = new TrieNode();
                }  
                current = current.Children[ch];
            }
            current.IsEndOfWord = true;
        }

        public bool Search(string word)
        {
            TrieNode current = Root;
            foreach (char ch in word)
            {
                if (!current.Children.ContainsKey(ch))
                {
                    Console.WriteLine("Word not found.");
                    break;
                }
                current = current.Children[ch];
            }

            return current.IsEndOfWord;
        }
    }
}
