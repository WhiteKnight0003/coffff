use coffeeApplication
go


-- Stored Procedure 

-- User
Create proc USP_Login
@UserName nvarchar(100), @Password nvarchar(100), @Phone nvarchar(100)
As
Begin
	SELECT * from Users where ( UserName = @UserName or Phone = @Phone ) and Password = @Password
end

Create proc USP_UserName 
@UserName nvarchar(100)
As 
BEgin
	select * from users where UserName=@username
end

create proc USP_Email
@Email nvarchar(100)
as
begin
	Select * from Users where Email = @Email
end

create proc USP_Phone
@Phone nvarchar(100)
as
begin
	Select * from Users where Phone = @Phone
end

create proc USP_Users
as
begin
	select * from Users
end



-- table 
create proc USP_Tables
as
begin
	select * from Tablee
end


-- product
create proc USP_Products
as
begin
	select * from Product
end

create proc USP_Roleid
@RoleID int 
as
begin
	select * from role where  RoleID = @RoleID
end

/*
create proc USP_Statics_year
@year int 
as
begin select * from bill where YEAR(DateCheckOut) = @year
end
*/

/*
DATEFROMPARTS(@year, 1, 1): Tạo ngày đầu tiên của năm dựa trên giá trị tham số @year.
DateCheckOut >= ... AND DateCheckOut < ...: So sánh phạm vi từ ngày đầu tiên của năm @year đến trước
ngày đầu tiên của năm tiếp theo (@year + 1)
*/
CREATE PROC USP_Statics_year
@year INT
AS
BEGIN
    SELECT * 
    FROM bill 
    WHERE DateCheckOut >= DATEFROMPARTS(@year, 1, 1)
    AND DateCheckOut < DATEFROMPARTS(@year + 1, 1, 1);
END



CREATE PROCEDURE USP_GetTotalSoldMonthByProduct
AS
BEGIN
    SELECT p.ID, p.Name, SUM(bd.count) AS TotalSold
    FROM Product p
    INNER JOIN BillDetails bd ON p.ID = bd.ProductID
	inner join Bill b on b.ID = bd.BillID
	where MONTH(b.DateCheckIn) = MONTH(GETDATE())
    GROUP BY p.ID, p.Name
    ORDER BY TotalSold DESC;
END;

exec USP_GetTotalSoldMonthByProduct



CREATE PROCEDURE USP_GetTotalSoldMonthAndYearByProduct
AS
BEGIN
    SELECT p.ID, p.Name, SUM(bd.count) AS TotalSold
    FROM Product p
    INNER JOIN BillDetails bd ON p.ID = bd.ProductID
	inner join Bill b on b.ID = bd.BillID
	where MONTH(b.DateCheckIn) = MONTH(GETDATE()) and YEar(b.DateCheckIn) = YEar(GETDATE())
    GROUP BY p.ID, p.Name
    ORDER BY TotalSold DESC;
END;

exec USP_GetTotalSoldMonthAndYearByProduct