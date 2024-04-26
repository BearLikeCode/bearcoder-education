using System;

class Program
{
    static void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && key < arr[j])
            {
                arr[j + 1] = arr[j];
                j -= 1;
            }
            arr[j + 1] = key;
        }
    }

    static void Main(string[] args)
    {
        int[] arr = { 12, 11, 13, 5, 6 };
        InsertionSort(arr);
        Console.Write("Sorted array is: ");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}

