use [puipuiDBv1]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[existeInstructor]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [existeInstructor]
go
CREATE procedure [dbo].[existeInstructor]
@cedula nchar (50)
as

BEGIN
	Select cedula
	FROM Instructor
	where cedula=@cedula
END;
GO


IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[agregarInstructor]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [agregarInstructor]
go
CREATE procedure [dbo].[agregarInstructor]
@cedula nvarchar(50),
@primerNombre nvarchar(50),
@segundoNombre nvarchar(50),
@primerApellido nvarchar(50),
@segundoApelldo nvarchar(50),
@genero nchar(1),
@fecha_nacimiento date,
@fecha_registro date,
@estado nvarchar(50),
@ciudad nvarchar(50),
@direccion nvarchar(255),
@telefonoLocal int,
@telefonoCelular int,
@correoElectronico nvarchar(50),
@nombreEmergencia nvarchar(50),
@contactoEmergencia int,
@status nchar(15)
as

BEGIN
	
	INSERT INTO Instructor(cedula, nombre1,nombre2,apellido1,apellido2,sexo,fecha_nac,fecha_ingreso,entidad_federal,ciudad,direccion,telefono_local,telefono_celular,email,nombre_contacto_emergencia,telefono_contacto_emergencia,inactivo)
	VALUES                (@cedula, @primerNombre,@segundoNombre,@primerApellido,@segundoApelldo,@genero,@fecha_nacimiento,@fecha_registro,@estado,@ciudad,@direccion,@telefonoLocal,@telefonoCelular,@correoElectronico,@nombreEmergencia,@contactoEmergencia,@status);	
END;
GO


IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[consultarTodosInstructores]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [consultarTodosInstructores]
go
CREATE procedure [dbo].[consultarTodosInstructores]
as
BEGIN
set nocount on	

	select id_instructor,
		   nombre1+' '+nombre2,
		   apellido1+' '+apellido2,
		   cedula
	from Instructor;
        
END;
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[consultarInstructor]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [consultarInstructor]
go

CREATE procedure [dbo].[consultarInstructor]
@cedula nchar(50)
as
BEGIN	
set nocount on	
  select id_instructor,
		   nombre1+' '+nombre2,
		   apellido1+' '+apellido2,
		   cedula
	from Instructor 
  where cedula = @cedula;
END;
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[obtenerIdInstructor]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [obtenerIdInstructor]
go

CREATE procedure [dbo].[obtenerIdInstructor]
@cedula nchar (50)

as

BEGIN
	SELECT id_instructor
	FROM Instructor
	WHERE cedula=@cedula
END;
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[eliminarInstructor]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [eliminarInstructor]
go
CREATE procedure [dbo].[eliminarInstructor]
@cedula nchar (50)

as

BEGIN
declare @status int;
set nocount on

	select inactivo =@status
		from Instructor
		where cedula=@cedula;

		if @status =1
		begin
			update Instructor set inactivo= 0 where cedula=@cedula;
		end
		else 
			update Instructor set inactivo= 1 where cedula=@cedula;
END;
GO


IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[consultarTodosInstructoresActivos]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [consultarTodosInstructoresActivos]
go
CREATE procedure [dbo].[consultarTodosInstructoresActivos]
as
BEGIN
set nocount on	

select  I.id_instructor, I.cedula, I.nombre_contacto_emergencia, I.apellido1
        from Instructor I
        where I.inactivo = 0;
        
END;
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[tieneClase]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [tieneClase]
go
CREATE procedure [dbo].[tieneClase]
@cedula nchar(50)
as
BEGIN
set nocount on	
        select C.id_instructor
        from Clase_Salon C, Instructor I
        where C.id_instructor = I.id_instructor
        and I.cedula = @cedula
END;
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[tieneCliente]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [tieneCliente]
go
CREATE procedure [dbo].[tieneCliente]
@cedula nchar(50)
as
BEGIN
set nocount on	
        select R.id_instructor
		from Reservacion_Instructor R, Instructor I
		where R.id_instructor = I.id_instructor
		and I.cedula = @cedula
END;
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[tieneEvaluacion]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [tieneEvaluacion]
go
CREATE procedure [dbo].[tieneEvaluacion]
@cedula nchar(50)
as
BEGIN
set nocount on	
        select E.id_instructor
		from Evaluacion_Instructor E, Instructor I
		where E.id_instructor = I.id_instructor
		and I.cedula = @cedula
END;
GO


IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[actualizarInstructor]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [actualizarInstructor]
go
CREATE procedure [dbo].[actualizarInstructor]
@id_instructor int,
@cedula nvarchar(50),
@primerNombre nvarchar(50),
@segundoNombre nvarchar(50),
@primerApellido nvarchar(50),
@segundoApelldo nvarchar(50),
@genero nchar(1),
@fecha_nacimiento date,
@fecha_registro date,
@estado nvarchar(50),
@ciudad nvarchar(50),
@direccion nvarchar(255),
@telefonoLocal int,
@telefonoCelular int,
@correoElectronico nvarchar(50),
@nombreEmergencia nvarchar(50),
@contactoEmergencia int,
@status int
as

BEGIN
    update Instructor
    set
	 cedula = lower (@cedula),
	 nombre1= lower(@primerNombre),
	 nombre2= lower(@segundoNombre),
	 apellido1= lower(@primerApellido),
	 apellido2= lower(@segundoApelldo),
	 sexo= lower(@genero),
	 fecha_nac= (@fecha_nacimiento),
	 entidad_federal=@estado,
	 ciudad= lower(@ciudad),
	 direccion= lower(@direccion),
	 telefono_local= (@telefonoLocal),
	 telefono_celular=(@telefonoCelular),
	 email= lower(@correoElectronico),
	 nombre_contacto_emergencia= lower(@nombreEmergencia),
	 telefono_contacto_emergencia=(@contactoEmergencia),
	 inactivo= lower(@status)	
	
    where id_instructor = @id_instructor;
END;
GO