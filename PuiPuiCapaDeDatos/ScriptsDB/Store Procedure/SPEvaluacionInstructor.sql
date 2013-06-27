use [puipuiDBv1]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[AgregarEvaluacionInstructor]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [AgregarEvaluacionInstructor]
go
CREATE PROCEDURE [dbo].[AgregarEvaluacionInstructor]
@fecha datetime,
@calificacion int,
@inactivo bit,
@observaciones NVARCHAR(200),
@id_cliente int,
@id_instructor int

AS

BEGIN

	SET NOCOUNT ON;    
    Insert Evaluacion_Instructor values(@fecha,@calificacion,@inactivo,@observaciones,@id_cliente,@id_instructor);
	
END

GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[ModificarEvaluacionInstructor]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [ModificarEvaluacionInstructor]
go
CREATE PROCEDURE [dbo].[ModificarEvaluacionInstructor]
@idEvaluacion int,
@fecha datetime,
@calificacion int,
@inactivo bit,
@observaciones NVARCHAR(200),
@id_cliente int,
@id_instructor bit
AS

BEGIN

	SET NOCOUNT ON;

    update Evaluacion_Instructor set fecha_evaluacion=@fecha, calificacion=@calificacion, inactivo = @inactivo,
	observaciones=@observaciones,id_cliente=@id_cliente, id_instructor=@id_instructor where id_eval_inst=@idEvaluacion;
    
	
END

GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[ListarEvaluacionesInstructor]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [ListarEvaluacionesInstructor]
go
CREATE PROCEDURE [dbo].[ListarEvaluacionesInstructor]
AS

BEGIN

	SET NOCOUNT ON;    
    Select id_eval_inst,fecha_evaluacion,calificacion,inactivo,observaciones,id_cliente,id_instructor
    from Evaluacion_Instructor;
	
END

GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[DetalleEvaluacionInstructor]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [DetalleEvaluacionInstructor]
GO
CREATE PROCEDURE [dbo].[DetalleEvaluacionInstructor]
@IdEvaluacionInstructor int
AS

BEGIN

	SET NOCOUNT ON;

    
    Select id_eval_inst,fecha_evaluacion,calificacion,inactivo,observaciones,id_cliente,id_instructor
    from Evaluacion_Instructor
    where id_eval_inst = @IdEvaluacionInstructor;
	
END
Go
