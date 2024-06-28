-- Приклад запиту для відображення клієнтів з кількістю замовлень більше ніж 5
SELECT CustomerID, COUNT(*) AS OrderCount
FROM Orders
GROUP BY CustomerID
HAVING COUNT(*) > 2;
