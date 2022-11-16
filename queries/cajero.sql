create table data_cajero(
    clave varchar(250) primary key,
	registered_by varchar(250) not null, -- admin que lo registro
	nombre varchar(250) not null,
	register_date varchar(60) DEFAULT CURRENT_TIMESTAMP,
	curp varchar(250) not null unique,
	fecha_nacimiento varchar(250) not null,
	nomina varchar(250) not null unique
	foreign key (registered_by) references data_admin(clave)
);

INSERT INTO data_cajero(clave,registered_by, nombre,curp,fecha_nacimiento,nomina)
VALUES('1','Admin1', 'alan', 'alancurp', '21/08/22','123456781234966');
select * from data_cajero;
drop table data_cajero;
delete from data_cajero where clave = '0x32a0'

-- ---------------------------------------------------------------------------------------------------------------------
create table login_cajero(
	clave varchar(250) not null,
    status_ bit DEFAULT 1,
	correo varchar(250) not null unique,
	contra varchar(250) not null,
    foreign key (clave) references data_cajero(clave)
);

INSERT INTO login_admin (clave, correo, contra)
VALUES ('1', 'david@hotmail.com', 'davidxd');

select * from login_cajero;
drop table login_cajero;

-- ---------------------------------------------------------------------------------------------------------------------
create table cajero_modifications(

    by_who varchar(250) not null, -- admin
    clave_cajero varchar(250) not null,
	last_modification varchar(60) DEFAULT CURRENT_TIMESTAMP,
    what varchar(250) not null,-- que movio?
	foreign key (by_who) references data_admin(clave)
);

select * from cajero_modifications
delete from cajero_modifications where by_who = 'clave';
drop table cajero_modifications;



-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------PROCEDIMIENTOS-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--Gestionar Cajero
If OBJECT_ID ('sp_GestionarCajero') is not null
	Drop procedure sp_GestionarCajero;
go
create proc sp_GestionarCajero
(
@Op							   CHAR(1),
--Tabla Data Cajero
@clave						   varchar(250),
@registered_by				   varchar(250),
@nombre						   varchar(250),
@curp						   varchar(250),
@fecha_nacimiento              varchar(250),
@nomina                        varchar(250),
--Tabla Login Cajero
@correo						   varchar(250),
@contra						   varchar(250)
)
as
Begin
	IF @Op = 'I' --insert
	Begin
		insert into data_cajero (clave,registered_by,nombre, curp, fecha_nacimiento,nomina)
								 values (@clave,@registered_by,@nombre,@curp,@fecha_nacimiento,@nomina)
		insert into login_cajero (clave,correo, contra) 
					values (@clave,@correo, @contra)
	End

    IF @Op = 'U' --update
	Begin
		update data_cajero set registered_by = @registered_by, nombre = @nombre, curp = @curp, fecha_nacimiento = @fecha_nacimiento, nomina = @nomina
		where clave = @clave
		update login_cajero set correo = @correo, contra = @contra
		where clave = @clave
	End

	IF @Op = 'D' --delete
	Begin
		delete from login_cajero where clave = @clave
		delete from data_cajero  where clave = @clave
	End

   IF @Op = 'B' --baja lógica
   BEGIN
      UPDATE login_cajero 
         SET 
	           status_ = 0
		 WHERE clave = @clave
   END

       IF @Op = 'F' --update fecha de nacimiento
	Begin
		update data_cajero set fecha_nacimiento = @fecha_nacimiento
		where clave = @clave
	End


End;
go

exec Insert_Cajero 'asda', 'moller', 'panchito', 'panchocurp', '01/04/993', 'nomina123','pancho@gmail.com','12345';
exec Get_Cajero

-- Get Cajero 
If OBJECT_ID ('sp_Get_Cajero') is not null
	Drop procedure sp_Get_Cajero;
go

create proc sp_Get_Cajero
as
select 
[Codigo de Cajero],
[Quien lo Registra],
[Cajero],
[Fecha de Registro],
[CURP],
[Fecha de Nacimiento],
[Numero de Nomina],
[Correo],
[Contraseña]
from vw_GetCajero 
order by [Fecha de Registro] asc
go

