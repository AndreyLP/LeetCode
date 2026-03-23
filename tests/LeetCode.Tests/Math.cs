using FluentAssertions;
using Math;

namespace LeetCode.Tests
{
    public class Math
    {
        [InlineData(121,true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        [Theory]
        public void IsPalindrome(int x, bool isCorrect)
        {
            var sut = new PalindromeNumber();

            var result = sut.IsPalindrome(x);

            result.Should().Be(isCorrect);
        }
    }
}
