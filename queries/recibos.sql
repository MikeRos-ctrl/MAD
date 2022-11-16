-- sucursales
create table data_recibos(
    IDr int primary key identity,
	IdRecibo int not null,
	status_ bit DEFAULT 1,
	caja   varchar(255) not null,
	codigo varchar(250) not null,
	produc varchar(255) not null,
	forma_pago varchar(255) not null,
	departamento varchar(255) not null,
	cantidad varchar(255) not null,
	Cajero Varchar(250),
	subtotal varchar(255) not null,
	total  varchar(255) not null,
	fecha_creacion Date

	foreign key (codigo) references data_producto (codigo)
);

drop table data_recibos
insert into data_recibos (IdRecibo, codigo) values ('1', 'codigo1')
insert into data_recibos (IdRecibo, codigo) values ('1', 'codigo2')
select * from data_recibos
delete from data_recibos where IDr < 20
Update data_recibos set status_ = 1

-------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------

--Procedimiento InsertNewRecibo
If OBJECT_ID ('sp_Recibo') is not null
	Drop procedure sp_Recibo;
go
create proc sp_Recibo
@IDr int = null,
@IdRecibo int,
@codigo varchar(255),
@Cajero Varchar(250),
@caja   varchar(255),
@produc varchar(255),
@forma_pago varchar(255),
@departamento varchar(255),
@cantidad varchar(255),
@subtotal varchar(255),
@total integer,
@fecha_creacion Date
as

	insert into data_recibos (IdRecibo,codigo, Cajero, caja, produc, forma_pago, departamento, cantidad,subtotal,total, fecha_creacion) 
	values     (@IdRecibo,@codigo, @Cajero, @caja, @produc,@forma_pago,@departamento, @cantidad, @subtotal, @total, @fecha_creacion)

go

	insert into data_recibos (IdRecibo,codigo, Cajero, caja, produc, forma_pago, departamento, cantidad,subtotal,total) 
	values     ('2134','31d34', 'a', 'caja 1', 'sopas','a','a', '1', '2', '1')

If OBJECT_ID ('sp_GetRecibo') is not null
	Drop procedure sp_GetRecibo;
go
create proc sp_GetRecibo
@Parametro varchar(250)
as
Select 
			IDr as 'ID', 
			IdRecibo as 'Numero de Recibo',
			codigo as 'Codigo del producto',
			produc as Producto,
			caja as Caja,
			forma_pago as 'Forma de pago',
			cantidad as Cantidad,
			subtotal as Subtotal,
			total as Total
		From data_recibos
		where IdRecibo like '%' + @Parametro + '%' And status_ = 1
go


If OBJECT_ID ('sp_GetnumRe') is not null
	Drop procedure sp_GetnumRe;
go
create proc sp_GetnumRe
as
Select DISTINCT IdRecibo from data_recibos
go

IF OBJECT_ID('cuentaD') IS NOT NULL
   DROP FUNCTION cuentaD

Go


--Cuenta Productos por Recibo
--CREATE FUNCTION cuentaPR (@IdRecibo INT, @Fecha DATE) 
--	RETURNS INT AS
--BEGIN

--	DECLARE @numProductos INT;

--		SELECT @numProductos = COUNT(*)
--		FROM data_producto				
--		WHERE descripcion = descripcion AND register_date <= @Fecha
--		GROUP BY descripcion
	
--		IF @numProductos IS NULL
--			set @numProductos =  0		

--	RETURN @numProductos

--END;
--Go

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------Reporte Cajero-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


If OBJECT_ID ('sp_Departamento') is not null
	Drop procedure sp_Departamento;
go
create proc sp_Departamento
as
Select DISTINCT departamento from data_producto
go

----
If OBJECT_ID ('sp_Cajero') is not null
	Drop procedure sp_Cajero;
go
create proc sp_Cajero
as
Select DISTINCT Cajero from data_recibos
go




If OBJECT_ID ('sp_GetReporteCajero') is not null
	Drop procedure sp_GetReporteCajero;
go
create proc sp_GetReporteCajero
@Parametro varchar(250),
@Parametro2 varchar(250),
@fecha1 Date,
@fecha2 Date
as
Select 
		
		Convert(datetime,fecha_creacion ,103) as 'Fecha de venta',
		Cajero as Cajero,
		caja as Caja,
		departamento as Departamento,
		cantidad as Cantidad,
		subtotal as Subtotal,
		total as Total

		FROM data_recibos 
		where Cajero like '%' + @Parametro + '%' 
		   And  departamento like '%' + @Parametro2 + '%'
		   And fecha_creacion Between @fecha1 and @fecha2
go


exec sp_GetReporteCajero 'a', 'gamesa', '10-11-2022', '14-11-2022'
go


If OBJECT_ID ('sp_GetReporteCajeroTodos') is not null
	Drop procedure sp_GetReporteCajeroTodos;
go
create proc sp_GetReporteCajeroTodos
as
Select 
		Convert(datetime,fecha_creacion ,103) as 'Fecha de venta',
		Cajero as Cajero,
		caja as Caja,
		departamento as Departamento,
		cantidad as Cantidad,
		subtotal as Subtotal,
		total as Total

		FROM data_recibos 
go


exec sp_GetReporteCajero 'a', 'fritos'
go

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------Reporte Ventas-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

If OBJECT_ID ('sp_Caja') is not null
	Drop procedure sp_Caja;
go
create proc sp_Caja
as
Select DISTINCT caja from data_recibos
go

If OBJECT_ID ('sp_GetReporteVentas') is not null
	Drop procedure sp_GetReporteVentas;
go

create proc sp_GetReporteVentas
@Parametro varchar(250),
@Parametro2 varchar(250),
@fecha1 Date,
@fecha2 Date
as
Select 
		Convert(datetime,R.fecha_creacion ,103) as 'Fecha de venta',
		R.departamento as Departamento,
		R.codigo as Codigo,
		P.unidad_de_medida as 'Unidad de medida',
		R.cantidad as Cantidad,
		R.subtotal as Subtotal,
		R.total as Total

		FROM data_recibos R
		inner join data_producto P
		on R.codigo = P.codigo
		where R.caja like '%' + @Parametro + '%' 
		   And  R.departamento like '%' + @Parametro2 + '%'
		   And R.fecha_creacion Between @fecha1 and @fecha2
go

If OBJECT_ID ('sp_GetReporteVentasTodas') is not null
	Drop procedure sp_GetReporteVentasTodas;
go

create proc sp_GetReporteVentasTodas
as
Select 
		Convert(datetime,R.fecha_creacion ,103) as 'Fecha de venta',
		R.departamento as Departamento,
		R.codigo as Codigo,
		P.unidad_de_medida as 'Unidad de medida',
		R.cantidad as Cantidad,
		R.subtotal as Subtotal,
		R.total as Total

		FROM data_recibos R
		inner join data_producto P
		on R.codigo = P.codigo
go

