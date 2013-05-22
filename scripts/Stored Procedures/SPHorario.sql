USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[agregarHorario]
@dia nchar (20),
@hora_inicio time (7),
@hora_fin time (7),
@id_instructor int
as

BEGIN
	INSERT
	INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	VALUES (@dia,@hora_inicio,@hora_fin,@id_instructor);
END;
GO