using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HashTable
{
    public class HNode
    {
        public string Key { get; set; }
        public int Value { get; set; }
        public HNode Next { get; set; }

        public HNode(string key, int value) 
        {
            Key = key;
            Value = value;
            Next = null; 
        }
    }
}
