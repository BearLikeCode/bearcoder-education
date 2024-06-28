using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 5, 1, 3, 9, 8, 2, 7, 4, 6 };
        Console.WriteLine("Original array:");
        PrintArray(arr);
        TimSort(arr);
        Console.WriteLine("Sorted array:");
        PrintArray(arr);
    }

    static void InsertionSort(int[] arr, int left, int right)
    {
        for (int i = left + 1; i <= right; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= left && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int lenLeft = mid - left + 1;
        int lenRight = right - mid;

        int[] leftArr = new int[lenLeft];
        int[] rightArr = new int[lenRight];

        Array.Copy(arr, left, leftArr, 0, lenLeft);
        Array.Copy(arr, mid + 1, rightArr, 0, lenRight);

        int i = 0, j = 0, k = left;
        while (i < lenLeft && j < lenRight)
        {
            if (leftArr[i] <= rightArr[j])
            {
                arr[k] = leftArr[i];
                i++;
            }
            else
            {
                arr[k] = rightArr[j];
                j++;
            }
            k++;
        }

        while (i < lenLeft)
        {
            arr[k] = leftArr[i];
            i++;
            k++;
        }

        while (j < lenRight)
        {
            arr[k] = rightArr[j];
            j++;
            k++;
        }
    }

    static void TimSort(int[] arr)
    {
        int n = arr.Length;
        int minRun = 32;

        for (int i = 0; i < n; i += minRun)
        {
            InsertionSort(arr, i, Math.Min(i + minRun - 1, n - 1));
        }

        for (int size = minRun; size < n; size *= 2)
        {
            for (int left = 0; left < n; left += 2 * size)
            {
                int mid = left + size - 1;
                int right = Math.Min(left + 2 * size - 1, n - 1);
                if (mid < right)
                {
                    Merge(arr, left, mid, right);
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

