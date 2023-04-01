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
    }
}
