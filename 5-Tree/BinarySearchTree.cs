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

        public void TraverseNode()
        {
            if (Root == null)
                return;

            //PreOrderTraversal(Root);
            //Console.WriteLine();
            //InOrderTraversal(Root);
            //Console.WriteLine();
            //PostOrderTraversal(Root);
            //Console.WriteLine();
            LevelOrderTraversal();
        }

        private void PreOrderTraversal(BNode node)
        {
            if (node == null)
                return;

            Console.Write(node.Value + " - ");
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }

        private void InOrderTraversal(BNode node)
        {
            if (node == null)
                return;

            InOrderTraversal(node.Left);
            Console.Write(node.Value + " - ");           
            InOrderTraversal(node.Right);
        }

        private void PostOrderTraversal(BNode node)
        {
            if (node == null)
                return;

            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.Write(node.Value + " - ");
        }

        public void LevelOrderTraversal()
        {
            if (Root == null)
                return;

            Queue<BNode> queue = new Queue<BNode>();
            queue.Enqueue(Root);
            while(queue.Any())
            {
                BNode queuenode = queue.Dequeue();
                Console.Write(queuenode.Value + " - ");
                if(queuenode.Left != null)
                    queue.Enqueue(queuenode.Left);

                if(queuenode.Right != null)
                    queue.Enqueue(queuenode.Right);
            }            
        }

        public int MinValue(BNode currenNode)
        {
            while(currenNode.Left != null)
            {
                currenNode = currenNode.Left;
            }

            return currenNode.Value;
        }

        public BNode DeleteNode(BNode currenNode, int Value)
        {
            if (currenNode == null)
                return null;

            if(Value < currenNode.Value)
            {
                currenNode.Left = DeleteNode(currenNode.Left, Value);
            }
            else if (Value > currenNode.Value)
            {
                currenNode.Right = DeleteNode(currenNode.Right, Value);
            }
            else
            {
                if(currenNode.Left == null && currenNode.Right == null)
                {
                    currenNode = null;
                }
                else if(currenNode.Left == null)
                {
                    currenNode = currenNode.Right;
                }
                else if (currenNode.Right == null)
                {
                    currenNode = currenNode.Left;
                }
                else
                {
                    int minValue = MinValue(currenNode.Right);
                    currenNode.Value = minValue;
                    currenNode.Right = DeleteNode(currenNode.Right, minValue);
                }
            }

            return currenNode;
        }
    }
}
