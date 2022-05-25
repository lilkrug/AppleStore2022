Use master;
Create Database Kursovoi;
Use Kursovoi;

Create Table Users
(
Id int constraint PK_USERS primary key(Id) identity(1,1),
Login nvarchar(50) NOT NULL Unique,
Password nvarchar(50) NOT NULL Unique
)

Create Table Goods
(
Id int constraint PK_GOODS primary key(Id) identity(1,1),
Name nvarchar(50) NOT NULL,
Category nvarchar(50) NOT NULL,
Price int default '0' NOT NULL,
Country nvarchar(50) NOT NULL,
Description nvarchar(50) NOT NULL,
ImageId int NOT NULL constraint FK_GOODS_DATA_GOODS foreign key (ImageId) references Images(ImageId)
)

Create Table Images
(
ImageId int constraint PK_IMAGES primary key(ImageId) identity(1,1),
Picture varbinary NOT NULL,
Path nvarchar(50) NOT NULL
)

Create Table Orders
(
Id int constraint PK_ORDERS primary key(Id) identity(1,1),
GoodId int NOT NULL constraint FK_ORDERS_DATA_ORDERS foreign key (GoodId) references Goods(Id),
UserId int NOT NULL constraint FK_ORDERS_DATA_ORDERS foreign key (UserId) references Users(Id)
)

Create Table Supports
(
Id int constraint PK_ORDERS primary key(Id) identity(1,1),
Email nvarchar(50) NOT NULL,
Subject nvarchar(50) NOT NULL,
Message nvarchar(50) NOT NULL
)
