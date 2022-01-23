USE GovorovDB;
GO
create procedure doljnost_get
@id int
as
select id,name from Doljnost where id=@id