use Preparatoria

create table Alumno(
	IDnombre int identity(1,1) primary key,
	nombreAlumno nvarchar (25),
	matricula as ( 'ALU-' + convert(nvarchar, IDnombre) ),
	semestre int
 )

create table Materia(
	IDmateria int identity(1,1) primary key,
	nombreMateria nvarchar (25),
	semestre int
)

create table Calificaciones(
	IDcalificacion int identity(1,1) primary key,
	IDnombre int,
	IDmateria int,
	cali1 int,
	cali2 int,
	cali3 int,
	semestral int,
	final int
)

go
 drop table Alumno
 select * from Alumno

ALTER PROCEDURE AgregarAlumno
	@nombreAlumno nvarchar (25),
	@semestre int
	--@matricula as ('ALU-' + convert(nvarchar, IDnombre)
as
begin 
		INSERT INTO Alumno (nombreAlumno, semestre) VALUES (@nombreAlumno, @semestre)
end

exec AgregarAlumno 'Yarely', 4
exec AgregarAlumno 'Cynthia',4

select * from Alumno
 ALTER PROCEDURE AgregarMateria
	@nombreMateria nvarchar (25),
	@semestre int
as 
begin
		INSERT INTO Materia (nombreMateria, semestre) VALUES (@nombreMateria, @semestre)
end 

select * from Alumno
go

ALTER PROCEDURE AgregarCalificacion
	--@IDcalificacion int identity(1,1) primary key,
	--@IDnombre int identity(1,1),
	--@IDmateria int identity(1,1),
	@matricula as ( 'ALU'- + convert(nvarchar,IDnombre) ),
	@cali1 int,
	@cali2 int,
	@cali3 int,
	@semestral int,
	@final int
as
begin
		INSERT INTO Calificaciones (@matricula, @cali1, @cali2, @cali3, @semestral, @final)
end
go

ALTER PROCEDURE MostrartodoslosAlumnos
as
begin 
	select matricula, nombreAlumno, semestre from Alumno
end

exec MostrartodoslosAlumnos
select * from Alumno
GO


CREATE PROCEDURE EliminarAlumno
	@nombreAlumno nvarchar (25),
	@semestre int
as
begin
	delete from Alumno where nombreAlumno = @nombreAlumno and semestre = @semestre
end
-- procedure va el dato que necesitas y el tipo de dato
CREATE PROCEDURE 

	@matricula nvarchar(50)
as
begin
	select nombreAlumno, semestre from Alumno 
	WHERE matricula = @matricula 
end

exec EliminarAlumno 'Marilu', 4
exec BuscarMatricula 'ALU-13'

select * from Alumno

CREATE PROCEDURE ModificarAlumno
	@nombreAlumno nvarchar (25),
	@semestre int
as 
begin
	UPDATE ModificarAlumno set nombreAlumno = @nuevonombreAlumno, semestre = @nuevosemestre
	WHERE nombreAlumno = @viejonombreAlumno
end
GO