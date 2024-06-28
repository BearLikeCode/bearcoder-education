-- Приклад запиту для отримання списку замовлень, які були доставлені та оброблені в той самий день
SELECT * FROM Orders WHERE OrderStatus = 'Processing' AND OrderDate = '2024-03-07';
