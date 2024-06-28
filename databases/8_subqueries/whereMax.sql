-- Приклад запиту для знаходження назви продукта з максимальною ціною
SELECT ProductName, Price
FROM Products
WHERE Price = (SELECT MAX(Price) FROM Products);