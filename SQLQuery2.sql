create database BancoSimple2M5
go
use BancoSimple2M5
go

create table Clientes(
ClienteId int Primary key identity (1,1),
Nombre Nvarchar (50) not null,
Identificacion Nvarchar (14) not null
);

create table Cuentas(
CuentaId int primary key identity (1,1),
NumeroCuenta Nvarchar (20) not null,
Saldo decimal (18,2) not null default 0,
Activo Bit not null default 1,
ClienteId int not null,
Foreign key (ClienteId) references Clientes (ClienteId)
);

create table Transacciones(
TransaccionId int primary key identity (1,1),
Monto decimal (18,2) not null,
Fecha datetime not null default getdate (),
Descripcion Nvarchar (200),
CuentaOrigenId int,
CuentaDestinoId int,
Foreign key (CuentaOrigenId) references Cuentas (CuentaId),
Foreign key (CuentaDestinoId) references Cuentas (CuentaId)
);