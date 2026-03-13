using FluentAssertions;

namespace Array.Tests
{
    public class MajorityElementTests
    {
        [InlineData(new int[3] { 3, 2, 3 }, 3)]
        [InlineData(new int[7] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
        [Theory]
        public void CheckMajorityElement(int[] nums, int majority)
        {
            MajorityElement sut = new MajorityElement();

            var result = sut.GetMajorityElement(nums);

            result.Should().Be(majority);
        }
    }
}