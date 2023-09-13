  public class ListNode 
{
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
 

public class Program
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode prevGroupTail = dummy;
            ListNode curr = head;
            int count = 0;

            // Count the number of nodes in the linked list
            while (curr != null)
            {
                count++;
                curr = curr.next;
            }

            while (count >= k)
            {
                curr = prevGroupTail.next;
                ListNode groupPrev = prevGroupTail;
                ListNode groupNext = curr;

                // Reverse k nodes in the current group
                for (int i = 0; i < k; i++)
                {
                    ListNode nextTemp = curr.next;
                    curr.next = groupPrev;
                    groupPrev = curr;
                    curr = nextTemp;
                }

                prevGroupTail.next = groupPrev;
                groupNext.next = curr;

                prevGroupTail = groupNext;
                count -= k;
            }

            return dummy.next;
        }
    }
}