use GovorovDB
go
create procedure tovarupdate
@Id int
as
Update Tovar Set price = 1337 where id = @Id