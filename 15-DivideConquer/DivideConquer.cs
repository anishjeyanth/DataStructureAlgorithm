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

        
        private int FindLCSLength(string s1, string s2, int i1, int i2)
        {
            if (i1 == s1.Length || i2 == s2.Length)
            {
                return 0;
            }
            int c1 = 0;
            if (s1[i1] == s2[i2])
            {
                c1 = 1 + FindLCSLength(s1, s2, i1 + 1, i2 + 1);
            }
            int c2 = FindLCSLength(s1, s2, i1, i2 + 1);
            int c3 = FindLCSLength(s1, s2, i1 + 1, i2);
            return Math.Max(c1, Math.Max(c2, c3));
        }

        public void LongestCommonSubsequence(string s1, string s2)
        {
            Console.WriteLine(FindLCSLength(s1, s2, 0, 0));
        }

        private int FindLPSLength(string st, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
            {
                return 0;
            }
            if (startIndex == endIndex)
            {
                return 1;
            }

            int count1 = 0;
            if (st[startIndex] == st[endIndex])
            {
                count1 = 2 + FindLPSLength(st, startIndex + 1, endIndex - 1);
            }
            int count2 = FindLPSLength(st, startIndex + 1, endIndex);
            int count3 = FindLPSLength(st, startIndex, endIndex - 1);

            return Math.Max(count1, Math.Max(count2, count3));
        }

        public void LongestPalindromicSubsequence(string st)
        {
            Console.WriteLine(FindLPSLength(st, 0, st.Length - 1));
        }

        public int MinCostToReachLastCell(int[,] array, int row, int col)
        {
            if (row == -1 || col == -1)
            {
                return int.MaxValue;
            }
            if (row == 0 && col == 0)
            {
                return array[0, 0];
            }

            int minCost1 = MinCostToReachLastCell(array, row, col - 1);
            int minCost2 = MinCostToReachLastCell(array, row - 1, col);
            int minCost = Math.Min(minCost1, minCost2);
            return minCost + array[row, col];
        }

        public int NumberOfPathsToReachLastCell(int[,] array, int row, int col, int cost)
        {
            if (cost < 0)
            {
                return 0;
            }

            if (row == 0 && col == 0)
            {
                return (array[0, 0] - cost == 0) ? 1 : 0;
            }

            if (row == 0)
            {
                return NumberOfPathsToReachLastCell(array, 0, col - 1, cost - array[row, col]);
            }

            if (col == 0)
            {
                return NumberOfPathsToReachLastCell(array, row - 1, 0, cost - array[row, col]);
            }

            int noOfPathsFromPreviousRow = NumberOfPathsToReachLastCell(array, row - 1, col, cost - array[row, col]);
            int noOfPathsFromPreviousCol = NumberOfPathsToReachLastCell(array, row, col - 1, cost - array[row, col]);

            return noOfPathsFromPreviousRow + noOfPathsFromPreviousCol;
        }

    }
}
