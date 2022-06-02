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
    public ListNode MiddleNode(ListNode head) {
        ListNode current=head;
        int count=0;
        while(current!=null){
            count++;
            current=current.next;
        }
        current=head;
        count=count/2;
        while(count-->0){
            current=current.next;
        }
        return current;
    }
}