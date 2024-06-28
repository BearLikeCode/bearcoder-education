/*

The Stack<T> class from the System.Collections.Generic namespace is used to implement a stack of integers.
The Push method is used to add elements to the top of the stack.
The Pop method is used to remove and return the top element from the stack.
The Peek method returns the top element without removing it.
The Count property is used to check the number of elements in the stack.
The Console.WriteLine statements are used for printing outputs.

*/

using System;
using System.Collections.Generic;

class StackExample
{
    static void Main()
    {
        // Example usage of the Stack
        Stack<int> stack = new Stack<int>();

        // Pushing elements onto the stack
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // Peeking at the top of the stack
        Console.WriteLine("Top of the stack: " + stack.Peek());

        // Popping elements from the stack
        int poppedItem = stack.Pop();
        Console.WriteLine("Popped item: " + poppedItem);

        // Checking if the stack is empty
        Console.WriteLine("Is the stack empty? " + (stack.Count == 0));

        // Checking the size of the stack
        Console.WriteLine("Size of the stack: " + stack.Count);
    }
}