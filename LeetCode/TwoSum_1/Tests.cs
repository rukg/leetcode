using Xunit;

namespace LeetCode.TwoSum_1
{
    public class Tests
    {
        [Fact]
        public void Test()
        {
            var solution = new Solution();
            var nums = new[] {2, 7, 11, 15};
            Assert.Equal(new[] {0, 1}, solution.TwoSum(nums, 9));
        }
    }
}