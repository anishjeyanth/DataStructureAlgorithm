using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class DNode
    {
        public int Value { get; set; }

        public DNode Prev { get; set; }
        public DNode Next { get; set; }

        public DNode() { }

        public DNode(int data)
        {
            Value = data;
            Prev = null;
            Next = null;
        }
    }
}
