// The Node class represents a node in the linked list, containing an integer Data and a reference to the next node (Next).
// The LinkedList class has methods such as Append, Prepend, Delete, Display, and an IsEmpty property.
// Example usage demonstrates creating a linked list, appending and prepending elements, deleting a specific element, and displaying the linked list.

using System;

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    private Node head;

    public bool IsEmpty()
    {
        return head == null;
    }

    public void Append(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Node lastNode = head;
        while (lastNode.Next != null)
        {
            lastNode = lastNode.Next;
        }

        lastNode.Next = newNode;
    }

    public void Prepend(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
    }

    public void Delete(int data)
    {
        if (head == null)
        {
            Console.WriteLine("Error: List is empty");
            return;
        }

        if (head.Data == data)
        {
            head = head.Next;
            return;
        }

        Node current = head;
        while (current.Next != null)
        {
            if (current.Next.Data == data)
            {
                current.Next = current.Next.Next;
                return;
            }
            current = current.Next;
        }

        Console.WriteLine($"Error: {data} not found in the list");
    }

    public void Display()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("None");
    }
}

class Program
{
    static void Main()
    {
        // Example usage of the LinkedList
        LinkedList linkedList = new LinkedList();

        linkedList.Append(1);
        linkedList.Append(2);
        linkedList.Append(3);
        linkedList.Prepend(0);

        Console.WriteLine("Original Linked List:");
        linkedList.Display();

        linkedList.Delete(2);
        Console.WriteLine("Linked List after deleting 2:");
        linkedList.Display();
    }
}
