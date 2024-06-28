// The TreeNode class represents a node in the binary tree with a Key and references to the left and right children.
// The InorderTraversal method performs an inorder traversal of the binary tree, printing the key of each visited node.
// Example usage creates a binary tree with nodes 1, 2, 3, 4, and 5, and then performs an inorder traversal, printing the nodes in sorted order (in this case, 4, 2, 5, 1, 3).


using System;

class TreeNode
{
    public int Key;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int key)
    {
        Key = key;
        Left = null;
        Right = null;
    }
}

class Program
{
    static void InorderTraversal(TreeNode root)
    {
        if (root != null)
        {
            // Traverse the left subtree
            InorderTraversal(root.Left);
            // Visit the root node
            Console.Write(root.Key + " ");
            // Traverse the right subtree
            InorderTraversal(root.Right);
        }
    }

    static void Main()
    {
        // Example usage of the binary tree
        // Creating nodes
        TreeNode root = new TreeNode(1);
        root.Left = new TreeNode(2);
        root.Right = new TreeNode(3);
        root.Left.Left = new TreeNode(4);
        root.Left.Right = new TreeNode(5);

        // Inorder traversal of the binary tree
        Console.WriteLine("Inorder Traversal:");
        InorderTraversal(root);
    }
}
