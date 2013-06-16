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
	[estatus] [int] not null,
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
	[isReservado] [int] NOT NULL,
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
	[idPersona] [int] IDENTITY(1,1) NOT NULL,
	[cedulaPersona] [nchar](10) NOT NULL,
	[nombrePersona1] [nchar](50) NOT NULL,
	[nombrePersona2] [nchar](50) NULL,
	[apellidoPersona1] [nchar](50) NOT NULL,
	[apellidoPersona2] [nchar](50) NULL,
	[generoPersona] [nchar](50) NOT NULL,
	[fechaNacimientoPersona] [date] NOT NULL,
	[fechaIngresoPersona] [date] NOT NULL,
	[ciudadPersona] [nchar] (50) NOT NULL,
	[DireccionPersona] [nchar] (300) NOT NULL,
	[telefonoLocalPersona] [nchar] (50) NULL,
	[telefonoCelularPersona] [nchar] (50) NULL,
	[correoPersona] [nchar](50) NULL,
	[contactoNombrePersona] [nchar](50) NULL,
	[contactoTelefonoPersona] [nchar] (50) NULL,
	[estadoPersona] [nchar](10) NOT NULL,
	[loginPersona] [nchar](50) NOT NULL,
	[passwordPersona] [nchar](50) NOT NULL,
	[tipoPersona] [nchar](50) NOT NULL,
	[statusPersona] [nchar](15) NOT NULL,
	
	
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON

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
	[id_musculo] [int] NOT NULL,
 CONSTRAINT [PK_Ejercicio] PRIMARY KEY CLUSTERED 
