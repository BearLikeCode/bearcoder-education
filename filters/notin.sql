-- Приклад запиту для отримання списку товарів, які не належать до категорії "Exotic Spices"
SELECT * FROM Products WHERE ProductCategory NOT IN ('Exotic Spices');
