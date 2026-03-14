using FluentAssertions;

namespace Array.Tests
{
    public class BuySellStockTests
    {
        [InlineData(new int[6] { 7, 1, 5, 3, 6, 4 }, 5)]
        [InlineData(new int[5] { 7, 6, 4, 3, 1 }, 0)]
        [Theory]
        public void CheckGetProfit(int[] nums, int majority)
        {
            BuySellStock sut = new();

            var result = sut.MaxProfit(nums);

            result.Should().Be(majority);
        }
    }
}