use GovorovDB
go
create procedure sotrydnik_update
@Id int
as
Update Sotrydnik Set name = '������' where id = @Id