--View Cajero
CREATE VIEW vw_GetCajero AS 
select  d.clave as 'Codigo de Cajero',
		d.registered_by as 'Quien lo Registra',
		d.nombre as 'Cajero',
		d.register_date as 'Fecha de Registro',
		d.curp as 'CURP',
		d.fecha_nacimiento as 'Fecha de Nacimiento',
		d.nomina as 'Numero de Nomina',
		l.correo as 'Correo',
		l.contra as 'Contraseña'
	from data_cajero d
	inner join login_cajero l
	on d.clave = l.clave
go

--Login_Cajero
If OBJECT_ID ('sp_Login_Cajeros') is not null
	Drop procedure sp_Login_Cajeros;
go

create proc sp_Login_Cajeros
@correo varchar (50)
as
select contra,
	   correo,
	   clave

from  login_cajero
where  correo=@correo
go

----Eliminar Cajero
--create proc sp_Eliminar_Cajero
--@clave varchar(255)
--as
--delete from login_cajero  where clave = @clave
--delete from data_cajero  where clave = @clave
--go

--exec Eliminar_Cajero 'asda';
--delete from data_cajero where clave = 'juanito'

--create proc Validar_que_no_se_elimine_Cajero_si_es_admin
--@Parametro varchar(100),
--@Existe bit output
--as
--if exists (select Encargado from SucursalEncargado where Encargado = ltrim(rtrim(@Parametro)))
--begin
--set @Existe=1
--end
	
--else
--begin
--set @Existe=0
--end


--- trigger update
If OBJECT_ID ('trg_cajeroMod_Update') is not null
	Drop Trigger trg_cajeroMod_Update;
go

Create Trigger trg_cajeroMod_Update
on data_cajero 
After update
as
begin
Declare @clave_cajero varchar(250), 
@by_who varchar(250),
@what varchar(250)


set @clave_cajero = (select clave from  inserted)
set @by_who = (select registered_by from inserted)
set @what =  (select concat('Nombre(s): ',nombre, ', Curp: ',curp, ', Fecha de nacimiento: ', 
            fecha_nacimiento, ', Nomina: ', nomina) from deleted)

insert into cajero_modifications (clave_cajero, by_who, what) values (@clave_cajero, @by_who, @what)

select clave_cajero, by_who, what from cajero_modifications
end

--- trigger Delete
If OBJECT_ID ('trg_cajeroMod_Delete') is not null
	Drop Trigger trg_cajeroMod_Delete;
go

Create Trigger trg_cajeroMod_Delete
on data_cajero 
After delete
as
begin
Declare @clave_cajero varchar(250);

select @clave_cajero = clave_cajero from cajero_modifications;

 delete from cajero_modifications  where clave_cajero = @clave_cajero;

end


delete from cajero_modifications  where clave_cajero = 'd078d5'
delete from cajero_modifications where by_who = 'clave';


--if clave (, ) is not null
--Drop proc Update_Cajero
--go

--create proc Update_Cajero
--@clave varchar(250),
--@nombre varchar(250),
--@curp varchar(250),
--@fecha_nacimiento varchar(250),
--@nomina varchar(250),
---- login_cajero
--@correo varchar(250),
--@contra varchar(250)
--as 
--begin
--set nocount on;
--update data_cajero set nombre = @nombre, curp = @curp, fecha_nacimiento = @fecha_nacimiento, nomina = @nomina
--where clave = @clave
--update login_cajero set correo = @correo, contra = @contra
--where clave = @clave
--end
--go

If OBJECT_ID ('sp_Get_ModCajero') is not null
	Drop procedure sp_Get_ModCajero;
go

create proc sp_Get_ModCajero
as
select 
[Codigo de Cajero],
[Quien lo Registra],
[Cambios],
[Ultimo Registro]

from vw_Get_ModCajero
order by [Ultimo Registro] asc
go


If OBJECT_ID ('vw_Get_ModCajero') is not null
	Drop View vw_Get_ModCajero;
go

CREATE VIEW vw_Get_ModCajero AS 
select  clave_cajero as 'Codigo de Cajero',
		by_who as 'Quien lo Registra',
		what as 'Cambios',
		last_modification as 'Ultimo Registro'
		from cajero_modifications

go
