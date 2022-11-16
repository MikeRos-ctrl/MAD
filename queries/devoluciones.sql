Create table data_devoluciones
(
	Id_D int primary key identity,
	IDr int not null,
	status_ bit DEFAULT 1,
	codigo varchar(250) not null,
	motivo Varchar(250) not null,
	merma Varchar(250) not null,
	fecha_creacion varchar(60) default current_timestamp,

	foreign key (IDr) references data_recibos (IDr),
	foreign key (codigo) references data_producto (codigo)
);

select * from data_devoluciones
drop table data_devoluciones
delete from data_devoluciones where IDr = 11
-----------------

If OBJECT_ID ('sp_devoluciones') is not null
	Drop procedure sp_devoluciones;
go
create proc sp_devoluciones
@IDr int = null,
@Id_D int = null,
@codigo Varchar(250), 
@motivo Varchar(250), 
@merma Varchar(250)
as	
     insert into data_devoluciones (IDr, codigo, motivo, merma) 
                          values (@IDr, @codigo, @motivo, @merma )
	
go


If OBJECT_ID ('sp_Get_devoluciones') is not null
	Drop procedure sp_Get_devoluciones;
go
create proc sp_Get_devoluciones
as
	select
		D.motivo, 
		R.IdRecibo,
		R.produc, 
		D.merma,
		R.forma_pago,
		R.subtotal
	From data_devoluciones D
	inner join data_recibos R
	on D.IDr = R.IDr

go



If OBJECT_ID ('trg_Recibo_Delete') is not null
	Drop Trigger trg_Recibo_Delete;
go

Create Trigger trg_Recibo_Delete
on data_devoluciones 
for insert
as
begin


Update data_recibos set status_ = 0

end


exec sp_Get_devoluciones
go


-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------Inventario-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

If OBJECT_ID ('sp_GetInventario') is not null
	Drop procedure sp_GetInventario;
go

create proc sp_GetInventario
@Parametro varchar(250),
@canExi int

as
Select DISTINCT

		P.departamento as Departamento,
		P.descripcion as Producto,
		P.unidad_de_medida as 'Unidad de Medida',
		P.costo as Subtotal,
		P.precio_unitario as 'Precio Unitario',
		P.existencia as Existencias,
		ISNUll(R.cantidad, 'Producto no vendido') as 'Unidades Vendidas',
        ISNUll(D.merma, 'Producto no devuelto')  as Merma 

		FROM data_producto P
		left join data_devoluciones D
		on P.codigo = D.codigo
		left join data_recibos R
		on P.codigo =  R.codigo
	   
		WHERE P.departamento like '%' + @Parametro + '%' 
		AND P.existencia <= @canExi
go

exec sp_GetInventario 'fritos', 20
go

If OBJECT_ID ('sp_GetInventarioTodo') is not null
	Drop procedure sp_GetInventarioTodo;
go

create proc sp_GetInventarioTodo


as
Select DISTINCT

			P.departamento as Departamento,
		P.descripcion as Producto,
		P.unidad_de_medida as 'Unidad de Medida',
		P.costo as Subtotal,
		P.precio_unitario as 'Precio Unitario',
		P.existencia as Existencias,
		ISNUll(R.cantidad, 'Producto no vendido') as 'Unidades Vendidas',
        ISNUll(D.merma, 'Producto no devuelto')  as Merma 

		FROM data_producto P
		left join data_devoluciones D
		on P.codigo = D.codigo
		left join data_recibos R
		on P.codigo =  R.codigo

go




exec sp_GetInventarioTodo 
go


If OBJECT_ID ('sp_GetInventarioMerma') is not null
	Drop procedure sp_GetInventarioMerma;
go

create proc sp_GetInventarioMerma
@merma varchar(250),
@Parametro varchar(250),
@canExi int

as
Select DISTINCT

		P.departamento as Departamento,
		P.descripcion as Producto,
		P.unidad_de_medida as 'Unidad de Medida',
		P.costo as Subtotal,
		P.precio_unitario as 'Precio Unitario',
		P.existencia as Existencias,
		ISNUll(R.cantidad, 'Producto no vendido') as 'Unidades Vendidas',
        ISNUll(D.merma, 'Producto no devuelto')  as Merma 

		FROM data_devoluciones D 
		left join data_producto P
		on D.codigo = P.codigo
		left join data_recibos R
		on D.codigo =  R.codigo
	   
		WHERE D.merma like @merma
		AND P.departamento like '%' + @Parametro + '%' 
		AND P.existencia <= @canExi
go

exec sp_GetInventarioMerma 'Tiene merma','fritos', 20
go

