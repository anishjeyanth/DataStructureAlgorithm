using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class DoublyLinkedList
    {
        DNode Head;
        DNode Tail;
        int Size;

        public DoublyLinkedList(int data)
        {
            DNode node = new DNode(data);
            Head = node;
            Tail = node;
            Size = 1;
        }

        public void AppendNode(int data)
        {
            DNode node = new DNode(data);
            if (Size == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                node.Prev = Tail;
                Tail = node;
            }

            Size++;
        }

        public void PrependNode(int data)
        {
            DNode node = new DNode(data);
            if (Size == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head.Prev = node;
                Head = node;
            }

            Size++;
        }

        public void RemoveFirst()
        {
            DNode temp = Head;
            if (Size == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
                temp.Next = null;
            }

            Size--;
        }

        public void RemoveLast()
        {
            DNode temp = Tail;
            if (Size == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail = Tail.Prev;
                Tail.Next = null;
                temp.Prev = null;
            }

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

            DNode node = new DNode(data);
            DNode before = GetNode(index - 1);
            DNode after = before.Next;
            node.Prev = before;
            node.Next = after;
            before.Next = node;
            after.Prev = node;
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

            DNode temp = GetNode(index);
            temp.Next.Prev = temp.Prev;
            temp.Prev.Next = temp.Next;
            temp.Prev = null;
            temp.Next = null;
            Size--;
        }

        public DNode GetNode(int index)
        {
            if (index < 0 || index >= Size)
                return null;

            DNode temp = Head;
            if (index < Size / 2)
            {
                for (int i = 0; i < index; i++)
                {
                    temp = temp.Next;
                }
            }
            else
            {
                temp = Tail;
                for (int i = Size - 1; i > index; i--)
                {
                    temp = temp.Prev;
                }
            }

            return temp;
        }

        public void SetNode(int index, int data)
        {
            DNode temp = GetNode(index);
            if (temp != null)
            {
                temp.Value = data;
            }
        }

        public void ListNode()
        {
            DNode temp = Head;
            while (temp != null)
            {
                Console.Write(temp.Value + "->");
                temp = temp.Next;
            }

            Console.WriteLine();
        }

        public void Reverse()
        {
            DNode temp = Tail;
            while (temp != null)
            {
                Console.Write(temp.Value + "->");
                temp = temp.Prev;
            }

            Console.WriteLine();
        }
    }
}
