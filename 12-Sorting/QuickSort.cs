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

        private static int Pivot(int[] arr, int pivotIndex, int endIndex)
        {
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
            if (left < right)
            {
                int pivotIndex = Pivot(arr, left, right);
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
