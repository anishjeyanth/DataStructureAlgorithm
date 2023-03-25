using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA._2_Array
{
    internal class Array
    {
        public static void ArrayReverse(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int other = array.Length - i - 1;
                int temp = array[i];
                array[i] = array[other];
                array[other] = temp;
            }

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
