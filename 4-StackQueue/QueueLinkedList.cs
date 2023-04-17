using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.StackQueue
{
    public class QueueLinkedList
    {
        Node First;
        Node Last;
        int Size = 0;

        public QueueLinkedList(int data)
        {
            Node node = new Node(data);
            First = node;
            Last = node;
            Size = 1;
        }

        public void List()
        {
            Node temp = First;
            while(temp != null)
            {
                Console.Write(temp.Value + "->");
                temp = temp.Next;
            }

            Console.WriteLine();
        }

        public int FirstNode()
        {
            if (First == null)
                return -1;

            return First.Value;
        }

        public int LastNode()
        {
            if (Last == null)
                return -1;

            return Last.Value;
        }

        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (Size == 0)
            {
                First = node;
                Last = node;
            }
            else
            {
                Last.Next = node;
                Last = node;
            }

            Size++;
        }

        public int Dequeue()
        {
            Node temp = First;
            if (Size == 1)
            {
                First = null;
                Last = null;
            }
            else
            {
                First = First.Next;
                temp.Next = null;  
            }

            Size--;
            return temp.Value;
        }
    }
}
