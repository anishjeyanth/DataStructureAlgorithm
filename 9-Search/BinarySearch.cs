using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Search
{
    public class BinarySearch
    {
        public int SearchArray(int[] Array, int value) 
        {
            int left = 0;
            int right = Array.Length - 1;

            while(left <= right)
            {
                int mid = (left + right) / 2;
                if (Array[mid] == value)
                    return mid;
                else if (Array[mid] < value)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        public int SearchString(string text, string word)
        {
            int count = 0;
            for(int i=0;i < text.Length; i++)
            {
                for(int j=0;j < word.Length; j++)
                {
                    if (word[j] != text[i + j])
                        break;

                    if (j == word.Length - 1)
                        count++;
                }
            }

            return count;
        }
    }
}
