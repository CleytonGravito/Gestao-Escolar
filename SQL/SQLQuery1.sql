create database escola
go
use escola
go

create table usuario
(
id_usuario varchar(5) not null,
nome varchar(50) not null,
nome_usuario varchar(20) not null,
senha varchar(10) not null,
id_tipo varchar(15) not null,
);

-- Tabela já existente
CREATE TABLE usuario (
  id INT PRIMARY KEY,
  nome VARCHAR(100)
);

DROP TABLE usuario

insert into usuario values('00001','admin','admin','Administrador')

create table Tipo
(
id_tipo varchar(5) not null,
nome_tipo varchar(20) not null,
)
insert into Tipo values('T0002','Administrador')

select * from usuario
delete usuario
SELECT name FROM sys.tables;

create proc sp_logar
@usuario varchar(20),
@senha varchar(10)
as
select nome_usuario,senha,id_tipo, id_usuario from usuario
where nome_usuario=@usuario and senha=@senha

--Dados dos Usuarios--
insert into usuario values ('00002','Cleyton','123','Administrador')

--Dados Tipo--
insert into Tipo values ('T0001','Administrador')
insert into Tipo values ('T0002','Secretaria')
insert into Tipo values ('T0003','Professor')


go

SELECT nome FROM dbo.usuario;

--- Procedimentos de Armazenamento de Usuarios ---

create procedure sp_buscar_usuario
@nome varchar(50)
as select id_usuario,u.nome,nome_usuario,t.id_tipo,nome_tipo as Tipo from usuario u, Tipo t
where t.id_tipo=u.id_tipo and nome like @nome
go

create procedure sp_listar_usuario
as select id_usuario,u.nome,nome_usuario,t.id_tipo,nome_tipo as Tipo from usuario u, Tipo t
where t.id_tipo=u.id_tipo order by id_usuario
go

--- CRUD ---

create procedure procedimento_usuario
@id_usuario varchar(5),
@nome varchar(50),
@nome_usuario varchar(20),
@senha varchar(10),
@id_tipo varchar(15),
@accão varchar(50) output
as if(@accão='1')
begin declare @novo varchar(5), @novoMax varchar(5)
set @novoMax=(select max(id_usuario) from usuario)
set @novoMax=isnull(@novoMax,'00000')
set @novoMax='0' + RIGHT(right (@novoMax,4)+ 10001,4)
insert into usuario(id_usuario,nome,nome_usuario,senha,id_tipo) values (@id_usuario,@nome,@nome_usuario,@senha,@id_tipo)
set @accão='usuario inserido' + @novoMax
end
else if(@accão='2')
begin update usuario set nome=@nome, nome_usuario=@nome_usuario, id_tipo=@id_tipo where id_usuario=@id_usuario
set @accão='usuario atualizado' + @id_usuario
end
else if(@accão='3')
begin delete from usuario where id_usuario=@id_usuario
set @accão='usuario deletado' + @id_usuario
end
