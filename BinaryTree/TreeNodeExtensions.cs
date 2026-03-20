namespace BinaryTree
{
    public static class TreeNodeExtensions
    {
        public static TreeNode? ToTreeNode(string values)
        {
            int?[] treeArray = values.Split(',')
                .Select(s => s.Trim().ToLower() == "null" ? (int?)null : int.Parse(s))
                .ToArray();
            return ToTreeNode(treeArray);
        }
        public static TreeNode? ToTreeNode(int?[] values)
        {
            if (values == null || values.Count() == 0)
                return null;

            Queue<TreeNode> queue = new Queue<TreeNode>();

            TreeNode root = new TreeNode(val: values[0].GetValueOrDefault());
            queue.Enqueue(root);
            int i = 1;

            while (i < values.Length)
            {
                var currentNode = queue.Dequeue();
                //left
                if (i < values.Length && values[i] != null)
                {
                    currentNode.left = new TreeNode(val: values[i].GetValueOrDefault());
                    queue.Enqueue(currentNode.left);
                }
                i++;
                //right
                if (i < values.Length && values[i] != null)
                {
                    currentNode.right = new TreeNode(val: values[i].GetValueOrDefault());
                    queue.Enqueue(currentNode.right);
                }
                i++;
            }
            return root;
        }
    }
}
