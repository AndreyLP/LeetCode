namespace LinkedList
{
    public static class ListNodeExtensions
    {
        public static ListNode? ToListNode(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return null;

            int[] values = input.Split(',')
                                .Select(s => int.Parse(s.Trim()))
                                .ToArray();

            return values.ToListNode();
        }
        public static ListNode? ToListNode(this IEnumerable<int> values)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            foreach (int val in values)
            {
                current.next = new ListNode(val);
                current = current.next;
            }

            return dummy.next;
        }
        public static int[] ToArray(this ListNode head)
        {
            var result = new List<int>();
            var current = head;

            while (current != null)
            {
                result.Add(current.val);
                current = current.next;
            }

            return result.ToArray();
        }
    }
}
