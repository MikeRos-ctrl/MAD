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

INSERT INTO `Dmarket`.`data_cajero`(`clave`,`nombre`,`curp`,`fecha_nacimiento`,`fecha_ingreso`,`nomina`)
VALUES('clave_Cajero_1', 'alan', 'alancurp', '21/08/22', '21/08/22','123456781234966');
select * from data_cajero;
drop table data_cajero;

-- ---------------------------------------------------------------------------------------------------------------------
create table login_cajero(
	clave varchar(250) not null,
    status_ bit DEFAULT 1,
	correo varchar(250) not null unique,
	contra varchar(250) not null,
    foreign key (clave) references data_cajero(clave)
);

INSERT INTO `mad`.`login_admin` (`clave`, `correo`, `contra`)
VALUES ('qwer', 'david@hotmail.com', 'davidxd');

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
		delete from login_cajero  where clave = @clave
		delete from data_cajero  where clave = @clave
	End

End;
go

exec Insert_Cajero 'asda', 'moller', 'panchito', 'panchocurp', '01/04/993', 'nomina123','pancho@gmail.com','12345';
exec Get_Cajero


create proc sp_Get_Cajero
as
select 
d.clave,
d.registered_by,
d.nombre,
d.register_date,
d.curp,
d.fecha_nacimiento,
d.nomina,
l.correo,
l.contra
from data_cajero d
inner join login_cajero l
on d.clave = l.clave
order by d.register_date asc
go

--Login_Cajero

create proc sp_Login_Cajeros
@correo varchar (50)
as
select contra
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

drop trg_cajeroMod_Update
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

insert into cajero_modifications(by_who, clave_cajero, what) values ('clave','clave del morre3','sii');
exec Update_Cajero 'clave del morre3', 'mariana', 'marianacurp', '24/10/1998', '43424322', 'aaaa', '1234'
go

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

create proc sp_Get_ModCajero
as
select 
by_who,
clave_cajero,
last_modification,
what

from cajero_modifications
order by last_modification asc
go