create schema `MAD`;
USE `MAD`;

create table data_admin(
	clave varchar(250) primary key,
    register_date varchar(60) DEFAULT CURRENT_TIMESTAMP,
	nombre varchar(250) not null,
	curp varchar(250) not null unique,
	fecha_nacimiento varchar(250) not null,
	fecha_ingreso varchar(250) not null,
	nomina varchar(250) not null unique
);

select * from data_admin;
drop table data_admin;

INSERT INTO data_admin(clave,nombre,curp,fecha_nacimiento,fecha_ingreso,nomina)
VALUES('clave', 'mike', 'curpdx', '21/08/22', '21/08/22','12345678966');
INSERT INTO data_admin(clave,nombre,curp,fecha_nacimiento,fecha_ingreso,nomina)
VALUES('qwer', 'moller', 'mollercurp', '21/08/98', 'ayer ingresoxd','tr7fedcr');


-- ---------------------------------------------------------------------------------------------------------------------
create table login_admin(
	clave varchar(250) not null,
    status_ bit DEFAULT 1,
	correo varchar(250) not null unique,
	contra varchar(250) not null,
    foreign key (clave) references data_admin(clave)
);

select * from login_admin;
drop table login_admin;
DELETE FROM login_admin WHERE correo = 'moller@hotmail.com';

INSERT INTO login_admin (clave, correo, contra)
VALUES ('clave', 'mike@hotmail.com', 'mikexd');

INSERT INTO login_admin (clave, correo, contra)
VALUES ('clave', 'moller@hotmail.com', 'mollerxd');


-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------PROCEDIMIENTOS-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--Get_Admin
create proc sp_Get_Admin
as
select 
d.clave,
d.nombre,
d.curp,
d.fecha_nacimiento,
d.fecha_ingreso,
d.nomina,
l.status_,
l.correo,
l.contra
from data_admin d
inner join login_admin l 
on d.clave = l.clave
order by d.fecha_ingreso asc
go
exec Get_Admin;

select clave from Get_Admin

--Login_Administrador

create proc sp_Login_Administrador
@Correo varchar (50)
as
select contra,
	   clave
from  login_admin
where  correo=@Correo
go

exec Login_Administrador 'moller@hotmail.comx'

