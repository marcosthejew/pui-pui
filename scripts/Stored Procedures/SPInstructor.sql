
/*CONSULTAR SI EXISTE INSTRUCTOR */
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



/*INSERTAR UN INSCTRUCTOR */

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



/*CONSULTAR LISTA DE INSTRUCTORES */

USE [puipuiDB]
GO
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
END;
GO

/*CONSULTAR UN INSTRUCTOR */
USE [puipuiDB]
GO
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


/*CONSULTAR ID DE INSTRUCTOR PARA AGREGARLE UN HORARIO */
USE [puipuiDB]
GO
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



/*SE ELIMINA O INACTIVA UN INSTRUCTOR*/
USE [puipuiDB]
GO
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
	WHERE @cedula=cedula
END;
GO
