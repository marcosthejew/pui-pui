USE [puipuiDB]
GO
/****** Object:  StoredProcedure [dbo].[SELTodasClasesDiponibles]    Script Date: 23/05/2013 19:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Carlos Del Toro
-- Create date: 23/05/2013
-- Description:	selecciona todos las clases ofertadas 
-- =============================================
CREATE PROCEDURE [dbo].[SELTodasClasesDiponibles] 
	
AS
BEGIN
	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    Select 0,'--Seleccione una opcion--'
	union
	SELECT id_clase,nombre,estatus FROM clase; 
END

