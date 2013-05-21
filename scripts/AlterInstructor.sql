use [puipuiDB]

/*SE AGREGAR EL CAMPO CEDULA A INSTRUCTOR */	
ALTER TABLE dbo.Instructor ADD cedula NCHAR(50);

/*SE MODIFICA EL TIPO DE DATO DE LOS TELEFONOS AL INSTRUCTOR */	
use [puipuiDB]
ALTER TABLE dbo.Instructor ALTER COLUMN telefono_celular BIGINT;
use [puipuiDB]
ALTER TABLE dbo.Instructor ALTER COLUMN telefono_local BIGINT;
use [puipuiDB]
ALTER TABLE dbo.Instructor ALTER COLUMN telefono_contacto_emergencia BIGINT;