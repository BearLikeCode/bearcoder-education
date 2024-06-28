def binary_search(arr, target):
    left, right = 0, len(arr) - 1
    
    while left <= right:
        mid = (left + right) // 2
        if arr[mid] == target:
            return mid  # Повертаємо індекс знайденого елемента
        elif arr[mid] < target:
            left = mid + 1  # Зміщуємо діапазон праворуч від середини
        else:
            right = mid - 1  # Зміщуємо діапазон ліворуч від середини
    
    return -1  # Повертаємо -1, якщо елемент не знайдено

# Приклад використання:
arr = [1, 2, 3, 4, 5, 6, 7, 8, 9]
target = 5
result = binary_search(arr, target)
if result != -1:
    print(f"Елемент {target} знайдено за індексом {result}")
else:
    print(f"Елемент {target} не знайдено у масиві")

