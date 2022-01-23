use GovorovDB
go
create procedure delete_sotrydnik
@Id int
as
Delete From Sotrydnik where id = @Id