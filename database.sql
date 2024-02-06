CREATE DATABASE Restaurant
GO

USE Restaurant
GO


-- Speisen
-- Tisch
-- SpeiseKatagorie
-- Konto
-- Rechnung
-- RechnungInfo

CREATE TABLE Tisch 
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(50) NOT NULL DEFAULT N'unbekannter Tisch',
	status NVARCHAR(50) NOT NULL DEFAULT N'frei'
)
GO

CREATE TABLE Konto
(
	UserName NVARCHAR(50) PRIMARY KEY,
	DisplayName NVARCHAR(50) NOT NULL DEFAULT N'unbekannt',
	Passwort NVARCHAR(50)NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0 --1:Chef  0:Mitarbeiter
)
GO

CREATE TABLE  SpeiseKatagorie
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(50) NOT NULL DEFAULT N'unbenennt'
)
GO

CREATE TABLE Speisen
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(50) NOT NULL DEFAULT N'unbenennt',
	idKategorie INT NOT NULL,
	price FLOAT NOT NULL

	FOREIGN KEY (idKategorie) REFERENCES dbo.SpeiseKatagorie(id)
)
GO
-- Tạo bảng Rechnung
ALTER TABLE Rechnung
(
    id INT IDENTITY PRIMARY KEY,
    DateCheckIn DATE NOT NULL,
    dateCheckOut DATE,
    idTisch INT NOT NULL,
    status INT NOT NULL DEFAULT 0, -- 1: Bezahlt 0: Unbezahlt

    FOREIGN KEY (idTisch) REFERENCES dbo.Tisch(id)
);

CREATE TABLE RechnungInfo
(
	id INT IDENTITY PRIMARY KEY,
	idRechnung INT NOT NULL,
	idSpeisen INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idRechnung) REFERENCES dbo.Rechnung(id),
	FOREIGN KEY (idSpeisen) REFERENCES dbo.Speisen(id)
)
GO


USE Restaurant
GO

INSERT INTO dbo.Konto (UserName,DisplayName,Passwort,Type)
VALUES (N'vuoiper',N'Trieu Phi Vu',1,1),
	   (N'Kteam',N'Long',0,0)
GO

SELECT * from dbo.Konto where UserName = N'vuoiper' and Passwort = N'1'
GO

-- store procedure
CREATE PROC USP_Login
@userName nvarchar(50), @passWort nvarchar(50)
AS 
BEGIN
	SELECT * FROM dbo.Konto WHERE UserName = @userName AND Passwort = @passWort
END
GO

-- Hinzufügen Daten in Table Tabelle
DECLARE @i INT = 11
WHILE @i <= 50
BEGIN 
	INSERT INTO dbo.Tisch (name,status) VALUES (N'Tisch '+CAST(@i AS nvarchar(50)),N'frei')
	SET @i = @i + 1
END

select * from dbo.Tisch
go

create proc USP_GetTableList
AS Select * from dbo.Tisch
go

Exec dbo.USP_GetTableList

update dbo.Tisch set status = N'frei' where id = 4

delete 

-- Kategorie Hinzuefugen
INSERT INTO dbo.SpeiseKatagorie(name)
VALUES
    (N'Hải Sản'),
    (N'Nông Sản'),
    (N'Lâm Sản'),
    (N'Sản Sản'),
    (N'Nước');

-- Speisen Hinzufuegen
insert into dbo.Speisen(name,idKategorie,price)
values 
	(N'mực một nắng',1,20),
	(N'Nghêu hấp xả',1,50),
	(N'vú dê nướng',2,30),
	(N'Heo rừng nướng mọi',3,40),
	(N'Cơm chiên mushi',4,15),
	(N'Bia',5,5.5),
	(N'Chanh Đá',5,6.5);

-- Bill Hinzufuegen
	insert into dbo.Rechnung(DateCheckIn,dateCheckOut,idTisch,status)
	values 
		(GETDATE(),null,1,0),
		(GETDATE(),null,2,0),
		(GETDATE(),null,2,0),
		(GETDATE(),null,3,0
		);

