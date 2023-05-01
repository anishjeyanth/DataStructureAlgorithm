using DSA.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HashTable
{
    public class ChainingHash
    {
        public int Size = 20;
        HNode[] ListMap;
        
        public ChainingHash()
        {
            ListMap = new HNode[Size];
        }

        private int Hash(string key)
        {
            int hash = 0;
            char[] chars = key.ToCharArray();
            for (int i=0; i < chars.Length; i++)
            {
                int ascii = chars[i];
                hash = (hash + ascii * 23) % ListMap.Length;
            }

            return hash;
        }

        public void Set(string key, int value)
        {
            int index = Hash(key);
            HNode node = new HNode(key, value);
            if (ListMap[index] == null)
            {
                ListMap[index] = node;
            }
            else
            {
                HNode temp = ListMap[index];
                if(temp.Key == key)
                {
                    temp.Value += value;
                    return;
                }

                while (temp.Next != null)
                {
                    temp = temp.Next;
                    if(temp.Key == key)
                    {
                        temp.Value += value;
                        return;
                    }
                }

                temp.Next = node;
            }
        }

        public int Get(string key)
        {
            int index = Hash(key);
            HNode temp = ListMap[index];
            while(temp.Next != null)
            {
                if (temp.Key == key)
                    return temp.Value;

                temp = temp.Next;
            }

            return 0;
        }

        public List<int> AllValues()
        {
            List<int> keys = new List<int>();
            for(int i =0;i < ListMap.Length; i++)
            {
                HNode temp = ListMap[i];
                while(temp != null)
                {
                    keys.Add(temp.Value);
                    temp = temp.Next;
                }
            }

            return keys;
        }
    }
}
