use coffeeApplication
go
Create proc USP_Login
@UserName nvarchar(100), @Password nvarchar(100)
As
Begin
	SELECT * from Users where UserName = @UserName and Password = @Password
end