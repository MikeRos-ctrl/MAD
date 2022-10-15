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

INSERT INTO `Dmarket`.`data_cajero`(`clave`,`nombre`,`curp`,`fecha_nacimiento`,`fecha_ingreso`,`nomina`)
VALUES('clave_Cajero_1', 'alan', 'alancurp', '21/08/22', '21/08/22','123456781234966');
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

select * from login_admin;

-- ---------------------------------------------------------------------------------------------------------------------
create table cajero_modifications(
	last_modification varchar(60) DEFAULT CURRENT_TIMESTAMP,
    by_who varchar(250) not null, -- admin
    clave_cajero varchar(250) not null,
    what varchar(250) not null,-- que movio?
	foreign key (by_who) references data_admin(clave),
    foreign key (clave_cajero) references data_cajero(clave)
);