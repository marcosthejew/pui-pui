USE [puipuiDB]
GO
/****** Object:  StoredProcedure [dbo].[SPHorariosDisponiblesPorClase]    Script Date: 05/22/2013 18:32:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:Carlos Del Toro		
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[SPHorariosDisponiblesPorClase]
 @idClase int
AS	
BEGIN
	SET NOCOUNT ON;
SELECT HR.id_horario_reserva,CONVERT(varchar,HR.fecha_inicio,103)+' de '+convert(char(5),HR.fecha_inicio, 108)+' a '+convert(char(5),HR.fecha_fin, 108) [horario]
FROM Clase_Salon CS,Horario_Reserva HR
WHERE HR.id_clase_salon=CS.id_clase_salon AND
	  CS.id_clase=@idClase
END


USE [puipuiDB]
GO
/****** Object:  StoredProcedure [dbo].[SPInstructoresDisponiblesPorHorario]    Script Date: 24/05/2013 4:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Carlos Del Toro
-- Create date: 23/05/2013
-- Description:	selecciona instructores disponibles
-- =============================================
ALTER PROCEDURE [dbo].[SPInstructoresDisponiblesPorHorario] 
@idHorario int
AS	
BEGIN
	SET NOCOUNT ON;
SELECT I.id_instructor,I.primer_nombre+''+I.primer_apellido as Instructor
FROM Clase_Salon CS,Horario_Reserva HR,Instructor I
WHERE HR.id_horario_reserva=@idHorario AND
	  HR.id_clase_salon=CS.id_clase_salon AND
	  CS.id_instructor=I.id_instructor AND
	  I.status='Activo'

END

USE [puipuiDB]
GO
/****** Object:  StoredProcedure [dbo].[SPInstructoresDisponiblesPorHorario]    Script Date: 23/05/2013 19:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Carlos Del Toro
-- Create date: 23/05/2013
-- Description:	selecciona instructores disponibles
-- =============================================
CREATE PROCEDURE [dbo].[SPInstructoresDisponiblesPorHorario] 
@idHorario int
AS	
BEGIN
	SET NOCOUNT ON;
SELECT HR.id_horario_reserva,CONVERT(varchar,HR.fecha_inicio,103)+' de '+convert(char(5),HR.fecha_inicio, 108)+' a '+convert(char(5),HR.fecha_fin, 108) [horario]
FROM Clase_Salon CS,Horario_Reserva HR,Instructor I
WHERE HR.id_horario_reserva=@idHorario AND
	  HR.id_clase_salon=CS.id_clase_salon AND
	  CS.id_instructor=I.id_instructor AND
	  I.status='Activo'
END

USE [puipuiDB]
GO
/****** Object:  StoredProcedure [dbo].[SELTodasClasesDiponibles]    Script Date: 23/05/2013 19:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Carlos Del Toro
-- Create date: 23/05/2013
-- Description:	selecciona todos las clases ofertadas 
-- =============================================
CREATE PROCEDURE [dbo].[SELTodasClasesDiponibles] 
	
AS
BEGIN
	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    Select 0,'--Seleccione una opcion--'
	union
	SELECT id_clase,nombre,estatus FROM clase; 
END

