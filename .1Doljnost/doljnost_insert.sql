use GovorovDB
go
create procedure doljnost_insert
@name nvarchar(50)
as
Insert Into Doljnost Values(@name)