namespace BinaryTree
{
    //104. Maximum Depth of Binary Tree
    //Given the root of a binary tree, return its maximum depth.

    //A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.



    //Example 1:


    //Input: root = [3, 9, 20, null, null, 15, 7]
    //Output: 3
    //Example 2:

    //Input: root = [1, null, 2]
    //Output: 2


    //Constraints:

    //The number of nodes in the tree is in the range[0, 104].
    //-100 <= Node.val <= 100
    public class MaximumDepthOfBinaryTree
    {
        public int MaxDepthBFS(TreeNode? root)
        {
            if (root == null)
            {
                return 0;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int depth = 0;
            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    var node = queue.Dequeue();

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                depth++;
            }

            return depth;
        }
        public int MaxDepthDFS(TreeNode? root)
        {
            if (root == null)
                return 0;

            int leftDepth = MaxDepthDFS(root.left);
            int rightDepth = MaxDepthDFS(root.right);

            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}
