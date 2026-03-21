namespace BinaryTree
{
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
