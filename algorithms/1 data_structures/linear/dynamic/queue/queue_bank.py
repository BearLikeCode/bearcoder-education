from queue import Queue

class BankService:
    def __init__(self):
        self.customer_queue = Queue()

    def enqueue_customer(self, customer_name):
        self.customer_queue.put(customer_name)
        print(f"{customer_name} added to the queue.")

    def process_customer(self):
        if not self.customer_queue.empty():
            next_customer = self.customer_queue.get()
            print(f"Processing customer: {next_customer}")
        else:
            print("No customers in the queue.")

    def display_queue(self):
        print("Current queue:")
        for customer in list(self.customer_queue.queue):
            print(customer)

# Створення об'єкту банківського сервісу
bank_service = BankService()

# Додавання клієнтів у чергу
bank_service.enqueue_customer("Alice")
bank_service.enqueue_customer("Bob")
bank_service.enqueue_customer("Charlie")

# Відображення черги
bank_service.display_queue()

# Обробка клієнтів
bank_service.process_customer()
bank_service.process_customer()
bank_service.process_customer()
bank_service.process_customer()

# Відображення оновленої черги
bank_service.display_queue()
