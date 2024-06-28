def quick_sort(arr):
    if len(arr) <= 1:
        return arr
    else:
        pivot = arr[0]  # Вибір опорного елемента (можна вибирати інший спосіб)
        less = [x for x in arr[1:] if x <= pivot]  # Елементи менші або рівні опорному
        greater = [x for x in arr[1:] if x > pivot]  # Елементи більші за опорний
        return quick_sort(less) + [pivot] + quick_sort(greater)

# Приклад використання:
arr = [64, 25, 12, 22, 11]
sorted_arr = quick_sort(arr)
print("Відсортований масив:", sorted_arr)

