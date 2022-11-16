
create table Venta(
	Id_v int identity not null,
	status_ bit DEFAULT 1,
	codigo Varchar(250) unique Not Null,
	nombreP Varchar(250)  Not Null,
	Cantidad float,
	fechaV varchar(60) DEFAULT CURRENT_TIMESTAMP,

	foreign key(codigo) references data_producto(codigo),

);

drop table Venta;

Insert Into Venta (codigo, nombreP, Cantidad) Values ('a07a8ab7-ba20-491e-a3d4-6266ef778052', 'Patas', 3)



select * from Venta
delete from Venta where Cantidad < 100
------------------------------------------------------------------
 -- Ventas

If OBJECT_ID ('sp_Get_Ventas') is not null
	Drop procedure sp_Get_Ventas;
go
--codigo = cliente
create proc sp_Get_Ventas

as
Select 
	Codigo, 
	Producto, 
    [Precio Unitario],
	Existencia,
	Departamento,
	[Punto de Reoden], 
	[Descuento del producto]
From  vw_GetVentas 

go


If OBJECT_ID ('sp_Busqueda_Ventas') is not null
	Drop procedure sp_Busqueda_Ventas;
go

create proc sp_Busqueda_Ventas
(
@Parametro varchar(250)
)
as
Select 
	Codigo, 
	Producto, 
    [Precio Unitario],
	Existencia,
	Departamento,
	[Punto de Reoden], 
	[Descuento del producto]
From  vw_GetVentas Codigo where Codigo like '%' + @Parametro + '%'
go

If OBJECT_ID ('vw_GetVentas') is not null
	Drop View vw_GetVentas;
go
Create View vw_GetVentas 
AS
	Select 
		[Codigo del producto] as Codigo, 
		[Producto] as Producto, 
		[Precio unitario] as 'Precio Unitario',
		[Existencia]  as Existencia,
		[Departamento] as Departamento,
		[Unidad de medida],
		[Punto de reorden] as 'Punto de Reoden', 
		Isnull(Descuento, '0%') as 'Descuento del producto',
		[Costo] as Subtotal,
		Isnull([Precio Con Descuento], [Costo]) as 'Total a pagar'
		From  vw_GetProducto P
		left join 	vw_GetDescuentos D
		on P.[Codigo del producto] = D.Codigo
		where [Existencia] > 0 
Go

exec sp_Get_Ventas
go

---
If OBJECT_ID ('sp_vender') is not null
	Drop procedure sp_vender;
go

create proc sp_vender
(
	@Op							   CHAR(1),
	@Id_v						   integer = null,
	@codigo						   Varchar(250),
	@nombreP					   Varchar(250),
	@Cantidad					   float
)
As
Begin 
	IF @Op = 'I' --insert
	Begin 
		Insert Into Venta (codigo, nombreP, Cantidad) Values (@codigo, @nombreP, @Cantidad)
	End

	IF @Op = 'U' --update
	Begin 
		Update data_producto set existencia = existencia - @Cantidad where Codigo = @codigo
	End

		IF @Op = 'D' --delete
	Begin 
		delete from Venta where Codigo = @codigo
	End

End;

exec sp_vender '1','a', 'Patas', 3, 'I'
go

-- trigger


If OBJECT_ID ('trg_Carrito_Delete') is not null
	Drop Trigger trg_Carrito_Delete;
go

Create Trigger trg_Carrito_Delete
on data_producto 
After update
as
begin

Declare @codigo varchar(250);

select @codigo  = codigo  from Venta;

delete from Venta where codigo  = @codigo ;



end


If OBJECT_ID ('sp_Get_Vcarrito') is not null
	Drop proc sp_Get_Vcarrito;
go
-- id_v = Carrito
create proc sp_Get_Vcarrito
--@Codigo varchar (250),
--@Total int
as
	Select 
		Codigo,
		Producto,
	    [Unidad de medida],
		Departamento,
		Cantidad,
	    [Precio Unitario],
		Subtotal,
		[Descuento del producto],
		[Total a pagar]

	From  vw_GetVcarrito
go

exec sp_Get_Vcarrito 'b8a3f792-518f-4bfb-bd7d-4094a86c896f'
go


If OBJECT_ID ('vw_GetVcarrito') is not null
	Drop View vw_GetVcarrito;
go

Create View vw_GetVcarrito
AS
	Select 
		GV.Codigo, 
		V.nombreP as Producto,
		GV.[Unidad de medida],
		GV.Departamento,
		V.Cantidad as Cantidad,
		GV.[Precio Unitario] as 'Precio Unitario',
		GV.Subtotal,
		GV.[Descuento del producto] as 'Descuento del producto',
		GV.[Total a pagar] * V.Cantidad as 'Total a pagar'
	From  Venta V
	inner Join vw_GetVentas GV
	on V.codigo = GV.Codigo
Go

If OBJECT_ID ('sp_Carrito_Vali') is not null
	Drop procedure sp_Carrito_Vali;
go

create proc sp_Carrito_Vali
@Codigo varchar (250)
as
select codigo,
	   Id_v
	   
from  Venta
where  Codigo = @Codigo
go

-----------------------------------------------------------------------

