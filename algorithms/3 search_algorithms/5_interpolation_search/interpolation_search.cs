using System;

class InterpolationSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int current = arr[i];
            int left = 0;
            int right = i - 1;

            // Use interpolation formula to calculate the approximate position
            int pos = left + ((right - left) / (arr[right] - arr[left])) * (current - arr[left]);

            // Adjust the position if it's out of bounds
            if (pos < 0)
                pos = 0;
            else if (pos > i)
                pos = i;

            // Shift elements to make space for the current element
            for (int j = i; j > pos; j--)
            {
                arr[j] = arr[j - 1];
            }

            // Insert the current element at its correct position
            arr[pos] = current;
        }
    }

    static void Main(string[] args)
    {
        int[] arr = { 3, 5, 1, 2, 4 };

        Console.WriteLine("Original array:");
        PrintArray(arr);

        Sort(arr);

        Console.WriteLine("Sorted array:");
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
