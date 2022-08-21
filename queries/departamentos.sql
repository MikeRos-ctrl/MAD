-- departamentos
create table departamentos(
  `id` int NOT NULL AUTO_INCREMENT primary key,
  `nombre` varchar(250) unique,
  `register_date` timestamp DEFAULT CURRENT_TIMESTAMP,
  registered_by varchar(250) not null, -- admin que lo registro
  foreign key (registered_by) references new_admin(clave)
);