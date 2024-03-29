USE [master]
GO --drop database puipuiDBv1
/****** Object:  Database [puipuiDB1]    Script Date: 16/05/2013 09:21:00 a.m. ******/
CREATE DATABASE [puipuiDBv1]
 CONTAINMENT = NONE
GO
ALTER DATABASE [puipuiDBv1] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [puipuiDBv1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [puipuiDBv1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [puipuiDBv1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [puipuiDBv1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [puipuiDBv1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [puipuiDBv1] SET ARITHABORT OFF 
GO
ALTER DATABASE [puipuiDBv1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [puipuiDBv1] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [puipuiDBv1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [puipuiDBv1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [puipuiDBv1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [puipuiDBv1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [puipuiDBv1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [puipuiDBv1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [puipuiDBv1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [puipuiDBv1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [puipuiDBv1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [puipuiDBv1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [puipuiDBv1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [puipuiDBv1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [puipuiDBv1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [puipuiDBv1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [puipuiDBv1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [puipuiDBv1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [puipuiDBv1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [puipuiDBv1] SET  MULTI_USER 
GO
ALTER DATABASE [puipuiDBv1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [puipuiDBv1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [puipuiDBv1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [puipuiDBv1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [puipuiDBv1]
GO
/****** Object:  Table [dbo].[Clase]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clase](
	[id_clase] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](50) NOT NULL,
	[descripcion] [nchar](255) NULL,
	[inactivo] [bit] NOT NULL,
 CONSTRAINT [PK_Clase] PRIMARY KEY CLUSTERED 
(
	[id_clase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clase_Salon]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clase_Salon](
	[id_clase_salon] [int] IDENTITY(1,1) NOT NULL,
	[inactivo] [bit] NOT NULL,
	[id_clase] [int] NOT NULL,
	[id_salon] [int] NOT NULL,
	[id_horario] [int] NOT NULL,
	[id_instructor] [int] NULL,
 CONSTRAINT [PK_Clase_Salon] PRIMARY KEY CLUSTERED 
(
	[id_clase_salon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Persona]    Script Date: 11/30/2012 12:32:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[id_persona] [int] IDENTITY(1,1) NOT NULL,
	[cedula] [nchar](10) NOT NULL,
	[nombre1] [nchar](50) NOT NULL,
	[nombre2] [nchar](50) NULL,
	[apellido1] [nchar](50) NOT NULL,
	[apellido2] [nchar](50) NULL,
	[sexo] [nchar](1) NOT NULL,
	[fecha_nac] [date] NOT NULL,
	[fecha_ingreso] [date] NOT NULL,
	[entidad_federal] [nchar] (50) NOT NULL,
	[ciudad] [nchar] (50) NOT NULL,
	[direccion] [nchar] (300) NOT NULL,
	[telefono_local] [nchar] (50) NULL,
	[telefono_celular] [nchar] (50) NULL,
	[email] [nchar](50) NULL,
	[nombre_contacto] [nchar](50) NULL,
	[telefono_contacto] [nchar] (50) NULL,
	[login] [nchar](50) NOT NULL,
	[password] [nchar](50) NOT NULL,
	[tipo] [nchar](15) NOT NULL,
	[inactivo] [bit] NOT NULL,
	
	
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ejercicio]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ejercicio](
	[id_ejercicio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](50) NOT NULL,
	[descripcion] [nchar](50) NOT NULL,
	[inactivo] [bit] NOT NULL,
 CONSTRAINT [PK_Ejercicio] PRIMARY KEY CLUSTERED 
(
	[id_ejercicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Evaluacion_Instructor]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluacion_Instructor](
	[id_eval_inst] [int] IDENTITY(1,1) NOT NULL,
	[fecha_evaluacion] [datetime] NOT NULL,
	[calificacion] [int] NOT NULL,
	[inactivo] [bit] NOT NULL,
	[observaciones] [nchar](150) NULL,
	[id_cliente] [int] NOT NULL,
	[id_instructor] [int] NOT NULL,
 CONSTRAINT [PK_Evaluacion_Instructor] PRIMARY KEY CLUSTERED 
(
	[id_eval_inst] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluacion_Clase](
	[id_eval_clase] [int] IDENTITY(1,1) NOT NULL,
	[fecha_evaluacion] [datetime] NOT NULL,
	[calificacion] [int] NOT NULL,
	[inactivo] [bit] NOT NULL,
	[observaciones] [nchar](150) NULL,
	[id_clase_salon] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
 CONSTRAINT [PK_Evaluacion_Clase] PRIMARY KEY CLUSTERED 
(
	[id_eval_clase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Historial_Ejercicio]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historial_Ejercicio](
	[id_hist_ejer] [int] IDENTITY(1,1) NOT NULL,
	[duracion_minutos] [int] NOT NULL,
	[repeticiones] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_rutina] [int] NOT NULL,
	[id_ejercicio] [int] NOT NULL,
	[inactivo] [bit] NOT NULL,
 CONSTRAINT [PK_Historial_Ejercicio] PRIMARY KEY CLUSTERED 
(
	[id_hist_ejer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reservacion_Instructor]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservacion_Instructor](
	[id_res_ins] [int] IDENTITY(1,1) NOT NULL,
	[fecha_reservacion] [datetime] NOT NULL,
	[id_horario] [int] NOT NULL,
	[id_instructor] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[inactivo] [bit] NOT NULL,
 CONSTRAINT [PK_Reserva_Instructor] PRIMARY KEY CLUSTERED 
(
	[id_res_ins] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Horario_Trabajo]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horario_Trabajo](
	[id_hora_tra] [int] IDENTITY(1,1) NOT NULL,
	[id_horario] [int] NOT NULL,
	[id_instructor] [int] NOT NULL,
 CONSTRAINT [PK_Horario_Trabajo] PRIMARY KEY CLUSTERED 
(
	[id_hora_tra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Instructor]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instructor](
	[id_instructor] [int] IDENTITY(1,1) NOT NULL,
	[cedula] [nchar](10) NOT NULL,
	[nombre1] [nchar](50) NOT NULL,
	[nombre2] [nchar](50) NULL,
	[apellido1] [nchar](50) NOT NULL,
	[apellido2] [nchar](50) NULL,
	[sexo] [nchar](1) NOT NULL,
	[fecha_nac] [date] NOT NULL,
	[fecha_ingreso] [date] NOT NULL,
	[entidad_federal] [nchar](50) NOT NULL,
	[ciudad] [nchar](50) NOT NULL,
	[direccion] [nchar](255) NOT NULL,
	[telefono_local] [nchar] (50) NOT NULL,
	[telefono_celular] [nchar] (50) NOT NULL,
	[email] [nchar](50) NOT NULL,
	[nombre_contacto_emergencia] [nchar](50) NOT NULL,
	[telefono_contacto_emergencia] [nchar] (50) NOT NULL,
	[inactivo] [bit] NOT NULL,
 CONSTRAINT [PK_Instructor] PRIMARY KEY CLUSTERED 
(
	[id_instructor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Musculo]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musculo](
	[id_musculo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](50) NOT NULL,
	[descripcion] [nchar](150) NULL,
	[inactivo] [bit] NOT NULL,
 CONSTRAINT [PK_Musculo] PRIMARY KEY CLUSTERED 
(
	[id_musculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Musculo_Involucrado]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musculo_Involucrado](
	[id_musc_invol] [int] IDENTITY(1,1) NOT NULL,
	[inactivo] [bit] NOT NULL,
	[id_musculo] [int] NOT NULL,
	[id_ejercicio] [int] NOT NULL,
 CONSTRAINT [PK_Musculo_Involucrado] PRIMARY KEY CLUSTERED 
(
	[id_musc_invol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reservacion_Clase]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservacion_Clase](
	[id_res_clase] [int] IDENTITY(1,1) NOT NULL,
	[fecha_reservacion] [datetime] NOT NULL,
	[inactivo] [bit] NOT NULL,
	[id_clase_salon] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
 CONSTRAINT [PK_Reservacion_Clase] PRIMARY KEY CLUSTERED 
(
	[id_res_clase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Horario]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horario](
	[id_horario] [int] IDENTITY(1,1) NOT NULL,
	[hora_inicio] [time] NOT NULL,
	[hora_fin] [time] NOT NULL,
	[dia_semana] [int] NOT NULL,
	[inactivo] [bit] NOT NULL,
 CONSTRAINT [PK_horario] PRIMARY KEY CLUSTERED 
(
	[id_horario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rutina]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rutina](
	[id_rutina] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](50) NOT NULL,
	[descripcion] [nchar](150) NULL,
	[inactivo] [bit] NOT NULL,
 CONSTRAINT [PK_Rutina] PRIMARY KEY CLUSTERED 
(
	[id_rutina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Salon]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salon](
	[id_salon] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [nchar](10) NOT NULL,
	[ubicacion] [nchar](50) NOT NULL,
	[capacidad] [int] NOT NULL,
	[inactivo] [bit] NOT NULL,
 CONSTRAINT [PK_Salon] PRIMARY KEY CLUSTERED 
(
	[id_salon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Clase_Salon]  WITH CHECK ADD  CONSTRAINT [FK_Clase_Salon_Clase] FOREIGN KEY([id_clase])
REFERENCES [dbo].[Clase] ([id_clase])
GO
ALTER TABLE [dbo].[Clase_Salon] CHECK CONSTRAINT [FK_Clase_Salon_Clase]
GO
ALTER TABLE [dbo].[Clase_Salon]  WITH CHECK ADD  CONSTRAINT [FK_Clase_Salon_Instructor] FOREIGN KEY([id_instructor])
REFERENCES [dbo].[Instructor] ([id_instructor])
GO
ALTER TABLE [dbo].[Clase_Salon] CHECK CONSTRAINT [FK_Clase_Salon_Instructor]
GO
ALTER TABLE [dbo].[Clase_Salon]  WITH CHECK ADD  CONSTRAINT [FK_Clase_Salon_Salon] FOREIGN KEY([id_salon])
REFERENCES [dbo].[Salon] ([id_salon])
GO
ALTER TABLE [dbo].[Clase_Salon] CHECK CONSTRAINT [FK_Clase_Salon_Salon]
GO
ALTER TABLE [dbo].[Clase_Salon]  WITH CHECK ADD  CONSTRAINT [FK_Clase_Salon_Horario] FOREIGN KEY([id_horario])
REFERENCES [dbo].[Horario] ([id_horario])
GO
ALTER TABLE [dbo].[Clase_Salon] CHECK CONSTRAINT [FK_Clase_Salon_Horario]
GO
ALTER TABLE [dbo].[Historial_Ejercicio]  WITH CHECK ADD  CONSTRAINT [FK_Historial_Ejercicio_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Persona] ([id_persona])
GO
ALTER TABLE [dbo].[Historial_Ejercicio] CHECK CONSTRAINT [FK_Historial_Ejercicio_Cliente]
GO
ALTER TABLE [dbo].[Historial_Ejercicio]  WITH CHECK ADD  CONSTRAINT [FK_Historial_Ejercicio_Ejercicio] FOREIGN KEY([id_ejercicio])
REFERENCES [dbo].[Ejercicio] ([id_ejercicio])
GO
ALTER TABLE [dbo].[Historial_Ejercicio] CHECK CONSTRAINT [FK_Historial_Ejercicio_Ejercicio]
GO
ALTER TABLE [dbo].[Historial_Ejercicio]  WITH CHECK ADD  CONSTRAINT [FK_Historial_Ejercicio_Rutina] FOREIGN KEY([id_rutina])
REFERENCES [dbo].[Rutina] ([id_rutina])
GO
ALTER TABLE [dbo].[Historial_Ejercicio] CHECK CONSTRAINT [FK_Historial_Ejercicio_Rutina]
GO
ALTER TABLE [dbo].[Horario_Trabajo]  WITH CHECK ADD  CONSTRAINT [FK_Horario_Trabajo_Instructor] FOREIGN KEY([id_instructor])
REFERENCES [dbo].[Instructor] ([id_instructor])
GO
ALTER TABLE [dbo].[Horario_Trabajo] CHECK CONSTRAINT [FK_Horario_Trabajo_Instructor]
GO
ALTER TABLE [dbo].[Horario_Trabajo]  WITH CHECK ADD  CONSTRAINT [FK_Horario_Trabajo_Horario] FOREIGN KEY([id_horario])
REFERENCES [dbo].[Horario] ([id_horario])
GO
ALTER TABLE [dbo].[Horario_Trabajo] CHECK CONSTRAINT [FK_Horario_Trabajo_Horario]
GO
ALTER TABLE [dbo].[Reservacion_Clase]  WITH CHECK ADD  CONSTRAINT [FK_Reservacion_Clase_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Persona] ([id_persona])
GO
ALTER TABLE [dbo].[Reservacion_Clase] CHECK CONSTRAINT [FK_Reservacion_Clase_Cliente]
GO
ALTER TABLE [dbo].[Reservacion_Clase]  WITH CHECK ADD  CONSTRAINT [FK_Reservacion_Clase_Clase_Salon] FOREIGN KEY([id_clase_salon])
REFERENCES [dbo].[Clase_Salon] ([id_clase_salon])
GO
ALTER TABLE [dbo].[Reservacion_Clase] CHECK CONSTRAINT [FK_Reservacion_Clase_Clase_Salon]
GO
ALTER TABLE [dbo].[Reservacion_Instructor]  WITH CHECK ADD  CONSTRAINT [FK_Reservacion_Instructor_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Persona] ([id_persona])
GO
ALTER TABLE [dbo].[Reservacion_Instructor] CHECK CONSTRAINT [FK_Reservacion_Instructor_Cliente]
GO
ALTER TABLE [dbo].[Reservacion_Instructor]  WITH CHECK ADD  CONSTRAINT [FK_Reservacion_Instructor_Instructor] FOREIGN KEY([id_instructor])
REFERENCES [dbo].[Instructor] ([id_instructor])
GO
ALTER TABLE [dbo].[Reservacion_Instructor] CHECK CONSTRAINT [FK_Reservacion_Instructor_Instructor]
GO
ALTER TABLE [dbo].[Reservacion_Instructor]  WITH CHECK ADD  CONSTRAINT [FK_Reservacion_Instructor_Horario] FOREIGN KEY([id_horario])
REFERENCES [dbo].[Horario] ([id_horario])
GO
ALTER TABLE [dbo].[Reservacion_Instructor] CHECK CONSTRAINT [FK_Reservacion_Instructor_Horario]
GO
ALTER TABLE [dbo].[Musculo_Involucrado]  WITH CHECK ADD  CONSTRAINT [FK_Musculo_Involucrado_Musculo] FOREIGN KEY([id_musculo])
REFERENCES [dbo].[Musculo] ([id_musculo])
GO
ALTER TABLE [dbo].[Musculo_Involucrado] CHECK CONSTRAINT [FK_Musculo_Involucrado_Musculo]
GO
ALTER TABLE [dbo].[Musculo_Involucrado]  WITH CHECK ADD  CONSTRAINT [FK_Musculo_Involucrado_Ejercicio] FOREIGN KEY([id_ejercicio])
REFERENCES [dbo].[Ejercicio] ([id_ejercicio])
GO
ALTER TABLE [dbo].[Musculo_Involucrado] CHECK CONSTRAINT [FK_Musculo_Involucrado_Ejercicio]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [CK_Persona_genero] CHECK  (([sexo]='m' OR [sexo]='f'))
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [CK_Persona_genero]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [CK_Persona_tipoPersona] CHECK  (([tipo]='cliente' OR [tipo]='administrador'))
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [CK_Persona_tipoPersona]
GO
ALTER TABLE [dbo].[Evaluacion_Instructor]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_Instructor_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Persona] ([id_persona])
GO
ALTER TABLE [dbo].[Evaluacion_Instructor] CHECK CONSTRAINT [FK_Evaluacion_Instructor_Cliente]
GO
ALTER TABLE [dbo].[Evaluacion_Instructor]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_Instructor_Instructor] FOREIGN KEY([id_instructor])
REFERENCES [dbo].[Instructor] ([id_instructor])
GO
ALTER TABLE [dbo].[Evaluacion_Instructor] CHECK CONSTRAINT [FK_Evaluacion_Instructor_Instructor]

GO
ALTER TABLE [dbo].[Evaluacion_Clase]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_Clase_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Persona] ([id_persona])
GO
ALTER TABLE [dbo].[Evaluacion_Clase] CHECK CONSTRAINT [FK_Evaluacion_Clase_Cliente]
GO
ALTER TABLE [dbo].[Evaluacion_Clase]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_Clase_Clase_Salon] FOREIGN KEY([id_clase_salon])
REFERENCES [dbo].[Clase_Salon] ([id_clase_salon])
GO
ALTER TABLE [dbo].[Evaluacion_Clase] CHECK CONSTRAINT [FK_Evaluacion_Clase_Clase_Salon]
GO
ALTER TABLE [dbo].[Instructor]  WITH CHECK ADD  CONSTRAINT [CK_Instructor_genero] CHECK  (([sexo]='m' OR [sexo]='f'))
GO
ALTER TABLE [dbo].[Instructor] CHECK CONSTRAINT [CK_Instructor_genero]

GO
USE [master]
GO
ALTER DATABASE [puipuiDBv1] SET  READ_WRITE 
GO
