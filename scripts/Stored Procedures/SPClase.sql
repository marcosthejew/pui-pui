use [puipuiDB]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarClase]
@Nombre NVARCHAR(50),
@Descripcion NVARCHAR(200),
@Status int
AS

BEGIN

	SET NOCOUNT ON;

    
    Insert Clase values(@Nombre,@Descripcion,@Status);
	
END

GO

CREATE PROCEDURE [dbo].[ListarClases]
AS

BEGIN

	SET NOCOUNT ON;

    
    Select id_clase,nombre,estatus
    from clase;
	
END

GO

CREATE PROCEDURE [dbo].[DetalleClase]
@idclass int
AS

BEGIN

	SET NOCOUNT ON;

    
    Select nombre,descripcion,estatus
    from clase
    where id_clase=@idclass;
	
END
