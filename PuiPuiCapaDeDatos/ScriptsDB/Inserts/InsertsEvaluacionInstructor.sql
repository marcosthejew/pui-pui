USE [puipuiDBv1]
GO

INSERT INTO [dbo].[Persona]([cedula],[nombre1],[nombre2],[apellido1],[apellido2],[sexo],[fecha_nac],[fecha_ingreso],[entidad_federal],[ciudad]
,[direccion],[telefono_local],[telefono_celular],[email],[nombre_contacto],[telefono_contacto],[login],[password],[tipo],[inactivo])
     VALUES('200000','Javier','Jose','Gutierres','Gonzalez','m','02/02/1991','02/02/2010','Caracas','Caracas','Caracas','212-4124122'
,'416-3453124','bla@gamil.com','Karem','212-4955342','javier','1234','cliente',1)
GO

INSERT INTO [dbo].[Evaluacion_Instructor]([fecha_evaluacion],[calificacion],[inactivo],[observaciones],[id_cliente],[id_instructor])
     VALUES
('06/06/2013',4,1,'primera evaluacion',1,1)
GO
INSERT INTO [dbo].[Evaluacion_Instructor]([fecha_evaluacion],[calificacion],[inactivo],[observaciones],[id_cliente],[id_instructor])
     VALUES
('06/07/2013',1,1,'segunda evaluacion',1,2)
GO
INSERT INTO [dbo].[Evaluacion_Instructor]([fecha_evaluacion],[calificacion],[inactivo],[observaciones],[id_cliente],[id_instructor])
     VALUES
('06/08/2013',5,1,'tercera evaluacion',1,3)
GO



