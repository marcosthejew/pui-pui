USE [puipuiDB]
GO
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
@telefonoLocal int,
@telefonoCelular int,
@correoElectronico nchar(50),
@nombreEmergencia nchar(50),
@contactoEmergencia int,
@status nchar(15)
as

BEGIN
	INSERT 
	INTO Instructor(cedula, primer_nombre,segundo_nombre,primer_apellido,segundo_apelldo,genero,fecha_nacimiento,fecha_registro,ciudad,direccion,telefono_local,telefono_celular,correo_electronico,nombre_contacto_emergencia,telefono_contacto_emergencia,status)
	VALUES (@cedula, @primerNombre,@segundoNombre,@primerApellido,@segundoApelldo,@genero,@fecha_nacimiento,@fecha_registro,@ciudad,@direccion,@telefonoLocal,@telefonoCelular,@correoElectronico,@nombreEmergencia,@contactoEmergencia,@status);	
END;

GO

USE [puipuiDB]
GO
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