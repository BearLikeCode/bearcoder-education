-- Приклад запиту для підрахунку кількості замовлень для кожного клієнта
SELECT CustomerID, COUNT(*) AS OrderCount
FROM Orders
GROUP BY CustomerID;
