Use ServerDB;
Create Table Users(
	ID INT PRIMARY KEY IDENTITY,
    	UserName VARCHAR(30),
	UserLogin  VARCHAR(30) NOT NULL
);
Create Table Orders(
	ID INT PRIMARY KEY IDENTITY,
	IDUser INT,
	CreationDate DATE,
	OrderPrice INT
)
Create Table Products(
	ID INT PRIMARY KEY IDENTITY,
	ProductName VARCHAR(30),
	Price INT,
	ProductQuantity INT
)
Create Table OrderItem(
	ID INT PRIMARY KEY IDENTITY,
	OrderID INT,
	ProductID INT,
	ProductQuantity INT
)

ALTER TABLE OrderItem ADD CONSTRAINT FK_OrderItem_Products 
FOREIGN KEY (ProductID) REFERENCES Products(ID);
ALTER TABLE OrderItem ADD CONSTRAINT FK_OrderItem_Orders 
FOREIGN KEY (OrderID) REFERENCES Orders(ID);
ALTER TABLE Orders ADD CONSTRAINT FK_Orders_Users 
FOREIGN KEY (IDUser) REFERENCES Users(ID);
INSERT INTO Products (ProductName,Price,ProductQuantity) Values('Book',350,12);
INSERT INTO Products (ProductName,Price,ProductQuantity) Values('Hat',450,7);
INSERT INTO Products (ProductName,Price,ProductQuantity) Values('Pen',30,20);
INSERT INTO Products (ProductName,Price,ProductQuantity) Values('Pencil',25,25);
INSERT INTO Products (ProductName,Price,ProductQuantity) Values('Shorts',490,7);
INSERT INTO Users (UserName,UserLogin) Values('user','user');
INSERT INTO Users (UserName,UserLogin) Values('Athens','Greece');
INSERT INTO Users (UserName,UserLogin) Values('Berlin','Germany');
INSERT INTO Users (UserName,UserLogin) Values('name','login');