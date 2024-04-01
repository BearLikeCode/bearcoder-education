using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 5, 3, 8, 2, 9, 1 };

        int minValue = FindMinimum(arr);
        int maxValue = FindMaximum(arr);

        Console.WriteLine($"Мінімальний елемент: {minValue}");
        Console.WriteLine($"Максимальний елемент: {maxValue}");
    }

    static int FindMinimum(int[] arr)
    {
        if (arr.Length == 0)
        {
            throw new ArgumentException("Масив порожній", nameof(arr));
        }

        int minVal = arr[0];
        foreach (int num in arr)
        {
            if (num < minVal)
            {
                minVal = num;
            }
        }
        return minVal;
    }

    static int FindMaximum(int[] arr)
    {
        if (arr.Length == 0)
        {
            throw new ArgumentException("Масив порожній", nameof(arr));
        }

        int maxVal = arr[0];
        foreach (int num in arr)
        {
            if (num > maxVal)
            {
                maxVal = num;
            }
        }
        return maxVal;
    }
}

