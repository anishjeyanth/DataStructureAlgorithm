using DSA.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting
{
    public class Sort
    {
        public void Bubble(int[] Arr)
        {
            for (int i = Arr.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        int temp = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = temp;
                    }
                }
            }

            foreach (int a in Arr)
                Console.Write(a + "-");

            Console.WriteLine();
        }

        public void Selection(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[j] < Arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (i != minIndex)
                {
                    int temp = Arr[i];
                    Arr[i] = Arr[minIndex];
                    Arr[minIndex] = temp;
                }
            }

            foreach (int a in Arr)
                Console.Write(a + "-");

            Console.WriteLine();
        }


        public void Insertion(int[] Arr)
        {
            for(int i = 1; i < Arr.Length; i++)
            {
                int temp = Arr[i];
                int j = i - 1;

                while (j > -1 && temp < Arr[j])
                {
                    Arr[j + 1] = Arr[j];
                    Arr[j] = temp;
                    j--;
                }
            }


            foreach (int a in Arr)
                Console.Write(a + "-");

            Console.WriteLine();
        }

        public void Bucket(int[] Arr, int BucketSize)
        {
            int N = Arr.Length;
            int minValue = Arr[0];
            int maxValue = Arr[0];

            // find minimum and maximum value in array
            for(int i = 1; i < N; i++)
            {
                if (Arr[i] < minValue)
                    minValue = Arr[i];
                else if (Arr[i]> maxValue) 
                    maxValue = Arr[i];
            }

            int bucketCount = (maxValue - minValue) / BucketSize + 1;
            List<int>[] buckets = new List<int>[bucketCount];

            for(int i=0; i < bucketCount; i++)
                buckets[i] = new List<int>();

            // Distribute each elements into the buckets
            for(int i = 0; i < N; i++)
            {
                int bucketIndex = (Arr[i] - minValue) / BucketSize;
                buckets[bucketIndex].Add(Arr[i]) ;
            }

            int currentIndex = 0;
            for(int i=0; i < bucketCount ; i++)
            {
                int[] bucketArray = buckets[i].ToArray();
                System.Array.Sort(bucketArray);

                for(int j =0; j < bucketArray.Length; j++)
                {
                    Arr[currentIndex] = bucketArray[j];
                    currentIndex++;
                }
            }


            foreach (int a in Arr)
                Console.Write(a + "-");

            Console.WriteLine();
        }
    }
}
