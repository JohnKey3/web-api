use GovorovDB
go
create procedure delete_prodaja
@Id int
as
Delete From Prodaja where id = @Id