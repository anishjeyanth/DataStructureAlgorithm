using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.BinaryHeap
{
    public class BinaryHeap
    {
        int[] Array;
        int SizeOfTree;

        public BinaryHeap(int Size)
        {
            Array = new int[Size+1];
            SizeOfTree = 0;
        }

        public void Push(int data)
        {
            Array[SizeOfTree+1] = data;
            SizeOfTree++;
            MinHeapify(SizeOfTree);
        }

        public int Pop()
        {
            if (SizeOfTree == 0)
                return -1;
            else
            {
                int value = Array[1];
                Array[1] = Array[SizeOfTree];
                MinHeapifyTopToBottom(1);
                return value;
            }

        }

        private void MaxHeapifyTopToBottom(int index)
        {
            int left = index * 2;
            int right = index * 2 + 1;
            int swap = 0;
            if (SizeOfTree < left)
                return;

            if(SizeOfTree == left)
            {
                if (Array[index] < Array[left])
                {
                    int tmp = Array[index];
                    Array[index] = Array[left];
                    Array[left] = tmp;
                }
                return;
            }
            else
            {
                if (Array[left] > Array[right]) 
                    swap = left;
                else
                    swap = right;

                if (Array[index] < Array[swap])
                {
                    int tmp = Array[index];
                    Array[index] = Array[swap];
                    Array[swap] = tmp;
                }
            }

            MaxHeapifyTopToBottom(swap);
        }

        private void MinHeapifyTopToBottom(int index)
        {
            int left = index * 2;
            int right = index * 2 + 1;
            int swap = 0;
            if (SizeOfTree < left)
                return;

            if (SizeOfTree == left)
            {
                if (Array[index] > Array[left])
                {
                    int tmp = Array[index];
                    Array[index] = Array[left];
                    Array[left] = tmp;
                }
                return;
            }
            else
            {
                if (Array[left] < Array[right])
                    swap = left;
                else
                    swap = right;

                if (Array[index] > Array[swap])
                {
                    int tmp = Array[index];
                    Array[index] = Array[swap];
                    Array[swap] = tmp;
                }
            }

            MinHeapifyTopToBottom(swap);
        }

        private void MinHeapify(int index)
        {
            int parent = index / 2;
            if (index <= 1)
                return;

            if (Array[index] < Array[parent])
            {
                int temp = Array[index];
                Array[index] = Array[parent];
                Array[parent] = temp;
            }

            MinHeapify(parent);
        }

        private void MaxHeapify(int index)
        {
            int parent = index / 2;
            if (index <= 1)
                return;

            if (Array[index] > Array[parent])
            {
                int temp = Array[index];
                Array[index] = Array[parent];
                Array[parent] = temp;
            }

            MaxHeapify(parent);
        }

        public void Traverse()
        {
            for(int i = 1; i <= SizeOfTree; i++)
            {
                Console.Write(Array[i]+ " - ");
            }

            Console.WriteLine();
        }
    }
}
