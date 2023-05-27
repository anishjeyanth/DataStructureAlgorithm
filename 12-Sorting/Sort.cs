using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting
{
    public class Sort
    {
        public void Bubble(int[] Array)
        {
            for (int i = Array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        int temp = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = temp;
                    }
                }
            }

            foreach (int a in Array)
                Console.Write(a + "-");

            Console.WriteLine();
        }

        public void Selection(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[j] < Array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (i != minIndex)
                {
                    int temp = Array[i];
                    Array[i] = Array[minIndex];
                    Array[minIndex] = temp;
                }
            }

            foreach (int a in Array)
                Console.Write(a + "-");

            Console.WriteLine();
        }


        public void Insertion(int[] Array)
        {
            for(int i = 1; i < Array.Length; i++)
            {
                int temp = Array[i];
                int j = i - 1;

                while (j > -1 && temp < Array[j])
                {
                    Array[j + 1] = Array[j];
                    Array[j] = temp;
                    j--;
                }
            }


            foreach (int a in Array)
                Console.Write(a + "-");

            Console.WriteLine();
        }
    }
}
