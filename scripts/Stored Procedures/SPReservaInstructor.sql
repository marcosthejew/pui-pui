USE [puipuiDB]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ConsultarReservacionesInstructorTodas]
AS

BEGIN
	SET NOCOUNT ON
		
	SELECT *
	FROM Reservacion_Instructor
	
END;