-- Create the database
CREATE DATABASE coffeeApplication;
GO

USE coffeeApplication;
GO

-- Table structure for `bill`
IF OBJECT_ID('bill', 'U') IS NOT NULL
    DROP TABLE bill;
GO

CREATE TABLE bill (
    ID INT IDENTITY PRIMARY KEY,
    DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
    DateCheckOut DATE NULL,
    status NVARCHAR(50) COLLATE Latin1_General_100_CI_AS_SC_UTF8 NULL,
    CustomerID INT NOT NULL,
    UserID INT NOT NULL,
    TableID INT NOT NULL,
    PaymentID INT NOT NULL
);
GO

-- Table structure for `billdetails`
IF OBJECT_ID('billdetails', 'U') IS NOT NULL
    DROP TABLE billdetails;
GO

CREATE TABLE billdetails (
    ID INT IDENTITY PRIMARY KEY,
    Count INT NOT NULL DEFAULT 0,
    BillID INT NOT NULL,
    ProductID INT NOT NULL
);
GO

-- Table structure for `category`
IF OBJECT_ID('category', 'U') IS NOT NULL
    DROP TABLE category;
GO

CREATE TABLE category (
    ID INT IDENTITY PRIMARY KEY,
    CategoryName NVARCHAR(255) COLLATE Latin1_General_100_CI_AS_SC_UTF8 NOT NULL,
    Description NVARCHAR(255) NULL
);
GO

-- Table structure for `customer`
IF OBJECT_ID('customer', 'U') IS NOT NULL
    DROP TABLE customer;
GO

CREATE TABLE customer (
    ID INT IDENTITY PRIMARY KEY,
    name NVARCHAR(50) COLLATE Latin1_General_100_CI_AS_SC_UTF8 NOT NULL,
    phone NVARCHAR(50) NULL,
);
GO

-- Table structure for `payment`
IF OBJECT_ID('payment', 'U') IS NOT NULL
    DROP TABLE payment;
GO

CREATE TABLE payment (
    ID INT IDENTITY PRIMARY KEY,
    PaymentName NVARCHAR(50) COLLATE Latin1_General_100_CI_AS_SC_UTF8 NOT NULL UNIQUE
);
GO

-- Table structure for `product`
IF OBJECT_ID('product', 'U') IS NOT NULL
    DROP TABLE product;
GO

CREATE TABLE product (
    ID INT IDENTITY PRIMARY KEY,
    Price FLOAT NOT NULL,
    Name NVARCHAR(50) COLLATE Latin1_General_100_CI_AS_SC_UTF8 NOT NULL UNIQUE,
    Description NVARCHAR(255) COLLATE Latin1_General_100_CI_AS_SC_UTF8 NULL,
    Image NVARCHAR(max) NULL,
    CategoryID INT NOT NULL
);
GO

-- Table structure for `role`
IF OBJECT_ID('role', 'U') IS NOT NULL
    DROP TABLE role;
GO

CREATE TABLE role (
    RoleID INT IDENTITY PRIMARY KEY,
    RoleName NVARCHAR(50) COLLATE Latin1_General_100_CI_AS_SC_UTF8 NOT NULL,
	Creator Nvarchar(50) COLLATE Latin1_General_100_CI_AS_SC_UTF8 null
);
GO

-- Table structure for `tablee`
IF OBJECT_ID('tablee', 'U') IS NOT NULL
    DROP TABLE tablee;
GO

CREATE TABLE tablee (
    ID INT IDENTITY PRIMARY KEY,
    TableName NVARCHAR(255)  NOT NULL,
    Status NVARCHAR(255) COLLATE Latin1_General_100_CI_AS_SC_UTF8 NULL
);
GO

-- Table structure for `users` (renamed from `user`)
IF OBJECT_ID('users', 'U') IS NOT NULL
    DROP TABLE users;
GO

