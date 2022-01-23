use GovorovDB
go
create procedure prodaja_insert
@id_tovara int,
@id_sotrydnika int,
@kolvo int,
@price int
as
Insert Into Prodaja Values(@id_tovara,@id_sotrydnika,@kolvo,@price)