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

        public void Set(string key, int value)
        {
            int index = key.GetHashCode() % Size;
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
            int index = key.GetHashCode() % Size;
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
                Console.WriteLine(Array[i].Key + " - " + Array[i].Value);
            }
        }
    }
}
