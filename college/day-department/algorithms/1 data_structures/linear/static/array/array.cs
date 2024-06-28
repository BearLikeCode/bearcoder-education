// The List<int> class is used to represent a dynamic array of integers.
// Elements are accessed using indexing, modified in place, and appended using the Add method.
// An element is removed using RemoveAt based on the index.
// The length of the array is obtained using the Count property.
// The modified array and its properties are then printed.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating an array
        List<int> myArray = new List<int> { 1, 2, 3, 4, 5 };

        // Accessing elements of the array
        Console.WriteLine("First element: " + myArray[0]);
        Console.WriteLine("Second element: " + myArray[1]);

        // Modifying an element of the array
        myArray[2] = 10;

        // Adding an element to the end of the array
        myArray.Add(6);

        // Removing an element from the array
        int removedElement = myArray[1];
        myArray.RemoveAt(1);

        // Length of the array
        int arrayLength = myArray.Count;

        // Printing the array and its properties
        Console.Write("Modified Array: ");
        foreach (int element in myArray)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
        
        Console.WriteLine("Removed Element: " + removedElement);
        Console.WriteLine("Length of the Array: " + arrayLength);
    }
}
