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
    public IList<int> Preorder(Node root) {
        if (root == null) return new List<int>();
        List<int> result = new();
        Stack<Node> stack = new();
        stack.Push(root);
        while (stack.Count != 0)
        {
            root=stack.Pop();
            result.Add(root.val);
            foreach (Node node in root.children.Reverse())
            {
                stack.Push(node);
            }
        }
        return result;
    }
}