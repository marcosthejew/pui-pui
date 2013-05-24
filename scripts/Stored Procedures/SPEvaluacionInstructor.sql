USE [puipuiDB]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ConsultarEvaluacionesTodas]
AS

BEGIN
	SET NOCOUNT ON
		
	SELECT I.*, E.*
	FROM Instructor I, Evaluacion E
	WHERE I.id_instructor = E.id_instructor
	
END;


GO
CREATE PROCEDURE [dbo].[AgregarEvaluacionInstructor]
@fechaEvaluacion DATETIME,
@calificacion INT,
@idCliente INT,
@idInstructor INT

AS

BEGIN
	SET NOCOUNT ON;
    
    INSERT INTO Evaluacion VALUES (@fechaEvaluacion,@calificacion,NULL,null,@idInstructor);
	
END;


GO
CREATE PROCEDURE [dbo].[ModificarEvaluacionInstructor]
@calificacion INT,
@idCliente INT,
@idInstructor INT,
@idEvaluacion INT

AS

BEGIN
	SET NOCOUNT ON;
    
    UPDATE Evaluacion SET fecha_evaluacion=getdate(), calificacion=@calificacion 
	WHERE id_evaluacion = @idEvaluacion AND id_cliente = @idCliente;
	
END;


--DROP procedure [dbo].[ConsultarEvaluacionesTodas]
--DROP procedure [dbo].[AgregarEvaluacionInstructor]
--DROP PROCEDURE [dbo].[ModificarEvaluacionInstructor]