using Array;
using FluentAssertions;

namespace LeetCode.Tests
{
    public class ArrayTests
    {
        [InlineData("III", 3)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        [Theory]
        public void CheckRomanToInt(string romanNumeral, int IntNumeral)
        {
            var sut = new RomanToInteger();

            var result = sut.RomanToInt(romanNumeral);

            result.Should().Be(IntNumeral);
        }
    }
}
