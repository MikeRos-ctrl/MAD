create table descuento (
	idDescuento int identity primary key  not null,
	descuento_ float not null,
	fecha     Date not null,
	fechaAux  Date not null,
	IdCodigo varchar(250) unique not null

);

drop table descuento
insert into descuento (descuento_,  fecha, fechaAux)
					Values ('0.20', '12/06/2022', '12/07/2022')
select * from descuento

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------PROCEDIMIENTOS-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


If OBJECT_ID ('sp_GestionarDescuento') is not null
	Drop procedure sp_GestionarDescuento;
go

create proc sp_GestionarDescuento
(
@Op							   CHAR(1),
@idDescuento				   integer = Null,
@descuento_					   float, 
@fecha						   Date,
@fechaAux					   Date,
@IdCodigo					   varchar(250)

)
as
Begin
	IF @Op = 'I' --insert
	Begin

		insert into descuento (descuento_, IdCodigo, fecha, fechaAux)
					Values (@descuento_, @IdCodigo, @fecha, @fechaAux)

	End

	IF @Op = 'U' --update
	Begin

		update descuento set descuento_ = @descuento_, IdCodigo = @IdCodigo, fecha = @fecha, fechaAux = @fechaAux
		where idDescuento = @idDescuento
	End

End;

create proc sp_Codigo_Vali
@idDescuento varchar (250)
as
select idDescuento,
	   IdCodigo

from  descuento
where  idDescuento = @idDescuento
go

-- View descuentos 

If OBJECT_ID ('sp_Get_CostoConDescuento') is not null
	Drop proc sp_Get_CostoConDescuento;
go

create proc sp_Get_CostoConDescuento
As
	Select 
			[Id del Descuento],
			[Productos],
			Descuento,
			Subtotal,
			[Precio Con Descuento],
			[Rango de Fechas]
	FROM vw_GetDescuentos 
Go

If OBJECT_ID ('vw_GetDescuentos') is not null
	Drop View vw_GetDescuentos;
go


Create View vw_GetDescuentos AS
	Select
	   D.IdCodigo as Codigo,
	   D.idDescuento as 'Id del Descuento',
	   P.descripcion as 'Productos',
	   concat(ISNULL(D.descuento_ , 0), '%') as Descuento,
	   P.costo as Subtotal,
	   (P.costo - P.costo * (D.descuento_ / 100))  as 'Precio Con Descuento',
	   Concat( 'Fecha de inicio: ', D.fecha, '  |  Fecha de fin: ', D.fechaAux ) as 'Rango de Fechas'
FROM descuento D
inner join data_producto P
	      on D.IdCodigo = P.Codigo

Go

exec sp_Get_CostoConDescuento
go


--
If OBJECT_ID ('trg_CostoDescuentos_Delete') is not null
	Drop Trigger trg_CostoDescuentos_Delete;
go

Create Trigger trg_CostoDescuentos_Delete
on data_producto 
After delete, update
as
begin
Declare @IdCodigo varchar(250);

select @IdCodigo = IdCodigo from descuento;

 delete from descuento  where IdCodigo = @IdCodigo;

end


