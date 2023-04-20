using DSA.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree
{
    public class BinarySearchTree
    {
        public BNode Root;

        public bool Insert(int value)
        {
            BNode node = new BNode(value);
            if(Root == null)
            {
                Root = node;
                return true;
            }

            BNode temp = Root;
            while (true)
            {
                if (node.Value == temp.Value)
                    return false;

                if(node.Value < temp.Value)
                {
                    if(temp.Left == null)
                    {
                        temp.Left = node;
                        return true;
                    }
                    temp = temp.Left;
                }
                else
                {
                    if (temp.Right == null)
                    {
                        temp.Right = node;
                        return true;
                    }
                    temp = temp.Right;
                }
            }
        }

        public bool Contains(int value)
        {
            if (Root == null)
                return false;

            BNode temp = Root;
            while (temp != null)
            {
                if(value < temp.Value)
                {
                    temp = temp.Left;
                }
                else if(value > temp.Value)
                {
                    temp = temp.Right;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public void PrintNode()
        {
            if (Root == null)
                return;

            PrintPreOrder(Root);
            Console.WriteLine();
            PrintInOrder(Root);
            Console.WriteLine();
            PrintPostOrder(Root);
            Console.WriteLine();
        }

        private void PrintPreOrder(BNode node)
        {
            if (node == null)
                return;

            Console.Write(node.Value + " - ");
            PrintPreOrder(node.Left);
            PrintPreOrder(node.Right);
        }

        private void PrintInOrder(BNode node)
        {
            if (node == null)
                return;
            
            PrintInOrder(node.Left);
            Console.Write(node.Value + " - ");
            PrintInOrder(node.Right);
        }

        private void PrintPostOrder(BNode node)
        {
            if (node == null)
                return;

            PrintPostOrder(node.Left);
            PrintPostOrder(node.Right);
            Console.Write(node.Value + " - ");
        }

        public void Print()
        {
            if (Root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }

            BNode current = Root;
            Stack<BNode> stack = new Stack<BNode>();

            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }

                current = stack.Pop();
                Console.Write(current.Value + " ");

                current = current.Right;
            }
        }
    }
}
