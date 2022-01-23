USE GovorovDB;
GO
create procedure prodajaget
@id int
as
select id,id_tovara,id_sotrydnika,kolvo,price from Prodaja where id=@id