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
USE [PuiPui]
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
