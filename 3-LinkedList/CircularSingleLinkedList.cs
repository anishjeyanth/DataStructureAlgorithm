using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class CircularSingleLinkedList
    {
        public Node Head;
        public Node Tail;
        public int Size;

        public CircularSingleLinkedList(int data)
        {
            Node node = new Node(data);
            Head = node;
            Tail = node;
            Tail.Next = Head;
            Size = 1;
        }

        public void AppendNode(int data)
        {
            Node node = new Node(data);

            if (Size == 0)
            {
                Head = node;
                Tail = node;
                Tail.Next = Head;
            }
            else
            {
                node.Next = Head;
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
                Tail.Next = Head;
            }
            else
            {
                node.Next = Head;
                Tail.Next = node;
                Head = node;                
            }
            Size++;
        }


        public void RemoveFirst()
        {
            if (Size == 0)
                return;

            Node tempNode = Head;
            Head = Head.Next;
            Tail.Next = Head;
            tempNode.Next = null;
            Size--;
        }

        public void RemoveLast()
        {
            if (Size == 0)
                return;

            Node previousNode = GetNode(Size - 2);
            previousNode.Next = Head;
            Tail = previousNode;
            Size--;
        }

        public void InsertNode(int index, int data)
        {
            if (index < 0 || index > Size)
                return;

            if (index == 0)
            {
                PrependNode(data);
                return;
            }

            if (index == Size)
            {
                AppendNode(data);
                return;
            }

            Node node = new Node(data);
            Node tempNode = GetNode(index - 1);
            node.Next = tempNode.Next;
            tempNode.Next = node;
            Size++;
        }

        public void RemoveNode(int index)
        {
            if (index < 0 || index >= Size)
                return;

            if (index == 0)
            {
                RemoveFirst();
                return;
            }

            if (index == Size - 1)
            {
                RemoveLast();
                return;
            }

            Node previousNode = GetNode(index - 1);
            Node tempNode = previousNode.Next;
            previousNode.Next = tempNode.Next;
            tempNode.Next = null;
            Size--;
        }

        public Node GetNode(int index)
        {
            if (index < 0 || index >= Size)
                return null;

            Node tempNode = Head;
            for (int i = 0; i < index; i++)
            {
                tempNode = tempNode.Next;
            }

            return tempNode;
        }

        public void SetNode(int index, int data)
        {
            Node tempNode = GetNode(index);
            if (tempNode != null)
            {
                tempNode.Value = data;
            }
        }

        public void Reverse()
        {
            Node temp = Head;
            Head = Tail;
            Tail = temp;
            Node after = null;
            Node before = Head;

            for (int i = 0; i < Size; i++)
            {
                after = temp.Next;
                temp.Next = before;
                before = temp;
                temp = after;
            }
        }

        public void ListNode()
        {
            Node tempNode = Head;
            do
            {
                Console.Write(tempNode.Value + "->");
                tempNode = tempNode.Next;
            } while (tempNode != Head);

            Console.WriteLine("");
        }
    }
}
