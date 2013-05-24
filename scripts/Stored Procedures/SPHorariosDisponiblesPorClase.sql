USE [puipuiDB]
GO
/****** Object:  StoredProcedure [dbo].[SPHorariosDisponiblesPorClase]    Script Date: 05/22/2013 18:32:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:Carlos Del Toro		
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[SPHorariosDisponiblesPorClase]
 @idClase int
AS	
BEGIN
	SET NOCOUNT ON;
SELECT HR.id_horario_reserva,CONVERT(varchar,HR.fecha_inicio,103)+' de '+convert(char(5),HR.fecha_inicio, 108)+' a '+convert(char(5),HR.fecha_fin, 108) [horario]
FROM Clase_Salon CS,Horario_Reserva HR
WHERE HR.id_clase_salon=CS.id_clase_salon AND
	  CS.id_clase=@idClase
END

