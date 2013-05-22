use [puipuiDB]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[AgregarClase]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [AgregarClase]
go
CREATE PROCEDURE [dbo].[AgregarClase]
@Nombre NVARCHAR(50),
@Descripcion NVARCHAR(200),
@Status int
AS

BEGIN

	SET NOCOUNT ON;

    
    Insert Clase values(@Nombre,@Descripcion,0);
	
END

GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[ModificarClase]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [ModificarClase]
go
CREATE PROCEDURE [dbo].[ModificarClase]
@Id_clase int,
@Nombre NVARCHAR(50),
@Descripcion NVARCHAR(200),
@Status int
AS

BEGIN

	SET NOCOUNT ON;

    update Clase set nombre=@Nombre, descripcion=@Descripcion, estatus=@Status where id_clase=@Id_clase;
    
	
END

GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[ListarClases]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [ListarClases]
go
CREATE PROCEDURE [dbo].[ListarClases]
AS

BEGIN

	SET NOCOUNT ON;

    
    Select id_clase,nombre,estatus
    from clase;
	
END

GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[DetalleClase]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [DetalleClase]
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
Go

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[BusquedaNombreClase]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [BusquedaNombreClase]
GO
CREATE PROCEDURE [dbo].[BusquedaNombreClase]
@Nombre NVARCHAR(50)
AS

BEGIN

	SET NOCOUNT ON;
	  
    Select id_clase, nombre,descripcion,estatus
    from clase
    where LOWER(nombre) like LOWER(@Nombre+'%');
	
END
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[BusquedaStatusClase]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [BusquedaStatusClase]
GO
CREATE PROCEDURE [dbo].[BusquedaStatusClase]
@Status int
AS

BEGIN

	SET NOCOUNT ON;
	  
    Select id_clase, nombre,descripcion,estatus
    from clase
    where estatus=@Status;
	
END
GO