using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 4, 7, 2, 9, 1, 5 };
        int target = 9;
        int result = LinearSearch(arr, target);
        if (result != -1)
        {
            Console.WriteLine($"Елемент {target} знайдено за індексом {result}");
        }
        else
        {
            Console.WriteLine($"Елемент {target} не знайдено у масиві");
        }
    }

    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i; // Повертає індекс шуканого елемента, якщо знайдено
            }
        }
        return -1; // Повертає -1, якщо шуканий елемент не знайдено
    }
}

