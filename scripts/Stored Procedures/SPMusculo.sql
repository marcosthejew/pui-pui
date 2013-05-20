
/*CONSULTAR SI EXISTE UN MUSCULO */

USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[existeMusculo]
@nombreMusculo nchar(50)
as

BEGIN
	set nocount on
		
	SELECT M.id_musculo
	FROM Musculo AS M
	where M.nombre = @nombreMusculo		
END;

GO
/*INSERTAR UN MUSCULO */
USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[agregarMusculo]
@nombreMusculo nchar(50)
as

BEGIN
	INSERT INTO Musculo (nombre) VALUES (@nombreMusculo);	
END;

GO

/*CONSULTAR LISTA DE MUSCULOS*/
USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON 
GO
CREATE procedure [dbo].[consultarTodosMusculos]
as
BEGIN
set nocount on	
select M.id_musculo, M.nombre
        from Musculo M
END;
GO





