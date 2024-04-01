using System;

class Program
{
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int min_index = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[min_index])
                {
                    min_index = j;
                }
            }
            int temp = arr[min_index];
            arr[min_index] = arr[i];
            arr[i] = temp;
        }
    }

    static void Main(string[] args)
    {
        int[] arr = { 64, 25, 12, 22, 11 };
        SelectionSort(arr);
        Console.Write("Sorted array is: ");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}

