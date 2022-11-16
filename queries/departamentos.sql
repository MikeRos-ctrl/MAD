-- departamentos
create table departamentos_data(
  id int identity unique,
  registered_by varchar(250) not null, -- admin que lo registro
  status_ bit DEFAULT 1,
  nombre varchar(250) primary key,
  register_date varchar(60) DEFAULT CURRENT_TIMESTAMP,
  foreign key (registered_by) references data_admin(clave)
);

drop table departamentos_data;
select  id, registered_by, status_, nombre, register_date from departamentos_data;
insert into departamentos_data (nombre, registered_by)
				       	Values ('gamesa', 'clave')
delete from departamentos_data where registered_by = 'clave'


-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------PROCEDIMIENTOS-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

If OBJECT_ID ('sp_GestionarDepartamentos') is not null
	Drop procedure sp_GestionarDepartamentos;
go


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

	  IF @Op = 'B' --baja lógica
    Begin
      Update departamentos_data 
         
		 Set status_ = 0

		 Where id = @id
    End

End;


-- Get Departamentos
If OBJECT_ID ('sp_Get_Departamentos') is not null
	Drop procedure sp_Get_Departamentos;
go

create proc sp_Get_Departamentos
as
select 				   
[Numero de Departamento],							
[Quien lo Registra],			      
Departamento,
[Fecha de Registro]

from vw_GetDepartamentos
order by [Fecha de Registro] asc
go

