create table data_producto(
  codigo varchar(250) primary key,
  descripcion varchar(250) not null,
  id_departamento int not null,
  precio_unitario float not null, -- cuanto me costo
  unidad_de_medida varchar(250) not null, -- gramos, litros,etc
  costo float not null, -- a cuanto lo vendo0
  register_date varchar(60) DEFAULT CURRENT_TIMESTAMP,
  existencia int not null, -- cantidad de productos
  punto_de_reorden varchar(255), -- cantidad de dias en los que se va a acabar ese producto
  registered_by varchar(250) not null, -- admin que lo registro
    foreign key (id_departamento) references departamentos_data(id),
	foreign key (registered_by) references data_admin(clave)
);

INSERT INTO `mad`.`data_cajero`(`clave`,`nombre`,`curp`,`fecha_nacimiento`,`fecha_ingreso`,`nomina`)
VALUES('clave_Cajero_1', 'alan', 'alancurp', '21/08/22', '21/08/22','123456781234966');
select * from data_cajero;
drop table data_producto;
-- ---------------------------------------------------------------------------------------------------------------------

create table producto_modifications(
  last_modification varchar(60) DEFAULT CURRENT_TIMESTAMP,
    by_who varchar(250) not null, -- admin
    codigo varchar(250) not null,
    what varchar(250) not null,-- que movio?
	foreign key (by_who) references data_cajero(clave),
    foreign key (codigo) references data_producto(codigo)
);