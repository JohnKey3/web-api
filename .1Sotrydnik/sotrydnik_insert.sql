use GovorovDB
go
create procedure sotrydnik_insert
@id_doljnosti int,
@surname nvarchar(50),
@name nvarchar(50),
@login nvarchar(50),
@password nvarchar(50),
@adress nvarchar(50),
@phone nvarchar(11)
as
Insert Into Sotrydnik Values(@id_doljnosti,@surname,@name,@login,@password,@adress,@phone)