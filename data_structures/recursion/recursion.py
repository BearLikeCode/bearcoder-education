def factorial(n):
    # Базовий випадок: факторіал 0 або 1 дорівнює 1
    if n == 0 or n == 1:
        return 1
    else:
        # Рекурсивний виклик для обчислення факторіалу
        return n * factorial(n - 1)

# Приклад виклику рекурсивної функції
result = factorial(5)

print(f"Factorial of 5 is: {result}")
