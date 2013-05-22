
/*CONSULTAR RUTINAS*/

USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[buscar_rutina]
@id_ruti int
as

BEGIN
	set nocount on
		
	SELECT *
	FROM Rutina 
	where id_rutina = @id_ruti		
END;

GO
/*INSERTAR RUTINA */
USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_Rutina]
@descripcion nchar(50),
@duracion time(7),
@repeticiones int
as

BEGIN
	INSERT INTO Rutina VALUES (@descripcion,Convert(Time(7),@duracion,108),@repeticiones);	
END;

GO

/*UPDATE RUTINAS*/
USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON 
GO
CREATE procedure [dbo].[update_Rutina]
@id_ruti int,
@descripcion nchar(50),
@duracion time(7),
@repeticiones int
as
BEGIN
set nocount on	
update Rutina set descripcion=@descripcion , duracion=@duracion ,repeteciones=@repeticiones where id_rutina = @id_ruti
END;
GO