-- RechnungInfo Hinzufuegen
	insert into dbo.RechnungInfo (idRechnung,idSpeisen,count)
	values 
		(1,1,2),
		(1,3,4),
		(1,5,1),
		(2,5,2),
		(2,1,2),
		(3,5,2);


select * from dbo.Rechnung;
select * from dbo.RechnungInfo;
select * from dbo.SpeiseKatagorie;
select * from dbo.Speisen;
select * from dbo.Tisch;


Go

use Restaurant
select s.name, ri.count, s.price, s.price*ri.count as totalprice  from dbo.RechnungInfo as ri , dbo.Rechnung as r, dbo.Speisen as s
where ri.idRechnung = r.id and ri.idSpeisen = s.id and r.status= 0 and r.idTisch = 2

DECLARE @i INT = 1
WHILE @i <= 50
BEGIN 
	Update dbo.Tisch set name = N'Tisch '++CAST(@i AS nvarchar(50)) where id = @i
	SET @i = @i + 1
END

use Restaurant
select * from dbo.Speisen where id = 1

select * from dbo.SpeiseKatagorie

--Insert bill
create proc USP_InsertBill
@idTable int
as
begin
	insert into dbo.Rechnung(dateCheckIn,dateCheckOut,idTisch,status,rabatt)
	values (GETDATE(),NULL,@idTable,0,0)
end

select * from Rechnung where idTisch = 8
use Restaurant
select max(id) from dbo.Rechnung

ALTER PROCEDURE USP_InsertBillInfo
    @idBill INT,
    @idFood INT,
    @count INT
AS
BEGIN
    DECLARE @isExistsBillInfo INT;
    DECLARE @FoodCount INT = 1;

    -- Kiểm tra xem đã có thông tin hóa đơn cho món ăn này chưa
    SELECT @isExistsBillInfo = id, @FoodCount = count
    FROM dbo.RechnungInfo
    WHERE idRechnung = @idBill AND idSpeisen = @idFood;

    IF (@isExistsBillInfo > 0)
    BEGIN
        -- Nếu đã tồn tại, cập nhật số lượng
        DECLARE @newCount INT = @FoodCount + @count;

        IF (@newCount > 0)
            UPDATE dbo.RechnungInfo
            SET count = @newCount
            WHERE idRechnung = @idBill and idSpeisen = @idFood;
        ELSE
            DELETE dbo.RechnungInfo
            WHERE idRechnung = @idBill AND idSpeisen = @idFood;
    END
    ELSE
    BEGIN
        -- Nếu chưa tồn tại, thêm mới
        INSERT INTO dbo.RechnungInfo (idRechnung, idSpeisen, count)
        VALUES (@idBill, @idFood, @count);
    END
END

alter trigger UTG_UpdateBillInfo
on dbo.RechnungInfo for insert, update
as
begin
	declare @idBill int

	select @idBill = idRechnung from inserted

	declare @idTable int

	select @idTable = idTisch from dbo.Rechnung where id = @idBill and status = 0
	
	update dbo.Tisch set status = N'besetzt' where id = @idTable
end
go



select * from dbo.RechnungInfo
select * from dbo.Rechnung
select * from dbo.Speisen
select * from dbo.SpeiseKatagorie

delete dbo.Rechnung
delete dbo.RechnungInfo
update dbo.Rechnung set status = 0 where idTisch = 8 or idTisch = 13
alter trigger UTG_UpdateBill
on dbo.Rechnung for update
as
begin
	declare @idBill int

	select @idBill = id from inserted

	declare @idTable int

	select @idTable = idTisch from dbo.Rechnung where id = @idBill

	declare @count int = 0

	select @count = COUNT(*) from dbo.Rechnung where idTisch = @idTable and status = 0

	if(@count = 0)
		update dbo.Tisch set status = N'frei' where id = @idTable
end
go

update Rechnung set rabatt = 0