-- Заповнення таблиці Товари
INSERT INTO Products (ProductName, ProductDescription, Price, ProductCategory, StockQuantity)
VALUES 
    ('Exotic Fruit', 'A variety of rare and exotic fruits from around the world.', 5.99, 'Fruits', 100),
    ('Rare Orchid', 'A unique and delicate orchid species found only in remote jungles.', 29.99, 'Plants', 20),
    ('Exotic Fish', 'Colorful tropical fish for your aquarium.', 19.99, 'Pets', 50),
    ('Rare Tea Blend', 'A special blend of rare teas from distant lands.', 9.99, 'Beverages', 30),
    ('Rare Bird Feathers', 'Colorful and exotic feathers from rare birds.', 14.99, 'Crafts', 25),
    ('Exotic Spices', 'Rare spices and seasonings from distant lands.', 8.99, 'Food', 40),
    ('Rare Gemstones', 'Beautiful and precious gemstones from around the world.', 99.99, 'Jewelry', 15),
    ('Exotic Perfume', 'Unique and exotic fragrances for men and women.', 49.99, 'Beauty', 20)
;

-- Заповнення таблиці Клієнти
INSERT INTO Customers (LastName, FirstName, Address, Email, Phone)
VALUES 
    ('Smith', 'John', '123 Main St, Anytown, USA', 'john@example.com', '123-456-7890'),
    ('Doe', 'Jane', '456 Elm St, Othertown, USA', 'jane@example.com', '456-789-0123'),
    ('Johnson', 'Bob', '789 Maple St, Anycity, USA', 'bob@example.com', '789-012-3456'),
    ('Brown', 'Sarah', '789 Oak St, Anothercity, USA', 'sarah@example.com', '012-345-6789'),
    ('Wilson', 'Tom', '101 Pine St, Yetanothercity, USA', 'tom@example.com', '345-678-9012'),
    ('Martinez', 'Maria', '111 Cedar St, Finalcity, USA', 'maria@example.com', '678-901-2345')
;

-- Заповнення таблиці Замовлення
INSERT INTO Orders (CustomerID, OrderDate, OrderStatus)
VALUES 
    (1, '2024-03-07', 'Processing'),
    (2, '2024-03-07', 'Shipped'),
    (3, '2024-03-06', 'Delivered'),
    (4, '2024-03-05', 'Delivered'),
    (5, '2024-03-04', 'Processing'),
    (6, '2024-03-03', 'Shipped')
;

-- Заповнення таблиці Деталі_замовлення
INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES 
    (1, 1, 2, 5.99),
    (2, 3, 1, 19.99),
    (3, 2, 3, 29.99),
    (4, 5, 1, 14.99),
    (5, 3, 2, 99.99),
    (6, 2, 1, 8.99)
;

-- Заповнення таблиці Категорії_товарів
INSERT INTO ProductCategories (CategoryName, CategoryDescription)
VALUES 
    ('Fruits', 'Exotic and rare fruits from around the world.'),
    ('Plants', 'Rare and exotic plants for your home or garden.'),
    ('Pets', 'Exotic pets and rare species for pet lovers.'),
    ('Beverages', 'Rare and unique beverages from distant lands.'),
    ('Crafts', 'Exotic materials for crafting and artistic projects.'),
    ('Food', 'Rare and unique food items from diverse cultures.'),
    ('Jewelry', 'Exquisite jewelry pieces made from rare gemstones.'),
    ('Beauty', 'Exotic beauty products and fragrances for personal care.')
;
