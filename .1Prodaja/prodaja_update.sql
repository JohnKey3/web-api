use GovorovDB
go
create procedure prodaja_update
@Id int
as
Update Prodaja Set id_tovara = 2 where id = @Id