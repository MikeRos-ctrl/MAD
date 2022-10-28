create table data_cajero(
    clave varchar(250) primary key,
	registered_by varchar(250) not null, -- admin que lo registro
	nombre varchar(250) not null,
	register_date varchar(60) DEFAULT CURRENT_TIMESTAMP,
	curp varchar(250) not null unique,
	fecha_nacimiento varchar(250) not null,
	fecha_ingreso varchar(250) not null,
	nomina varchar(250) not null unique
);

INSERT INTO data_cajero(clave,registered_by,nombre,curp,fecha_nacimiento,fecha_ingreso,nomina)
VALUES('clave_Cajero_1','qwer', 'alan', 'alancurp', '21/08/22', '21/08/22','123456781234966');
select * from data_cajero;
drop table data_cajero;

-- ---------------------------------------------------------------------------------------------------------------------
create table login_cajero(
	clave varchar(250) not null,
    status bit DEFAULT 1,
	correo varchar(250) not null unique,
	contra varchar(250) not null,
    foreign key (clave) references data_cajero(clave)
);

INSERT INTO `mad`.`login_admin` (`clave`, `correo`, `contra`)
VALUES ('qwer', 'david@hotmail.com', 'davidxd');

select * from login_cajero;

-- ---------------------------------------------------------------------------------------------------------------------
create table cajero_modifications(
	last_modification varchar(60) DEFAULT CURRENT_TIMESTAMP,
    by_who varchar(250) not null, -- admin
    clave_cajero varchar(250) not null,
    what varchar(250) not null,-- que movio?
	foreign key (by_who) references data_admin(clave),
    foreign key (clave_cajero) references data_cajero(clave)
);

--INSERT CAJERO
create proc Insert_Cajero
@clave varchar(255),
@registered_by varchar(255),
@nombre varchar(255),
@curp varchar(255),
@fecha_nacimiento varchar(255),
@fecha_ingreso varchar(255),
@nomina varchar(255),
--
@correo varchar(255),
@contra varchar(255)
as
insert into data_cajero(clave,registered_by,nombre,curp,fecha_nacimiento,fecha_ingreso,nomina)
values(				@clave,@registered_by,@nombre,@curp,@fecha_nacimiento,@fecha_ingreso,@nomina)
insert into login_cajero(clave,correo,contra)values(@clave,@correo,@contra)
go

exec Insert_Cajero 'nueva_clave_supreme','qwer','la sinegrita','negrita','algo','antier','esta es una nomina de sirenita','ariel@hotmail.com','arielcontra';


