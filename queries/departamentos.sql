-- departamentos
create table departamentos_data(
  id int primary key identity,
  registered_by varchar(250) not null, -- admin que lo registro
  nombre varchar(250) unique,
  register_date varchar(60) DEFAULT CURRENT_TIMESTAMP,
  foreign key (registered_by) references data_admin(clave)
);

select  id, registered_by, nombre, register_date from departamentos_data;
insert into departamentos_data (nombre, registered_by)
				       	Values ('gamesa', 'clave')
delete from departamentos_data where registered_by = 'clave'

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------PROCEDIMIENTOS-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


create proc sp_GestionarDepartamentos
(
@Op							   CHAR(1),
@id							   integer = null,
@registered_by			       varchar(250),
@nombre						   varchar(250)

)
as
Begin
	IF @Op = 'I' --insert
	Begin
		insert into departamentos_data (nombre, registered_by)
				       	Values (@nombre, @registered_by)
	End

	IF @Op = 'U' --update
	Begin
		Update departamentos_data set registered_by = @registered_by, nombre = @nombre
		where id = @id	
	End

	IF @Op = 'D' --delete
	Begin
		delete from departamentos_data  where id = @id
	End

End;


-- Get Departamentos
create proc sp_Get_Departamentos
as
select 				   
id,							
registered_by,			      
nombre,
register_date

from departamentos_data
order by register_date asc
go

