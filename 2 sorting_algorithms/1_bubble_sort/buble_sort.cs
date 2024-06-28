using System;
using System.Diagnostics;

class Program
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            // Last i elements are already sorted, so we don't need to check them
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap if the element found is greater than the next element
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static double MeasureTime(int[] arr)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        BubbleSort(arr);
        stopwatch.Stop();
        return stopwatch.Elapsed.TotalSeconds;
    }

    static void Main()
    {
        // Generate a random array for testing
        Random rand = new Random();
        int[] arrayToSort = new int[1000];
        for (int i = 0; i < arrayToSort.Length; i++)
        {
            arrayToSort[i] = rand.Next(1, 1000);
        }

        Console.WriteLine("Original Array:");
        foreach (int num in arrayToSort)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Measure time taken by bubble sort
        double timeTaken = MeasureTime(arrayToSort);

        Console.WriteLine("   ");

        Console.WriteLine("Sorted Array:");
        foreach (int num in arrayToSort)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Time taken by Bubble Sort: {0:F6} seconds", timeTaken);
    }
}
