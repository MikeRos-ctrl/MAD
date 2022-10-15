-- sucursales
create table sucursales(
	numero int primary key identity,
	fecha_creacion varchar(60) default current_timestamp,
	comicilio_completo varchar(250),
	encargado varchar(250) not null,--admin
	nombre varchar (250),
    foreign key (encargado) references data_admin(clave)
);


