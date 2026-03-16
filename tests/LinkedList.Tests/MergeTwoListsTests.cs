using FluentAssertions;
namespace LinkedList.Tests
{
    public class MergeTwoListsTests
    {
        [InlineData("1,2,4", "1,3,4", "1,1,2,3,4,4")]
        [InlineData("", "", "")]
        [InlineData("", "0", "0")]
        [Theory]
        public void MergeTwoLists(string list1, string list2, string output)
        {
            MergeTwoLists sut = new();

            var result = sut.GetMergeTwoLists(list1.ToListNode(), list2.ToListNode())?.ToString() ?? "";

            result.Should().Be(output);
        }
    }
}