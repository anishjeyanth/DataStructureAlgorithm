using DSA.LinkedList;
using System;
using System.Collections;
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
            BNode newNode = new BNode(value);
            if(Root == null)
            {
                Root = newNode;
                return true;
            }

            BNode temp = Root;
            while (true)
            {
                if (newNode.Value == temp.Value)
                    return false;

                if(newNode.Value < temp.Value)
                {
                    if(temp.Left == null)
                    {
                        temp.Left = newNode;
                        return true;
                    }
                    temp = temp.Left;
                }
                else
                {
                    if (temp.Right == null)
                    {
                        temp.Right = newNode;
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

        public void RInsert(int value)
        {
            if (Root == null)
                Root = new BNode(value);

            RecursiveInsert(Root, value);
        }

        private BNode RecursiveInsert(BNode currentNode, int value)
        {
            if(currentNode == null)
                return new BNode(value);

            if(value < currentNode.Value)
                currentNode.Left = RecursiveInsert(currentNode.Left, value);
            else if(value > currentNode.Value)
                currentNode.Right = RecursiveInsert(currentNode.Right, value);

            return currentNode;
        }

        public bool RContains(int value)
        {
            return RecursiveContains(Root, value);
        }

        private bool RecursiveContains(BNode currentNode, int value)
        {
            if(currentNode == null) 
                return false;

            if(currentNode.Value == value) 
                return true;

            if(value < currentNode.Value) 
                return RecursiveContains(currentNode.Left, value);
            else
                return RecursiveContains(currentNode.Right, value);
        }

        public void ListNode()
        {
            if (Root == null)
                return;


            //ListPreOrder(Root);
            //Console.WriteLine();
            //ListInOrder(Root);
            //Console.WriteLine();
            //ListPostOrder(Root);
            //Console.WriteLine();
            ListLevelOrder();
        }

        private void ListPreOrder(BNode node)
        {
            if (node == null)
                return;

            Console.Write(node.Value + " - ");
            ListPreOrder(node.Left);
            ListPreOrder(node.Right);
        }

        private void ListInOrder(BNode node)
        {
            if (node == null)
                return;

            ListInOrder(node.Left);
            Console.Write(node.Value + " - ");           
            ListInOrder(node.Right);
        }

        private void ListPostOrder(BNode node)
        {
            if (node == null)
                return;

            ListPostOrder(node.Left);
            ListPostOrder(node.Right);
            Console.Write(node.Value + " - ");
        }

        public void ListLevelOrder()
        {
            if (Root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }

            Queue<BNode> queue = new Queue<BNode>();
            queue.Enqueue(Root);
            while(queue.Any())
            {
                BNode queuenode = queue.Dequeue();
                Console.Write(queuenode.Value + " - ");
                if(queuenode.Left != null)
                    queue.Enqueue(queuenode.Left);

                if (queuenode.Right != null)
                    queue.Enqueue(queuenode.Right);
            }            
        }
    }
}
