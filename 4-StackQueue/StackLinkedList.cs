using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.StackQueue
{
    public class StackLinkedList
    {
        int[] Array;
        int Top;
        int MaxSize;
        public StackLinkedList(int size)
        {
            Array = new int[size];
            Top = -1;
            MaxSize = size;
        }

        public bool IsEmpty()
        {
            return Top <= -1;
        }

        public bool IsFull()
        {
            return Top == MaxSize - 1;
        }

        public void Push(int data)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is Full");
            }
            else
            {
                Top++;
                Array[Top] = data;
            }
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                return -1;
            }
            else
            {
                int item = Array[Top];
                Top--;
                return item;
            }
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                return -1;
            }
            else
            {
                return Array[Top];
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Empty");
            }
            else
            {
                for (int i = Top; i >= 0; i--)
                {
                    Console.WriteLine(Array[i]);
                }
            }
        }
    }
}
