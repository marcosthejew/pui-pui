USE [puipuiDB]
GO
/****** Object:  StoredProcedure [dbo].[consultarModificarPersona]   Script Date: 12/06/2012 18:39:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultarModificarPersona]
as

BEGIN
	set nocount on
		
	SELECT P.idPersona, P.nombrePersona1, P.apellidoPersona1, P.fechaIngresoPersona
	FROM Persona AS P
	where P.tipoPersona = 'Cliente'
		
END;



GO
USE [puipuiBD]
GO
/****** Object:  StoredProcedure [dbo].[consultarDetallePersona]   Script Date: 12/06/2012 18:39:36 ******/
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



/* Insertar cliente */

USE [puipuiDB]
GO
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
@genero nchar(1),
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
@tipo nchar(20),
as
BEGIN	
INSERT INTO Persona (cedulaPersona, nombrePersona1,nombrePersona2,apellidoPersona1,apellidoPersona2,generoPersona,fechaNacimientoPersona,fechaIngresoPersona,ciudadPersona,DireccionPersona,telefonoLocalPersona,telefonoCelularPersona,correoPersona,contactoNombrePersona,contactoTelefonoPersona,estadoPersona,loginPersona,passwordPersona,tipoPersona)
	   VALUES (@cedulacliente,@primerNombreCliente,@segundoNombreCliente,@primerApellidoCliente,@segundoaApellidoCliente,@genero,@fechaNacimiento,@fechaRegistro,@ciudad,@direccion,@telefonoLocal,@telefonoCelular,@email,@nombreContactoEmergencia,@telefonoContactoEmergencia,@estado,@usuario,@password,@tipo);
END;

GO

GO
USE [puipuiDB]
GO
/****** Object:  StoredProcedure [dbo].[modificarPersona]    Script Date: 19/05/2013 23:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[modificarPersona]

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







