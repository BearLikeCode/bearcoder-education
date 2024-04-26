def heapify(arr, n, i):
    largest = i  # Ініціалізуємо найбільший елемент як кореневий
    left = 2 * i + 1
    right = 2 * i + 2

    # Перевіряємо, чи існує лівий дочірній вузол і чи більший він за кореневий
    if left < n and arr[left] > arr[largest]:
        largest = left

    # Перевіряємо, чи існує правий дочірній вузол і чи більший він за кореневий
    if right < n and arr[right] > arr[largest]:
        largest = right

    # Якщо найбільший елемент не кореневий, то міняємо їх місцями і викликаємо heapify для піддерева
    if largest != i:
        arr[i], arr[largest] = arr[largest], arr[i]
        heapify(arr, n, largest)


def heap_sort(arr):
    n = len(arr)

    # Будуємо кучу (heapify) - розміщаємо масив так, щоб властивість кучі була задоволена
    for i in range(n // 2 - 1, -1, -1):
        heapify(arr, n, i)

    # Виконуємо сортування кучі: по черзі видаляємо найбільший елемент та пересортовуємо кучу
    for i in range(n - 1, 0, -1):
        arr[0], arr[i] = arr[i], arr[0]  # Переносимо кореневий елемент (найбільший) на кінець
        heapify(arr, i, 0)  # Повторно кучуємо з кореневого елемента

# Приклад використання:
arr = [12, 11, 13, 5, 6, 7]
heap_sort(arr)
print("Відсортований масив:", arr)

