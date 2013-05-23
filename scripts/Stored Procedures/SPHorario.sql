/*INSERTAR UN HORARIO DE TRABAJO DEL INSTRUCTOR */

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


/*CONSULTAR  HORARIOS DE TRABAJO DEL INSTRUCTOR */

USE [puipuiDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON 
GO
CREATE procedure [dbo].[consultarHorariosInstructor]
@cedula nchar(50)
as
BEGIN
set nocount on	
select  H.dia, H.hora_inicio, H.hora_fin
        from Instructor I, Horario_Trabajo H
		where I.id_instructor=H.id_instructor and I.cedula=	@cedula
END;
GO