CREATE TABLE users (
    ID INT IDENTITY PRIMARY KEY,
    UserName NVARCHAR(50) NOT NULL,
    phone NVARCHAR(20) not NULL,
    address NVARCHAR(100) COLLATE Latin1_General_100_CI_AS_SC_UTF8 NULL,
    DateWork DATE NOT NULL DEFAULT GETDATE(),
    password NVARCHAR(Max) NOT NULL,
    FullName NVARCHAR(50)  COLLATE Latin1_General_100_CI_AS_SC_UTF8 Null,
    RoleID INT NOT NULL,
    codeEmail NVARCHAR(45) NULL,
    statusEmail NVARCHAR(20) COLLATE Latin1_General_100_CI_AS_SC_UTF8  NULL,
    email NVARCHAR(45) NOT NULL,
    gender NVARCHAR(50) NULL,
    image Nvarchar(max) NULL
);
GO


-- Add foreign keys
ALTER TABLE bill
ADD CONSTRAINT FK_bill_customer FOREIGN KEY (CustomerID) REFERENCES customer(ID),
    CONSTRAINT FK_bill_users FOREIGN KEY (UserID) REFERENCES users(ID),
    CONSTRAINT FK_bill_tablee FOREIGN KEY (TableID) REFERENCES tablee(ID),
    CONSTRAINT FK_bill_payment FOREIGN KEY (PaymentID) REFERENCES payment(ID);
GO

ALTER TABLE billdetails
ADD CONSTRAINT FK_billdetails_bill FOREIGN KEY (BillID) REFERENCES bill(ID),
    CONSTRAINT FK_billdetails_product FOREIGN KEY (ProductID) REFERENCES product(ID);
GO

ALTER TABLE product
ADD CONSTRAINT FK_product_category FOREIGN KEY (CategoryID) REFERENCES category(ID);
GO

ALTER TABLE users
ADD CONSTRAINT FK_users_role FOREIGN KEY (RoleID) REFERENCES role(RoleID);
GO

-- Turn IDENTITY_INSERT ON
SET IDENTITY_INSERT dbo.role ON;
USE coffeeApplication;
GO
-- Insert data into role table
INSERT INTO role (RoleID, RoleName) 
VALUES 
    (0, N'Quản Lý'),
    (1, N'Nhân Viên');
SET IDENTITY_INSERT dbo.role OFF;

USE coffeeApplication;
GO


-- Insert data into users table
INSERT INTO users (UserName, FullName, Password, Phone, email,codeEmail,statusEmail, Gender, RoleID) 
VALUES
    (N'TienChung', N'Lê Tiến Chung', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', N'0384905333',N'tienchung2612@gmail.com',N'123456',N'True', N'Female', 1);



-- DROP PROCEDURE IF EXISTS USP_Login
--go 

Create proc USP_Login
@UserName nvarchar(100), @Password nvarchar(100), @Phone nvarchar(100)
As
Begin
	SELECT * from Users where ( UserName = @UserName or Phone = @Phone ) and Password = @Password
end


insert into category (CategoryName, Description) values (N'Tôm',N'Loại thức ăn từ biển');
insert into category (CategoryName, Description) values (N'Cá',N'Loại thức ăn từ biển');
insert into category (CategoryName, Description) values (N'Bò',N'Loại thức ăn từ biển');

insert into product (Price, Name,Description, Image,CategoryID) values (100000, N'Tôm chiên', N'dsadasdas', '',1)
insert into product (Price, Name,Description, Image,CategoryID) values (100000, N'Cá chiên', N'dsadasdas', '',2)
insert into product (Price, Name,Description, Image,CategoryID) values (100000, N'Bò chiên', N'dsadasdas', '',3)

insert into tablee (TableName, Status) values (N'Bàn', N'Trống')
insert into tablee (TableName, Status) values (N'Bàn', N'Trống')
insert into tablee (TableName, Status) values (N'Bàn', N'Trống')
insert into tablee (TableName, Status) values (N'Bàn', N'Trống')
insert into tablee (TableName, Status) values (N'Bàn', N'Trống')
insert into tablee (TableName, Status) values (N'Bàn', N'Trống')
insert into tablee (TableName, Status) values (N'Bàn', N'Trống')
insert into tablee (TableName, Status) values (N'Bàn', N'Trống')