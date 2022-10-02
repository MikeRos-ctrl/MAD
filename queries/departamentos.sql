-- departamentos
create table departamentos_data(
  id int primary key identity,
  nombre varchar(250) unique,
  register_date varchar(60) DEFAULT CURRENT_TIMESTAMP,
  registered_by varchar(250) not null, -- admin que lo registro
  foreign key (registered_by) references data_admin(clave)
);

