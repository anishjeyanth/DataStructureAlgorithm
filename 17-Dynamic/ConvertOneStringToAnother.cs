using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Dynamic
{
    public class ConvertOneStringToAnother
    {
        public int FindMinOperationsTopDown(string s1, string s2)
        {
            int?[,] dp = new int?[s1.Length + 1, s2.Length + 1];
            return FindMinOperationsTopDown(dp, s1, s2, 0, 0);
        }

        private int FindMinOperationsTopDown(int?[,] dp, string s1, string s2, int i1, int i2)
        {
            if (dp[i1, i2] == null)
            {
                if (i1 == s1.Length) // if we have reached the end of s1, then insert all the remaining characters of s2
                {
                    dp[i1, i2] = s2.Length - i2;
                }
                else if (i2 == s2.Length) // if we have reached the end of s2, then delete all the remaining characters of s1
                {
                    dp[i1, i2] = s1.Length - i1;
                }
                else if (s1[i1] == s2[i2]) // If the strings have a matching character, recursively match for the remaining lengths.
                {
                    dp[i1, i2] = FindMinOperationsTopDown(dp, s1, s2, i1 + 1, i2 + 1);
                }
                else
                {
                    int c1 = FindMinOperationsTopDown(dp, s1, s2, i1 + 1, i2); // delete
                    int c2 = FindMinOperationsTopDown(dp, s1, s2, i1, i2 + 1); // insert
                    int c3 = FindMinOperationsTopDown(dp, s1, s2, i1 + 1, i2 + 1); // replace
                    dp[i1, i2] = 1 + Math.Min(c1, Math.Min(c2, c3));
                }
            }

            return dp[i1, i2].Value;
        }

        public int FindMinOperationsBottomUp(string s1, string s2)
        {
            int[,] dp = new int[s1.Length + 1, s2.Length + 1];

            for (int i1 = 0; i1 <= s1.Length; i1++) // if we have reached the end of s1, then insert all the remaining characters of s2
            {
                dp[i1, 0] = i1;
            }

            for (int i2 = 0; i2 <= s2.Length; i2++) // if we have reached the end of s2, then delete all the remaining characters of s1
            {
                dp[0, i2] = i2;
            }

            for (int i1 = 1; i1 <= s1.Length; i1++)
            {
                for (int i2 = 1; i2 <= s2.Length; i2++) // If the strings have a matching character, recursively match for the remaining lengths.
                {
                    if (s1[i1 - 1] == s2[i2 - 1])
                    {
                        dp[i1, i2] = dp[i1 - 1, i2 - 1];
                    }
                    else
                    {
                        dp[i1, i2] = 1 + Math.Min(dp[i1 - 1, i2], // delete
                                            Math.Min(dp[i1, i2 - 1], // insert
                                                      dp[i1 - 1, i2 - 1])); // replace
                    }
                }
            }

            return dp[s1.Length, s2.Length];
        }
    }

}
