/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public int GetDecimalValue(ListNode head) {
      StringBuilder builder = new();

        ListNode current = head;
        while (current != null)
        {
            builder.Append(current.val);
            current = current.next;
        }
        int ans = Convert.ToInt32(builder.ToString(),2);
        return ans;

        
    }
}