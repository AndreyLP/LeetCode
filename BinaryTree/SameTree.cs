namespace BinaryTree
{
    //100. Same Tree
    //Given the roots of two binary trees p and q, write a function to check if they are the same or not.

    //Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.

    //Example 1:

    //Input: p = [1, 2, 3], q = [1, 2, 3]
    //Output: true
    //Example 2:

    //Input: p = [1, 2], q = [1, null, 2]
    //Output: false
    //Example 3:

    //Input: p = [1, 2, 1], q = [1, 1, 2]
    //Output: false

    //Constraints:

    //The number of nodes in both trees is in the range [0, 100].
    //-10^4 <= Node.val <= 10^4
    public class SameTree
    {
        public bool IsSameTreeDFS(TreeNode? p, TreeNode? q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            if (p == null || q == null)
            {
                return false;
            }
            if (p.val != q.val)
            {
                return false;
            }

            return IsSameTreeDFS(p.left, q.left) && IsSameTreeDFS(p.right, q.right);
        }
        public bool IsSameTreeBFS(TreeNode? p, TreeNode? q)
        {
            Queue<(TreeNode?, TreeNode?)> queue = new();
            queue.Enqueue((p, q));

            while (queue.Count > 0)
            {
                var (n1, n2) = queue.Dequeue();

                if (n1 == null && n2 == null)
                {
                    return true;
                }
                if (n1 == null || n2 == null || n1.val != n2.val)
                {
                    return false;
                }
                queue.Enqueue((n1.left, n2.left));
                queue.Enqueue((n1.right, n2.right));
            }
            return true;
        }
    }
}
