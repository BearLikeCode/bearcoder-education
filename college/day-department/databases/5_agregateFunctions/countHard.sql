-- Приклад запиту для підрахунку кількості замовлень для кожного клієнта та сортування результатів за кількістю замовлень у спадаючому порядку
SELECT CustomerID, COUNT(*) AS OrderCount 
FROM Orders 
GROUP BY CustomerID 
ORDER BY OrderCount DESC;
