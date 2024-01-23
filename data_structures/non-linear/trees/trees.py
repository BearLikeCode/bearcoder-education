# The TreeNode class represents a node in the binary tree with a key and references to the left and right children.
# The inorder_traversal function performs an inorder traversal of the binary tree, printing the key of each visited node.
# The example usage creates a binary tree with nodes 1, 2, 3, 4, and 5 and then performs an inorder traversal, which should print the nodes in sorted order (in this case, 4, 2, 5, 1, 3).

class TreeNode:
    def __init__(self, key):
        self.key = key
        self.left = None
        self.right = None

def inorder_traversal(root):
    if root:
        # Traverse the left subtree
        inorder_traversal(root.left)
        # Visit the root node
        print(root.key, end=" ")
        # Traverse the right subtree
        inorder_traversal(root.right)

# Example usage of the binary tree
# Creating nodes
root = TreeNode(1)
root.left = TreeNode(2)
root.right = TreeNode(3)
root.left.left = TreeNode(4)
root.left.right = TreeNode(5)

# Inorder traversal of the binary tree
print("Inorder Traversal:")
inorder_traversal(root)
