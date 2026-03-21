namespace BinaryTree
{
    public class MinimumAbsoluteDifference
    {
        private int minDiff = int.MaxValue;
        private TreeNode? prev = null;
        public int GetMinimumDifference(TreeNode? root)
        {
            Inorder(root);

            return minDiff;
        }

        private void Inorder(TreeNode? node)
        {
            if (node == null)
            {
                return;
            }
            Inorder(node.left);

            if (prev != null)
            {
                minDiff = Math.Min(minDiff, node.val - prev.val);
            }
            prev= node;

            Inorder(node.right);
        }
    }
}
