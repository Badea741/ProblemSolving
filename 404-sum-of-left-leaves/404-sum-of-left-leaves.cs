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
    public int SumOfLeftLeaves(TreeNode root) {
        if(root==null)return 0;
        Stack<TreeNode> stack=new();
        stack.Push(root);
        int sum=0;
        while(stack.Count!=0){
            root = stack.Pop();
            if(root.left!=null){
                    stack.Push(root.left);
                    if(root.left.left==null&&root.left.right==null)
                        sum+=root.left.val;
                }
            if(root.right!=null){
                    stack.Push(root.right);
                // if(root.left.left==null&&root.left.right==null)
                //         sum+=root.left.val;
                
                }
        }
        return sum;
    }
}