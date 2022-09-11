create schema `MAD`;
USE `MAD`;

create table new_admin(
  clave varchar(250) primary key,
  register_date varchar(60) DEFAULT CURRENT_TIMESTAMP
  );

insert into new_admin (clave) values ('clave');
insert into new_admin (clave) values ('qwer');
select * from new_admin;
-- ---------------------------------------------------------------------------------------------------------------------

create table data_admin(
	clave varchar(250) not null,
	nombre varchar(250) not null,
	curp varchar(250) not null unique,
	fecha_nacimiento varchar(250) not null,
	fecha_ingreso varchar(250) not null,
	nomina varchar(250) not null unique,
    foreign key (clave) references new_admin(clave)
);

INSERT INTO data_admin(clave,nombre,curp,fecha_nacimiento,fecha_ingreso,nomina)
VALUES('clave', 'mike', 'curpdx', '21/08/22', '21/08/22','12345678966');
INSERT INTO data_admin(clave,nombre,curp,fecha_nacimiento,fecha_ingreso,nomina)
VALUES('qwer', 'moller', 'mollercurp', '21/08/98', 'ayer ingresoxd','tr7fedcr');
select * from data_admin;

-- ---------------------------------------------------------------------------------------------------------------------
create table login_admin(
	clave varchar(250) not null,
    status_ bit DEFAULT 1,
	correo varchar(250) not null unique,
	contra varchar(250) not null,
    foreign key (clave) references new_admin(clave)
);

INSERT INTO login_admin (clave, correo, contra)
VALUES ('clave', 'mike@hotmail.com', 'mikexd');

INSERT INTO login_admin (clave, correo, contra)
VALUES ('qwer', 'moller@hotmail.com', 'mollerxd');

select * from login_admin;

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------PROCEDIMIENTOS-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--Get_Admin
create proc Get_Admin
as
select 
n.clave,
d.nombre,
d.curp,
d.fecha_nacimiento,
d.fecha_ingreso,
d.nomina,
l.status_,
l.correo,
l.contra
from new_admin n
inner join data_admin d
on n.clave = d.clave
inner join login_admin l 
on n.clave = l.clave
order by d.fecha_ingreso asc
go
exec Get_Admin;


--Login_Administrador

create proc Login_Administrador
@correo varchar (50)
as
select contra
from  login_admin
where  correo=@correo
go

exec Login_Administrador 'moller@hotmail.comx'


