using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    internal class Array
    {
        public static void ArrayReverse(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int index = array.Length - i - 1;
                int temp = array[i];
                array[i] = array[index];
                array[index] = temp;
            }

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

        public static void FindMissingNo(int[] array)
        {
            int arraySum = 0;
            int totalSum = 0;
            foreach (int i in array) 
            {
                arraySum += i;
                //arraySum = arraySum + i;
            }
            totalSum = 15 * (15 + 1) / 2;
            Console.WriteLine(totalSum - arraySum);
        }

        public static void TwoSum(int[] array, int target)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int j=i+1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == target)
                        Console.WriteLine(i + "," + j);
                }
            }
        }

        public static void MaxProduct(int[] array)
        {
            int product = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] * array[j] > product)
                    {
                        product = array[i] * array[j];
                        Console.WriteLine(i + "=" + array[i] + "|" + j + "=" + array[j] );
                        Console.WriteLine(product);
                    }                        
                }
            }
        }

        public static void Duplicate(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {                        
                        Console.WriteLine(false);
                    }
                }
            }
        }

        public static bool Permutation(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
                return false;

            int sum1 = 0;
            int sum2 = 0;
            int mul1 = 1;
            int mul2 = 1;
            for (int i=0;i< array1.Length; i++)
            {
                sum1 += array1[i];
                sum2 += array2[i];
                mul1 *= array1[i];
                mul2 *= array2[i];
            }

            if(sum1 == sum2 && mul1 == mul2)
                return true;

            return false;
        }


        public static void  RotateMatrix(int[,] matrix)
        {
            int N = matrix.GetLength(0);
            for (int x = 0; x < N / 2; x++)
            {
                // Consider elements
                // in group of 4 in
                // current square
                for (int y = x; y < N - x - 1; y++)
                {
                    // store current cell
                    // in temp variable
                    int temp = matrix[x, y];

                    // right to top
                    matrix[x, y] = matrix[y, N - 1 - x];

                    // bottom to right
                    matrix[y, N - 1 - x] = matrix[N - 1 - x, N - 1 - y];

                    // left to bottom
                    matrix[N - 1 - x, N - 1 - y]  = matrix[N - 1 - y, x];

                    // assign temp to left
                    matrix[N - 1 - y, x] = temp;
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(" " + matrix[i, j]);
                Console.WriteLine();
            }
        }
    }
}
