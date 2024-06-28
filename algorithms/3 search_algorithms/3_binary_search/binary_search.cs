using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int target = 5;
        int result = BinarySearch(arr, target);
        if (result != -1)
        {
            Console.WriteLine($"Елемент {target} знайдено за індексом {result}");
        }
        else
        {
            Console.WriteLine($"Елемент {target} не знайдено у масиві");
        }
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] == target)
            {
                return mid;  // Повертаємо індекс знайденого елемента
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;  // Зміщуємо діапазон праворуч від середини
            }
            else
            {
                right = mid - 1;  // Зміщуємо діапазон ліворуч від середини
            }
        }

        return -1;  // Повертаємо -1, якщо елемент не знайдено
    }
}

