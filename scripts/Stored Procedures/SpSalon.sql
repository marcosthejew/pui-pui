use [puipuiDB]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarSalon]
@Ubicacion NVARCHAR(50),
@Capacidad int,
@Status int
AS

BEGIN

	SET NOCOUNT ON;

	
    
    Insert Salon values(@Ubicacion,@Capacidad,@Status);
	
END

GO

CREATE PROCEDURE [dbo].[ListarSalones]
AS

BEGIN

	SET NOCOUNT ON;

    
    Select id_clase,ubicacion,capacidad, estatus
    from Salon;
	
END

GO

