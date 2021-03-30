using Xunit;

namespace LeetCode.TwoSum_1
{
    public class Tests
    {
        [Theory]
        [InlineData(new[] {2,7,11,15}, 9, new[] { 0 , 1})]
        [InlineData(new[] {3,2,4}, 6, new[] { 1 , 2})]
        [InlineData(new[] {1,3,3}, 6, new[] { 1 , 2})]

        public void Test(int[] nums, int target, int[] expected)
        {
            var solution = new Solution();
            Assert.Equal(expected, solution.TwoSum(nums, target));
        }
        
    }
}