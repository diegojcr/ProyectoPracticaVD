drop database if exists proyecto;
create database proyecto;
use proyecto;

create table Vehiculo(
placa    varchar(30)   not null primary key,
id_modelo   varchar(30)   not null,
id_marca    varchar(40)   not null,
color    varchar(40)   not null,
linea   varchar(40)   not null,
id_tipocombustible   varchar(40)  not null,
cm_cubicos    varchar(40)   not null,
cilindros    varchar(40)   not null,
precio       varchar(40)   not null
);

create table Modelo(
id_modelo   varchar(30)   not null primary key,
descripcion   varchar(40)  not null
);

create table Marca(
id_marca   varchar(40)   not null primary key,
descripcion   varchar(40)  not null
);


create table TipoCombustible(
id_tipocombustible    varchar(30)  not null primary key,
descripcion   varchar(40)  not null
);

create table Clientes(
id_cliente  varchar(40)  not null primary key,
nit    varchar(40)  not null,
direccion  varchar(40)  not null,
nombre   varchar(40)  not null,
telefono  varchar(40)  not null
);

create table AlquilerAutomovil(
placa   varchar(30)   not null,
id_cliente  varchar(40)  not null,
montopagar  varchar(40)  not null,
depositoDaños   varchar(40)  not null
);


insert into Marca values('MA001','Volskwagen');
insert into Marca values('MA002','Audi');
insert into Marca values('MA003','BMW');
insert into Marca values('MA004','Mercedes-Benz');
insert into Marca values('MA005','Toyota');
insert into Marca values('MA006','Mazda');

insert into TipoCombustible values('TC1','Diesel');
insert into TipoCombustible values('TC2','Regular');
insert into TipoCombustible values('TC3','Premium');

insert into Vehiculo values('P987KMN','2021','MA001','Negro','Jetta','TC3','2480','5','70000');
insert into Vehiculo values('P213POL','2019','MA002','Azul','R8','TC3','5204','10','204000');
insert into Vehiculo values('P596MNM','2018','MA003','Blanco','X5M','TC1','2998','6','147000');
insert into Vehiculo values('P068JSK','2021','MA006','Rojo','CX-5','TC2','1998','5','45000');
insert into Vehiculo values('P332SKW','2016','MA001','Gris','Amarok','TC1','2967','6','70000');
insert into Vehiculo values('P684TKZ','2018','MA004','Corinto','Clase A','TC2','1999','4','30000');
insert into Vehiculo values('P942AQZ','2017','MA005','Dorado','GT86','TC1','1998','4','70000');
insert into Vehiculo values('P663AWZ','2020','MA004','Blanco','Clase G','TC3','3999','8','90000');
insert into Vehiculo values('P650LLA','2020','MA003','Amarillo','Serie 3','TC3','2998','4','65000');
insert into Vehiculo values('P103EPZ','2021','MA001','Naranja','Tiguan','TC3','1395','4','55000');