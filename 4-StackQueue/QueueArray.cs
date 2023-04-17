using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.StackQueue
{
    public class QueueArray
    {
        int[] Array;
        int Capacity;
        int Size;
        int Front;
        int Rear;

        public QueueArray(int capacity)
        {
            Array =  new int[capacity];
            Capacity = capacity;
            Size = 0;
            Front = 0;
            Rear = -1;
        }

        public bool IsFull()
        {
            return Size == Capacity;
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }

        public void List()
        {
            while (!IsEmpty())
            {
                Console.WriteLine(Dequeue());
            }
        }

        public void Enqueue(int data)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue Full");
            }
            else
            {
                Rear = (Rear + 1) % Capacity;
                Array[Rear] = data;
                Size++;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                return -1;
            }
            else
            {
                int removedItem = Array[Front];
                Front = (Front + 1) % Capacity;
                Size--;
                return removedItem;
            }
        }
    }
}
