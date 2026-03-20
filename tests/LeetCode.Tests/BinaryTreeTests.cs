using BinaryTree;
using FluentAssertions;

namespace LeetCode.Tests
{
    public class BinaryTreeTests
    {
        [InlineData("3,9,20,null,null,15,7", 3)]
        [InlineData("1,null,2", 2)]
        [Theory]
        public void CheckMaximumDepthOfBinaryTreeBFS(string treeArray, int maxDepth)
        {
            var sut = new MaximumDepthOfBinaryTree();

            var result = sut.MaxDepthBFS(TreeNodeExtensions.ToTreeNode(treeArray));

            result.Should().Be(maxDepth);
        }

        [InlineData("3,9,20,null,null,15,7", 3)]
        [InlineData("1,null,2", 2)]
        [Theory]
        public void CheckMaximumDepthOfBinaryTreeDFS(string treeArray, int maxDepth)
        {
            var sut = new MaximumDepthOfBinaryTree();

            var result = sut.MaxDepthDFS(TreeNodeExtensions.ToTreeNode(treeArray));

            result.Should().Be(maxDepth);
        }

    }
}
