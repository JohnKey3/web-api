use GovorovDB
go
create procedure tovarinsert
@name nvarchar(50),
@kolvo int,
@price int,
@description nvarchar(50)
as
Insert Into Tovar Values(@name,@kolvo,@price,@description)