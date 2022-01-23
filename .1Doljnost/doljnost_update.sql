use GovorovDB
go
create procedure doljnost_update
@Id int,
@name nvarchar(50)
as
Update Doljnost Set name = @name where id = @Id