def interpolation_sort(arr):
    n = len(arr)
    for i in range(1, n):
        current = arr[i]
        left = 0
        right = i - 1
        
        # Use interpolation formula to calculate the approximate position
        pos = left + ((right - left) // (arr[right] - arr[left])) * (current - arr[left])
        
        # Adjust the position if it's out of bounds
        if pos < 0:
            pos = 0
        elif pos > i:
            pos = i
        
        # Shift elements to make space for the current element
        for j in range(i, pos, -1):
            arr[j] = arr[j - 1]
        
        # Insert the current element at its correct position
        arr[pos] = current

# Example usage:
arr = [3, 5, 1, 2, 4]
print("Original array:", arr)
interpolation_sort(arr)
print("Sorted array:", arr)
