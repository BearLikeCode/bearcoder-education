CREATE TABLE sql8691397.Products (
    ProductID INT PRIMARY KEY AUTO_INCREMENT,
    ProductName VARCHAR(255),
    ProductDescription TEXT,
    Price DECIMAL(10, 2),
    ProductCategory VARCHAR(255),
    StockQuantity INT
);

CREATE TABLE sql8691397.Customers (
    CustomerID INT PRIMARY KEY AUTO_INCREMENT,
    LastName VARCHAR(100),
    FirstName VARCHAR(100),
    Address VARCHAR(255),
    Email VARCHAR(255),
    Phone VARCHAR(20)
);

CREATE TABLE sql8691397.Orders (
    OrderID INT PRIMARY KEY AUTO_INCREMENT,
    CustomerID INT,
    OrderDate DATE,
    OrderStatus VARCHAR(100),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE sql8691397.OrderDetails (
    OrderDetailID INT PRIMARY KEY AUTO_INCREMENT,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    UnitPrice DECIMAL(10, 2),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

CREATE TABLE sql8691397.ProductCategories (
    CategoryID INT PRIMARY KEY AUTO_INCREMENT,
    CategoryName VARCHAR(255),
    CategoryDescription TEXT
);
