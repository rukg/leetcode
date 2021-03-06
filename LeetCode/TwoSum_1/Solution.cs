using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.TwoSum_1
{
    public class Solution
    {
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can return the answer in any order.
        /// Example 1:
        /// Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        /// Output: Because nums[0] + nums[1] == 9, we return [0, 1].
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {

            var dict = new Dictionary<int, int>();
            
            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = i;
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }

            for (var i = 0; i < nums.Length; i++)
            {
                var remainder = target - nums[i];

                if (dict.ContainsKey(remainder) && dict[remainder] != i)
                {
                    return new[] {i, dict[remainder]};
                }
            }

            return null;
        }
    }
}