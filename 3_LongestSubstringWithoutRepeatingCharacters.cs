using System;
using System.Collections.Generic;
namespace leetcode
{
    internal class LongestSubstringWithoutRepeatingCharacters
    {

        public class Solution
        {

            public int LengthOfLongestSubstring(string s)
            {
                char[] chars = s.ToCharArray();
                List<char> temp = new List<char>();
                int answ = 0;
                foreach (char c in chars)
                {
                    if (temp.Contains(c))
                    {
                        temp.RemoveRange(0, temp.IndexOf(c) + 1);
                    }
                    temp.Add(c);
                    answ = (answ < temp.Count) ? temp.Count : answ;
                }

                return answ;
            }
        }

        static void Main(string[] args)
        {

            Solution solution = new Solution();
            Console.WriteLine(solution.LengthOfLongestSubstring("aabaab!bb"));

        }
    }
}