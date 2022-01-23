USE GovorovDB;
GO
create procedure tovarselect
as
select id,name,kolvo,price,description from Tovar