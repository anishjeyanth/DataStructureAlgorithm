using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Dynamic
{
    public class HouseRobber
    {
        public int MaxMoneyTopDown(int[] houseNetWorth)
        {
            int[] dp = new int[houseNetWorth.Length];
            return MaxMoneyTopDown(dp, houseNetWorth, 0);
        }

        //{ 6, 7, 1, 30, 8, 2, 4 }

        private int MaxMoneyTopDown(int[] dp, int[] houseNetWorth, int currentIndex)
        {
            if (currentIndex >= houseNetWorth.Length)
                return 0;

            if (dp[currentIndex] == 0)
            {
                int max = MaxMoneyTopDown(dp, houseNetWorth, currentIndex + 2);
                int stealCurrent = houseNetWorth[currentIndex] + max;
                int skipCurrent = MaxMoneyTopDown(dp, houseNetWorth, currentIndex + 1);
                dp[currentIndex] = Math.Max(stealCurrent, skipCurrent);
            }
            return dp[currentIndex];
        }

        public int MaxMoneyBottomUp(int[] wealth)
        {
            int[] dp = new int[wealth.Length + 2]; // '+1' to handle the zero house
            dp[wealth.Length] = 0; // if there are no houses, the thief can't steal anything
            for (int i = wealth.Length - 1; i >= 0; i--)
            {
                dp[i] = Math.Max(wealth[i] + dp[i + 2], dp[i + 1]);
            }

            return dp[0];
        }
    }
}
