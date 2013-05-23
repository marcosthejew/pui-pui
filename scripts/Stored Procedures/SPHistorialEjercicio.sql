/*Buscar RUTINAS por Id_cliente*/
USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[busca_rutina_idCliente]
@id_cli int
as

BEGIN
	set nocount on
		
	SELECT Distinct id_rutina
	FROM Historial_Ejercicio
	where id_cliente = @id_cli	
END;

GO
/*INSERTAR HISTORIAL EJERCICIO */
USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_HistorialEjercicio]
@id_rutina int,
@id_cliente int,
@id_ejercicio int
as

BEGIN
	INSERT INTO Historial_Ejercicio VALUES (@id_cliente,@id_rutina,@id_ejercicio);	
END;

GO
/*BUSCAR ID DE EJERCICICO CON ID RUTINA Y ID CLIENTE */
USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[busca_rutina_idEjercicio]
@id_cli int,
@id_ru int
as

BEGIN
	set nocount on
		
	SELECT id_ejercicio
	FROM Historial_Ejercicio
 where id_cliente = @id_cli and id_rutina=@id_ru;
END;

GO


/*DELETE en el Historial RUTINAS*/
USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON 
GO
CREATE procedure [dbo].[delete_Historial_Rutina]
@id_ruti int,
@id_cli  int
as
BEGIN
set nocount on	
DELETE FROM Historial_Ejercicio where id_rutina = @id_ruti and id_cliente=@id_cli
END;
GO