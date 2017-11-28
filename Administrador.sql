create datebase Administrador
	go
use Administrador
	go

/* Creación de las tablas */

create table Usuario(
	ID varchar(10) primary key not null,
	Contraseña varchar(50),
	Nombre varchar(50),
	Apellido varchar(50),
	FotoPerfil image
)
	go
create table Cliente(
	ID int identity(1,1) primary key not null,
	Nombre varchar(200) null,
	Domicilio varchar(300) null,
	Telefono varchar(100),
	Email varchar(50) null
)
	go
create table Proveedor(
	ID int identity(1,1) primary key not null,
	Nombre nvarchar(250) null,
	Domicilio nvarchar(300),
	Telefono nvarchar(250),
	Email nvarchar(50)
)
	go
create table Producto(
	ID int identity(1,1) primary key not null,
	CategoriaID int,
	Nombre varchar(200),
	PrecioVenta decimal(18,2),
	Stock int,
	Descripcion varchar(250),
	Estado int
)
	go
create table Categoria(
	ID int identity(1,1) primary key not null,
	Nombre varchar(100),
	Descripcion varchar(250),
	Estado int
)
	go
create table Compra(
	ID varchar(15) primary key not null,
	ProveedorID int null,
	FechaCompra date null,
	TipoPago int null,
	Monto decimal(18,2) null
)
	go
create table Detalle_Compra(
	CompraID varchar(15) not null,
	ProductoID int not null,
	Cantidad int not null,
	CostoUnitario decimal(18,2) not null,
	Total decimal(18,2)
)
	go
create table Venta(
	ID varchar(15) primary key not null,
	ClienteID int not null,
	UsuarioID varchar(10) not null,
	FechaVenta date not null,
	TipoPago int not null,
	TipoVenta int,
	SubTotal decimal(18,2),
	Impuesto decimal(18,2),
	Total decimal(18,2)
)
	go
create table Detalle_Venta(
	VentaID varchar(15) not null,
	ProductoID int not null,
	Cantidad int,
	PrecioUnitario decimal(18,2),
	Descuento decimal(18,2),
	Impuesto decimal(18,2),
	Total decimal(18,2)
)
	go
alter table Producto
add foreign key (CategoriaID) references Categoria(ID)
	go
alter table Compra 
add foreign key	(ProveedorID) references Proveedor(ID)
	go
alter table Detalle_Compra
add foreign key (CompraID) references Compra(Id)
	go
alter table Detalle_Compra
add foreign key (ProductoID) references Producto(ID)
	go
alter table Venta
add foreign key (ClienteID) references Cliente(ID)
	go
alter table Venta
add foreign key (UsuarioID) references Usuario(ID)
	go
alter table Detalle_Venta
add foreign key (VentaID) references Venta(ID)
	go 
alter table Detalle_Venta
add foreign key (ProductoID) references Producto(ID)
	go

/*                    *
 *   Procedimientos   *
 *                    */
create procedure [Insertar_Usuario](
	@ID varchar(10),
	@Contraseña varchar(50),
	@Nombre varchar(50),
	@Apellido varchar(50),
	@FotoPerfil image
)
as
begin
	insert into Usuario(ID, Contraseña, Nombre, Apellido, FotoPerfil)
	values(@ID, @Contraseña, @Nombre, @Apellido, @FotoPerfil)	
end

 go

create procedure [Actualizar_Usuario](
	@ID varchar(10),
	@Contraseña varchar(50),
	@Nombre varchar(50),
	@Apellido varchar(50),
	@FotoPerfil image
)
as
begin
	Update Usuario
		Set
			Contraseña = @Contraseña,
			Nombre = @Nombre,
			Apellido = @Apellido,
			FotoPerfil = @FotoPerfil
	where ID = @ID
end

 go

create procedure [Insertar_Cliente](
	@Nombre varchar(200),
	@Domicilio varchar(200),
	@Telefono varchar(200),
	@Email varchar(200)
)
as
begin
	insert into Cliente(Nombre, Domicilio, Telefono, Email)
	values (@Nombre, @Domicilio, @Telefono, @Email)
end

	go

create procedure [Actualizar_Cliente](	
	@ID Int,
	@Nombre varchar(200),
	@Domicilio varchar (300),
	@Telefono varchar(200),
	@Email varchar (200)
)
as
begin
	Update Cliente 
		Set Nombre=@Nombre, 
			Domicilio=@Domicilio,
			Telefono=@Telefono,
			Email=@Email
	where ID=@ID
	select @@ROWCOUNT as CantidadAfectada
