using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.StackQueue
{
    public class StackLinkedList
    {
        Node Top;
        int Size;
        public StackLinkedList(int data)
        {
            Node node = new Node(data);
            Top = node;
            Size = 1;
        }        

        public void Push(int data)
        {
            Node node = new Node(data);
            if(Size == 0)
            {
                Top = node;
            }
            else
            {
                node.Next = Top;
                Top = node;
            }

            Size++;
        }

        public int Pop()
        {
            if (Size == 0)
                return -1;

            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            Size--;
            return temp.Value;
        }

        public int Peek()
        {
            if (Top == null)
                return 0;

            return Top.Value;
        }

        public void List()
        {
            Node temp = Top;
            while(temp != null)
            {
                Console.Write(temp.Value + "->");
                temp = temp.Next;
            }
            Console.WriteLine("");
        }
    }
}
