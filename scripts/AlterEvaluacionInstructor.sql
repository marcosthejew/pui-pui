USE [puipuiDB]
GO

ALTER TABLE Evaluacion DROP CONSTRAINT FK_Evaluacion_Cliente
ALTER TABLE Evaluacion ALTER COLUMN id_cliente bigint
ALTER TABLE Evaluacion ADD CONSTRAINT FK_Evaluacion_Cliente FOREIGN KEY (id_cliente) REFERENCES Persona (idPersona)