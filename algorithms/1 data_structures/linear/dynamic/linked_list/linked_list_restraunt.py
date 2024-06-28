class Order:
    def __init__(self, order_id, items, delivery_address):
        self.order_id = order_id
        self.items = items
        self.delivery_address = delivery_address
        self.next_order = None

class LinkedList:
    def __init__(self):
        self.head = None

    def add_order(self, order):
        if not self.head:
            self.head = order
        else:
            current_order = self.head
            while current_order.next_order:
                current_order = current_order.next_order
            current_order.next_order = order

    def display_orders(self):
        current_order = self.head
        while current_order:
            print(f"Order ID: {current_order.order_id}, Delivery Address: {current_order.delivery_address}")
            current_order = current_order.next_order

# Створення зв'язаного списку замовлень
order_list = LinkedList()
order_list.add_order(Order(1, ["Pizza", "Coke"], "123 Main St"))
order_list.add_order(Order(2, ["Burger", "Fries"], "456 Oak St"))
order_list.add_order(Order(3, ["Sushi", "Green Tea"], "789 Pine St"))

# Відображення замовлень
order_list.display_orders()
