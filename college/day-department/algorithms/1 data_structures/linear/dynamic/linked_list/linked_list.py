# he Node class represents a node in the linked list, containing data and a reference to the next node.
# The LinkedList class has methods such as append (to add a node at the end), prepend (to add a node at the beginning), delete (to delete a node with a specific value), and display (to print the linked list).
# Example usage demonstrates creating a linked list, appending and prepending elements, deleting a specific element, and displaying the linked list.

class Node:
    def __init__(self, data):
        self.data = data
        self.next = None

class LinkedList:
    def __init__(self):
        self.head = None

    def is_empty(self):
        return self.head is None

    def append(self, data):
        new_node = Node(data)
        if self.head is None:
            self.head = new_node
            return
        last_node = self.head
        while last_node.next:
            last_node = last_node.next
        last_node.next = new_node

    def prepend(self, data):
        new_node = Node(data)
        new_node.next = self.head
        self.head = new_node

    def delete(self, data):
        if self.head is None:
            print("Error: List is empty")
            return

        if self.head.data == data:
            self.head = self.head.next
            return

        current_node = self.head
        while current_node.next:
            if current_node.next.data == data:
                current_node.next = current_node.next.next
                return
            current_node = current_node.next

        print(f"Error: {data} not found in the list")

    def display(self):
        current_node = self.head
        while current_node:
            print(current_node.data, end=" -> ")
            current_node = current_node.next
        print("None")

# Example usage of the LinkedList
linked_list = LinkedList()

linked_list.append(1)
linked_list.append(2)
linked_list.append(3)
linked_list.prepend(0)

print("Original Linked List:")
linked_list.display()

linked_list.delete(2)
print("Linked List after deleting 2:")
linked_list.display()