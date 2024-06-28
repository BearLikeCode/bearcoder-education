def linear_search(arr, target):
    for i in range(len(arr)):
        if arr[i] == target:
            return i  # Повертає індекс шуканого елемента, якщо знайдено
    return -1  # Повертає -1, якщо шуканий елемент не знайдено

# Приклад використання:
arr = [4, 7, 2, 9, 1, 5]
target = 9
result = linear_search(arr, target)
if result != -1:
    print(f"Елемент {target} знайдено за індексом {result}")
else:
    print(f"Елемент {target} не знайдено у масиві")

