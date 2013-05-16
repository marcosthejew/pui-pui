USE [master]
GO
/****** Object:  Database [puipuiDB]    Script Date: 16/05/2013 09:21:00 a.m. ******/
CREATE DATABASE [puipuiDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'puipuiDB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER\MSSQL\DATA\puipuiDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'puipuiDB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER\MSSQL\DATA\puipuiDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [puipuiDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [puipuiDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [puipuiDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [puipuiDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [puipuiDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [puipuiDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [puipuiDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [puipuiDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [puipuiDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [puipuiDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [puipuiDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [puipuiDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [puipuiDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [puipuiDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [puipuiDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [puipuiDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [puipuiDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [puipuiDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [puipuiDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [puipuiDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [puipuiDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [puipuiDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [puipuiDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [puipuiDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [puipuiDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [puipuiDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [puipuiDB] SET  MULTI_USER 
GO
ALTER DATABASE [puipuiDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [puipuiDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [puipuiDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [puipuiDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [puipuiDB]
GO
/****** Object:  Table [dbo].[Administrador]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrador](
	[id_administrador] [int] IDENTITY(1,1) NOT NULL,
	[primer_nombre] [nchar](50) NOT NULL,
	[segundo_nombre] [nchar](50) NULL,
	[primer_apellido] [nchar](50) NOT NULL,
	[segundo_apellido] [nchar](50) NULL,
	[genero] [nchar](1) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[fecha_registro] [date] NOT NULL,
	[ciudad] [nchar](50) NOT NULL,
	[direccion] [nchar](255) NOT NULL,
	[telefono_local] [int] NOT NULL,
	[telefono_celular] [int] NOT NULL,
	[correo_electronico] [nchar](50) NOT NULL,
	[nombre_contacto_emergencia] [nchar](50) NOT NULL,
	[telefono_contacto_emergencia] [int] NOT NULL,
	[status] [nchar](15) NOT NULL,
	[usuario] [nchar](50) NOT NULL,
	[password] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Administrador] PRIMARY KEY CLUSTERED 
(
	[id_administrador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

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
	[id_instructor] [int] NULL,
 CONSTRAINT [PK_Clase_Salon] PRIMARY KEY CLUSTERED 
(
	[id_clase_salon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[primer_nombre] [nchar](50) NOT NULL,
	[segundo_nombre] [nchar](50) NULL,
	[primer_apellido] [nchar](50) NOT NULL,
	[segundo_apellido] [nchar](50) NULL,
	[genero] [nchar](1) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[fecha_registro] [date] NOT NULL,
	[ciudad] [nchar](50) NOT NULL,
	[direccion] [nchar](255) NOT NULL,
	[telefono_local] [int] NOT NULL,
	[telefono_celular] [int] NOT NULL,
	[correo_electronico] [nchar](50) NOT NULL,
	[nombre_contacto_emergencia] [nchar](50) NOT NULL,
	[telefono_contacto_emergencia] [int] NOT NULL,
	[status] [nchar](15) NOT NULL,
	[usuario] [nchar](50) NOT NULL,
	[password] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
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
/****** Object:  Table [dbo].[Horario_Reserva]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horario_Reserva](
	[id_horario_reserva] [int] IDENTITY(1,1) NOT NULL,
	[fecha_inicio] [datetime] NOT NULL,
	[fecha_fin] [datetime] NOT NULL,
	[id_clase_salon] [int] NOT NULL,
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
	[dia] [nchar](20) NOT NULL,
	[hora_inicio] [time](7) NOT NULL,
	[hora_fin] [time](7) NOT NULL,
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
	[primer_nombre] [nchar](50) NOT NULL,
	[segundo_nombre] [nchar](50) NULL,
	[primer_apellido] [nchar](50) NOT NULL,
	[segundo_apelldo] [nchar](50) NULL,
	[genero] [nchar](1) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[fecha_registro] [date] NOT NULL,
	[ciudad] [nchar](50) NOT NULL,
	[direccion] [nchar](255) NOT NULL,
	[telefono_local] [int] NOT NULL,
	[telefono_celular] [int] NOT NULL,
	[correo_electronico] [nchar](50) NOT NULL,
	[nombre_contacto_emergencia] [nchar](50) NOT NULL,
	[telefono_contacto_emergencia] [int] NOT NULL,
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
	[id_horario_reserva] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
 CONSTRAINT [PK_Reservacion_Clase] PRIMARY KEY CLUSTERED 
(
	[id_reservacion_clase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reservacion_Instructor]    Script Date: 16/05/2013 09:21:00 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservacion_Instructor](
	[id_reservacion_instructor] [int] IDENTITY(1,1) NOT NULL,
	[fecha_reservacion] [datetime] NOT NULL,
	[fecha_inicio] [datetime] NOT NULL,
	[fecha_fin] [datetime] NOT NULL,
	[status] [nchar](15) NOT NULL,
	[id_instructor] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
 CONSTRAINT [PK_Reservacion_Instructor] PRIMARY KEY CLUSTERED 
(
	[id_reservacion_instructor] ASC
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
REFERENCES [dbo].[Cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_Evaluacion_Cliente]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_Instructor] FOREIGN KEY([id_instructor])
REFERENCES [dbo].[Instructor] ([id_instructor])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_Evaluacion_Instructor]
GO
ALTER TABLE [dbo].[Historial_Ejercicio]  WITH CHECK ADD  CONSTRAINT [FK_Historial_Ejercicio_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id_cliente])
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
ALTER TABLE [dbo].[Horario_Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Horario_Reserva_Clase_Salon] FOREIGN KEY([id_clase_salon])
REFERENCES [dbo].[Clase_Salon] ([id_clase_salon])
GO
ALTER TABLE [dbo].[Horario_Reserva] CHECK CONSTRAINT [FK_Horario_Reserva_Clase_Salon]
GO
ALTER TABLE [dbo].[Horario_Trabajo]  WITH CHECK ADD  CONSTRAINT [FK_Horario_Trabajo_Instructor] FOREIGN KEY([id_instructor])
REFERENCES [dbo].[Instructor] ([id_instructor])
GO
ALTER TABLE [dbo].[Horario_Trabajo] CHECK CONSTRAINT [FK_Horario_Trabajo_Instructor]
GO
ALTER TABLE [dbo].[Reservacion_Clase]  WITH CHECK ADD  CONSTRAINT [FK_Reservacion_Clase_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[Reservacion_Clase] CHECK CONSTRAINT [FK_Reservacion_Clase_Cliente]
GO
ALTER TABLE [dbo].[Reservacion_Clase]  WITH CHECK ADD  CONSTRAINT [FK_Reservacion_Clase_Horario_Reserva] FOREIGN KEY([id_horario_reserva])
REFERENCES [dbo].[Horario_Reserva] ([id_horario_reserva])
GO
ALTER TABLE [dbo].[Reservacion_Clase] CHECK CONSTRAINT [FK_Reservacion_Clase_Horario_Reserva]
GO
ALTER TABLE [dbo].[Reservacion_Instructor]  WITH CHECK ADD  CONSTRAINT [FK_Reservacion_Instructor_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[Reservacion_Instructor] CHECK CONSTRAINT [FK_Reservacion_Instructor_Cliente]
GO
ALTER TABLE [dbo].[Reservacion_Instructor]  WITH CHECK ADD  CONSTRAINT [FK_Reservacion_Instructor_Instructor] FOREIGN KEY([id_instructor])
REFERENCES [dbo].[Instructor] ([id_instructor])
GO
ALTER TABLE [dbo].[Reservacion_Instructor] CHECK CONSTRAINT [FK_Reservacion_Instructor_Instructor]
GO
ALTER TABLE [dbo].[Administrador]  WITH CHECK ADD  CONSTRAINT [CK_Administrador_genero] CHECK  (([genero]='m' OR [genero]='f'))
GO
ALTER TABLE [dbo].[Administrador] CHECK CONSTRAINT [CK_Administrador_genero]
GO
ALTER TABLE [dbo].[Administrador]  WITH CHECK ADD  CONSTRAINT [CK_Administrador_status] CHECK  (([status]='activo' OR [status]='inactivo'))
GO
ALTER TABLE [dbo].[Administrador] CHECK CONSTRAINT [CK_Administrador_status]
GO
ALTER TABLE [dbo].[Clase_Salon]  WITH CHECK ADD  CONSTRAINT [CK_Clase_Salon_IsReservado] CHECK  (([isReservado]=(0) OR [isReservado]=(1)))
GO
ALTER TABLE [dbo].[Clase_Salon] CHECK CONSTRAINT [CK_Clase_Salon_IsReservado]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [CK_Cliente_genero] CHECK  (([genero]='m' OR [genero]='f'))
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [CK_Cliente_genero]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [CK_Cliente_status] CHECK  (([status]='activo' OR [status]='inactivo'))
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [CK_Cliente_status]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [CK_Evaluacion_Calificacion] CHECK  (([calificacion]>=(0) AND [calificacion]<=(10)))
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [CK_Evaluacion_Calificacion]
GO
ALTER TABLE [dbo].[Horario_Trabajo]  WITH CHECK ADD  CONSTRAINT [CK_Horario_Trabajo_Dia] CHECK  (([dia]='lunes' OR [dia]='martes' OR [dia]='miercoles' OR [dia]='jueves' OR [dia]='viernes' OR [dia]='sabado' OR [dia]='domingo'))
GO
ALTER TABLE [dbo].[Horario_Trabajo] CHECK CONSTRAINT [CK_Horario_Trabajo_Dia]
GO
ALTER TABLE [dbo].[Instructor]  WITH CHECK ADD  CONSTRAINT [CK_Instructor_genero] CHECK  (([genero]='m' OR [genero]='f'))
GO
ALTER TABLE [dbo].[Instructor] CHECK CONSTRAINT [CK_Instructor_genero]
GO
ALTER TABLE [dbo].[Instructor]  WITH CHECK ADD  CONSTRAINT [CK_Instructor_status] CHECK  (([status]='activo' OR [status]='inactivo'))
GO
ALTER TABLE [dbo].[Instructor] CHECK CONSTRAINT [CK_Instructor_status]
GO
ALTER TABLE [dbo].[Reservacion_Clase]  WITH CHECK ADD  CONSTRAINT [CK_Reservacion_Clase_Status] CHECK  (([status]='completada' OR [status]='cancelada' OR [status]='espera'))
GO
ALTER TABLE [dbo].[Reservacion_Clase] CHECK CONSTRAINT [CK_Reservacion_Clase_Status]
GO
ALTER TABLE [dbo].[Reservacion_Instructor]  WITH CHECK ADD  CONSTRAINT [CK_Reservacion_Instructor_Status] CHECK  (([status]='completada' OR [status]='cancelada' OR [status]='espera'))
GO
ALTER TABLE [dbo].[Reservacion_Instructor] CHECK CONSTRAINT [CK_Reservacion_Instructor_Status]
GO
USE [master]
GO
ALTER DATABASE [puipuiDB] SET  READ_WRITE 
GO
