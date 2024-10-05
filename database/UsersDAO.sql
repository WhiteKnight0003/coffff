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