(
	[id_ejercicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Evaluacion]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluacion](
	[id_evaluacion] [int] IDENTITY(1,1) NOT NULL,
	[fecha_evaluacion] [datetime] NOT NULL,
	[calificacion] [int] NOT NULL,
	[id_clase_salon] [int] NULL,
	[id_cliente] [int] NULL,
	[id_instructor] [int] NOT NULL,
 CONSTRAINT [PK_Evaluacion] PRIMARY KEY CLUSTERED 
(
	[id_evaluacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Historial_Ejercicio]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historial_Ejercicio](
	[id_historial_ejercicio] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_rutina] [int] NOT NULL,
	[id_ejercicio] [int] NOT NULL,
 CONSTRAINT [PK_Historial_Ejercicio] PRIMARY KEY CLUSTERED 
(
	[id_historial_ejercicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reserva_Instructor]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva_Instructor](
	[id_horario_reserva] [int] IDENTITY(1,1) NOT NULL,
	[fecha_reserva] [datetime] NOT NULL,
	[id_horario] [int] NOT NULL,
	[id_instructor] [int] NOT NULL,
	[idPersona] [int] NOT NULL,
	[status] [nchar](15) NOT NULL,
 CONSTRAINT [PK_Horario_Reserva] PRIMARY KEY CLUSTERED 
(
	[id_horario_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Horario_Trabajo]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horario_Trabajo](
	[id_horario_trabajo] [int] IDENTITY(1,1) NOT NULL,
	[id_horario] [int] NOT NULL,
	[id_instructor] [int] NOT NULL,
 CONSTRAINT [PK_Horario_Trabajo] PRIMARY KEY CLUSTERED 
(
	[id_horario_trabajo] ASC
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
	[primer_nombre] [nchar](50) NOT NULL,
	[segundo_nombre] [nchar](50) NULL,
	[primer_apellido] [nchar](50) NOT NULL,
	[segundo_apelldo] [nchar](50) NULL,
	[genero] [nchar](1) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[fecha_registro] [date] NOT NULL,
	[ciudad] [nchar](50) NOT NULL,
	[direccion] [nchar](255) NOT NULL,
	[telefono_local] [nchar] (50) NOT NULL,
	[telefono_celular] [nchar] (50) NOT NULL,
	[correo_electronico] [nchar](50) NOT NULL,
	[nombre_contacto_emergencia] [nchar](50) NOT NULL,
	[telefono_contacto_emergencia] [nchar] (50) NOT NULL,
	[status] [nchar](15) NOT NULL,
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
 CONSTRAINT [PK_Musculo] PRIMARY KEY CLUSTERED 
(
	[id_musculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reservacion_Clase]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservacion_Clase](
	[id_reservacion_clase] [int] IDENTITY(1,1) NOT NULL,
	[fecha_reservacion] [datetime] NOT NULL,
	[status] [nchar](15) NOT NULL,
	[id_clase_salon] [int] NOT NULL,
	[id_persona] [int] NOT NULL,
 CONSTRAINT [PK_Reservacion_Clase] PRIMARY KEY CLUSTERED 
(
	[id_reservacion_clase] ASC
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
	[descripcion] [nchar](50) NOT NULL,
	[duracion] [time](7) NOT NULL,
	[repeteciones] [int] NULL,
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
	[ubicacion] [nchar](50) NOT NULL,
	[capacidad] [int] NOT NULL,
	[estatus] [int] NOT NULL,
 CONSTRAINT [PK_Salon] PRIMARY KEY CLUSTERED 
(
	[id_salon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Clase_Salon]  WITH CHECK ADD  CONSTRAINT [CK_Clase_Salon_IsReservado] CHECK  (([isReservado]=(0) OR [isReservado]=(1)))
GO
ALTER TABLE [dbo].[Clase_Salon] CHECK CONSTRAINT [CK_Clase_Salon_IsReservado]
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
ALTER TABLE [dbo].[Ejercicio]  WITH CHECK ADD  CONSTRAINT [FK_Ejercicio_Musculo] FOREIGN KEY([id_musculo])
REFERENCES [dbo].[Musculo] ([id_musculo])
GO
ALTER TABLE [dbo].[Ejercicio] CHECK CONSTRAINT [FK_Ejercicio_Musculo]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_Clase_Salon] FOREIGN KEY([id_clase_salon])
REFERENCES [dbo].[Clase_Salon] ([id_clase_salon])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_Evaluacion_Clase_Salon]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_Evaluacion_Cliente]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_Instructor] FOREIGN KEY([id_instructor])
REFERENCES [dbo].[Instructor] ([id_instructor])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_Evaluacion_Instructor]
GO
ALTER TABLE [dbo].[Historial_Ejercicio]  WITH CHECK ADD  CONSTRAINT [FK_Historial_Ejercicio_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Persona] ([idPersona])
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
ALTER TABLE [dbo].[Reservacion_Clase]  WITH CHECK ADD  CONSTRAINT [FK_Reservacion_Clase_Persona] FOREIGN KEY([id_persona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Reservacion_Clase] CHECK CONSTRAINT [FK_Reservacion_Clase_Persona]
GO
ALTER TABLE [dbo].[Reservacion_Clase]  WITH CHECK ADD  CONSTRAINT [FK_Reservacion_Clase_Clase_Salon] FOREIGN KEY([id_clase_salon])
REFERENCES [dbo].[Clase_Salon] ([id_clase_salon])
GO
ALTER TABLE [dbo].[Reservacion_Clase] CHECK CONSTRAINT [FK_Reservacion_Clase_Clase_Salon]
GO
ALTER TABLE [dbo].[Reserva_Instructor]  WITH CHECK ADD  CONSTRAINT [FK_Reservacion_Instructor_Persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Reserva_Instructor] CHECK CONSTRAINT [FK_Reservacion_Instructor_Persona]
GO
ALTER TABLE [dbo].[Reserva_Instructor]  WITH CHECK ADD  CONSTRAINT [FK_Reservacion_Instructor_Instructor] FOREIGN KEY([id_instructor])
REFERENCES [dbo].[Instructor] ([id_instructor])
GO
ALTER TABLE [dbo].[Reserva_Instructor] CHECK CONSTRAINT [FK_Reservacion_Instructor_Instructor]
GO
ALTER TABLE [dbo].[Reserva_Instructor]  WITH CHECK ADD  CONSTRAINT [FK_Reservacion_Instructor_Horario] FOREIGN KEY([id_horario])
REFERENCES [dbo].[Horario] ([id_horario])
GO
ALTER TABLE [dbo].[Reserva_Instructor] CHECK CONSTRAINT [FK_Reservacion_Instructor_Horario]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [CK_Persona_genero] CHECK  (([generoPersona]='m' OR [generoPersona]='f'))
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [CK_Persona_genero]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [CK_Persona_status] CHECK  (([statusPersona]='activo' OR [statusPersona]='inactivo'))
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [CK_Persona_status]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [CK_Persona_tipoPersona] CHECK  (([tipoPersona]='cliente' OR [tipoPersona]='administrador'))
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [CK_Persona_tipoPersona]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [CK_Evaluacion_Calificacion] CHECK  (([calificacion]>=(0) AND [calificacion]<=(10)))
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [CK_Evaluacion_Calificacion]
GO
ALTER TABLE [dbo].[Instructor]  WITH CHECK ADD  CONSTRAINT [CK_Instructor_genero] CHECK  (([genero]='m' OR [genero]='f'))
GO
ALTER TABLE [dbo].[Instructor] CHECK CONSTRAINT [CK_Instructor_genero]
GO
ALTER TABLE [dbo].[Instructor]  WITH CHECK ADD  CONSTRAINT [CK_Instructor_status] CHECK  (([status]='activo' OR [status]='inactivo'))
GO
ALTER TABLE [dbo].[Instructor] CHECK CONSTRAINT [CK_Instructor_status]
GO
ALTER TABLE [dbo].[Reserva_Instructor]  WITH CHECK ADD  CONSTRAINT [CK_Reserva_Instructor_Status] CHECK  (([status]='completada' OR [status]='cancelada' OR [status]='espera'))
GO
ALTER TABLE [dbo].[Reserva_Instructor] CHECK CONSTRAINT [CK_Reserva_Instructor_Status]
GO
USE [master]
GO
ALTER DATABASE [puipuiDBv1] SET  READ_WRITE 
GO
