using System;
using System.Collections.Generic;
namespace leetcode
{
    internal class TwoSum
    {

        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

                for (int i = 0; i < nums.Length; i++)
                {
                    if (dict.ContainsKey(nums[i]))
                    {
                        dict[nums[i]].Add(i);
                    }
                    else
                    {
                        dict[nums[i]] = new List<int>() { i };
                    }
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    int x = target - nums[i];
                    if (dict.ContainsKey(x))
                    {
                        List<int> xIndices = dict[x];
                        foreach (int index in xIndices)
                        {
                            if (index != i)
                            {
                                return new int[] { i, index };
                            }
                        }
                    }
                }

                return new int[0];
            }
        }

        static void Main(string[] args)
        {

            Solution solution = new Solution();
            int[] arr = solution.TwoSum(new int[] { 3, 2, 4 }, 6);
            Console.WriteLine("Indexes:");
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }

        }
    }
}