end

	go

create procedure [Insertar_Proveedor](
	@Nombre varchar(200),
	@Domicilio varchar(200),
	@Telefono varchar(200),
	@Email varchar(200)
)
as
begin
	insert into Proveedor(Nombre, Domicilio, Telefono, Email)
	values (@Nombre, @Domicilio, @Telefono, @Email)
end

	go

create procedure [Actualizar_Proveedores](	
	@ID Int,
	@Nombre varchar(200),
	@Domicilio varchar (200),
	@Tel varchar(200),
	@Email varchar (200)
)
as
begin
	Update Proveedor 
		Set Nombre=@Nombre, 
			Domicilio=@Domicilio,
			Tel=@Tel,Email=@Email
	where ID=@ID
	select @@ROWCOUNT as CantidadAfectada
end

	go

create procedure [Insertar_Producto](
	@CategoriaID int,
	@Nombre varchar(200),
	@PrecioVenta decimal(18,2),
	@Stock int,
	@Descripcion varchar(250),
	@Estado int
)
as
begin
	insert into Producto(CategoriaID, Nombre, PrecioVenta, Stock, Descripcion, Estado)
	values(@CategoriaID, @Nombre, @PrecioVenta, @Stock, @Descripcion, @Estado)
end

	go

create procedure [Actualizar_Producto](
	@ID int,
	@CategoriaID int,
	@Nombre varchar(200),
	@PrecioVenta decimal(18,2),
	@Stock int,
	@Descripcion varchar(250),
	@Estado int
)
as
begin
	Update Producto
		set 
			CategoriaID = @CategoriaID,
			Nombre = @Nombre,
			PrecioVenta = @PrecioVenta,
			Stock = @Stock,
			Descripcion = @Descripcion,
			Estado = @Estado
	where ID = @ID
end

	go

create procedure [Insertar_Categoria](
	@Nombre varchar(100),
	@Descripcion varchar(250),
	@Estado int
)
as
begin
	insert into Categoria(Nombre, Descripcion, Estado)
	values(@Nombre, @Descripcion, @Estado)
end

	go

create procedure [Actualizar_Categoria](
	@ID int,
	@Nombre varchar(100),
	@Descripcion varchar(250),
	@Estado int
)
as
begin
	Update Categoria
		set 
			Nombre = @Nombre,
			Descripcion = @Descripcion,
			Estado = @Estado
	where ID = @Id
end

	go

create procedure [Insertar_Compra](
	@ID varchar(15),
	@ProveedorID int,
	@FechaCompra date,
	@TipoPago int,
	@Monto decimal(18,2)
)
as
begin
	insert into Compra(ID, ProveedorID, FechaCompra, TipoPago, Monto)
	values(@ID, @ProveedorID, @FechaCompra, @TipoPago, @Monto)
end 

	go

create procedure [Actualizar_Compra](
	@ID varchar(15),
	@ProveedorID int,
	@FechaCompra date,
	@TipoPago int,
	@Monto decimal(18,2)
)
as
begin
	Update Compra
		set 
			ProveedorID = @ProveedorID,
			FechaCompra = @FechaCompra,
			TipoPago = @TipoPago,
			Monto = @Monto
	where ID = @ID
end 

	go

create procedure [Insertar_Detalle_Compra](
	CompraID varchar(15),
	ProductoID int,
	Cantidad int,
	CostoUnitario decimal(18,2),
	Total decimal(18,2)
)
as 
begin
	insert into Detalle_Compra(CompraID, ProductoID, Cantidad, CostoUnitario, Total)
	values(@CompraID, @ProductoID, @Cantidad, @CostoUnitario, @Total)
		go
	Update Producto
		set 
			Stock = Stock + @Cantidad
	where ID = @ProductoID
end

	go

create procedure [Actualizar_Detalle_Compra](
	@CompraID varchar(15),
	@ProductoID int,
	@Cantidad int,
	@CostoUnitario decimal(18,2),
	@Total decimal(18,2)
)
as
begin
	Declare 
		@ActualizaStock as int,
		@ActualCantidad as int

	set @ActualizaStock = (select Cantidad from Detalle_Compra where CompraID = @CompraID and ProductoID = @ProductoID)
		go
	Update Detalle_Compra 
		set 
			Cantidad = @Cantidad,
			CostoUnitario = @CostoUnitario,
			Total = @Total
	where CompraID = @CompraID and ProductoID = @ProductoID
		go
	set @ActualCantidad = (select Cantidad from Detalle_Compra where CompraID = @CompraID and ProductoID = @ProductoID)
		go
	Update Producto
		set 
			Stock = Stock + (@ActualCantidad - @ActualizaStock)
	where ID = @ProductoID
