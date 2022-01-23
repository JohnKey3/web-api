USE GovorovDB;
GO
create procedure sotrydnikget
@id int
as
select id,id_doljnosti,surname,name,login,password,adress,phone from Sotrydnik where id=@id