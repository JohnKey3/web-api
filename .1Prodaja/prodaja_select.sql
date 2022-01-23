USE GovorovDB;
GO
create procedure prodajaselect
as
select id,id_tovara,id_sotrydnika,kolvo,price from Prodaja