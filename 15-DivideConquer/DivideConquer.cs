using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.DivideConquer
{
    public class DivideConquer
    {

        private int MaxMoneyR(int[] houseNetWorth, int currentIndex)
        {
            if(currentIndex >= houseNetWorth.Length)
                return 0;

            int stealCurrentHouse = houseNetWorth[currentIndex] + MaxMoneyR(houseNetWorth, currentIndex+2);
            int skipCurrentHouse = MaxMoneyR(houseNetWorth, currentIndex + 1);

            return Math.Max(stealCurrentHouse, skipCurrentHouse);
        }

        public void HouseRobber(int[] houseNetWorth)
        {
            Console.WriteLine(MaxMoneyR(houseNetWorth, 0));
        }

        private int FindMinOperations(string s1, string s2, int i1, int i2)
        {
            if (i1 == s1.Length)
            {
                return s2.Length - i2;
            }
            if (i2 == s2.Length)
            {
                return s1.Length - i1;
            }

            if (s1[i1] == s2[i2])
            {
                return FindMinOperations(s1, s2, i1 + 1, i2 + 1);
            }

            int deleteOp = 1 + FindMinOperations(s1, s2, i1 + 1, i2);
            int insertOp = 1 + FindMinOperations(s1, s2, i1, i2 + 1);
            int replaceOp = 1 + FindMinOperations(s1, s2, i1 + 1, i2 + 1);
            return Math.Min(deleteOp, Math.Min(insertOp, replaceOp));
        }

        public void ConvertOneStringToAnother(string s1, string s2)
        {
            Console.WriteLine(FindMinOperations(s1, s2, 0, 0));
        }

        private int KnapSack(int[] profits, int[] weights, int capacity, int currentIndex)
        {
            if (capacity <= 0 || currentIndex < 0 || currentIndex >= profits.Length)
            {
                return 0;
            }

            int profit1 = 0;

            if (weights[currentIndex] <= capacity)
            {
                profit1 = profits[currentIndex] + KnapSack(profits, weights, capacity - weights[currentIndex], currentIndex + 1);
            }

            int profit2 = KnapSack(profits, weights, capacity, currentIndex + 1);

            return Math.Max(profit1, profit2);
        }

        public void ZeroOneKnapsack(int[] profits, int[] weights, int capacity)
        {
            Console.WriteLine(KnapSack(profits, weights, capacity, 0));
        }
    }
}
