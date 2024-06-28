import random
import time

def bubble_sort(arr):
    n = len(arr)
    for i in range(n):
        # Last i elements are already sorted, so we don't need to check them
        for j in range(0, n-i-1):
            if arr[j] > arr[j+1]:
                # Swap if the element found is greater than the next element
                arr[j], arr[j+1] = arr[j+1], arr[j]

# Function to measure the time taken by bubble sort
def measure_time(arr):
    start_time = time.time()
    bubble_sort(arr)
    end_time = time.time()
    elapsed_time = end_time - start_time
    return elapsed_time

# Example usage
if __name__ == "__main__":
    # Generate a random array for testing
    array_to_sort = [random.randint(1, 1000) for _ in range(1000)]

    print("Original Array:", array_to_sort)

    # Measure time taken by bubble sort
    time_taken = measure_time(array_to_sort)

    print("   ")

    print("Sorted Array:", array_to_sort)
    print("Time taken by Bubble Sort: {:.6f} seconds".format(time_taken))
