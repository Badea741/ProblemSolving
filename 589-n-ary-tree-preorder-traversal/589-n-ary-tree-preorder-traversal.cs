/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    List<int> result=new();
    public IList<int> Preorder(Node root) {
        if(root==null)return result;
        result.Add(root.val);
        foreach(Node node in root.children)
            Preorder(node);
        return result;
    }
}