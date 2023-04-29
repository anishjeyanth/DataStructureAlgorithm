using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HashTable
{
    public class HNode
    {
        public string Key;
        public int Value;
        public HNode Next;

        public HNode(string key, int value) 
        {
            Key = key;
            Value = value;
            Next = null; 
        }
    }
}
