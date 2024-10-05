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
    Name NVARCHAR(50) COLLATE Latin1_General_100_CI_AS_SC_UTF8 NOT NULL,
    Phone NVARCHAR(50) NULL,
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
    UserName NVARCHAR(50) NOT NULL UNIQUE,
	FullName NVARCHAR(50)  COLLATE Latin1_General_100_CI_AS_SC_UTF8 Null,
	password NVARCHAR(Max) NOT NULL,
    phone NVARCHAR(20) not NULL ,
	email NVARCHAR(45) NOT NULL UNIQUE,
	codeEmail NVARCHAR(45) NULL,
    statusEmail NVARCHAR(20) COLLATE Latin1_General_100_CI_AS_SC_UTF8  NULL,
    address NVARCHAR(100) COLLATE Latin1_General_100_CI_AS_SC_UTF8 NULL,
    DateWork DATE NOT NULL DEFAULT GETDATE(), 
    RoleID INT NOT NULL,
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
    (1, N'Quản Lý'),
    (2, N'Nhân Viên');
SET IDENTITY_INSERT dbo.role OFF;


USE coffeeApplication;
GO


-- Insert data into users table
INSERT INTO users (UserName, FullName, Password, Phone, email,codeEmail,statusEmail, Gender, RoleID) 
VALUES
    (N'Admin', N'', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', N'0384905333',N'tienchung2612@gmail.com',N'123456',N'Đã xác thực', N'Female', 1);

-- DROP PROCEDURE IF EXISTS USP_Login
--go 



insert into category (CategoryName, Description) values (N'Cafe',N'Đồ uống được làm ra từ những hạt cafe nguyên chất');
insert into category (CategoryName, Description) values (N'Trà',N'Sự hòa quyện giữa chà và những nguyên liệu tự nhiên khác');
insert into category (CategoryName, Description) values (N'Sinh tố',N'Xay nhuyễn các nguyên liệu để tạo ra đồ uống thơm ngon');
insert into category (CategoryName, Description) values (N'Sữa chua',N'Sự kết hợp giữa Sữa chua và các hương vị mới');
insert into category (CategoryName, Description) values (N'Kem',N'Đồ uống có hương vị mát lạnh');

insert into product (Price, Name,Description, Image,CategoryID) values (25000, N'Nâu đá', N'', '',1)
insert into product (Price, Name,Description, Image,CategoryID) values (25000, N'Đen đá không đường', N'', '',1)
insert into product (Price, Name,Description, Image,CategoryID) values (45000, N'Đào cam sả', N'', '',2)
insert into product (Price, Name,Description, Image,CategoryID) values (45000, N'Đào sả quế', N'', '',2)
insert into product (Price, Name,Description, Image,CategoryID) values (45000, N'Sinh tố bơ', N'', '',3)
insert into product (Price, Name,Description, Image,CategoryID) values (45000, N'Sinh tố xoài', N'', '',3)
insert into product (Price, Name,Description, Image,CategoryID) values (35000, N'Sữa chua cà phê', N'', '',4)
insert into product (Price, Name,Description, Image,CategoryID) values (40000, N'Sữa chua ca cao', N'', '',4)
insert into product (Price, Name,Description, Image,CategoryID) values (30000, N'Kem socola', N'', '',5)

insert into tablee (TableName, Status) values (N'Bàn', N'Trống')
insert into tablee (TableName, Status) values (N'Bàn', N'Trống')
insert into tablee (TableName, Status) values (N'Bàn', N'Trống')
insert into tablee (TableName, Status) values (N'Bàn', N'Trống')
insert into tablee (TableName, Status) values (N'Bàn', N'Trống')
insert into tablee (TableName, Status) values (N'Bàn', N'Trống')
insert into tablee (TableName, Status) values (N'Bàn', N'Trống')
insert into tablee (TableName, Status) values (N'Bàn', N'Trống')

insert into payment (PaymentName) values (N'Tiền mặt')
insert into payment (PaymentName) values (N'Chuyển khoản')
insert into payment (PaymentName) values (N'Quẹt thẻ tín dụng')