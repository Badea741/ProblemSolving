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
    
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode current=head;
        while(current!=null && current.next!=null){
            if(current.val!=current.next.val){
                current=current.next;
            }
            else
            {
                current.next=current.next.next;
            }
            

        }
        return head;
    }
}