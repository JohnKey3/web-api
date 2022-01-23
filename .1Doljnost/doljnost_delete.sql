use GovorovDB
go
create procedure doljnostdelete
@Id int
as
Delete From Doljnost where id = @Id