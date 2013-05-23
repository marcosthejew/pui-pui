
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
@descripcionEjercicio nchar(250),
@idMusculo int
as
BEGIN
set nocount on	
        INSERT INTO Ejercicio (nombre, descripcion, id_musculo)
        VALUES (@nombreEjercicio, @descripcionEjercicio, @idMusculo);
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
        order by E.nombre ASC
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
    select E.id_ejercicio, lower(E.nombre), lower(E.descripcion), M.id_musculo, lower(M.nombre)   
    from
      Ejercicio E, Musculo M   
    where M.id_musculo = E.id_musculo and E.nombre = @nombre		
END;
GO

USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[eliminarEjercicio]
@nombreEjercicio nchar(50)
as

BEGIN
	set nocount on
        
        delete from Ejercicio
        where nombre = @nombreEjercicio
END;
GO

USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizarEjercicio]
@nombreEjercicio nchar(50), @descripcionEjercicio nchar(250), @idMusculo int,
@idEjercicio int
as

BEGIN
    update Ejercicio
    set nombre = lower(@nombreEjercicio), descripcion = lower(@descripcionEjercicio),
    id_musculo = @idMusculo
    where id_ejercicio = @idEjercicio
END;
GO

USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[existeRutinaConEjercicio]
@nombreEjercicio nchar(50)
as

BEGIN
	set nocount on
        
        select H.id_ejercicio
        from Historial_Ejercicio H, Ejercicio E
        where E.nombre = lower(@nombreEjercicio)
        and H.id_ejercicio = E.id_ejercicio
END;
GO

USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[existeNombreOtroId]
@nombreEjercicio nchar(50),
@idEjercicio int
as

BEGIN
	set nocount on
		
	SELECT E.id_ejercicio
	FROM Ejercicio AS E
	where E.nombre = lower(@nombreEjercicio)
	and id_ejercicio <> @idEjercicio
END;

GO






