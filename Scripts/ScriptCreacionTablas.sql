create table modulo_refacciones(
codigorefa varchar(100) primary key,
nombre varchar(100),
descripcion varchar(150),
marca varchar(100));

create table modulo_herramientas(
codigoherra varchar(100) primary key,
nombre varchar(100),
medida varchar(100),
descripcion varchar(150),
marca varchar(100));

create table permisos(
idpermisos enum('ADMIN', 'GENERAL') primary key);

create table usuario(
idusuario int primary key auto_increment,
rfc varchar(50),
nombre varchar(100),
apellidop varchar(100),
apellidom varchar(100),
fechanacimiento date,
fkidpermisos enum('ADMIN', 'GENERAL'),
foreign key(fkidpermisos) references permisos(idpermisos));