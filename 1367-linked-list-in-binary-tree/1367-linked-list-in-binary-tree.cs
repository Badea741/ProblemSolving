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
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSubPath(ListNode head, TreeNode root) {
       Stack<KeyValuePair<TreeNode, string>> stack = new();
        ListNode curr = head;
        StringBuilder builder = new();
        while (curr != null)
        {
            builder.Append(curr.val);
            curr = curr.next;
        }
        string linkedListString = builder.ToString();
        string path = root.val.ToString();
        stack.Push(new(root, path));
        while (stack.Count != 0)
        {
            (root, path) = stack.Pop();
            if (path.Contains(linkedListString)) return true;
            if (root.right != null)
                stack.Push(new(root.right, path + root.right.val.ToString()));
            if (root.left != null)
                stack.Push(new(root.left, path + root.left.val.ToString()));
        }
        return false;
    }
}