/*                               *
 *   Procedimientos de mostrar   *
 *                               */

use Administrador
go

-- Usuarios
create procedure [Mostrar_Usuarios]
as begin
	select * from Usuario
end

	go

-- Clientes
create procedure [Mostrar_Clientes]
as begin
	select * from Cliente
end

	go

-- Proveedores
create procedure [Mostrar_Proveedores]
as begin
	select * from Proveedor
end

	go

-- Productos
create procedure [Mostrar_Productos]
as begin
	select * from Producto where Estado = 1
end

	go

-- Categorias habilitadas
create procedure [Mostrar_Categorias]
as begin
	select * from Categoria where Estado = 1
end

	go

-- Categorias habilitadas/deshabilitadas
create procedure [Mostrar_Todo_Categorias]
as begin
	select * from Categoria
end

	go

-- Compras
create procedure [Mostrar_Compras]
as begin
	select * from Compra
end

	go

-- Ventas
create procedure [Mostrar_Ventas]
as begin
	select * from Venta
end