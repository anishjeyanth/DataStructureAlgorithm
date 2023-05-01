using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HashTable
{
    public class QuadraticHash
    {
        HashArray[] Array;
        int Size = 0;
        int[] Proble;
        public QuadraticHash(int size)
        {
            Size = size;
            Array = new HashArray[size];
            Proble = new int[size];
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
            int i = 1;

            while (Array[index] != null && !Array[index].Key.Equals(key))
            {
                index = (index + i * 1) % Size;
                i++;

                if(i > Size)
                {
                    Console.WriteLine("HashTable full");
                    break;
                }
            }

            Proble[index] = i;
            Array[index] = new HashArray(key, value);
        }

        public int Get(string key)
        {
            int index = Hash(key);
            int i = 1;

            while (Array[index] != null && !Array[index].Key.Equals(key))
            {
                index = (index + i * 1) % Size;
                i++;

                if (i > Proble[index])
                {
                    Console.WriteLine("Key not Found");
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
                HashArray hashArray = Array[i];
                Console.WriteLine(hashArray?.Key + " - " + hashArray?.Value);
            }
        }
    }
}
