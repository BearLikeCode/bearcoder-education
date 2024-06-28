using System;

class Program
{
    static void Main()
    {
        // Приклад виклику рекурсивної функції
        int result = Factorial(5);

        Console.WriteLine($"Factorial of 5 is: {result}");
    }

    // Рекурсивна функція для обчислення факторіалу
    static int Factorial(int n)
    {
        // Базовий випадок: факторіал 0 або 1 дорівнює 1
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            // Рекурсивний виклик для обчислення факторіалу
            return n * Factorial(n - 1);
        }
    }
}
