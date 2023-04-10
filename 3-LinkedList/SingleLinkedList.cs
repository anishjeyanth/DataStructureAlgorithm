using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class SingleLinkedList
    {
        public Node Head;
        public Node Tail;
        public int Size;

        public SingleLinkedList(int data)
        {
            Node node = new Node(data);
            Head = node;
            Tail = node;
            Size = 1;
        }

        public void AppendNode(int data)
        {
            Node node = new Node(data);

            if(Size == 0)
            {
                Head= node;
                Tail= node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
           
            Size++;
        }

        public void PrependNode(int data)
        {
            Node node = new Node(data);
            if (Size == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
            Size++;
        }


        public void RemoveFirst()
        {
            Node tempNode = Head;
            Head = Head.Next;
            tempNode.Next = null;
            Size--;

            if (Size == 0)
                Tail = null;
        }

        public void RemoveLast()
        {
            Node tempNode = Head;
            Node previousNode = Head;
            while(tempNode != null)
            {
                previousNode = tempNode;
                tempNode = tempNode.Next;
            }

            Tail = previousNode;
            Tail.Next = null;
            Size--;

            if (Size == 0)
            {
                Head = null;
                Tail = null;
            }
        }

        public Node GetNode(int index)
        {
            Node tempNode = Head;
            for(int i=0; i < index; i++)
            {
                tempNode = tempNode.Next;
            }

            return tempNode;
        }

        public void SetNode(int index,int data)
        {
            Node tempNode = GetNode(index);
            if (tempNode != null)
            {
                tempNode.Value = data;
            }
        }

        public void ListNode()
        {
            Node tempNode = Head;
            while(tempNode != null)
            {
                Console.WriteLine(tempNode.Value);
                tempNode = tempNode.Next;
            }
        }
    }
}

