USE [puipuiDBv1]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[agregarHorario]
@hora_inicio time (7),
@hora_fin time (7),
@dia_semana int
as

BEGIN
	INSERT
	INTO Horario(hora_inicio,hora_fin,dia_semana,inactivo)
	VALUES (@hora_inicio,@hora_fin,@dia_semana,0);
END;
GO

