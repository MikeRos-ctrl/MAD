create table data_producto(
  codigo varchar(250) primary key,
  registered_by varchar(250) not null, -- admin que lo registro
  descripcion varchar(250) not null,
  departamento varchar(250)  not null,
  precio_unitario float not null, -- cuanto me costo
  unidad_de_medida varchar(250) not null, -- gramos, litros,etc
  costo float not null, -- a cuanto lo vendo0
  register_date varchar(60) DEFAULT CURRENT_TIMESTAMP,
  existencia int not null, -- cantidad de productos
  punto_de_reorden int not null, -- cantidad de dias en los que se va a acabar ese producto
  foreign key (registered_by) references data_admin(clave)
);

	insert into data_producto (codigo, registered_by, departamento, descripcion, precio_unitario, unidad_de_medida, costo, existencia, punto_de_reorden)
				       	Values ('a',  'clave', 'gansito', 'takis', '10', 'gr', '20', '20', '5')
select * from data_cajero;
drop table data_producto;
-- ---------------------------------------------------------------------------------------------------------------------

create table producto_modifications(
  last_modification varchar(60) DEFAULT CURRENT_TIMESTAMP,
    by_who varchar(250) not null, -- admin
    codigo varchar(250) not null,
    what varchar(250) not null,-- que movio?
	foreign key (by_who) references data_admin(clave)
);

drop table producto_modifications;

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------PROCEDIMIENTOS-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

If OBJECT_ID ('sp_GestionarProducto') is not null
	Drop Trigger sp_GestionarProducto;
go

create proc sp_GestionarProducto
(
@Op							   CHAR(1),

@codigo					       varchar(250),
@registered_by				   varchar(250),
@departamento				   varchar(250),
@descripcion				   varchar(250),
@precio_unitario			   float,
@unidad_de_medida			   varchar(250),
@costo						   float,
@existencia					   int,
@punto_de_reorden			   integer

)
as
Begin
	IF @Op = 'I' --insert
	Begin
		insert into data_producto (codigo, registered_by, departamento, descripcion, precio_unitario, unidad_de_medida, costo, existencia, punto_de_reorden)
				       	Values (@codigo,  @registered_by, @departamento, @descripcion, @precio_unitario, @unidad_de_medida, @costo, @existencia, @punto_de_reorden)

	End

	IF @Op = 'U' --update
	Begin
		update data_producto set registered_by = @registered_by, departamento = @departamento, descripcion = @descripcion, precio_unitario = @precio_unitario, costo = @costo,
		       existencia = @existencia, punto_de_reorden = @punto_de_reorden
		where codigo = @codigo
	End

	IF @Op = 'D' --delete
	Begin
		delete from data_producto  where codigo = @codigo
	End

End;

-- Get Producto
create proc sp_Get_Producto
as
select 				   
codigo,					       
registered_by,				   
departamento,				  
descripcion,				   
precio_unitario,			  
unidad_de_medida,			   
costo,						   
existencia,					   
punto_de_reorden,
register_date

from data_producto
order by register_date asc
go


--- trigger update
If OBJECT_ID ('trg_cajeroMod_Update') is not null
	Drop Trigger trg_cajeroMod_Update;
go


Create Trigger trg_ProductoMod_Update
on data_producto 
After update
as
begin
Declare @codigo varchar(250), 
@by_who varchar(250),
@what varchar(250)


set  @codigo = (select codigo from  inserted)
set @by_who = (select registered_by from inserted)
set @what =  (select concat('Descripcion: ',descripcion, ', Departamento: ',departamento, ', Precio unitario: ', 
            precio_unitario, ', Unidad de medida: ', unidad_de_medida, ',  Costo: ',  costo, 
			', Fecha de registro: ', register_date, ', Existencia: ', existencia, ', Punto de reorden: ', punto_de_reorden) from deleted)


insert into producto_modifications (codigo, by_who, what) values (@codigo, @by_who, @what)

select codigo, by_who, what from producto_modifications
end

--- trigger Delete
If OBJECT_ID ('trg_cajeroMod_Delete') is not null
	Drop Trigger trg_cajeroMod_Delete;
go

Create Trigger trg_ProductoMod_Delete
on data_producto 
After delete
as
begin
Declare @codigo varchar(250);

select @codigo = codigo from producto_modifications;

 delete from producto_modifications  where codigo = @codigo;

end


create proc sp_Get_ModProducto
as
select 
by_who,
codigo,
last_modification,
what

from producto_modifications
order by last_modification asc
go