end

	go

create procedure [Insertar_Venta](
	@ID varchar(15),
	@ClienteID int,
	@UsuarioID varchar(10),
	@FechaVenta date,
	@TipoPago int,
	@TipoVenta int,
	@SubTotal decimal(18,2),
	@Impuesto decimal(18,2),
	@Total decimal(18,2)
)
as
begin
	insert into Venta(ID, ClienteID, UsuarioID, FechaVenta, TipoPago, TipoVenta, SubTotal, Impuesto, Total)
	values(@ID, @ClienteID, @UsuarioID, @FechaVenta, @TipoPago, @TipoVenta, @SubTotal, @Impuesto, @Total)
end

	go

create procedure [Actualizar_Venta](
	@ID varchar(15),
	@ClienteID int,
	@UsuarioID varchar(10),
	@FechaVenta date,
	@TipoPago int,
	@TipoVenta int,
	@SubTotal decimal(18,2),
	@Impuesto decimal(18,2),
	@Total decimal(18,2)
)
as
begin
	Update Venta
		set
			ClienteID = @ClienteID,
			UsuarioID = @UsuarioID,
			FechaVenta = @FechaVenta,
			TipoPago = @TipoPago,
			TipoVenta = @TipoVenta,
			SubTotal = @SubTotal,
			Impuesto = @Impuesto,
			Total = @Total
	where ID = @ID
end

	go

create procedure [Insertar_Detalle_Venta](
	@VentaID varchar(15),
	@ProductoID int,
	@Cantidad int,
	@PrecioUnitario decimal(18,2),
	@Descuento decimal(18,2),
	@Impuesto decimal(18,2),
	@Total decimal(18,2)
)
as
begin
	insert into Detalle_Venta(VentaID, ProductoID, Cantidad, PrecioUnitario, Descuento, Impuesto, Total)
	values(@VentaID, @ProductoID, @Cantidad, @PrecioUnitario, @Descuento, @Impuesto, @Total)
		go
	Update Producto
		set Stock = Stock - @Cantidad
	where ID = @ProductoID
end

	go

create procedure [Actualizar_Detalle_Venta](
	@VentaID varchar(15),
	@ProductoID int,
	@Cantidad int,
	@PrecioUnitario decimal(18,2),
	@Descuento decimal(18,2),
	@Impuesto decimal(18,2),
	@Total decimal(18,2)
)
as
begin
	Declare 
		@ActualizaStock as int,
		@ActualCantidad as int

	set @ActualizaStock = (select Cantidad from Detalle_Venta where VentaID = @VentaID and ProductoID = @ProductoID)
		go
	Update Detalle_Venta
		set
			Cantidad = @Cantidad,
			PrecioUnitario = @PrecioUnitario,
			Descuento = @Descuento,
			Impuesto = @Impuesto,
			Total = @Total
	where VentaID = @VentaID and ProductoID = @ProductoID
		go
	set @ActualCantidad = (select Cantidad from Detalle_Venta where VentaID = @VentaID and ProductoID = @ProductoID)
		go
	Update Producto
		set 
			Stock = Stock - (@ActualCantidad - @ActualizaStock)
	where ID = @ProductoID
end

	go

create procedure [Remover_Producto_Detalle_Venta](
	@VentaID varchar(15),
	@ProductoID int
)
as
begin
	delete * from Detalle_Venta where VentaID = @VentaID and ProductoID = @ProductoID
end

	go

create procedure [Remover_Producto_Detalle_Compra](
	@CompraID varchar(15),
	@ProductoID int
)
as
begin
	delete * from Detalle_Compra where CompraID = @CompraID and ProductoID = @ProductoID
end

	go

create procedure [TabInicio_Contador_Clientes]
as
begin
	select count(ID) from Cliente
end

	go

create procedure [TabInicio_Contador_Productos]
as
begin
	select count(ID) from Producto
end

	go

create procedure [TabInicio_Contador_Proveedores]
as
begin
	select count(ID) from Proveedor
end

	go

create procedure [TabInicio_Contador_VentasMes](
	@Fecha date
)
as
begin
	select sum(Total) from Venta where month(FechaVenta) = month(getdate()) and year(FechaVenta) = year(getdate())
