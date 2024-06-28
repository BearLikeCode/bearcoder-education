# We create an array named my_array with initial values [1, 2, 3, 4, 5].
# We access and print individual elements using indexing.
# We modify the third element of the array to be 10.
# We append a new element 6 to the end of the array.
# We remove the second element from the array using the pop method and store the removed element in the variable removed_element.
# We determine the length of the array using the len function.
# Finally, we print the modified array, the removed element, and the length of the array.

# Creating an array
my_array = [1, 2, 3, 4, 5]

# Accessing elements of the array
print("First element:", my_array[0])
print("Second element:", my_array[1])

# Modifying an element of the array
my_array[2] = 10

# Adding an element to the end of the array
my_array.append(6)

# Removing an element from the array
removed_element = my_array.pop(1)

# Length of the array
array_length = len(my_array)

# Printing the array and its properties
print("Modified Array:", my_array)
print("Removed Element:", removed_element)
print("Length of the Array:", array_length)
