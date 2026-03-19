using Hashmap;
using FluentAssertions;

namespace LeetCode.Tests
{
    public class HashmapTests
    {
        [InlineData("a", "b", false)]
        [InlineData("aa", "ab", false)]
        [InlineData("aa", "aab", true)]
        [Theory]
        public void CheckRansomeNote(string ransomNote, string magazine, bool result)
        {
            var sut = new RansomNote();

            var sutRes = sut.CanConstruct(ransomNote, magazine);

            sutRes.Should().Be(result);
        }
    }
}