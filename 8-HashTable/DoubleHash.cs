using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HashTable
{
    public class DoubleHash
    {
        HashArray[] Array;
        int Size = 0;
        public DoubleHash(int size)
        {
            Size = size;
            Array = new HashArray[size];
        }

        public void Set(string key, int value)
        {
            int index = key.GetHashCode() % Size;
            int offset = 1;
            while (Array[index] != null && !Array[index].Key.Equals(key))
            {
                index = (index + offset * (key.GetHashCode() % (Size- 2) + 1)) % Size;
                offset++;
            }

            Array[index] = new HashArray(key, value);
        }

        public int Get(string key)
        {
            int index = key.GetHashCode() % Size;
            int offset = 1;
            while (Array[index] != null && !Array[index].Key.Equals(key))
            {
                index = (index + offset * (key.GetHashCode() % (Size - 2) + 1)) % Size;
                offset++;

                if(offset > Size)
                {
                    Console.WriteLine("Key not found");
                    break;
                }
            }

            if (Array[index] == null)
                return -1;

            return Array[index].Value;
        }

        public void List()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine(Array[i].Key + " - " + Array[i].Value);
            }
        }
    }
}
