using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HashTable
{
    public class LinearHash
    {
        HashArray[] Array;
        int Size = 0;
        public LinearHash(int size)
        {
            Size = size;
            Array = new HashArray[size];
        }

        private int Hash(string key)
        {
            int hash = 0;
            char[] chars = key.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                int ascii = chars[i];
                hash = (hash + ascii * 23) % Array.Length;
            }

            return hash;
        }

        public void Set(string key, int value)
        {
            int index = Hash(key);
            while (Array[index] != null && !Array[index].Key.Equals(key))
            {
                index = (index + 1) % Size;
            }

            Array[index] = new HashArray(key, value);
        }

        public int Get(string key)
        {
            int index = Hash(key);
            while (Array[index] != null && !Array[index].Key.Equals(key))
            {
                index = (index + 1) % Size;
            }

            if (Array[index] == null)
                return - 1;

            return Array[index].Value;
        }

        public void List()
        {
            for(int i=0; i < Size; i++)
            {
                Console.WriteLine(Array[i]?.Key + " - " + Array[i]?.Value);
            }
        }
    }
}
