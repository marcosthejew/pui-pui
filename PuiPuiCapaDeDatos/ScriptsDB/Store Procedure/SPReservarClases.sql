-- =============================================
-- Author:		Carlos Del Toro
-- Create date: 25/06/2013
-- Description:	Buscar Eventos Reservaciones
-- =============================================
USE [puipuiDBv1]
GO
/****** Object:  StoredProcedure [dbo].[consultarTodosReservacionesCalendario]    Script Date: 25/06/2013 04:21:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[consultarTodosReservacionesCalendario] 
AS	
BEGIN
	SET NOCOUNT ON;
select rc.id_res_clase,c.nombre,CONVERT(CHAR(8),h.hora_inicio,8) as inicio,CONVERT(CHAR(8),h.hora_fin,8) as fin,i.nombre1+' '+i.apellido1 as instructor,s.capacidad,rc.inactivo
from Reservacion_Clase rc,Clase_Salon cs,Clase c,Salon s,Instructor i,Horario h
where rc.id_clase_salon = cs.id_clase_salon
and cs.id_clase= c.id_clase
and cs.id_salon = s.id_salon
and cs.id_instructor = i.id_instructor
and cs.id_horario = h.id_horario

END
GO
