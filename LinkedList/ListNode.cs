using System.Text;

namespace LinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            ListNode? current = this;
            while (current != null)
            {
                sb.Append(current.val).Append(current.next != null ? "," : "");
                current = current.next;
            }
            return sb.ToString();
        }
    }
}
