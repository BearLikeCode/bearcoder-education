-- Приклад використання підзапиту у класі FROM для вибору кількості замовлень для кожного клієнта
SELECT CustomerID, OrderCount
FROM (
    SELECT CustomerID, COUNT(*) AS OrderCount
    FROM Orders
    GROUP BY CustomerID
) AS Subquery;
