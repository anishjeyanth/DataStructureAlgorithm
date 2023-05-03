using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Trie
{
    public class Trie
    {
        public TrieNode Root;

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

        public void Delete(string word)
        {
            NodeDelete(Root, word, 0);
        }

        private bool NodeDelete(TrieNode current, string word, int index)
        {
            if (index == word.Length)
            {
                if (!current.IsEndOfWord)
                    return false;

                current.IsEndOfWord = false;
                return current.Children.Count == 0;
            }

            char ch = word[index];
            TrieNode tempNode = current.Children[ch];
            if (tempNode == null)
                return false;

            bool toDelete = NodeDelete(tempNode, word, index + 1) && !tempNode.IsEndOfWord;
            if (toDelete)
            {
                current.Children.Remove(ch);
                return current.Children.Count == 0;
            }

            return false;
        }
    }
}
