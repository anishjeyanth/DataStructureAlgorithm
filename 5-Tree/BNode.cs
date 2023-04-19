using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class BNode
    {
        public BNode Right { get; set; }
        public BNode Left { get; set; }
        public int Value { get; set; }

        public BNode(int data) 
        {
            Value = data;
        }
    }
}
