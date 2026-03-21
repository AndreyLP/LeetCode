using FluentAssertions;
using Graph;

namespace LeetCode.Tests
{
    public class GraphTests
    {
        [Theory]
        [MemberData(nameof(CheckNumIslandsGrid))]
        public void CheckNumIslands(char[][] grid, int islands)
        {
            var sut = new NumberOfIslands();

            var result = sut.NumIslands(grid);

            result.Should().Be(islands);
        }
        public static IEnumerable<object[]> CheckNumIslandsGrid()
        {
            return [
                [new char[][] { ['1','1','1','1','0'],
                                ['1','1','0','1','0'],
                                ['1','1','0','0','0'],
                                ['0','0','0','0','0'] },
                1],
                [new char[][] { ['1','1','0','0','0'],
                                ['1','1','0','0','0'],
                                ['0','0','1','0','0'],
                                ['0','0','0','1','1'] },
                3]
            ];
        }
    }
}
