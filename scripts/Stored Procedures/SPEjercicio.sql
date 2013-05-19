USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultarTodosEjercicios]
as

BEGIN
	set nocount on
		
	select E.id_ejercicio, E.nombre
        from Ejercicio E		
END;

GO

USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultarEjercicio]
@nombre nchar(50)
as

BEGIN
	set nocount on
		
	select E.id_ejercicio, E.nombre, E.descripcion, M.id_musculo, M.nombre
        from Ejercicio E, Musculo M
        where M.id_musculo = E.id_musculo and E.nombre = @nombre		
END;

GO




