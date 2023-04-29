using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.AVLTree
{
    public class ANode
    {
        public ANode Left { get; set; }
        public ANode Right { get; set; }

        public int Value { get; set; }

        public int Height { get; set; }

        public ANode(int data)
        {
            Value = data;
        }
    }
}
