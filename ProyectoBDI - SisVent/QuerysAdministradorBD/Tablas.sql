/*  DESKTOP-6NVT70E  -> servidor Harold  */

create database Administrador
	go
use Administrador
	go

/* Creación de las tablas */

create table Usuario(
	ID varchar(15) primary key not null,
	Contraseña varchar(50),
	Nombre varchar(50),
	Apellido varchar(50),
	FotoPerfil image
)
	go
create table Cliente(
	ID int identity(1,1) primary key not null,
	Nombre varchar(50),
	Domicilio varchar(125),
	Telefono varchar(25),
	Email varchar(50)
)
	go
create table Proveedor(
	ID int identity(1,1) primary key not null,
	Nombre varchar(50) ,
	Domicilio varchar(125),
	Telefono varchar(25),
	Email varchar(50)
)
	go
create table Producto(
	ID int identity(1,1) primary key not null,
	CategoriaID int,
	Nombre varchar(50),
	PrecioVenta decimal(18,2),
	Stock int,
	Descripcion varchar(250),
	Estado int
)
	go
create table Categoria(
	ID int identity(1,1) primary key not null,
	Nombre varchar(50),
	Descripcion varchar(250),
	Estado int
)
	go
create table Compra(
	ID varchar(15) primary key not null,
	ProveedorID int,
	FechaCompra date,
	TipoPago int,
	Monto decimal(18,2)
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
alter table Detalle_Venta
add foreign key (VentaID) references Venta(ID)
	go 
alter table Detalle_Venta
add foreign key (ProductoID) references Producto(ID)