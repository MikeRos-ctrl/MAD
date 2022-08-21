create schema `MAD`;
USE `MAD`;

create table `new_admin`(
  `clave` varchar(250) primary key unique,
  `register_date` timestamp DEFAULT CURRENT_TIMESTAMP
  );

insert into new_admin (clave) values ('clave');
select * from new_admin;
-- ---------------------------------------------------------------------------------------------------------------------

create table `data_admin`(
	clave varchar(250) not null,
	nombre varchar(250) not null,
	curp varchar(250) not null unique,
	fecha_nacimiento varchar(250) not null,
	fecha_ingreso varchar(250) not null,
	nomina varchar(250) not null unique,
    foreign key (clave) references new_admin(clave)
);

INSERT INTO `mad`.`data_admin`(`clave`,`nombre`,`curp`,`fecha_nacimiento`,`fecha_ingreso`,`nomina`)
VALUES('clave', 'mike', 'curpdx', '21/08/22', '21/08/22','12345678966');
select * from data_admin;

-- ---------------------------------------------------------------------------------------------------------------------
create table `login_admin`(
	clave varchar(250) not null,
    `status` bit DEFAULT 1,
	correo varchar(250) not null unique,
	contra varchar(250) not null,
    foreign key (clave) references new_admin(clave)
);

INSERT INTO `mad`.`login_admin` (`clave`, `correo`, `contra`)
VALUES ('qwer', 'david@hotmail.com', 'davidxd');

select * from login_admin;