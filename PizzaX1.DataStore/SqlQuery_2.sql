-- Target Server: SQL Server
-- Server Version: 2019

-- 
-- Dropping a table Stores 
-- 
DROP TABLE Stores
GO

-- 
-- Dropping a table Pizzas 
-- 
DROP TABLE Pizzas
GO

-- 
-- Dropping a table Orders 
-- 
DROP TABLE Orders
GO

-- 
-- Creating a table Orders 
-- 
CREATE TABLE Orders (
   Name NVARCHAR(4000) NOT NULL,
   Address NVARCHAR(40) NOT NULL,
   payment NVARCHAR(4000) NOT NULL,
   Stores NVARCHAR(20) NOT NULL,
   items NVARCHAR(4000) NOT NULL,
   ordertime DATETIME2 NOT NULL,
   CONSTRAINT PK_Orders PRIMARY KEY (Name, ordertime)
)
GO

-- 
-- Creating a table Stores 
-- 
CREATE TABLE Stores (
   Address NVARCHAR(4000) NOT NULL,
   StoreNo SMALLINT NOT NULL,
   Name NVARCHAR(4000),
   ordertime DATETIME2,
   CONSTRAINT PK_Stores PRIMARY KEY (StoreNo)
   --CONSTRAINT FK_Stores_Orders_0 FOREIGN KEY (Name, ordertime) REFERENCES Orders (Name, ordertime)
)
GO

-- 
-- Creating a table Pizzas 
-- 
CREATE TABLE Pizzas (
   unitcost FLOAT NOT NULL,
   [count] SMALLINT NOT NULL,
   size INT NOT NULL,
   toppings VARBINARY(MAX) NOT NULL,
   Name NVARCHAR(4000),
   crust INT NOT NULL,
   Size SMALLINT NOT NULL,
   Property1 INT NOT NULL,
   CONSTRAINT PK_Pizzas PRIMARY KEY (Property1)
  
)
GO

