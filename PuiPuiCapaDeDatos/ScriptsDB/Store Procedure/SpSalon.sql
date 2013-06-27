use [puipuiDBv1]

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
@Status int,
@Codigo NVARCHAR(50)
AS

BEGIN

	SET NOCOUNT ON;

	
    
    Insert Salon values(@Codigo,@Ubicacion,@Capacidad,0);
	
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

    
    Select codigo,id_salon,ubicacion,capacidad, inactivo
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

    
    Select codigo,ubicacion,capacidad,inactivo
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
@Status int,
@Codigo NVARCHAR(50)
AS

BEGIN

	SET NOCOUNT ON;

    update Salon set codigo=@Codigo, ubicacion=@Ubicacion, capacidad=@Capacidad, inactivo=@Status where id_salon=@Id_salon;
    
	
END

GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[BusquedaUbicacionSalon]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [BusquedaUbicacionSalon]
GO
CREATE PROCEDURE [dbo].[BusquedaUbicacionSalon]
@Ubicacion NVARCHAR(50)
AS

BEGIN

	SET NOCOUNT ON;
	  
    Select id_salon,codigo,ubicacion,capacidad,inactivo
    from Salon
    where LOWER(ubicacion) like LOWER('%'+@Ubicacion+'%');
	
END
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[BusquedaStatusSalon]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [BusquedaStatusSalon]
GO
CREATE PROCEDURE [dbo].[BusquedaStatusSalon]
@Status int
AS

BEGIN

	SET NOCOUNT ON;
	  
    Select id_salon,codigo, ubicacion,capacidad,inactivo
    from Salon
    where inactivo=@Status;
	
END
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[BusquedaCapacidadMayorSalon]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [BusquedaCapacidadMayorSalon]
GO
CREATE PROCEDURE [dbo].[BusquedaCapacidadMayorSalon]
@Capacidad int
AS

BEGIN

	SET NOCOUNT ON;
	  
    Select id_salon,codigo, ubicacion,capacidad,inactivo
    from Salon
    where capacidad >= @Capacidad;
	
END
GO


IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[BusquedaCapacidadMenorSalon]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [BusquedaCapacidadMenorSalon]
GO
CREATE PROCEDURE [dbo].[BusquedaCapacidadMenorSalon]
@Capacidad int
AS

BEGIN

	SET NOCOUNT ON;
	  
    Select id_salon,codigo, ubicacion,capacidad,inactivo
    from Salon
    where capacidad <= @Capacidad;
	
END
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[AgregarSalonClase]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [AgregarSalonClase]
go
CREATE PROCEDURE [dbo].[AgregarSalonClase]
@Id_salon NVARCHAR(50),
@Id_clase int,
@Id_horario int,
@Id_instructor int
AS

BEGIN

	SET NOCOUNT ON;

	
    
    Insert Clase_Salon values(0,@Id_clase,@Id_salon,@Id_horario,@Id_instructor);
END

GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[ModificarSalonClase]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [ModificarSalonClase]
go
CREATE PROCEDURE [dbo].[ModificarSalonClase]
@Id_salon NVARCHAR(50),
@Id_clase int,
@Id_instructor int,
@Id_clase_salon int,
@disponibilidad int
AS

BEGIN

	SET NOCOUNT ON;

	
    
    update Clase_Salon set id_clase=@Id_clase,id_salon=@Id_salon,id_instructor= @Id_instructor, inactivo=@disponibilidad where id_clase_salon=@Id_clase_salon ;
	
END

GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[ListarSalonesClase]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [ListarSalonesClase]
go
CREATE PROCEDURE [dbo].[ListarSalonesClase]
AS

BEGIN

	SET NOCOUNT ON;

    
    Select clasal.id_clase_salon, clas.nombre,sal.codigo,sal.ubicacion,ins.nombre1, ins.apellido1, clasal.inactivo
    from Clase clas, Salon sal, Instructor ins, Clase_Salon clasal
	where clasal.id_clase=clas.id_clase
	and clasal.id_salon=sal.id_salon
	and clasal.id_instructor=ins.id_instructor;
	
END

GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[ListarSalonesClaseTclase]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [ListarSalonesClaseTclase]
go
CREATE PROCEDURE [dbo].[ListarSalonesClaseTclase]
@nombre varchar(50) 
AS

BEGIN

	SET NOCOUNT ON;

    
    Select clasal.id_clase_salon, clas.nombre,sal.codigo,sal.ubicacion,ins.nombre1+' '+ins.apellido1, clasal.inactivo
    from Clase clas, Salon sal, Instructor ins, Clase_Salon clasal
	where LOWER(clas.nombre) like LOWER(@nombre+'%')
	and clasal.id_clase=clas.id_clase
	and clasal.id_salon=sal.id_salon
	and clasal.id_instructor=ins.id_instructor;
	
END

GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[ListarSalonesClaseTsalon]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [ListarSalonesClaseTsalon]
go
CREATE PROCEDURE [dbo].[ListarSalonesClaseTsalon]
@Ubicacion int 
AS

BEGIN

	SET NOCOUNT ON;

    
    Select clasal.id_clase_salon, clas.nombre,sal.codigo,sal.ubicacion,ins.nombre1+' '+ins.apellido1, clasal.inactivo
    from Clase clas, Salon sal, Instructor ins, Clase_Salon clasal
	where LOWER(sal.ubicacion) like LOWER(@Ubicacion+'%')
	and clasal.id_clase=clas.id_clase
	and clasal.id_salon=sal.id_salon
	and clasal.id_instructor=ins.id_instructor;
	
END

GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[ListarSalonesClaseTinstructor]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [ListarSalonesClaseTinstructor]
go
CREATE PROCEDURE [dbo].[ListarSalonesClaseTinstructor]
@Nombre int 
AS

BEGIN

	SET NOCOUNT ON;

    
    Select clasal.id_clase_salon,clas.nombre,sal.codigo,sal.ubicacion,ins.nombre1+' '+ins.apellido1, clasal.inactivo
    from Clase clas, Salon sal, Instructor ins, Clase_Salon clasal
	where LOWER(ins.nombre1) like LOWER(@Nombre+'%')
	or LOWER(ins.apellido1) like LOWER(@Nombre+'%')
	and clasal.id_clase=clas.id_clase
	and clasal.id_salon=sal.id_salon
	and clasal.id_instructor=ins.id_instructor;
	
END

GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[ListarSalonesClaseTdisponible]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [ListarSalonesClaseTdisponible]
go
CREATE PROCEDURE [dbo].[ListarSalonesClaseTdisponible]
@reservacion int 
AS

BEGIN

	SET NOCOUNT ON;

    
    Select clasal.id_clase_salon,sal.codigo, clas.nombre,sal.ubicacion,ins.nombre1+' '+ins.apellido1, clasal.inactivo
    from Clase clas, Salon sal, Instructor ins, Clase_Salon clasal
	where clasal.inactivo=@reservacion
	and clasal.id_clase=clas.id_clase
	and clasal.id_salon=sal.id_salon
	and clasal.id_instructor=ins.id_instructor;
	
END

GO

