/*
Here's the equivalent implementation of a simple queue in C# using the Queue<T> class

The Queue<T> class from the System.Collections.Generic namespace is used to implement a queue of integers.
The Enqueue method is used to add elements to the rear of the queue.
The Dequeue method is used to remove and return the front element from the queue.
The Peek method returns the front element without removing it.
The Count property is used to check the number of elements in the queue.
The Console.WriteLine statements are used for printing outputs.
*/


using System;
using System.Collections.Generic;

class QueueExample
{
    static void Main()
    {
        // Example usage of the Queue
        Queue<int> queue = new Queue<int>();

        // Enqueuing elements into the queue
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        // Checking the front of the queue
        Console.WriteLine("Front of the queue: " + queue.Peek());

        // Dequeuing elements from the queue
        int dequeuedItem = queue.Dequeue();
        Console.WriteLine("Dequeued item: " + dequeuedItem);

        // Checking if the queue is empty
        Console.WriteLine("Is the queue empty? " + (queue.Count == 0));

        // Checking the size of the queue
        Console.WriteLine("Size of the queue: " + queue.Count);
    }
}