using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class CircularDoublyLinkedList
    {
        public DNode Head { get; set; }
        public DNode Tail { get; set; }
        int Size;

        public CircularDoublyLinkedList(int data)
        {
            DNode node = new DNode(data);
            Head = node;
            Tail = node;            
            Head.Prev = Tail;
            Tail.Next = Head;
            Size = 1;
        }

        public void AppendNode(int data)
        {
            DNode node = new DNode(data);
            if (Size == 0)
            {
                Head = node;
                Tail = node;                
                Head.Prev = Tail;
                Tail.Next = Head;
            }
            else
            {
                node.Prev = Tail;
                node.Next = Head;
                Tail.Next = node;
                Head.Prev = node;
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
                Head.Prev = Tail;
                Tail.Next = Head;
            }
            else
            {
                node.Next = Head;
                node.Prev = Tail;
                Head.Prev = node;
                Tail.Next = node;
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
                Head.Prev = Tail;
                Tail.Next = Head;
                temp.Prev = null;
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
                Tail.Next = Head;
                Head.Prev = Tail;
                temp.Prev = null;
                temp.Next = null;
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
            do
            {
                Console.Write(temp.Value + "->");
                temp = temp.Next;
            } while (temp != Head);

            Console.Write(" # ");

            DNode temp1 = Tail;
            do
            {
                Console.Write(temp1.Value + "<-");
                temp1 = temp1.Prev;
            } while (temp1 != Tail);

            Console.WriteLine();
        }

        public void Reverse()
        {
            DNode temp = Head;
            Head = Tail;
            Tail = temp;
            DNode after = null;
            DNode before = Head;

            for (int i = 0; i < Size; i++)
            {
                after = temp.Next;
                temp.Next = before;
                temp.Prev = after;
                before = temp;
                temp = after;
            }
        }
    }
}
