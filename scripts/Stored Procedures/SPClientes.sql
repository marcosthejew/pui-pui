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




