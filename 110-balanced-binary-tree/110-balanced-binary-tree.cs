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
    public int depthLeft(TreeNode root){
         if(root==null)return 0;
        int depthLeft1=depthLeft(root.left)+1;
        int depthRight1=depthLeft(root.right)+1;
        return depthLeft1;
    }
     public int depthRight(TreeNode root){
         if(root==null)return 0;
        int depthLeft1=depthRight(root.left)+1;
        int depthRight1=depthRight(root.right)+1;
        return Math.Max(depthLeft1,depthRight1);
    }
    
    public bool IsBalanced(TreeNode root) {
     if(root==null)return true;
        int left=depthRight(root.left);
        int right=depthRight(root.right);
        return Math.Abs(left-right)<=1&&IsBalanced(root.left)&&IsBalanced(root.right);
    }
}