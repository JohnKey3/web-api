USE GovorovDB;
GO
create procedure sotrydnikselect
as
select id,id_doljnosti,surname,name,login,password,adress,phone from Sotrydnik