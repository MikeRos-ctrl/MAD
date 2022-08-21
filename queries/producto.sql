create table `new_producto`(
  `codigo` varchar(250) primary key unique,
  `register_date` timestamp DEFAULT CURRENT_TIMESTAMP,
  registered_by varchar(250) not null, -- admin que lo registro
  foreign key (registered_by) references new_admin(clave)
  );

insert into new_cajero (clave,registered_by) values ('clave_Cajero_1','qwerbyvtrcfedxs');
select * from new_cajero;
-- ---------------------------------------------------------------------------------------------------------------------

create table `data_producto`(
	codigo varchar(250) not null,
    descuento int not null,
	descripcion varchar(250) not null,
	id_departamento int not null,
	unidad_de_medida varchar(250) not null, -- gramos, litros,etc
	precio_unitario double not null,-- cuanto me costo
	costo double not null, -- a cuanto lo vendo
    `existencia` bit DEFAULT 1,
    `se_puede_devolver` bit DEFAULT 1,
    punto_de_reorden int, -- creo que son los voy a comprar mensualmnete
    foreign key (codigo) references new_producto(codigo),
    foreign key (id_departamento) references departamentos(id)
);

INSERT INTO `mad`.`data_cajero`(`clave`,`nombre`,`curp`,`fecha_nacimiento`,`fecha_ingreso`,`nomina`)
VALUES('clave_Cajero_1', 'alan', 'alancurp', '21/08/22', '21/08/22','123456781234966');
select * from data_cajero;
drop table data_producto;
-- ---------------------------------------------------------------------------------------------------------------------

create table producto_modifications(
	`last_modification` timestamp DEFAULT CURRENT_TIMESTAMP,
    by_who varchar(250) not null, -- admin
    codigo varchar(250) not null,
    what varchar(250) not null,-- que movio?
	foreign key (by_who) references new_producto(codigo),
    foreign key (codigo) references new_cajero(clave)
);