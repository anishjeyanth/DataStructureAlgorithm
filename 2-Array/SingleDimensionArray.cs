using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    public class SingleDimensionArray
    {
        int[] array = null;
        public SingleDimensionArray(int size) 
        {
            array = new int[size];
        }

        public void Insert(int index, int value)
        {
            ValidateArray(index);
            array[index] = value;
        }

        public void Delete(int index)
        {
            ValidateArray(index);
            array[index] = 0;
        }

        public void Find(int value)
        {
            foreach (int i in array)
            {
                if (i == value)
                {
                    Console.WriteLine("Item Found");
                }
            }
        }

        public void Display()
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

        private void ValidateArray(int index)
        {
            if (index >= array.Length)
                throw new Exception("out of index");
        }
    }
}