end

	go 

create procedure [TabInicio_UltimasVentas]
as
begin
	select 
		ID, 
		FechaVenta as Fecha, 
		Total 
	from Venta
	order by (ID) desc limit 5
end

	go

create procedure [Busqueda_Cliente](
	@valor varchar(100),
	@clave int
)
as
begin
	if @clave = 0
		select * from Cliente where Nombre like '%'+@valor+'%' or ID like '%'+@valor+'%'
	else
		if @clave = 1
			select * from Cliente where Email like '%'+@valor+'%'
		else
			if @clave = 2
				select * from Cliente where Domicilio like '%'+@valor+'%'
			else
				if @clave = 3
					select * from Cliente where Telefono like '%'+@valor+'%'
end

	go

create procedure [Busqueda_Proveedor](
	@valor varchar(100),
	@clave int
)
as
begin
	if @clave = 0
		select * from Proveedor where Nombre like '%'+@valor+'%' or ID like '%'+@valor+'%'
	else
		if @clave = 1
			select * from Proveedor where Email like '%'+@valor+'%'
		else
			if @clave = 2
				select * from Proveedor where Domicilio like '%'+@valor+'%'
			else
				if @clave = 3
					select * from Proveedor where Telefono like '%'+@valor+'%'
end

	go

create procedure [Busqueda_Compras](
	@valor varchar(100),
	@clave int
)
as
begin
	if @clave = 0
		select * from Compra where ID like '%'+@valor+'%'
	else
		if @clave = 1
			select * from Compra where ProveedorID like '%'+@valor+'%'
		else
			if @clave = 2
				select * from Compra where FechaCompra like '%'+@valor+'%'
			else
				if @clave = 3
					select * from Compra where Monto like '%'+@valor+'%'
end

	go

create procedure [Busqueda_Ventas](
	@valor varchar(100),
	@clave int
)
as
begin
	if @clave = 0
		select * from Venta where ID like '%'+@valor+'%'
	else
		if @clave = 1
			select * from Venta where ClienteID like '%'+@valor+'%'
		else
			if @clave = 2
				select * from Venta where FechaVenta like '%'+@valor+'%'
			else
				if @clave = 3
					select * from Venta where Total like '%'+@valor+'%'
end

	go

create procedure [Busqueda_Productos](
	@valor varchar(100),
	@clave int
)
as
begin
	if @clave = 0
		select * from Producto where (Nombre like '%'+@valor+'%' or ID like '%'+@valor+'%') and Estado = 1
	else
		if @clave = 1
			select * from Producto  where (ProveedorID like '%'+@valor+'%') and Estado = 1
		else
			if @clave = 2
				select * from Producto where (CategoriaID like '%'+@valor+'%') and Estado = 1
			else
				if @clave = 3
					select * from Producto where (PrecioUnitario like '%'+@valor+'%') and Estado = 1
				else
					if @clave = 4
						select * from Producto where (Stock like '%'+@valor+'%') and Estado = 1
end

	go

create procedure [Busqueda_Categoria](
	@valor varchar(100),
	@estado int
)
as
begin
	if @estado = 1
		select * from Categoria where (Nombre like '%'+@valor+'%' or ID like '%'+@valor+'%') and Estado = 1
	else
		select * from Categoria where Nombre like '%'+@valor+'%' or ID like '%'+@valor+'%'
end

	go

create procedure [Busqueda_Productos_Deshabilitados](
	@valor varchar(100),
	@estado int
)
as
begin
		select * from Producto where (Nombre like '%'+@valor+'%' or ID like '%'+@valor+'%') and Estado = 0
end

	go

create procedure [Validar_Usuario](
	@Usuario varchar(500),
	@Contraseña varchar (150)
)
as
begin
	Select ID from Usuario with(nolock) where ID =  @Usuario and Contraseña=@Contraseña
end

	go

create procedure [Mostrar_Usuarios]
as
begin
	select * from Usuario
end

	go

create procedure [Mostrar_Clientes]
as
begin
	select * from Cliente
end

	go

create procedure [Mostar_Proveedores]
as
begin
	select * from Proveedor
end

	go

create procedure [Mostar_Productos]
as
begin
	select * from Producto where Estado = 1
end

	go

create procedure [Mostar_Ventas]
as
begin
	select * from Venta
end

	go

create procedure [Mostar_Compras]
as
begin
	select * from Compra
end