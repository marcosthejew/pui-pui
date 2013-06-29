USE [puipuiDBv1]
GO
/*INSERTAR RUTINA */
USE [puipuiDBv1]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_Rutina]
@nombre nchar(50),
@descripcion nchar(50)

as

BEGIN
	INSERT INTO Rutina VALUES (@nombre,@descripcion,0);	
END;

GO


USE [puipuiDBv1]
GO
/****** Object:  StoredProcedure [dbo].[consultarRutinasPorCliente]    Script Date: 23/06/2013 16:55:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[consultarRutinasPorCliente]
	@idPersona bigint
AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT distinct(R.id_rutina), r.nombre, r.descripcion, H.inactivo
	FROM Rutina R, Historial_Ejercicio H 
	WHERE H.id_cliente = @idPersona AND h.id_rutina = r.id_rutina
	group by R.id_rutina, r.nombre, r.descripcion, H.inactivo
	
END;

GO
use [puipuiDBv1]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE ConsultarEjerciciosPorIDRutina
	@idRutina int
AS
BEGIN
	SET NOCOUNT ON;

    SELECT e.id_ejercicio, e.nombre, e.descripcion, h.duracion_minutos, h.repeticiones
	FROM Rutina r, Historial_Ejercicio h, Ejercicio e
	WHERE r.id_rutina = h.id_rutina and h.id_ejercicio= e.id_ejercicio and r.id_rutina = @idRutina

END;
GO
USE [puipuiDBv1]
GO
/****** Object:  StoredProcedure [dbo].[ActivarDesactivarRutina]    Script Date: 23/06/2013 16:22:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ActivarDesactivarRutina]
	@idRutina int, 
	@inactivo bit
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE Historial_Ejercicio
	SET 
		inactivo = @inactivo
		
	WHERE id_rutina = @idRutina
END;
GO

/*****************Stored Procedures de Ejercicios ******************************/

/*CONSULTAR LISTA DE EJERCICIOS */
USE [puipuiDBv1]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON 
GO
CREATE procedure [dbo].[consultarTodosEjerciciosR]
as
BEGIN
set nocount on	
        select E.id_ejercicio, E.nombre
        from Ejercicio E
        order by E.nombre ASC
END;
GO

/*stored insertar historial ejercicio*/
USE [puipuiDBv1]
GO
/****** Object:  StoredProcedure [dbo].[insertar_Rutina]    Script Date: 18/06/2013 14:42:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[insertar_HistorialEjercicio]
@duracion int,
@repeticion int,
@idCliente int,
@idRutina int,
@idEjercicio int,
@inactivo bit
as

BEGIN
	INSERT INTO Historial_Ejercicio VALUES (@duracion, @repeticion, @idCliente, @idRutina, @idEjercicio, @inactivo);	
END;

GO
--ultimo id rutina

/*metodo para buscar el ultimo id insertado */
USE [puipuiDBv1]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[buscarUltimoIdRutina]
as
BEGIN
	set nocount on
		
	SELECT max(id_rutina)
	FROM Rutina 	
END;
GO


USE [puipuiDBv1]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[consultarStatusRutinaPorID]
	@idRutina  int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT distinct(h.inactivo)
	FROM Historial_Ejercicio h
	WHERE h.id_rutina =  @idRutina
	group by h.inactivo

END
GO


USE [puipuiDBv1]
GO
/****** Object:  StoredProcedure [dbo].[consultarPersonaPorLogin]    Script Date: 28/06/2013 23:49:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultarPersonaPorLogin]
@loginPersona nchar (50)
as

BEGIN
 set nocount on
  
  SELECT *
 FROM Persona AS P
 where P.login = @loginPersona

END;