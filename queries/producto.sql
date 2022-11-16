create table data_producto(
  codigo varchar(250) primary key,
  status_ bit DEFAULT 1,
  registered_by varchar(250) not null, -- admin que lo registro
  descripcion varchar(250) not null,
  departamento varchar(250)  not null,
  precio_unitario float not null, -- cuanto me costo
  unidad_de_medida varchar(250) not null, -- gramos, litros,etc
  costo float not null, -- a cuanto lo vendo0
  register_date varchar(60) DEFAULT CURRENT_TIMESTAMP,
  existencia int not null, -- cantidad de productos
  punto_de_reorden int not null, -- cantidad de dias en los que se va a acabar ese producto
  foreign key (registered_by) references data_admin(clave),
  
  CONSTRAINT FK_data_Producto_departamentos
	Foreign Key(departamento) References departamentos_data (nombre)
);

	insert into data_producto (codigo, registered_by, departamento, descripcion, precio_unitario, unidad_de_medida, costo, existencia, punto_de_reorden)
				       	Values ('a',  'clave', 'gansito', 'takis', '10', 'gr', '20', '20', '5')
select * from data_producto;
drop table data_producto;
delete from data_producto where precio_unitario < 100
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
	Drop procedure sp_GestionarProducto;
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
		IF @Op = 'E' --update Existencia
	Begin
		update data_producto set registered_by = @registered_by, existencia = @existencia
		where codigo = @codigo
	End
	IF @Op = 'D' --delete
	Begin
		delete from data_producto  where codigo = @codigo
	End

    IF @Op = 'B' --baja lógica
    Begin
      Update data_producto 
         
		 Set status_ = 0

		 Where codigo = @codigo
    End
End;

-- Get Producto
If OBJECT_ID ('sp_Get_Producto') is not null
	Drop procedure sp_Get_Producto;
go

create proc sp_Get_Producto
as
select 
[Codigo del producto],	
Producto,
[Quien lo Registra],		
[Departamento],				  	   
[Precio unitario],
[Unidad de medida],
[Costo],
[Existencia],
[Punto de reorden],
[Fecha de Registro]

from vw_GetProducto
order by [Fecha de Registro] asc
go

exec sp_Get_Producto
go
--View Producto
If OBJECT_ID ('vw_GetProducto') is not null
	Drop View vw_GetProducto;
go

Create View vw_GetProducto AS
	Select codigo as 'Codigo del producto', 
			   CASE WHEN status_ = 1 THEN descripcion WHEN status_ = 0 THEN 'Producto eliminado' END AS Producto,
			   registered_by as 'Quien lo Registra',
			   departamento as 'Departamento',
			   precio_unitario AS 'Precio unitario',			  
			   unidad_de_medida AS 'Unidad de medida',			   
			    costo AS 'Costo',						   
			   existencia  AS 'Existencia',					   
			   punto_de_reorden  AS 'Punto de reorden',
			   register_date  AS 'Fecha de Registro'
		FROM data_producto WHERE status_ = 1
Go

IF OBJECT_ID('cuentaD') IS NOT NULL
   DROP FUNCTION cuentaD

Go

CREATE FUNCTION ExistenciaP (@codigo varchar(250)) 
	RETURNS INT AS
BEGIN

DECLARE @Existencia INT,
		@Cantidad INT; 
		
		SET @Existencia = (select existencia from data_producto)
		SET @Cantidad = (select Cantidad from Venta)
		
		IF (@Existencia >= @Cantidad) 
		
		SELECT ProductID, Name, ProductNumber  
		FROM Production.Product  
		WHERE ProductID = @MyProduct; 
   
	RETURN @numEmpleados
END;
Go
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


If OBJECT_ID ('sp_Get_ModProducto') is not null
	Drop procedure sp_Get_ModProducto;
go

create proc sp_Get_ModProducto
as
select 
[Codigo de Cajero],
[Quien lo Registra],
[Ultimo Registro],
[Cambios]

from vw_Get_ModProducto
order by [Ultimo Registro] asc
go

If OBJECT_ID ('vw_Get_ModProducto') is not null
	Drop View vw_Get_ModProducto;
go

CREATE VIEW vw_Get_ModProducto AS 
select  codigo as 'Codigo de Cajero',
		by_who as 'Quien lo Registra',
		last_modification as 'Ultimo Registro',
		what as 'Cambios'
		from producto_modifications

go


-- productos que ya llegaron a su punto de reorden

If OBJECT_ID ('sp_Get_PuntoRe') is not null
	Drop procedure sp_Get_PuntoRe;
go

create proc sp_Get_PuntoRe
as
Select 
codigo as Codigo, 
descripcion as Producto, 
existencia as Existencia, 
punto_de_reorden as 'Punto de Reoden', 
costo as Subtotal
From data_producto where existencia <= punto_de_reorden
order by register_date asc
go




create proc sp_Get_Producto

as
select 
[Codigo del producto],	
Producto,
[Quien lo Registra],		
[Departamento],				  	   
[Precio unitario],
[Unidad de medida],
[Costo],
[Existencia],
[Punto de reorden],
[Fecha de Registro]

from vw_GetProducto where [Codigo del producto]
order by [Fecha de Registro] asc
go

-- Procedimiento traer departamento al producto
create proc sp_TraerDepaPro
@descripcion varchar (255)
as
select departamento
from   data_producto
where  descripcion = @descripcion
go

--
If OBJECT_ID ('Get_existencia_producto') is not null
	Drop procedure Get_existencia_producto;
go
create proc Get_existencia_producto
@descripcion varchar (255)
as
select existencia
from data_producto
where  descripcion = @descripcion
go

If OBJECT_ID ('sp_GestionarProduPu') is not null
	Drop procedure sp_GestionarProduPu;
go

create proc sp_GestionarProduPu


@codigo					       varchar(250),
@registered_by				   varchar(250),
@existencia					   int

as
		update data_producto set registered_by = @registered_by, existencia = @existencia
		where codigo = @codigo
go