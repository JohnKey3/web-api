USE GovorovDB;
GO
create procedure tovarget
@id int
as
select id,name,kolvo,price,description from Tovar where id=@id