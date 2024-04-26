# Створення хеш-таблиці для зберігання телефонних номерів
phone_book = {}

# Додавання контактів до хеш-таблиці
phone_book["Alice"] = "+123456789"
phone_book["Bob"] = "+987654321"
phone_book["Charlie"] = "+111223344"

# Отримання номера телефону за іменем
alice_number = phone_book.get("Alice", "Number not found")
bob_number = phone_book.get("Bob", "Number not found")
dave_number = phone_book.get("Dave", "Number not found")

# Виведення інформації про контакти
print(f"Alice's number: {alice_number}")
print(f"Bob's number: {bob_number}")
print(f"Dave's number: {dave_number}")
