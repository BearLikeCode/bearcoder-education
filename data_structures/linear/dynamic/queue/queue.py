# Certainly! In Python, you can implement a simple queue using the collections.deque class.

# The Queue class is implemented using the collections.deque class for efficient queue operations.
# The enqueue method is used to add elements to the rear of the queue.
# The dequeue method is used to remove and return the front element from the queue.
# The front method returns the front element without removing it.
# The is_empty method checks if the queue is empty.
# The size method returns the number of elements in the queue.

from collections import deque

class Queue:
    def __init__(self):
        self.items = deque()

    def is_empty(self):
        return len(self.items) == 0

    def enqueue(self, item):
        self.items.append(item)

    def dequeue(self):
        if not self.is_empty():
            return self.items.popleft()
        else:
            print("Error: Queue is empty")

    def front(self):
        if not self.is_empty():
            return self.items[0]
        else:
            print("Error: Queue is empty")

    def size(self):
        return len(self.items)


# Example usage of the Queue
queue = Queue()

# Enqueuing elements into the queue
queue.enqueue(1)
queue.enqueue(2)
queue.enqueue(3)

# Checking the front of the queue
print("Front of the queue:", queue.front())

# Dequeuing elements from the queue
dequeued_item = queue.dequeue()
print("Dequeued item:", dequeued_item)

# Checking if the queue is empty
print("Is the queue empty?", queue.is_empty())

# Checking the size of the queue
print("Size of the queue:", queue.size())
