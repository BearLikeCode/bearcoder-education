using System;

class Node
{
    public int Key;
    public Node Left, Right;

    public Node(int item)
    {
        Key = item;
        Left = Right = null;
    }
}

class BinarySearchTree
{
    Node root;

    public BinarySearchTree()
    {
        root = null;
    }

    public void Insert(int key)
    {
        root = InsertRec(root, key);
    }

    Node InsertRec(Node root, int key)
    {
        if (root == null)
        {
            root = new Node(key);
            return root;
        }

        if (key < root.Key)
            root.Left = InsertRec(root.Left, key);
        else if (key > root.Key)
            root.Right = InsertRec(root.Right, key);

        return root;
    }

    public Node Search(int key)
    {
        return SearchRec(root, key);
    }

    Node SearchRec(Node root, int key)
    {
        if (root == null || root.Key == key)
            return root;

        if (key < root.Key)
            return SearchRec(root.Left, key);

        return SearchRec(root.Right, key);
    }

    static void Main()
    {
        BinarySearchTree bst = new BinarySearchTree();

        bst.Insert(50);
        bst.Insert(30);
        bst.Insert(70);
        bst.Insert(20);
        bst.Insert(40);

        Node node = bst.Search(40);
        if (node != null)
            Console.WriteLine("Елемент знайдено: " + node.Key);
        else
            Console.WriteLine("Елемент не знайдено");
    }
}

