
/*CONSULTAR SI EXISTE EJERCICIO */

USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[existeEjercicio]
@nombreEjercicio nchar(50)
as

BEGIN
	set nocount on
		
	SELECT E.id_ejercicio
	FROM Ejercicio AS E
	where E.nombre = @nombreEjercicio		
END;

GO



/*INSERTAR UN EJERCICIO */

USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertarEjercicio]
@nombreEjercicio nchar(50),
@descripcionEjercicio nchar(50),
@idMusculo int
as
BEGIN	
INSERT INTO Ejercicio (nombre, descripcion, id_musculo) VALUES (@nombreEjercicio, @descripcionEjercicio, @idMusculo);
END;

GO




/*CONSULTAR LISTA DE EJERCICIOS */
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



/*CONSULTAR UN EJERCICIO */
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
  from
    Ejercicio E, Musculo M   
  where M.id_musculo = E.id_musculo and E.nombre = @nombre		
END;
GO









