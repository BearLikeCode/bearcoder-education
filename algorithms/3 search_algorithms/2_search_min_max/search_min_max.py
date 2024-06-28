def find_minimum(arr):
    if not arr:
        return None  # Повертає None, якщо масив порожній
    min_val = arr[0]  # Початкове значення мінімума
    for num in arr:
        if num < min_val:
            min_val = num  # Оновлюємо мінімальне значення, якщо знаходимо менше
    return min_val

def find_maximum(arr):
    if not arr:
        return None  # Повертає None, якщо масив порожній
    max_val = arr[0]  # Початкове значення максимума
    for num in arr:
        if num > max_val:
            max_val = num  # Оновлюємо максимальне значення, якщо знаходимо більше
    return max_val

# Приклад використання:
arr = [5, 3, 8, 2, 9, 1]
print("Мінімальний елемент:", find_minimum(arr))
print("Максимальний елемент:", find_maximum(arr))

