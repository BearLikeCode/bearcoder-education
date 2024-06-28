-- Приклад запиту для отримання списку товарів з категорії "Exotic Spices" або "Exotic Perfume"
SELECT * FROM Exotic_or_Rare_Goods_Store.Products WHERE ProductName = 'Exotic Spices' OR ProductName = 'Exotic Perfume';
