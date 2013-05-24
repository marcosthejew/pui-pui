USE [puipuiDB]
GO
/****** Object:  StoredProcedure [dbo].[SPInstructoresDisponiblesPorHorario]    Script Date: 23/05/2013 19:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Carlos Del Toro
-- Create date: 23/05/2013
-- Description:	selecciona instructores disponibles
-- =============================================
CREATE PROCEDURE [dbo].[SPInstructoresDisponiblesPorHorario] 
@idHorario int
AS	
BEGIN
	SET NOCOUNT ON;
SELECT HR.id_horario_reserva,CONVERT(varchar,HR.fecha_inicio,103)+' de '+convert(char(5),HR.fecha_inicio, 108)+' a '+convert(char(5),HR.fecha_fin, 108) [horario]
FROM Clase_Salon CS,Horario_Reserva HR,Instructor I
WHERE HR.id_horario_reserva=@idHorario AND
	  HR.id_clase_salon=CS.id_clase_salon AND
	  CS.id_instructor=I.id_instructor AND
	  I.status='Activo'
END

