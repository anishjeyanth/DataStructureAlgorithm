using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting
{
    public class RadixSort
    {
        private static int GetDigit(int num, int i)
        {
            return (int)(Math.Abs(num) / Math.Pow(10, i)) % 10;
        }

        private static int DigitCount(int num)
        {
            if (num == 0)
                return 1;

            return (int)(Math.Floor(Math.Log10(Math.Abs(num))) + 1);
        }

        private static int MostDigits(int[] num)
        {
            int maxDigits = 0;
            for(int i=0; i < num.Length; i++)
            {
                maxDigits = Math.Max(maxDigits, DigitCount(num[i]));
            }

            return maxDigits;
        }

        public static int[] Sort(int[] num)
        {
            int maxDigitCount = MostDigits(num);
            for(int k=0; k<maxDigitCount; k++)
            {
                List<int>[] digitBucket =  new List<int>[10];
                for(int i = 0; i < 10; i++)
                {
                    digitBucket[i] = new List<int>();
                }

                for(int i=0;i< num.Length; i++)
                {
                    int digit = GetDigit(num[i], k);
                    digitBucket[digit].Add(num[i]);
                }

                List<int> sortedNum = new List<int>();
                for (int i = 0; i < 10; i++)
                {
                    sortedNum.AddRange(digitBucket[i]);
                }

                num = sortedNum.ToArray();
            }

            return num;
        }
    }
}
