
alter PROC [dbo].[USP_InsertBill]
@idTable INT, @userID int
AS
BEGIN
	INSERT dbo.Bill 
	        ( DateCheckIn ,
	          DateCheckOut ,
	          TableID ,
	          status,
	          discount,
			  UserID
	        )
	VALUES  ( GETDATE() , -- DateCheckIn - date
	          NULL , -- DateCheckOut - date
	          @idTable , -- idTable - int
	          0,  -- status - int
	          0,
			  @userID -- userid int
	        )
END
GO

Create PROC [dbo].[USP_GetListBillByDate]
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT t.TableName AS [Tên bàn], b.TotalBill AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá]
	FROM dbo.Bill AS b,dbo.tablee AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.TableID
END

Create PROC [dbo].[USP_GetListBillByDateAndPage]
@checkIn date, @checkOut date, @page int
AS 
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1) * @pageRows
	
	;WITH BillShow AS( SELECT b.ID, t.TableName AS [Tên bàn], b.TotalBill AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá]
	FROM dbo.Bill AS b,dbo.tablee AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.TableID)
	
	SELECT TOP (@selectRows) * FROM BillShow WHERE id NOT IN (SELECT TOP (@exceptRows) id FROM BillShow)
END

Create PROC [dbo].[USP_GetNumBillByDate]
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT COUNT(*)
	FROM dbo.Bill AS b,dbo.tablee AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.TableID
END

alter PROC [dbo].[USP_InsertBillInfo]
@idBill INT, @idFood INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @isExitsBillInfo = id, @foodCount = b.count 
	FROM dbo.billdetails AS b 
	WHERE BillID = @idBill AND ProductID = @idFood

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.billdetails	SET count = @foodCount + @count WHERE ProductID = @idFood and BillID = @idBill
		ELSE
			DELETE dbo.billdetails WHERE BillID = @idBill AND ProductID = @idFood
	END
	ELSE
	BEGIN
		INSERT	dbo.billdetails
        ( BillID, ProductID, count )
		VALUES  ( @idBill, -- idBill - int
          @idFood, -- idFood - int
          @count  -- count - int
          )
	END
END

alter PROC [dbo].[USP_SwitchTabel]
@idTable1 INT, @idTable2 int, @userID int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE TableID = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE TableID = @idTable1 AND status = 0
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	-- bàn 1 trống, bàn 2 đã có người(thêm hóa đơn của bàn 1)
	IF (@idFirstBill IS NULL)
	BEGIN
		PRINT '0000001'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          TableID ,
		          status,
				  UserID
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable1 , -- idTable - int
		          0,  -- status - int
				  @userID
		        )
		
		-- lấy ra ID mới của hóa đơn sau khi thêm hóa đơn của bàn 1
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE TableID = @idTable1 AND status = 0
		
	END
	
	-- check xem ở bảng billdetails đã có các thành phần món ăn sau khi chuyển từ bàn trống qua bàn có người chưa
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.billdetails WHERE BillID = @idFirstBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	-- bàn 1 có người, bàn 2 trống(thêm hóa đơn của bàn 2)
	IF (@idSeconrdBill IS NULL)
	BEGIN
		PRINT '0000002'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          TableID ,
		          status,
				  UserID
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable2 , -- idTable - int
		          0,  -- status - int
				  @userID
		        )

		-- lấy ra hóa đơn mới sau khi thêm hóa đơn của bàn 2
		SELECT @idSeconrdBill = MAX(id) FROM dbo.Bill WHERE TableID = @idTable2 AND status = 0
		
	END
	
	-- check xem ở bảng billdetails đã có các thành phần món ăn sau khi chuyển từ bàn có người qua bàn trống chưa
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.billdetails WHERE BillID = @idSeconrdBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'

	-- Chuyển đổi hóa đơn chi tiết của từng bàn với nhau:
	-- 4 trường hợp: 
	-- + b1 b2 có người
	-- + b1 trống b2 có người
	-- + b1 có người b2 trống
	-- + b1 b2 trống
	SELECT id INTO IDBillInfoTable FROM dbo.billdetails WHERE BillID = @idSeconrdBill
	
	UPDATE dbo.billdetails SET BillID = @idSeconrdBill WHERE BillID = @idFirstBill
	
	UPDATE dbo.billdetails SET BillID = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	-- bàn 1 ở trong bảng billdetails đã có các thành phần món ăn sau khi chuyển từ bàn trống qua bàn có người chưa
	IF (@isFirstTablEmty = 0)
	Begin
		-- chuyển bàn 1 thành có người, bàn 2 trống
		UPDATE dbo.tablee SET status = N'Trống' WHERE id = @idTable2
		-- xóa đi hóa đơn cũ của bàn có người ban đầu
		delete from bill where TableID = @idTable2 and status = 0 and id = @idSeconrdBill
	End
		
	-- bàn 2 ở trong bảng billdetails đã có các thành phần món ăn sau khi chuyển từ bàn có người qua bàn trống chưa
	IF (@isSecondTablEmty= 0)
	Begin
		-- chuyển bàn 1 thành trống, bàn 2 thành có người
		UPDATE dbo.tablee SET status = N'Trống' WHERE id = @idTable1
		-- xóa đi hóa đơn cũ của bàn có người ban đầu
		delete from bill where TableID = @idTable1 and status = 0 and id = @idFirstBill
	End
END

Create PROC [dbo].[USP_GetTableList]
AS SELECT * FROM dbo.tablee

update tablee 
set TableName = N'Bàn 8'
where id = 9

create proc test
@stt int
as begin
	set @stt = 24
	declare @bd int
	set @bd = 9
	while(@bd <= @stt)
	Begin
		Update tablee
		set Status = N'Trống'
		where Id = @bd
		set @bd = @bd +1
	End
end

exec test @stt = 24;

--Trigger mỗi khi thêm hoặc cập nhật hóa đơn
create trigger UTG_UpdateBillInfo
ON billdetails for insert, update
as
begin
	declare @idBill int

	select @idBill = BillID from inserted

	declare @idTable int

	Select @idTable = TableID from dbo.bill where id = @idBill and status = 0 --nếu chưa checkOut

	declare @count int
	select @count = COUNT(*) from billdetails where BillID = @idBill

	-- cập nhật lại trạng thái bàn 
	if(@count > 0)
	begin
		print @idTable
		print @idBill
		print @count
		update dbo.tablee set status = N'Có người' where id = @idTable
	end
	else 
	begin
		print @idTable
		print @idBill
		print @count
		update dbo.tablee set status = N'Trống' where id = @idTable
	end
end


create TRigger UTG_UpdateBill
on dbo.Bill for update
as
begin
	declare @idBill int

	select @idBill = id from inserted

	declare @idTable int

	Select @idTable = TableID from dbo.bill where id = @idBill

	declare @count int = 0

	select @count = Count(*) from Bill where TableID = @idTable and status = 0

	if(@count = 0)
		update tablee set status = N'Trống' where id = @idTable

end
go

delete from billdetails where BillID = 8
delete from bill where id = 8 or id = 10

