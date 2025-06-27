create database escola
go
use escola
go

create table usuario
(
id_usuario varchar(5) not null,
nome_usuario varchar(20) not null,
senha varchar(10) not null,
id_tipo varchar(15) not null,
)
insert into usuario values('00001','admin','admin','Administrador')

create table Tipo
(
id_tipo varchar(5) not null,
nome_tipo varchar(20) not null,
)
insert into Tipo values('T0001','Administrador')
