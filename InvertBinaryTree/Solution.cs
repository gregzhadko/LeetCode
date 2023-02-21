namespace InvertBinaryTree;

public class Solution
{
    public TreeNode InvertTreeSivykh(TreeNode root)
    {
        if (root == null)
        {
            return null;
        }

        var temp = root.left;
        root.left = InvertTreeSivykh(root.right);
        root.right = InvertTreeSivykh(temp);
        return root;
    }
    
    public TreeNode InvertTreeGreg(TreeNode root)
    {
        if (root is null)
        {
            return null;
        }

        (root.left, root.right) = (InvertTreeGreg(root.right), InvertTreeGreg(root.left));
        return root;
    }

    public TreeNode InvertTreeLeetCode(TreeNode root)
    {
        void Browse(TreeNode node)
        {
            if (node != null)
            {
                Browse(node.left);
                Browse(node.right);
                var temp = node.left;
                node.left = node.right;
                node.right = temp;
            }
        }
        
        Browse(root);
        return root;
    }
}