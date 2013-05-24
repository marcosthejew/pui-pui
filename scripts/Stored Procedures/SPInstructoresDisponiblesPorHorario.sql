USE [puipuiDB]
GO
/****** Object:  StoredProcedure [dbo].[SPInstructoresDisponiblesPorHorario]    Script Date: 24/05/2013 4:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Carlos Del Toro
-- Create date: 23/05/2013
-- Description:	selecciona instructores disponibles
-- =============================================
ALTER PROCEDURE [dbo].[SPInstructoresDisponiblesPorHorario] 
@idHorario int
AS	
BEGIN
	SET NOCOUNT ON;
SELECT I.id_instructor,I.primer_nombre+''+I.primer_apellido as Instructor
FROM Clase_Salon CS,Horario_Reserva HR,Instructor I
WHERE HR.id_horario_reserva=@idHorario AND
	  HR.id_clase_salon=CS.id_clase_salon AND
	  CS.id_instructor=I.id_instructor AND
	  I.status='Activo'

END

