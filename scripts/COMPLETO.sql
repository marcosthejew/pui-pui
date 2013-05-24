USE [master]
GO
/****** Object:  Database [puipuiDB]    Script Date: 23/05/2013 11:54:44 p.m. ******/
CREATE DATABASE [puipuiDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'puipuiDB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER\MSSQL\DATA\puipuiDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'puipuiDB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER\MSSQL\DATA\puipuiDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [puipuiDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [puipuiDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [puipuiDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [puipuiDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [puipuiDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [puipuiDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [puipuiDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [puipuiDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [puipuiDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [puipuiDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [puipuiDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [puipuiDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [puipuiDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [puipuiDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [puipuiDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [puipuiDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [puipuiDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [puipuiDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [puipuiDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [puipuiDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [puipuiDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [puipuiDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [puipuiDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [puipuiDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [puipuiDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [puipuiDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [puipuiDB] SET  MULTI_USER 
GO
ALTER DATABASE [puipuiDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [puipuiDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [puipuiDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [puipuiDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [puipuiDB]
GO
/****** Object:  StoredProcedure [dbo].[ActivarDesactivarPersona]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ActivarDesactivarPersona]
@estadoPersona nchar (50),
@idPersona bigint
as

BEGIN
	set nocount on
		
	  
	UPDATE [Persona]
	SET 
		[Persona].estadoPersona = @estadoPersona
		
	WHERE [Persona].idPersona = @idPersona

		
END;


GO
/****** Object:  StoredProcedure [dbo].[actualizarEjercicio]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizarEjercicio]
@nombreEjercicio nchar(50), @descripcionEjercicio nchar(250), @idMusculo int,
@idEjercicio int
as

BEGIN
    update Ejercicio
    set nombre = lower(@nombreEjercicio), descripcion = lower(@descripcionEjercicio),
    id_musculo = @idMusculo
    where id_ejercicio = @idEjercicio
END;


GO
/****** Object:  StoredProcedure [dbo].[actualizarHorario]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizarHorario]
@idInstructor int,
@dia nchar(20), 
@horaini time(7),
@horafin time(7)
as

BEGIN
    update Horario_Trabajo 
    set dia = @dia, 
		hora_inicio = @horaini,
		hora_fin = @horafin
    where id_instructor = @idInstructor
END;


GO
/****** Object:  StoredProcedure [dbo].[actualizarInstructor]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizarInstructor]
@id int,
@cedula nchar(50),
@primerNombre nchar(50),
@segundoNombre nchar(50),
@primerApellido nchar(50),
@segundoApelldo nchar(50),
@genero nchar(1),
@fecha_nacimiento date,
@ciudad nchar(50),
@direccion nchar(255),
@telefonoLocal bigint,
@telefonoCelular bigint,
@correoElectronico nchar(50),
@nombreEmergencia nchar(50),
@contactoEmergencia bigint,
@status nchar(15)
as

BEGIN
    update Instructor
    set
	 cedula = lower (@cedula),
	 primer_nombre= lower(@primerNombre),
	 segundo_nombre= lower(@segundoNombre),
	 primer_apellido= lower(@primerApellido),
	 segundo_apelldo= lower(@segundoApelldo),
	 genero= lower(@genero),
	 fecha_nacimiento= (@fecha_nacimiento),
	 ciudad= lower(@ciudad),
	 direccion= lower(@direccion),
	 telefono_local= (@telefonoLocal),
	 telefono_celular=(@telefonoCelular),
	 correo_electronico= lower(@correoElectronico),
	 nombre_contacto_emergencia= lower(@nombreEmergencia),
	 telefono_contacto_emergencia=(@contactoEmergencia),
	 status= lower(@status)	
	
    where id_instructor = @id
END;


GO
/****** Object:  StoredProcedure [dbo].[AgregarClase]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarClase]
@Nombre NVARCHAR(50),
@Descripcion NVARCHAR(200),
@Status int
AS

BEGIN

	SET NOCOUNT ON;

    
    Insert Clase values(@Nombre,@Descripcion,0);
	
END



GO
/****** Object:  StoredProcedure [dbo].[AgregarEvaluacionInstructor]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarEvaluacionInstructor]
@fechaEvaluacion DATETIME,
@calificacion INT,
@idCliente INT,
@idInstructor INT

AS

BEGIN
	SET NOCOUNT ON;
    
    INSERT INTO Evaluacion VALUES (@fechaEvaluacion,@calificacion,NULL,null,@idInstructor);
	
END;




GO
/****** Object:  StoredProcedure [dbo].[agregarHorario]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[agregarHorario]
@dia nchar (20),
@hora_inicio time (7),
@hora_fin time (7),
@id_instructor int
as

BEGIN
	INSERT
	INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	VALUES (@dia,@hora_inicio,@hora_fin,@id_instructor);
END;


GO
/****** Object:  StoredProcedure [dbo].[agregarInstructor]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[agregarInstructor]
@cedula nchar(50),
@primerNombre nchar(50),
@segundoNombre nchar(50),
@primerApellido nchar(50),
@segundoApelldo nchar(50),
@genero nchar(1),
@fecha_nacimiento date,
@fecha_registro date,
@ciudad nchar(50),
@direccion nchar(255),
@telefonoLocal bigint,
@telefonoCelular bigint,
@correoElectronico nchar(50),
@nombreEmergencia nchar(50),
@contactoEmergencia bigint,
@status nchar(15)
as

BEGIN
	INSERT 
	INTO Instructor(cedula, primer_nombre,segundo_nombre,primer_apellido,segundo_apelldo,genero,fecha_nacimiento,fecha_registro,ciudad,direccion,telefono_local,telefono_celular,correo_electronico,nombre_contacto_emergencia,telefono_contacto_emergencia,status)
	VALUES (@cedula, @primerNombre,@segundoNombre,@primerApellido,@segundoApelldo,@genero,@fecha_nacimiento,@fecha_registro,@ciudad,@direccion,@telefonoLocal,@telefonoCelular,@correoElectronico,@nombreEmergencia,@contactoEmergencia,@status);	
END;

GO
/****** Object:  StoredProcedure [dbo].[agregarMusculo]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[agregarMusculo]
@nombreMusculo nchar(50)
as

BEGIN
	INSERT INTO Musculo (nombre) VALUES (lower(@nombreMusculo));	
END;



GO
/****** Object:  StoredProcedure [dbo].[AgregarSalon]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarSalon]
@Ubicacion NVARCHAR(50),
@Capacidad int,
@Status int
AS

BEGIN

	SET NOCOUNT ON;

	
    
    Insert Salon values(@Ubicacion,@Capacidad,0);
	
END



GO
/****** Object:  StoredProcedure [dbo].[AgregarSalonClase]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarSalonClase]
@Id_salon NVARCHAR(50),
@Id_clase int,
@Id_instructor int
AS

BEGIN

	SET NOCOUNT ON;

	
    
    Insert Clase_Salon values(0,@Id_clase,@Id_salon,@Id_instructor);
	
END



GO
/****** Object:  StoredProcedure [dbo].[busca_rutina_idCliente]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[busca_rutina_idCliente]
@id_cli int
as

BEGIN
	set nocount on
		
	SELECT Distinct id_rutina
	FROM Historial_Ejercicio
	where id_persona = @id_cli	
END;



GO
/****** Object:  StoredProcedure [dbo].[busca_rutina_idEjercicio]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[busca_rutina_idEjercicio]
@id_cli int,
@id_ru int
as

BEGIN
	set nocount on
		
	SELECT id_ejercicio
	FROM Historial_Ejercicio
 where id_persona = @id_cli and id_rutina=@id_ru;
END;



GO
/****** Object:  StoredProcedure [dbo].[buscar_rutina]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[buscar_rutina]
@id_ruti int
as

BEGIN
	set nocount on
		
	SELECT *
	FROM Rutina 
	where id_rutina = @id_ruti		
END;



GO
/****** Object:  StoredProcedure [dbo].[buscar_ultimo_id]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[buscar_ultimo_id]
as
BEGIN
	set nocount on
		
	SELECT max(id_rutina)
	FROM Rutina 	
END;


GO
/****** Object:  StoredProcedure [dbo].[BusquedaCapacidadMayorSalon]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BusquedaCapacidadMayorSalon]
@Capacidad int
AS

BEGIN

	SET NOCOUNT ON;
	  
    Select id_salon, ubicacion,capacidad,estatus
    from Salon
    where capacidad >= @Capacidad;
	
END


GO
/****** Object:  StoredProcedure [dbo].[BusquedaCapacidadMenorSalon]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BusquedaCapacidadMenorSalon]
@Capacidad int
AS

BEGIN

	SET NOCOUNT ON;
	  
    Select id_salon, ubicacion,capacidad,estatus
    from Salon
    where capacidad <= @Capacidad;
	
END


GO
/****** Object:  StoredProcedure [dbo].[BusquedaNombreClase]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BusquedaNombreClase]
@Nombre NVARCHAR(50)
AS

BEGIN

	SET NOCOUNT ON;
	  
    Select id_clase, nombre,descripcion,estatus
    from clase
    where LOWER(nombre) like LOWER(@Nombre+'%');
	
END


GO
/****** Object:  StoredProcedure [dbo].[BusquedaStatusClase]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BusquedaStatusClase]
@Status int
AS

BEGIN

	SET NOCOUNT ON;
	  
    Select id_clase, nombre,descripcion,estatus
    from clase
    where estatus=@Status;
	
END


GO
/****** Object:  StoredProcedure [dbo].[BusquedaStatusSalon]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BusquedaStatusSalon]
@Status int
AS

BEGIN

	SET NOCOUNT ON;
	  
    Select id_salon, ubicacion,capacidad,estatus
    from Salon
    where estatus=@Status;
	
END


GO
/****** Object:  StoredProcedure [dbo].[BusquedaUbicacionSalon]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BusquedaUbicacionSalon]
@Ubicacion NVARCHAR(50)
AS

BEGIN

	SET NOCOUNT ON;
	  
    Select id_salon,ubicacion,capacidad,estatus
    from Salon
    where LOWER(ubicacion) like LOWER('%'+@Ubicacion+'%');
	
END


GO
/****** Object:  StoredProcedure [dbo].[cambiarContraseña]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cambiarContraseña]

	@idPersona bigint,
	@passwordPersona [nchar](50)
	
AS

BEGIN

	SET NOCOUNT ON;

    
	UPDATE [Persona]
	SET [Persona].passwordPersona = @passwordPersona
		

	WHERE [Persona].idPersona = @idPersona
	
END;


GO
/****** Object:  StoredProcedure [dbo].[consultarAccesoPersonaB]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[consultarAccesoPersonaB]
	@loginPersona nchar (50),
	@passwordPersona nchar (50)
as

BEGIN
	set nocount on
		SELECT P.loginPersona, P.passwordPersona
		FROM Persona AS P
		where P.loginPersona = @loginPersona and P.passwordPersona = @passwordPersona
		and P.tipoPersona = 'Admin'
END;


GO
/****** Object:  StoredProcedure [dbo].[consultarAccesoPersonaF]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultarAccesoPersonaF]
@loginPersona nchar (50),
@passwordPersona nchar (50)
as

BEGIN
	set nocount on
		SELECT P.loginPersona, P.passwordPersona
		FROM Persona AS P
		where P.loginPersona = @loginPersona and P.passwordPersona = @passwordPersona
		and P.tipoPersona = 'Cliente'
END;



GO
/****** Object:  StoredProcedure [dbo].[consultarActivarDesactivarPersona]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultarActivarDesactivarPersona]
as

BEGIN
	set nocount on
		
	SELECT P.idPersona, P.nombrePersona1, P.apellidoPersona1, P.estadoPersona
	FROM Persona AS P
	
		
END;


GO
/****** Object:  StoredProcedure [dbo].[consultarDetallePersona]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultarDetallePersona]
@idPersona bigint
as

BEGIN
	set nocount on
		
		SELECT *
	FROM Persona AS P
	where P.idPersona = @idPersona

END;



GO
/****** Object:  StoredProcedure [dbo].[consultarEjercicio]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultarEjercicio]
@nombre nchar(50)
as
BEGIN	
set nocount on	
    select E.id_ejercicio, lower(E.nombre), lower(E.descripcion), M.id_musculo, lower(M.nombre)   
    from
      Ejercicio E, Musculo M   
    where M.id_musculo = E.id_musculo and E.nombre = @nombre		
END;


GO
/****** Object:  StoredProcedure [dbo].[ConsultarEvaluacionesTodas]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ConsultarEvaluacionesTodas]
AS

BEGIN
	SET NOCOUNT ON
		
	SELECT I.*, E.*
	FROM Instructor I, Evaluacion E
	WHERE I.id_instructor = E.id_instructor
	
END;




GO
/****** Object:  StoredProcedure [dbo].[consultarHorariosInstructor]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultarHorariosInstructor]
@cedula nchar(50)
as
BEGIN
set nocount on	
select  H.dia, H.hora_inicio, H.hora_fin
        from Instructor I, Horario_Trabajo H
		where I.id_instructor=H.id_instructor and I.cedula=	@cedula
END;


GO
/****** Object:  StoredProcedure [dbo].[consultarInstructor]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultarInstructor]
@cedula nchar(50)
as
BEGIN	
set nocount on	
  select i.cedula, i.primer_nombre,i.segundo_nombre,i.primer_apellido,i.segundo_apelldo,i.genero,i.fecha_nacimiento,i.fecha_registro,i.ciudad,i.direccion,i.telefono_local,i.telefono_celular,i.correo_electronico,i.nombre_contacto_emergencia,i.telefono_contacto_emergencia,i.status  
  from
    Instructor I  
  where I.cedula = @cedula	
END;


GO
/****** Object:  StoredProcedure [dbo].[consultarPersona]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[consultarPersona]
as

BEGIN
	set nocount on
		
	SELECT P.idPersona, P.cedulaPersona, P.nombrePersona1 +' '+ P.nombrePersona2 as nombrePersona1, 
	       P.apellidoPersona1+' '+P.apellidoPersona2 as apellidoPersona1, P.fechaIngresoPersona
	FROM Persona P
		
END;


GO
/****** Object:  StoredProcedure [dbo].[consultarPersonaCedula]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultarPersonaCedula]
@cedulaPersona bigint
as
BEGIN
	set nocount on
		
	SELECT P.idPersona, P.cedulaPersona, P.nombrePersona1 +' '+ P.nombrePersona2 as nombrePersona1, 
	       P.apellidoPersona1+' '+P.apellidoPersona2 as apellidoPersona1, P.fechaIngresoPersona
	FROM Persona P
	where P.cedulaPersona = @cedulaPersona
		
END;


GO
/****** Object:  StoredProcedure [dbo].[consultarPersonaNombre]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultarPersonaNombre]
@nombrePersona1 nchar (50)
as
BEGIN
	set nocount on
		
	SELECT P.idPersona, P.cedulaPersona, P.nombrePersona1 +' '+ P.nombrePersona2 as nombrePersona1, 
	       P.apellidoPersona1+' '+P.apellidoPersona2 as apellidoPersona1, P.fechaIngresoPersona
	FROM Persona P
	where (P.nombrePersona1 = @nombrePersona1 or P.nombrePersona2 = @nombrePersona1 or 
	       P.apellidoPersona1 = @nombrePersona1 or P.apellidoPersona2 = @nombrePersona1)
		
END;


GO
/****** Object:  StoredProcedure [dbo].[consultarPersonaPorLogin]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultarPersonaPorLogin]
@loginPersona nchar (50)
as

BEGIN
 set nocount on
  
  SELECT *
 FROM Persona AS P
 where P.loginPersona = @loginPersona

END;

GO
/****** Object:  StoredProcedure [dbo].[ConsultarReservacionesInstructorTodas]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ConsultarReservacionesInstructorTodas]
AS

BEGIN
	SET NOCOUNT ON
		
	SELECT *
	FROM Reservacion_Instructor
	
END;

GO
/****** Object:  StoredProcedure [dbo].[consultarTodosEjercicios]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultarTodosEjercicios]
as
BEGIN
set nocount on	
        select E.id_ejercicio, E.nombre
        from Ejercicio E
        order by E.nombre ASC
END;


GO
/****** Object:  StoredProcedure [dbo].[consultarTodosInstructores]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultarTodosInstructores]
as
BEGIN
set nocount on	
select  I.id_instructor, I.cedula, I.primer_nombre, I.primer_apellido
        from Instructor I
        order by I.primer_nombre, I.primer_apellido ASC
END;


GO
/****** Object:  StoredProcedure [dbo].[consultarTodosInstructoresActivos]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultarTodosInstructoresActivos]
as
BEGIN
set nocount on	
select  I.id_instructor, I.cedula, I.primer_nombre, I.primer_apellido
        from Instructor I
        where I.status = 'Activo'
        order by I.primer_nombre, I.primer_apellido ASC
END;


GO
/****** Object:  StoredProcedure [dbo].[consultarTodosMusculos]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultarTodosMusculos]
as
BEGIN
set nocount on	
        select M.id_musculo, lower(M.nombre)
        from Musculo M
        order by M.nombre ASC
END;


GO
/****** Object:  StoredProcedure [dbo].[delete_Historial_Rutina]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[delete_Historial_Rutina]
@id_ruti int,
@id_cli  int
as
BEGIN
set nocount on	
DELETE FROM Historial_Ejercicio where id_rutina = @id_ruti and id_persona=@id_cli
END;


GO
/****** Object:  StoredProcedure [dbo].[DetalleClase]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DetalleClase]
@idclass int
AS

BEGIN

	SET NOCOUNT ON;

    
    Select nombre,descripcion,estatus
    from clase
    where id_clase=@idclass;
	
END


GO
/****** Object:  StoredProcedure [dbo].[DetalleSalon]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DetalleSalon]
@id_salon int
AS

BEGIN

	SET NOCOUNT ON;

    
    Select ubicacion,capacidad,estatus
    from Salon
    where id_salon=@id_salon;
	
END


GO
/****** Object:  StoredProcedure [dbo].[eliminarEjercicio]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[eliminarEjercicio]
@nombreEjercicio nchar(50)
as

BEGIN
	set nocount on
        
        delete from Ejercicio
        where nombre = @nombreEjercicio
END;


GO
/****** Object:  StoredProcedure [dbo].[eliminarInstructor]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[eliminarInstructor]
@cedula nchar (50)

as

BEGIN
	UPDATE Instructor
	SET status='Inactivo'
	WHERE cedula=@cedula
END;


GO
/****** Object:  StoredProcedure [dbo].[eliminarMusculo]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[eliminarMusculo]
@idMusculo int
as

BEGIN
	set nocount on
        
        delete from Musculo
        where id_musculo = @idMusculo
END;


GO
/****** Object:  StoredProcedure [dbo].[existeEjercicio]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[existeEjercicio]
@nombreEjercicio nchar(50)
as

BEGIN
	set nocount on
		
	SELECT E.id_ejercicio
	FROM Ejercicio AS E
	where E.nombre = @nombreEjercicio		
END;



GO
/****** Object:  StoredProcedure [dbo].[existeEjercicioConMusculo]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[existeEjercicioConMusculo]
@idMusculo int
as

BEGIN
	set nocount on
        
        select E.id_musculo
        from Ejercicio E
        where E.id_musculo = @idMusculo
END;


GO
/****** Object:  StoredProcedure [dbo].[existeInstructor]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[existeInstructor]
@cedula nchar (50)
as

BEGIN
	Select cedula
	FROM Instructor
	where cedula=@cedula
END;


GO
/****** Object:  StoredProcedure [dbo].[existeMusculo]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[existeMusculo]
@nombreMusculo nchar(50)
as

BEGIN
	set nocount on
		
	SELECT M.id_musculo
	FROM Musculo AS M
	where M.nombre = @nombreMusculo		
END;



GO
/****** Object:  StoredProcedure [dbo].[existeNombreOtroId]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[existeNombreOtroId]
@nombreEjercicio nchar(50),
@idEjercicio int
as

BEGIN
	set nocount on
		
	SELECT E.id_ejercicio
	FROM Ejercicio AS E
	where E.nombre = lower(@nombreEjercicio)
	and id_ejercicio <> @idEjercicio
END;



GO
/****** Object:  StoredProcedure [dbo].[existeRutinaConEjercicio]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[existeRutinaConEjercicio]
@nombreEjercicio nchar(50)
as

BEGIN
	set nocount on
        
        select H.id_ejercicio
        from Historial_Ejercicio H, Ejercicio E
        where E.nombre = lower(@nombreEjercicio)
        and H.id_ejercicio = E.id_ejercicio
END;


GO
/****** Object:  StoredProcedure [dbo].[insertar_HistorialEjercicio]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_HistorialEjercicio]
@id_rutina int,
@id_cliente int,
@id_ejercicio int
as

BEGIN
	INSERT INTO Historial_Ejercicio VALUES (@id_cliente,@id_rutina,@id_ejercicio);	
END;



GO
/****** Object:  StoredProcedure [dbo].[insertar_Rutina]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_Rutina]
@descripcion nchar(50),
@duracion time(7),
@repeticiones int
as

BEGIN
	INSERT INTO Rutina VALUES (@descripcion,Convert(Time(7),@duracion,108),@repeticiones);	
END;



GO
/****** Object:  StoredProcedure [dbo].[insertarCliente]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertarCliente]
	@cedulaCliente bigint,
	@primerNombreCliente nchar(50),
	@segundoNombreCliente nchar(50),
	@primerApellidoCliente nchar(50),
	@segundoaApellidoCliente nchar(50),
	@genero nchar(10),
	@fechaNacimiento datetime,
	@fechaRegistro datetime,
	@ciudad nchar(50),
	@direccion nchar(200),
	@telefonoLocal nchar(12),
	@telefonoCelular nchar(12),
	@email nchar(50),
	@nombreContactoEmergencia nchar(100),
	@telefonoContactoEmergencia nchar(12),
	@estado nchar(10),
	@usuario nchar(50),
	@password nchar(20),
	@tipo nchar(20)
as
BEGIN	
INSERT INTO Persona (cedulaPersona, nombrePersona1,nombrePersona2,apellidoPersona1,apellidoPersona2,generoPersona,fechaNacimientoPersona,fechaIngresoPersona,ciudadPersona,DireccionPersona,telefonoLocalPersona,telefonoCelularPersona,correoPersona,contactoNombrePersona,contactoTelefonoPersona,estadoPersona,loginPersona,passwordPersona,tipoPersona)
	   VALUES (@cedulacliente,@primerNombreCliente,@segundoNombreCliente,@primerApellidoCliente,@segundoaApellidoCliente,@genero,@fechaNacimiento,@fechaRegistro,@ciudad,@direccion,@telefonoLocal,@telefonoCelular,@email,@nombreContactoEmergencia,@telefonoContactoEmergencia,@estado,@usuario,@password,@tipo);
END;


GO
/****** Object:  StoredProcedure [dbo].[insertarEjercicio]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertarEjercicio]
@nombreEjercicio nchar(50),
@descripcionEjercicio nchar(250),
@idMusculo int
as
BEGIN
set nocount on	
        INSERT INTO Ejercicio (nombre, descripcion, id_musculo)
        VALUES (@nombreEjercicio, @descripcionEjercicio, @idMusculo);
END;



GO
/****** Object:  StoredProcedure [dbo].[ListarClases]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarClases]
AS

BEGIN

	SET NOCOUNT ON;

    
    Select id_clase,nombre,estatus
    from clase;
	
END



GO
/****** Object:  StoredProcedure [dbo].[ListarSalones]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarSalones]
AS

BEGIN

	SET NOCOUNT ON;

    
    Select id_salon,ubicacion,capacidad, estatus
    from Salon;
	
END



GO
/****** Object:  StoredProcedure [dbo].[ListarSalonesClase]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarSalonesClase]
AS

BEGIN

	SET NOCOUNT ON;

    
    Select clasal.id_clase_salon, clas.nombre,sal.ubicacion,ins.primer_nombre, ins.primer_apellido, clasal.isReservado
    from Clase clas, Salon sal, Instructor ins, Clase_Salon clasal
	where clasal.id_clase=clas.id_clase
	and clasal.id_salon=sal.id_salon
	and clasal.id_instructor=ins.id_instructor;
	
END



GO
/****** Object:  StoredProcedure [dbo].[ListarSalonesClaseTclase]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarSalonesClaseTclase]
@nombre varchar(50) 
AS

BEGIN

	SET NOCOUNT ON;

    
    Select clasal.id_clase_salon, clas.nombre,sal.ubicacion,ins.primer_nombre+' '+ins.primer_apellido, clasal.isReservado
    from Clase clas, Salon sal, Instructor ins, Clase_Salon clasal
	where LOWER(clas.nombre) like LOWER(@nombre+'%')
	and clasal.id_clase=clas.id_clase
	and clasal.id_salon=sal.id_salon
	and clasal.id_instructor=ins.id_instructor;
	
END



GO
/****** Object:  StoredProcedure [dbo].[ListarSalonesClaseTdisponible]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarSalonesClaseTdisponible]
@reservacion int 
AS

BEGIN

	SET NOCOUNT ON;

    
    Select clasal.id_clase_salon, clas.nombre,sal.ubicacion,ins.primer_nombre+' '+ins.primer_apellido, clasal.isReservado
    from Clase clas, Salon sal, Instructor ins, Clase_Salon clasal
	where clasal.isReservado=@reservacion
	and clasal.id_clase=clas.id_clase
	and clasal.id_salon=sal.id_salon
	and clasal.id_instructor=ins.id_instructor;
	
END



GO
/****** Object:  StoredProcedure [dbo].[ListarSalonesClaseTinstructor]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarSalonesClaseTinstructor]
@Nombre int 
AS

BEGIN

	SET NOCOUNT ON;

    
    Select clasal.id_clase_salon,clas.nombre,sal.ubicacion,ins.primer_nombre+' '+ins.primer_apellido, clasal.isReservado
    from Clase clas, Salon sal, Instructor ins, Clase_Salon clasal
	where LOWER(ins.primer_nombre) like LOWER(@Nombre+'%')
	or LOWER(ins.primer_apellido) like LOWER(@Nombre+'%')
	and clasal.id_clase=clas.id_clase
	and clasal.id_salon=sal.id_salon
	and clasal.id_instructor=ins.id_instructor;
	
END



GO
/****** Object:  StoredProcedure [dbo].[ListarSalonesClaseTsalon]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarSalonesClaseTsalon]
@Ubicacion int 
AS

BEGIN

	SET NOCOUNT ON;

    
    Select clasal.id_clase_salon, clas.nombre,sal.ubicacion,ins.primer_nombre+' '+ins.primer_apellido, clasal.isReservado
    from Clase clas, Salon sal, Instructor ins, Clase_Salon clasal
	where LOWER(sal.ubicacion) like LOWER(@Ubicacion+'%')
	and clasal.id_clase=clas.id_clase
	and clasal.id_salon=sal.id_salon
	and clasal.id_instructor=ins.id_instructor;
	
END



GO
/****** Object:  StoredProcedure [dbo].[ModificarClase]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarClase]
@Id_clase int,
@Nombre NVARCHAR(50),
@Descripcion NVARCHAR(200),
@Status int
AS

BEGIN

	SET NOCOUNT ON;

    update Clase set nombre=@Nombre, descripcion=@Descripcion, estatus=@Status where id_clase=@Id_clase;
    
	
END



GO
/****** Object:  StoredProcedure [dbo].[ModificarEvaluacionInstructor]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarEvaluacionInstructor]
@calificacion INT,
@idCliente INT,
@idInstructor INT

AS

BEGIN
	SET NOCOUNT ON;
    
    UPDATE Evaluacion SET fecha_evaluacion=getdate(), calificacion=@calificacion 
	WHERE id_instructor=@idInstructor AND id_persona=@idCliente;
	
END;


--DROP procedure [dbo].[ConsultarEvaluacionesTodas]
--DROP procedure [dbo].[AgregarEvaluacionInstructor]
--DROP PROCEDURE [dbo].[ModificarEvaluacionInstructor]

GO
/****** Object:  StoredProcedure [dbo].[modificarPersona]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[modificarPersona]

	@idPersona bigint,
	@cedulaPersona bigint,
	@nombrePersona1 [nchar](50),
	@nombrePersona2 [nchar](50),
	@apellidoPersona1 [nchar](50),
	@apellidoPersona2 [nchar](50),
	@generoPersona [nchar](50),
	@fechaNacimientoPersona [date],
	@fechaIngresoPersona [date],
	@ciudadPersona [nchar](50),
	@direccionPersona [nchar](300),
	@telefonoLocalPersona [nchar](50),
	@telefonoCelularPersona [nchar](50),
	@correoPersona [nchar](50),
	@contactoNombrePersona [nchar](50),
	@contactoTelefonoPersona [nchar](50),
	@estadoPersona [nchar](50),
	@loginPersona [nchar](50),
	@passwordPersona [nchar](50),
	@tipoPersona [nchar](50)

AS

BEGIN

	SET NOCOUNT ON;

    
	UPDATE [Persona]
	SET [Persona].cedulaPersona = @cedulaPersona, 
		[Persona].nombrePersona1 = @nombrePersona1, 
		[Persona].nombrePersona2 = @nombrePersona2,
		[Persona].apellidoPersona1 = @apellidoPersona1,
		[Persona].apellidoPersona2 = @apellidoPersona2,
		[Persona].generoPersona = @generoPersona,
		[Persona].fechaNacimientoPersona = @fechaNacimientoPersona,
		[Persona].ciudadPersona = @ciudadPersona,
		[Persona].DireccionPersona = @direccionPersona,
		[Persona].telefonoLocalPersona = @telefonoLocalPersona,
		[Persona].telefonoCelularPersona = @telefonoCelularPersona,
		[Persona].correoPersona = @correoPersona,
		[Persona].contactoNombrePersona = @contactoNombrePersona,
		[Persona].contactoTelefonoPersona = @contactoTelefonoPersona,
		[Persona].estadoPersona = @estadoPersona,
		[Persona].loginPersona = @loginPersona,
		[Persona].passwordPersona = @passwordPersona,
		[Persona].tipoPersona = @tipoPersona

	WHERE [Persona].idPersona = @idPersona
	
END;


GO
/****** Object:  StoredProcedure [dbo].[ModificarSalon]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarSalon]
@Id_salon int,
@Ubicacion NVARCHAR(50),
@Capacidad NVARCHAR(200),
@Status int
AS

BEGIN

	SET NOCOUNT ON;

    update Salon set ubicacion=@Ubicacion, capacidad=@Capacidad, estatus=@Status where id_salon=@Id_salon;
    
	
END



GO
/****** Object:  StoredProcedure [dbo].[ModificarSalonClase]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarSalonClase]
@Id_salon NVARCHAR(50),
@Id_clase int,
@Id_instructor int,
@Id_clase_salon int,
@disponibilidad int
AS

BEGIN

	SET NOCOUNT ON;

	
    
    update Clase_Salon set id_clase=@Id_clase,id_salon=@Id_salon,id_instructor= @Id_instructor, isReservado=@disponibilidad where id_clase_salon=@Id_clase_salon ;
	
END



GO
/****** Object:  StoredProcedure [dbo].[obtenerIdInstructor]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtenerIdInstructor]
@cedula nchar (50)

as

BEGIN
	SELECT id_instructor
	FROM Instructor
	WHERE cedula=@cedula
END;


GO
/****** Object:  StoredProcedure [dbo].[tieneClase]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[tieneClase]
@cedula nchar(50)
as
BEGIN
set nocount on	
        select C.id_instructor
        from Clase_Salon C, Instructor I
        where C.id_instructor = I.id_instructor
        and I.cedula = @cedula
END;


GO
/****** Object:  StoredProcedure [dbo].[tieneCliente]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[tieneCliente]
@cedula nchar(50)
as
BEGIN
set nocount on	
        select R.id_instructor
		from Reservacion_Instructor R, Instructor I
		where R.id_instructor = I.id_instructor
		and I.cedula = @cedula
END;


GO
/****** Object:  StoredProcedure [dbo].[tieneEvaluacion]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[tieneEvaluacion]
@cedula nchar(50)
as
BEGIN
set nocount on	
        select E.id_instructor
		from Evaluacion E, Instructor I
		where E.id_instructor = I.id_instructor
		and I.cedula = @cedula
END;


GO
/****** Object:  StoredProcedure [dbo].[update_Rutina]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[update_Rutina]
@id_ruti int,
@descripcion nchar(50),
@duracion time(7),
@repeticiones int
as
BEGIN
set nocount on	
update Rutina set descripcion=@descripcion , duracion=@duracion ,repeteciones=@repeticiones where id_rutina = @id_ruti
END;


GO
/****** Object:  Table [dbo].[Clase]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clase](
	[id_clase] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](50) NOT NULL,
	[descripcion] [nchar](255) NULL,
	[estatus] [int] NOT NULL,
 CONSTRAINT [PK_Clase] PRIMARY KEY CLUSTERED 
(
	[id_clase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clase_Salon]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clase_Salon](
	[id_clase_salon] [int] IDENTITY(1,1) NOT NULL,
	[isReservado] [int] NOT NULL,
	[id_clase] [int] NOT NULL,
	[id_salon] [int] NOT NULL,
	[id_instructor] [int] NULL,
 CONSTRAINT [PK_Clase_Salon] PRIMARY KEY CLUSTERED 
(
	[id_clase_salon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ejercicio]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ejercicio](
	[id_ejercicio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](50) NOT NULL,
	[descripcion] [nchar](255) NOT NULL,
	[id_musculo] [int] NOT NULL,
 CONSTRAINT [PK_Ejercicio] PRIMARY KEY CLUSTERED 
(
	[id_ejercicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Evaluacion]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluacion](
	[id_evaluacion] [int] IDENTITY(1,1) NOT NULL,
	[fecha_evaluacion] [datetime] NOT NULL,
	[calificacion] [int] NOT NULL,
	[id_clase_salon] [int] NULL,
	[id_persona] [int] NULL,
	[id_instructor] [int] NOT NULL,
 CONSTRAINT [PK_Evaluacion] PRIMARY KEY CLUSTERED 
(
	[id_evaluacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Historial_Ejercicio]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historial_Ejercicio](
	[id_historial_ejercicio] [int] IDENTITY(1,1) NOT NULL,
	[id_persona] [int] NOT NULL,
	[id_rutina] [int] NOT NULL,
	[id_ejercicio] [int] NOT NULL,
 CONSTRAINT [PK_Historial_Ejercicio] PRIMARY KEY CLUSTERED 
(
	[id_historial_ejercicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Horario_Reserva]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horario_Reserva](
	[id_horario_reserva] [int] IDENTITY(1,1) NOT NULL,
	[fecha_inicio] [datetime] NOT NULL,
	[fecha_fin] [datetime] NOT NULL,
	[id_clase_salon] [int] NOT NULL,
 CONSTRAINT [PK_Horario_Reserva] PRIMARY KEY CLUSTERED 
(
	[id_horario_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Horario_Trabajo]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horario_Trabajo](
	[id_horario_trabajo] [int] IDENTITY(1,1) NOT NULL,
	[dia] [nchar](20) NOT NULL,
	[hora_inicio] [time](7) NOT NULL,
	[hora_fin] [time](7) NOT NULL,
	[id_instructor] [int] NOT NULL,
 CONSTRAINT [PK_Horario_Trabajo] PRIMARY KEY CLUSTERED 
(
	[id_horario_trabajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Instructor]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instructor](
	[id_instructor] [int] IDENTITY(1,1) NOT NULL,
	[primer_nombre] [nchar](50) NOT NULL,
	[segundo_nombre] [nchar](50) NULL,
	[primer_apellido] [nchar](50) NOT NULL,
	[segundo_apelldo] [nchar](50) NULL,
	[genero] [nchar](1) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[fecha_registro] [date] NOT NULL,
	[ciudad] [nchar](50) NOT NULL,
	[direccion] [nchar](255) NOT NULL,
	[telefono_local] [bigint] NULL,
	[telefono_celular] [bigint] NULL,
	[correo_electronico] [nchar](50) NOT NULL,
	[nombre_contacto_emergencia] [nchar](50) NOT NULL,
	[telefono_contacto_emergencia] [bigint] NULL,
	[status] [nchar](15) NOT NULL,
	[cedula] [bigint] NULL,
 CONSTRAINT [PK_Instructor] PRIMARY KEY CLUSTERED 
(
	[id_instructor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Musculo]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musculo](
	[id_musculo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Musculo] PRIMARY KEY CLUSTERED 
(
	[id_musculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Persona]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[idPersona] [int] IDENTITY(1,1) NOT NULL,
	[cedulaPersona] [bigint] NOT NULL,
	[nombrePersona1] [nchar](50) NOT NULL,
	[nombrePersona2] [nchar](50) NULL,
	[apellidoPersona1] [nchar](50) NOT NULL,
	[apellidoPersona2] [nchar](50) NULL,
	[generoPersona] [nchar](50) NOT NULL,
	[fechaNacimientoPersona] [date] NOT NULL,
	[fechaIngresoPersona] [date] NOT NULL,
	[ciudadPersona] [nchar](50) NOT NULL,
	[DireccionPersona] [nchar](300) NOT NULL,
	[telefonoLocalPersona] [nchar](50) NULL,
	[telefonoCelularPersona] [nchar](50) NULL,
	[correoPersona] [nchar](50) NULL,
	[contactoNombrePersona] [nchar](50) NULL,
	[contactoTelefonoPersona] [nchar](50) NULL,
	[estadoPersona] [nchar](10) NOT NULL,
	[loginPersona] [nchar](50) NOT NULL,
	[passwordPersona] [nchar](50) NOT NULL,
	[tipoPersona] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reservacion_Clase]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservacion_Clase](
	[id_reservacion_clase] [int] IDENTITY(1,1) NOT NULL,
	[fecha_reservacion] [datetime] NOT NULL,
	[status] [nchar](15) NOT NULL,
	[id_horario_reserva] [int] NOT NULL,
	[id_persona] [int] NOT NULL,
 CONSTRAINT [PK_Reservacion_Clase] PRIMARY KEY CLUSTERED 
(
	[id_reservacion_clase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reservacion_Instructor]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservacion_Instructor](
	[id_reservacion_instructor] [int] IDENTITY(1,1) NOT NULL,
	[fecha_reservacion] [datetime] NOT NULL,
	[fecha_inicio] [datetime] NOT NULL,
	[fecha_fin] [datetime] NOT NULL,
	[status] [nchar](15) NOT NULL,
	[id_instructor] [int] NOT NULL,
	[id_persona] [int] NOT NULL,
 CONSTRAINT [PK_Reservacion_Instructor] PRIMARY KEY CLUSTERED 
(
	[id_reservacion_instructor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rutina]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rutina](
	[id_rutina] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nchar](50) NOT NULL,
	[duracion] [time](7) NOT NULL,
	[repeteciones] [int] NULL,
 CONSTRAINT [PK_Rutina] PRIMARY KEY CLUSTERED 
(
	[id_rutina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Salon]    Script Date: 23/05/2013 11:54:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salon](
	[id_salon] [int] IDENTITY(1,1) NOT NULL,
	[ubicacion] [nchar](50) NOT NULL,
	[capacidad] [int] NOT NULL,
	[estatus] [int] NOT NULL,
 CONSTRAINT [PK_Salon] PRIMARY KEY CLUSTERED 
(
	[id_salon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Clase_Salon]  WITH CHECK ADD  CONSTRAINT [FK_Clase_Salon_Clase] FOREIGN KEY([id_clase])
REFERENCES [dbo].[Clase] ([id_clase])
GO
ALTER TABLE [dbo].[Clase_Salon] CHECK CONSTRAINT [FK_Clase_Salon_Clase]
GO
ALTER TABLE [dbo].[Clase_Salon]  WITH CHECK ADD  CONSTRAINT [FK_Clase_Salon_Instructor] FOREIGN KEY([id_instructor])
REFERENCES [dbo].[Instructor] ([id_instructor])
GO
ALTER TABLE [dbo].[Clase_Salon] CHECK CONSTRAINT [FK_Clase_Salon_Instructor]
GO
ALTER TABLE [dbo].[Clase_Salon]  WITH CHECK ADD  CONSTRAINT [FK_Clase_Salon_Salon] FOREIGN KEY([id_salon])
REFERENCES [dbo].[Salon] ([id_salon])
GO
ALTER TABLE [dbo].[Clase_Salon] CHECK CONSTRAINT [FK_Clase_Salon_Salon]
GO
ALTER TABLE [dbo].[Ejercicio]  WITH CHECK ADD  CONSTRAINT [FK_Ejercicio_Musculo] FOREIGN KEY([id_musculo])
REFERENCES [dbo].[Musculo] ([id_musculo])
GO
ALTER TABLE [dbo].[Ejercicio] CHECK CONSTRAINT [FK_Ejercicio_Musculo]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_Clase_Salon] FOREIGN KEY([id_clase_salon])
REFERENCES [dbo].[Clase_Salon] ([id_clase_salon])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_Evaluacion_Clase_Salon]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_Instructor] FOREIGN KEY([id_instructor])
REFERENCES [dbo].[Instructor] ([id_instructor])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_Evaluacion_Instructor]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_Persona] FOREIGN KEY([id_persona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_Evaluacion_Persona]
GO
ALTER TABLE [dbo].[Historial_Ejercicio]  WITH CHECK ADD  CONSTRAINT [FK_Historial_Ejercicio_Ejercicio] FOREIGN KEY([id_ejercicio])
REFERENCES [dbo].[Ejercicio] ([id_ejercicio])
GO
ALTER TABLE [dbo].[Historial_Ejercicio] CHECK CONSTRAINT [FK_Historial_Ejercicio_Ejercicio]
GO
ALTER TABLE [dbo].[Historial_Ejercicio]  WITH CHECK ADD  CONSTRAINT [FK_Historial_Ejercicio_Persona] FOREIGN KEY([id_persona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Historial_Ejercicio] CHECK CONSTRAINT [FK_Historial_Ejercicio_Persona]
GO
ALTER TABLE [dbo].[Historial_Ejercicio]  WITH CHECK ADD  CONSTRAINT [FK_Historial_Ejercicio_Rutina] FOREIGN KEY([id_rutina])
REFERENCES [dbo].[Rutina] ([id_rutina])
GO
ALTER TABLE [dbo].[Historial_Ejercicio] CHECK CONSTRAINT [FK_Historial_Ejercicio_Rutina]
GO
ALTER TABLE [dbo].[Horario_Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Horario_Reserva_Clase_Salon] FOREIGN KEY([id_clase_salon])
REFERENCES [dbo].[Clase_Salon] ([id_clase_salon])
GO
ALTER TABLE [dbo].[Horario_Reserva] CHECK CONSTRAINT [FK_Horario_Reserva_Clase_Salon]
GO
ALTER TABLE [dbo].[Horario_Trabajo]  WITH CHECK ADD  CONSTRAINT [FK_Horario_Trabajo_Instructor] FOREIGN KEY([id_instructor])
REFERENCES [dbo].[Instructor] ([id_instructor])
GO
ALTER TABLE [dbo].[Horario_Trabajo] CHECK CONSTRAINT [FK_Horario_Trabajo_Instructor]
GO
ALTER TABLE [dbo].[Reservacion_Clase]  WITH CHECK ADD  CONSTRAINT [FK_Reservacion_Clase_Horario_Reserva] FOREIGN KEY([id_horario_reserva])
REFERENCES [dbo].[Horario_Reserva] ([id_horario_reserva])
GO
ALTER TABLE [dbo].[Reservacion_Clase] CHECK CONSTRAINT [FK_Reservacion_Clase_Horario_Reserva]
GO
ALTER TABLE [dbo].[Reservacion_Clase]  WITH CHECK ADD  CONSTRAINT [FK_Reservacion_Clase_Persona] FOREIGN KEY([id_persona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Reservacion_Clase] CHECK CONSTRAINT [FK_Reservacion_Clase_Persona]
GO
ALTER TABLE [dbo].[Reservacion_Instructor]  WITH CHECK ADD  CONSTRAINT [FK_Reservacion_Instructor_Instructor] FOREIGN KEY([id_instructor])
REFERENCES [dbo].[Instructor] ([id_instructor])
GO
ALTER TABLE [dbo].[Reservacion_Instructor] CHECK CONSTRAINT [FK_Reservacion_Instructor_Instructor]
GO
ALTER TABLE [dbo].[Reservacion_Instructor]  WITH CHECK ADD  CONSTRAINT [FK_Reservacion_Instructor_Persona] FOREIGN KEY([id_persona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Reservacion_Instructor] CHECK CONSTRAINT [FK_Reservacion_Instructor_Persona]
GO
ALTER TABLE [dbo].[Clase_Salon]  WITH CHECK ADD  CONSTRAINT [CK_Clase_Salon_IsReservado] CHECK  (([isReservado]=(0) OR [isReservado]=(1)))
GO
ALTER TABLE [dbo].[Clase_Salon] CHECK CONSTRAINT [CK_Clase_Salon_IsReservado]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [CK_Evaluacion_Calificacion] CHECK  (([calificacion]>=(0) AND [calificacion]<=(10)))
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [CK_Evaluacion_Calificacion]
GO
ALTER TABLE [dbo].[Horario_Trabajo]  WITH CHECK ADD  CONSTRAINT [CK_Horario_Trabajo_Dia] CHECK  (([dia]='lunes' OR [dia]='martes' OR [dia]='miercoles' OR [dia]='jueves' OR [dia]='viernes' OR [dia]='sabado' OR [dia]='domingo'))
GO
ALTER TABLE [dbo].[Horario_Trabajo] CHECK CONSTRAINT [CK_Horario_Trabajo_Dia]
GO
ALTER TABLE [dbo].[Instructor]  WITH CHECK ADD  CONSTRAINT [CK_Instructor_genero] CHECK  (([genero]='m' OR [genero]='f'))
GO
ALTER TABLE [dbo].[Instructor] CHECK CONSTRAINT [CK_Instructor_genero]
GO
ALTER TABLE [dbo].[Instructor]  WITH CHECK ADD  CONSTRAINT [CK_Instructor_status] CHECK  (([status]='activo' OR [status]='inactivo'))
GO
ALTER TABLE [dbo].[Instructor] CHECK CONSTRAINT [CK_Instructor_status]
GO
ALTER TABLE [dbo].[Reservacion_Clase]  WITH CHECK ADD  CONSTRAINT [CK_Reservacion_Clase_Status] CHECK  (([status]='completada' OR [status]='cancelada' OR [status]='espera'))
GO
ALTER TABLE [dbo].[Reservacion_Clase] CHECK CONSTRAINT [CK_Reservacion_Clase_Status]
GO
ALTER TABLE [dbo].[Reservacion_Instructor]  WITH CHECK ADD  CONSTRAINT [CK_Reservacion_Instructor_Status] CHECK  (([status]='completada' OR [status]='cancelada' OR [status]='espera'))
GO
ALTER TABLE [dbo].[Reservacion_Instructor] CHECK CONSTRAINT [CK_Reservacion_Instructor_Status]
GO
USE [master]
GO
ALTER DATABASE [puipuiDB] SET  READ_WRITE 
GO
