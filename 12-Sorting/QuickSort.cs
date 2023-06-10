using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting
{
    public class QuickSort
    {
        private static void Swap(int[] arr, int firstIndex, int secondIndex)
        {
            int temp = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = temp;
        }

        //{ 4, 2, 6, 5, 1, 3, 8, 2, 7 };
        private static int Pivot(int[] arr, int pivotIndex, int endIndex)
        {
            Console.WriteLine(pivotIndex + " " + endIndex);
            int swapIndex = pivotIndex;
            for(int i= pivotIndex + 1; i <= endIndex; i++)
            {
                if (arr[i] < arr[pivotIndex])
                {
                    swapIndex++;
                    Swap(arr, swapIndex, i);
                }
            }

            Swap(arr, pivotIndex, swapIndex);

            return swapIndex;
        }

        private static void SortHelper(int[] arr, int left, int right)
        {
            Console.WriteLine(left + " - " + right);
            if (left < right)
            {
                int pivotIndex = Pivot(arr, left, right);
                Console.WriteLine("Pivot-" + pivotIndex);
                SortHelper(arr, left, pivotIndex - 1);
                SortHelper(arr, pivotIndex + 1, right);
            }
        }

        public static void Sort(int[] arr)
        {
            SortHelper(arr, 0, arr.Length - 1);
            foreach(int value in arr)
            {
                Console.Write(value + " - ");
            }
        }
    }
}
