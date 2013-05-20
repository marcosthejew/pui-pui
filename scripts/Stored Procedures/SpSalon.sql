use [puipuiDB]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[AgregarSalon]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [AgregarSalon]
go
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

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[ListarSalones]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [ListarSalones]
go
CREATE PROCEDURE [dbo].[ListarSalones]
AS

BEGIN

	SET NOCOUNT ON;

    
    Select id_salon,ubicacion,capacidad, estatus
    from Salon;
	
END

GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[DetalleSalon]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [DetalleSalon]
GO
CREATE PROCEDURE [dbo].[DetalleSalon]
@id_salon int
AS

BEGIN

	SET NOCOUNT ON;

    
    Select ubicacion,capacidad,estatus
    from Salon
    where id_salon=@id_salon;
	
END
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[ModificarSalon]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [ModificarSalon]
go
CREATE PROCEDURE [dbo].[ModificarSalon]
@Id_salon int,
@Ubicacion NVARCHAR(50),
@Capacidad NVARCHAR(200),
@Status int
AS

BEGIN

	SET NOCOUNT ON;

    update Salon set ubicacion=@Ubicacion, capacidad=@Capacidad, estatus=@Status where id_salon=@Id_salon;
    
	
END

GO