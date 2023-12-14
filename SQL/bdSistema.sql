create database dbSistema;
select * from empleado;
use dbSistema;

insert into Departamento (departamento)
values ('programacion');

select * from Departamento;
select * from empleado;

-- funciona
insert into Empleado (nombre, primerApellido, segundoApellido,correo)
values ('kevin','montero','del Rosario', 'kevinfmdelrosario@gmail.com');