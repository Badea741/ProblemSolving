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
    List<string> result=new();
    List<string> InOrderTraversal(TreeNode root){
        if(root ==null){result.Add("");}else{
                    result.Add(root.val.ToString());

        InOrderTraversal(root.left);
        InOrderTraversal(root.right);
        }
                return result;

    }
    
    
    public bool IsSameTree(TreeNode p, TreeNode q) {
        List<string> tree1=InOrderTraversal(p);
        result=new();
        List<string> tree2=InOrderTraversal(q);
        return tree1.SequenceEqual(tree2);
    }
}