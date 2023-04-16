using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.StackQueue
{
    public class Node
    {
        public int Value;
        public Node Next;

        public Node() { }

        public Node(int data) 
        {
            Value = data;
            Next = null;
        }
    }
}
