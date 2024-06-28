# In Python, you can implement a simple stack using a list.

# The Stack class is implemented with methods such as push, pop, peek, is_empty, and size.
# The push method is used to add elements to the top of the stack.
# The pop method is used to remove and return the top element from the stack.
# The peek method returns the top element without removing it.
# The is_empty method checks if the stack is empty.
# The size method returns the number of elements in the stack.

class Stack:
    def __init__(self):
        self.items = []

    def is_empty(self):
        return len(self.items) == 0

    def push(self, item):
        self.items.append(item)

    def pop(self):
        if not self.is_empty():
            return self.items.pop()
        else:
            print("Error: Stack is empty")

    def peek(self):
        if not self.is_empty():
            return self.items[-1]
        else:
            print("Error: Stack is empty")

    def size(self):
        return len(self.items)


# Example usage of the Stack
stack = Stack()

# Pushing elements onto the stack
stack.push(1)
stack.push(2)
stack.push(3)

# Peeking at the top of the stack
print("Top of the stack:", stack.peek())

# Popping elements from the stack
popped_item = stack.pop()
print("Popped item:", popped_item)

# Checking if the stack is empty
print("Is the stack empty?", stack.is_empty())

# Checking the size of the stack
print("Size of the stack:", stack.size())