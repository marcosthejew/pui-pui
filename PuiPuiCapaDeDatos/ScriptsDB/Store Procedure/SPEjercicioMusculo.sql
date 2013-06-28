use [puipuiDBv1]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[ExisteEjercicio]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [ExisteEjercicio]
go
CREATE PROCEDURE [dbo].[ExisteEjercicio]
@Nombre NVARCHAR(50)
AS

BEGIN

	SET NOCOUNT ON;

    select id_ejercicio
	from Ejercicio
	where LOWER(nombre)=LOWER(@Nombre);
	
END

GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[insertarEjercicio]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [insertarEjercicio]
go
CREATE PROCEDURE [dbo].[insertarEjercicio]
@Nombre NVARCHAR(50),
@Descripcion nvarchar(150),	
@idMusculo int
AS
BEGIN

	SET NOCOUNT ON;

    insert into Ejercicio (nombre,descripcion,inactivo) values (@Nombre,@Descripcion,1);
	/*SELECT SCOPE_IDENTITY();*/
	
	
END

GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[consultarTodosEjercicios]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [consultarTodosEjercicios]
go

CREATE procedure [dbo].[consultarTodosEjercicios]
as
BEGIN
set nocount on	
        
		select eje.id_ejercicio,
			   eje.nombre,
			   eje.descripcion,
			   eje.inactivo,
			   mus.id_musculo,
			   mus.nombre
		from Ejercicio eje,
		     Musculo mus, 
			 Musculo_Involucrado mi
		where eje.id_ejercicio=mi.id_ejercicio and
			  mus.id_musculo=mi.id_musculo;

END;
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[consultarEjercicio]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [consultarEjercicio]
go

CREATE procedure [dbo].[consultarEjercicio]
@id_ejercicio int
as
BEGIN	
set nocount on	

    select E.id_ejercicio, 
		   E.nombre, 
		   E.descripcion, 
		   M.id_musculo, 
		   M.nombre   
    from Ejercicio E, 
	     Musculo M, 
		 Musculo_Involucrado MI
    where E.id_ejercicio=@id_ejercicio and
		  E.id_ejercicio=mi.id_ejercicio and
		  M.id_musculo=mi.id_musculo;
	 
    
END;
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[eliminarEjercicio]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [eliminarEjercicio]
go

CREATE procedure [dbo].[eliminarEjercicio]
@id_ejercicio nvarchar(50)
as

BEGIN
declare @status int;
	set nocount on
        
        
		select inactivo =@status
		from Ejercicio
		where id_ejercicio=@id_ejercicio;

		if @status =1
		begin
			update Ejercicio set inactivo= 0 where id_ejercicio=@id_ejercicio;
		end
		else 
			update Ejercicio set inactivo= 1 where id_ejercicio=@id_ejercicio;
END;
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[actualizarEjercicio]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [actualizarEjercicio]
go


CREATE procedure [dbo].[actualizarEjercicio]
@idEjercicio int,
@nombreEjercicio nchar(50),
@descripcionEjercicio nchar(250)
as

BEGIN
declare @idAnterior int;
    update Ejercicio
    set nombre = @nombreEjercicio,
		descripcion =@descripcionEjercicio
    where id_ejercicio = @idEjercicio;
END;
GO



IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[existeRutinaConEjercicio]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [existeRutinaConEjercicio]
go


CREATE procedure [dbo].[existeRutinaConEjercicio]
@nombreEjercicio nchar(50)
as

BEGIN
	set nocount on
        
        select MI.id_musc_invol
        from Musculo_Involucrado MI, Ejercicio E, musculo m
        where E.nombre = lower(@nombreEjercicio)
        and Mi.id_musc_invol = E.id_ejercicio
		and- Mi.id_musculo=m.id_musculo;
END;
GO


IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[existeNombreOtroId]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [existeNombreOtroId]
go
CREATE procedure [dbo].[existeNombreOtroId]
@nombreEjercicio nchar(50),
@idEjercicio int
as

BEGIN
	set nocount on
		
	SELECT E.id_ejercicio
	FROM Ejercicio AS E
	where E.nombre = lower(@nombreEjercicio)
	and id_ejercicio <> @idEjercicio
END;

GO

/*MUSCULOS*/

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[existeMusculo]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [existeMusculo]
go
CREATE procedure [dbo].[existeMusculo]
@nombreMusculo nchar(50)
as

BEGIN
	set nocount on
		
	SELECT M.id_musculo
	FROM Musculo M
	where M.nombre = @nombreMusculo		
END;

GO


IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[buscarMusculoPorId]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [buscarMusculoPorId]
go
CREATE procedure [dbo].[buscarMusculoPorId]
@idMusculo nchar(50)
as

BEGIN
	set nocount on
		
	SELECT M.id_musculo,
	M.nombre,
	M.descripcion,
	M.inactivo
	FROM Musculo M
	where M.id_musculo = @idMusculo		
END;

GO
IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[agregarMusculo]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [agregarMusculo]
go

CREATE procedure [dbo].[agregarMusculo]
@nombreMusculo nvarchar(50),
@descripcionMusculo nvarchar(150)
as

BEGIN
	INSERT INTO Musculo (nombre,descripcion,inactivo) VALUES (@nombreMusculo,@descripcionMusculo,0);	
END;

GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[consultarTodosMusculos]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [consultarTodosMusculos]
go
CREATE procedure [dbo].[consultarTodosMusculos]
as
BEGIN
set nocount on	
        select M.id_musculo, M.nombre,M.descripcion,M.inactivo
        from Musculo M;
END;
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[existeEjercicioConMusculo]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [existeEjercicioConMusculo]
go
CREATE procedure [dbo].[existeEjercicioConMusculo]
@idMusculo int
as

BEGIN
	set nocount on
        
        select MI.id_musc_invol
        from  Musculo_Involucrado MI
        where MI.id_musculo = @idMusculo;
END;
GO

IF EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[eliminarMusculo]')
AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [eliminarMusculo]
go

CREATE procedure [dbo].[eliminarMusculo]
@idMusculo int
as

BEGIN
	declare @status int;
	set nocount on
        
        
		select inactivo =@status
		from Musculo
		where id_musculo=@idMusculo;

		if @status =1
		begin
			update Musculo set inactivo= 0 where id_musculo=@idMusculo;
		end
		else 
			update Musculo set inactivo= 1 where id_musculo=@idMusculo;
END;