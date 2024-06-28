-- Приклад використання підзапиту у класі SELECT для отримання кількості замовлень для кожного клієнта
SELECT CustomerID, FirstName, 
       (SELECT COUNT(*) 
        FROM Orders 
        WHERE Orders.CustomerID = Customers.CustomerID) AS OrderCount
FROM Customers
