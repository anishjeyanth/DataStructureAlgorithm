using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class DNode
    {
        public int Value;

        public DNode Prev;
        public DNode Next;

        public DNode() { }

        public DNode(int data)
        {
            Value = data;
            Prev = null;
            Next = null;
        }
    }
}
