use GovorovDB
go
create procedure tovardelete
@Id int
as
Delete From Tovar where id = @Id