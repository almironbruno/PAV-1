USE [master]
GO
/****** Object:  Database [BD3K3G03_2022]    Script Date: 14/11/2022 12:57:28 ******/
CREATE DATABASE [BD3K3G03_2022]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD3K3G03_2022', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BD3K3G03_2022.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BD3K3G03_2022_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BD3K3G03_2022_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BD3K3G03_2022] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD3K3G03_2022].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD3K3G03_2022] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD3K3G03_2022] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD3K3G03_2022] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD3K3G03_2022] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD3K3G03_2022] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD3K3G03_2022] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD3K3G03_2022] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD3K3G03_2022] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD3K3G03_2022] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD3K3G03_2022] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD3K3G03_2022] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD3K3G03_2022] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD3K3G03_2022] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD3K3G03_2022] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD3K3G03_2022] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BD3K3G03_2022] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD3K3G03_2022] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD3K3G03_2022] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD3K3G03_2022] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD3K3G03_2022] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD3K3G03_2022] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD3K3G03_2022] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD3K3G03_2022] SET RECOVERY FULL 
GO
ALTER DATABASE [BD3K3G03_2022] SET  MULTI_USER 
GO
ALTER DATABASE [BD3K3G03_2022] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD3K3G03_2022] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD3K3G03_2022] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD3K3G03_2022] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BD3K3G03_2022] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BD3K3G03_2022] SET QUERY_STORE = OFF
GO
USE [BD3K3G03_2022]
GO
/****** Object:  Table [dbo].[autos]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[autos](
	[cod_serie_fabrica] [varchar](25) NOT NULL,
	[id_nombrecomercial] [int] NOT NULL,
	[año_fabricacion] [int] NOT NULL,
	[id_condicion] [int] NOT NULL,
	[nro_chasis] [int] NOT NULL,
	[nro_motor] [int] NOT NULL,
	[patente] [varchar](10) NOT NULL,
	[monto] [int] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [autos_pk] PRIMARY KEY CLUSTERED 
(
	[cod_serie_fabrica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[barrios]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[barrios](
	[id_barrios] [int] IDENTITY(1,1) NOT NULL,
	[nombre_barrio] [varchar](25) NOT NULL,
 CONSTRAINT [barrios_pk] PRIMARY KEY CLUSTERED 
(
	[id_barrios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[caracteristicas]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[caracteristicas](
	[cod_caracteristica] [int] IDENTITY(1,1) NOT NULL,
	[tipo_caracteristica] [int] NOT NULL,
	[descripcion] [varchar](60) NOT NULL,
 CONSTRAINT [caracteristicas_pk] PRIMARY KEY CLUSTERED 
(
	[cod_caracteristica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[caracteristicas_telefonicas]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[caracteristicas_telefonicas](
	[nro_caracteristica_telefonica] [int] IDENTITY(1,1) NOT NULL,
	[nombre_region] [varchar](25) NOT NULL,
 CONSTRAINT [caracteristicas_telefonicas_pk] PRIMARY KEY CLUSTERED 
(
	[nro_caracteristica_telefonica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cargos_empleados]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cargos_empleados](
	[id_cargo] [int] IDENTITY(1,1) NOT NULL,
	[nombre_cargo] [varchar](25) NOT NULL,
 CONSTRAINT [cargos_empleados_pk] PRIMARY KEY CLUSTERED 
(
	[id_cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[tipo_doc_cliente] [int] NOT NULL,
	[nro_doc_cliente] [int] NOT NULL,
	[nombre] [varchar](25) NOT NULL,
	[apellido] [varchar](25) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[calle] [varchar](25) NOT NULL,
	[nro_calle] [int] NOT NULL,
	[id_barrio] [int] NULL,
 CONSTRAINT [clientes_pk] PRIMARY KEY CLUSTERED 
(
	[tipo_doc_cliente] ASC,
	[nro_doc_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[condicion]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[condicion](
	[id_condicion] [int] IDENTITY(1,1) NOT NULL,
	[nombre_condicion] [varchar](25) NOT NULL,
 CONSTRAINT [condicion_pk] PRIMARY KEY CLUSTERED 
(
	[id_condicion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_caracteristicas_x_auto]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_caracteristicas_x_auto](
	[cod_caracteristica] [int] NOT NULL,
	[cod_serie_fabrica] [varchar](25) NOT NULL,
	[grado] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[comentario] [varchar](50) NOT NULL,
 CONSTRAINT [detalle_caractetisticas_x_autos_pk] PRIMARY KEY CLUSTERED 
(
	[cod_caracteristica] ASC,
	[cod_serie_fabrica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_encargo]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_encargo](
	[nro_encargo] [int] NOT NULL,
	[cod_caracteristica] [int] NOT NULL,
	[prioridad] [varchar](50) NULL,
 CONSTRAINT [PK_detalle_encargo] PRIMARY KEY CLUSTERED 
(
	[nro_encargo] ASC,
	[cod_caracteristica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_ventas]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_ventas](
	[nro_factura] [int] NOT NULL,
	[cod_serie_fabrica] [varchar](25) NOT NULL,
	[monto] [numeric](18, 0) NULL,
 CONSTRAINT [detalle_ventas_pk] PRIMARY KEY CLUSTERED 
(
	[nro_factura] ASC,
	[cod_serie_fabrica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empleados]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleados](
	[legajo_empleado] [int] NOT NULL,
	[apellido] [varchar](25) NOT NULL,
	[nombre] [varchar](25) NOT NULL,
	[cargo] [int] NULL,
 CONSTRAINT [empleados_pk] PRIMARY KEY CLUSTERED 
(
	[legajo_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[encargo]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[encargo](
	[nro_encargo] [int] IDENTITY(1,1) NOT NULL,
	[tipo_doc_cliente] [int] NOT NULL,
	[nro_doc_cliente] [int] NOT NULL,
	[fecha] [varchar](50) NULL,
	[id_nombrecomercial] [int] NOT NULL,
	[legajo_empleado] [int] NOT NULL,
 CONSTRAINT [PK__encargo__6D863F1D132515A3] PRIMARY KEY CLUSTERED 
(
	[nro_encargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[encargos]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[encargos](
	[nro_encargo] [int] IDENTITY(1,1) NOT NULL,
	[tipo_doc_cliente] [int] NOT NULL,
	[nro_doc_cliente] [int] NOT NULL,
	[fecha] [varchar](50) NULL,
	[id_nombrecomercial] [int] NULL,
	[legajo_empleado] [int] NULL,
	[cod_caracteristica] [int] NULL,
	[prioridad] [int] NULL,
 CONSTRAINT [PK_encargos] PRIMARY KEY CLUSTERED 
(
	[nro_encargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gamas]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gamas](
	[id_gama] [int] IDENTITY(1,1) NOT NULL,
	[nombre_gama] [varchar](25) NULL,
 CONSTRAINT [gamas_pk] PRIMARY KEY CLUSTERED 
(
	[id_gama] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[localidades]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[localidades](
	[cod_postal] [int] IDENTITY(1,1) NOT NULL,
	[nombre_localidad] [varchar](25) NULL,
 CONSTRAINT [localidades_pk] PRIMARY KEY CLUSTERED 
(
	[cod_postal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[marcas]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[marcas](
	[id_marca] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NULL,
 CONSTRAINT [marcas_pk] PRIMARY KEY CLUSTERED 
(
	[id_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nombres_comerciales]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nombres_comerciales](
	[id_nombrecomercial] [int] IDENTITY(1,1) NOT NULL,
	[nombre_comercial] [varchar](25) NOT NULL,
	[id_marca] [int] NOT NULL,
	[id_gama] [int] NOT NULL,
 CONSTRAINT [nombres_comerciales_pk] PRIMARY KEY CLUSTERED 
(
	[id_nombrecomercial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prioridades]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prioridades](
	[id_prioridad] [int] IDENTITY(1,1) NOT NULL,
	[nombre_prioridad] [varchar](25) NULL,
 CONSTRAINT [PK_prioridades] PRIMARY KEY CLUSTERED 
(
	[id_prioridad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[telefonos]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[telefonos](
	[nro_telefono] [int] NOT NULL,
	[nro_caracteristica] [int] NOT NULL,
	[tipo_doc_cliente] [int] NULL,
	[nro_doc_cliente] [int] NULL,
 CONSTRAINT [telefonos_pk] PRIMARY KEY CLUSTERED 
(
	[nro_telefono] ASC,
	[nro_caracteristica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_caracteristica]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_caracteristica](
	[id_caracteristica] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tipo] [varchar](25) NULL,
 CONSTRAINT [tipo_caracteristica_pk] PRIMARY KEY CLUSTERED 
(
	[id_caracteristica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_doc_clientes]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_doc_clientes](
	[id_doc_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tipo_doc] [varchar](25) NOT NULL,
 CONSTRAINT [tipo_doc_clientes_pk] PRIMARY KEY CLUSTERED 
(
	[id_doc_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NOT NULL,
	[apellido] [varchar](25) NOT NULL,
	[password] [varchar](25) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[legajo] [int] NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ventas]    Script Date: 14/11/2022 12:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventas](
	[nro_factura] [int] IDENTITY(1,1) NOT NULL,
	[tipo_doc_cliente] [int] NULL,
	[nro_doc_cliente] [int] NULL,
	[fecha] [date] NULL,
	[legajo_empleado] [int] NULL,
 CONSTRAINT [ventas_pk] PRIMARY KEY CLUSTERED 
(
	[nro_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'1234', 1, 1233, 2, 3412, 2314, N'acssq12', 1000, 1)
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'2123-22', 6, 2022, 1, 8379, 9734, N'611qa', 50000, 1)
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'2123-23', 6, 2020, 1, 8376, 9736, N'645ERT', 50400, 1)
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'A12WS1', 5, 2015, 2, 4569, 9898, N'1as211', 65478, 1)
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'ABC-567', 3, 2000, 1, 2353, 3242, N'OPR234', 5400, 1)
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'abcdas', 4, 1996, 2, 2112, 2121, N'DAR213', 4852, 1)
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'acb123', 1, 2022, 1, 4444, 4445, N'EFG123', 5000, 1)
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'acb124', 3, 2022, 1, 7777, 4455, N'EAG126', 5030, 1)
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'acb125', 4, 2022, 1, 4332, 4425, N'BNC125', 5070, 1)
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'acb126', 5, 2022, 1, 2323, 4435, N'HJK127', 5030, 1)
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'acb128', 3, 2022, 1, 4234, 4476, N'ERG121', 5020, 1)
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'acb129', 4, 2022, 1, 1111, 4655, N'TRG128', 5030, 1)
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'acb134', 1, 1998, 1, 1131, 4645, N'EGG124', 5030, 1)
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'acca1122', 6, 2023, 2, 8979, 9744, N'6111qa', 498987, 1)
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'ACSSQW1', 4, 2011, 2, 3246, 7798, N'PA1223', 98888, 1)
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'agr2113', 1, 2022, 1, 2312, 2132, N'dsadad', 500000, 0)
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'AS997', 1, 2014, 1, 6997, 9444, N'ACZ661QW', 649877, 1)
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'ASCCWQ', 1, 2015, 1, 121, 1212, N'abc332', 46471, 1)
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'asd1111', 5, 2012, 1, 4787, 9879, N'APCC11', 12344112, 1)
INSERT [dbo].[autos] ([cod_serie_fabrica], [id_nombrecomercial], [año_fabricacion], [id_condicion], [nro_chasis], [nro_motor], [patente], [monto], [estado]) VALUES (N'azasc', 6, 2015, 1, 6677, 5447, N'667447', 4778, 1)
GO
SET IDENTITY_INSERT [dbo].[barrios] ON 

INSERT [dbo].[barrios] ([id_barrios], [nombre_barrio]) VALUES (3, N'Guemes')
INSERT [dbo].[barrios] ([id_barrios], [nombre_barrio]) VALUES (4, N'Alberdi')
INSERT [dbo].[barrios] ([id_barrios], [nombre_barrio]) VALUES (5, N'Arguello')
INSERT [dbo].[barrios] ([id_barrios], [nombre_barrio]) VALUES (6, N'Alta Cordoba')
INSERT [dbo].[barrios] ([id_barrios], [nombre_barrio]) VALUES (35, N'Nueva Cordoba')
SET IDENTITY_INSERT [dbo].[barrios] OFF
GO
SET IDENTITY_INSERT [dbo].[caracteristicas] ON 

INSERT [dbo].[caracteristicas] ([cod_caracteristica], [tipo_caracteristica], [descripcion]) VALUES (1, 2, N'autito')
SET IDENTITY_INSERT [dbo].[caracteristicas] OFF
GO
SET IDENTITY_INSERT [dbo].[caracteristicas_telefonicas] ON 

INSERT [dbo].[caracteristicas_telefonicas] ([nro_caracteristica_telefonica], [nombre_region]) VALUES (1, N'Salta')
INSERT [dbo].[caracteristicas_telefonicas] ([nro_caracteristica_telefonica], [nombre_region]) VALUES (2, N'Cordoba')
SET IDENTITY_INSERT [dbo].[caracteristicas_telefonicas] OFF
GO
SET IDENTITY_INSERT [dbo].[cargos_empleados] ON 

INSERT [dbo].[cargos_empleados] ([id_cargo], [nombre_cargo]) VALUES (1, N'Gerente')
INSERT [dbo].[cargos_empleados] ([id_cargo], [nombre_cargo]) VALUES (2, N'Responsable de Ventas')
INSERT [dbo].[cargos_empleados] ([id_cargo], [nombre_cargo]) VALUES (3, N'Responsable de Deposito')
SET IDENTITY_INSERT [dbo].[cargos_empleados] OFF
GO
INSERT [dbo].[clientes] ([tipo_doc_cliente], [nro_doc_cliente], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [id_barrio]) VALUES (1, 33232, N'ddsdasd', N'sadsadas', CAST(N'2121-02-21' AS Date), N'wqqewqe', 3323, 1)
INSERT [dbo].[clientes] ([tipo_doc_cliente], [nro_doc_cliente], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [id_barrio]) VALUES (1, 121212, N'weqewq', N'eqweq', CAST(N'2121-01-01' AS Date), N'dsada', 121212, 1)
INSERT [dbo].[clientes] ([tipo_doc_cliente], [nro_doc_cliente], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [id_barrio]) VALUES (1, 123123, N'Pedro', N'Mariano', CAST(N'1992-05-24' AS Date), N'Buenos Aires', 123, 1)
INSERT [dbo].[clientes] ([tipo_doc_cliente], [nro_doc_cliente], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [id_barrio]) VALUES (1, 1243567, N'Pepe Juan', N'Juarez', CAST(N'2021-11-12' AS Date), N'Alberdi', 1243567, 3)
INSERT [dbo].[clientes] ([tipo_doc_cliente], [nro_doc_cliente], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [id_barrio]) VALUES (1, 6666666, N'epepepepepee', N'aaaaaaaaaaaaa', CAST(N'1654-01-01' AS Date), N'pepepe', 6666666, 1)
INSERT [dbo].[clientes] ([tipo_doc_cliente], [nro_doc_cliente], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [id_barrio]) VALUES (1, 21321312, N'Adriel', N'Coria', CAST(N'2022-10-04' AS Date), N'Alberdi', 21321312, 2)
INSERT [dbo].[clientes] ([tipo_doc_cliente], [nro_doc_cliente], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [id_barrio]) VALUES (1, 22222222, N'Juan', N'Trabajo', CAST(N'2000-12-21' AS Date), N'Sol de Mayo', 22222222, 4)
INSERT [dbo].[clientes] ([tipo_doc_cliente], [nro_doc_cliente], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [id_barrio]) VALUES (1, 27564289, N'Juan', N'Perez', CAST(N'1994-05-24' AS Date), N'Avenida Colon', 400, NULL)
INSERT [dbo].[clientes] ([tipo_doc_cliente], [nro_doc_cliente], [nombre], [apellido], [fecha_nacimiento], [calle], [nro_calle], [id_barrio]) VALUES (1, 44444444, N'dsdass', N'asdasdad', CAST(N'1111-11-11' AS Date), N'asdadaa', 44444444, 1)
GO
SET IDENTITY_INSERT [dbo].[condicion] ON 

INSERT [dbo].[condicion] ([id_condicion], [nombre_condicion]) VALUES (1, N'Nuevo')
INSERT [dbo].[condicion] ([id_condicion], [nombre_condicion]) VALUES (2, N'Usado')
SET IDENTITY_INSERT [dbo].[condicion] OFF
GO
INSERT [dbo].[detalle_ventas] ([nro_factura], [cod_serie_fabrica], [monto]) VALUES (18, N'ACSSQW1', CAST(98888 AS Numeric(18, 0)))
INSERT [dbo].[detalle_ventas] ([nro_factura], [cod_serie_fabrica], [monto]) VALUES (18, N'azasc', CAST(4778 AS Numeric(18, 0)))
INSERT [dbo].[detalle_ventas] ([nro_factura], [cod_serie_fabrica], [monto]) VALUES (19, N'A12WS1', CAST(65478 AS Numeric(18, 0)))
INSERT [dbo].[detalle_ventas] ([nro_factura], [cod_serie_fabrica], [monto]) VALUES (20, N'ASCCWQ', CAST(46471 AS Numeric(18, 0)))
INSERT [dbo].[detalle_ventas] ([nro_factura], [cod_serie_fabrica], [monto]) VALUES (22, N'1234', CAST(1000 AS Numeric(18, 0)))
INSERT [dbo].[detalle_ventas] ([nro_factura], [cod_serie_fabrica], [monto]) VALUES (23, N'asd1111', CAST(12344112 AS Numeric(18, 0)))
INSERT [dbo].[detalle_ventas] ([nro_factura], [cod_serie_fabrica], [monto]) VALUES (31, N'acca1122', CAST(498987 AS Numeric(18, 0)))
INSERT [dbo].[detalle_ventas] ([nro_factura], [cod_serie_fabrica], [monto]) VALUES (32, N'acb124', CAST(5030 AS Numeric(18, 0)))
INSERT [dbo].[detalle_ventas] ([nro_factura], [cod_serie_fabrica], [monto]) VALUES (33, N'ABC-567', CAST(5400 AS Numeric(18, 0)))
INSERT [dbo].[detalle_ventas] ([nro_factura], [cod_serie_fabrica], [monto]) VALUES (33, N'AS997', CAST(649877 AS Numeric(18, 0)))
INSERT [dbo].[detalle_ventas] ([nro_factura], [cod_serie_fabrica], [monto]) VALUES (34, N'2123-23', CAST(50400 AS Numeric(18, 0)))
INSERT [dbo].[detalle_ventas] ([nro_factura], [cod_serie_fabrica], [monto]) VALUES (34, N'acb126', CAST(5030 AS Numeric(18, 0)))
INSERT [dbo].[detalle_ventas] ([nro_factura], [cod_serie_fabrica], [monto]) VALUES (34, N'acb129', CAST(5030 AS Numeric(18, 0)))
INSERT [dbo].[detalle_ventas] ([nro_factura], [cod_serie_fabrica], [monto]) VALUES (35, N'acb125', CAST(5070 AS Numeric(18, 0)))
INSERT [dbo].[detalle_ventas] ([nro_factura], [cod_serie_fabrica], [monto]) VALUES (36, N'2123-22', CAST(50000 AS Numeric(18, 0)))
INSERT [dbo].[detalle_ventas] ([nro_factura], [cod_serie_fabrica], [monto]) VALUES (45, N'abcdas', CAST(4852 AS Numeric(18, 0)))
GO
INSERT [dbo].[empleados] ([legajo_empleado], [apellido], [nombre], [cargo]) VALUES (12121, N'perezperez', N'pepe', 2)
INSERT [dbo].[empleados] ([legajo_empleado], [apellido], [nombre], [cargo]) VALUES (12345, N'Coria', N'Adriel', 2)
INSERT [dbo].[empleados] ([legajo_empleado], [apellido], [nombre], [cargo]) VALUES (12545, N'Sanchez', N'Pedro', NULL)
INSERT [dbo].[empleados] ([legajo_empleado], [apellido], [nombre], [cargo]) VALUES (14725, N'Giacobino', N'Tomas', 2)
INSERT [dbo].[empleados] ([legajo_empleado], [apellido], [nombre], [cargo]) VALUES (45678, N'Almiron', N'Bruno', 2)
INSERT [dbo].[empleados] ([legajo_empleado], [apellido], [nombre], [cargo]) VALUES (45687, N'Sanchez', N'Pedro', 1)
INSERT [dbo].[empleados] ([legajo_empleado], [apellido], [nombre], [cargo]) VALUES (78945, N'Pizarro', N'Emilio', 2)
GO
SET IDENTITY_INSERT [dbo].[encargo] ON 

INSERT [dbo].[encargo] ([nro_encargo], [tipo_doc_cliente], [nro_doc_cliente], [fecha], [id_nombrecomercial], [legajo_empleado]) VALUES (6, 1, 33232, N'2022-10-22', 1, 12121)
SET IDENTITY_INSERT [dbo].[encargo] OFF
GO
SET IDENTITY_INSERT [dbo].[encargos] ON 

INSERT [dbo].[encargos] ([nro_encargo], [tipo_doc_cliente], [nro_doc_cliente], [fecha], [id_nombrecomercial], [legajo_empleado], [cod_caracteristica], [prioridad]) VALUES (49, 1, 33232, N'24/10/2022', 1, 12121, 1, 1)
SET IDENTITY_INSERT [dbo].[encargos] OFF
GO
SET IDENTITY_INSERT [dbo].[gamas] ON 

INSERT [dbo].[gamas] ([id_gama], [nombre_gama]) VALUES (1, N'Alta')
INSERT [dbo].[gamas] ([id_gama], [nombre_gama]) VALUES (2, N'Media')
INSERT [dbo].[gamas] ([id_gama], [nombre_gama]) VALUES (3, N'Baja')
SET IDENTITY_INSERT [dbo].[gamas] OFF
GO
SET IDENTITY_INSERT [dbo].[localidades] ON 

INSERT [dbo].[localidades] ([cod_postal], [nombre_localidad]) VALUES (14, N'CARLOS PAZ')
INSERT [dbo].[localidades] ([cod_postal], [nombre_localidad]) VALUES (17, N'RIO CUARTO')
INSERT [dbo].[localidades] ([cod_postal], [nombre_localidad]) VALUES (18, N'RIO CEBALLO')
INSERT [dbo].[localidades] ([cod_postal], [nombre_localidad]) VALUES (19, N'JESUS MARIA')
INSERT [dbo].[localidades] ([cod_postal], [nombre_localidad]) VALUES (20, N'VILLA MARIA')
INSERT [dbo].[localidades] ([cod_postal], [nombre_localidad]) VALUES (21, N'SAN JUSTO')
INSERT [dbo].[localidades] ([cod_postal], [nombre_localidad]) VALUES (22, N'SANTA MARIA')
SET IDENTITY_INSERT [dbo].[localidades] OFF
GO
SET IDENTITY_INSERT [dbo].[marcas] ON 

INSERT [dbo].[marcas] ([id_marca], [nombre]) VALUES (1, N'Toyota')
INSERT [dbo].[marcas] ([id_marca], [nombre]) VALUES (3, N'Cadillac')
INSERT [dbo].[marcas] ([id_marca], [nombre]) VALUES (5, N'Ford')
INSERT [dbo].[marcas] ([id_marca], [nombre]) VALUES (6, N'Lincoln ')
SET IDENTITY_INSERT [dbo].[marcas] OFF
GO
SET IDENTITY_INSERT [dbo].[nombres_comerciales] ON 

INSERT [dbo].[nombres_comerciales] ([id_nombrecomercial], [nombre_comercial], [id_marca], [id_gama]) VALUES (1, N'Corolla', 1, 2)
INSERT [dbo].[nombres_comerciales] ([id_nombrecomercial], [nombre_comercial], [id_marca], [id_gama]) VALUES (3, N'Maveric', 5, 2)
INSERT [dbo].[nombres_comerciales] ([id_nombrecomercial], [nombre_comercial], [id_marca], [id_gama]) VALUES (4, N'Escalade', 3, 1)
INSERT [dbo].[nombres_comerciales] ([id_nombrecomercial], [nombre_comercial], [id_marca], [id_gama]) VALUES (5, N'Navigator', 6, 1)
INSERT [dbo].[nombres_comerciales] ([id_nombrecomercial], [nombre_comercial], [id_marca], [id_gama]) VALUES (6, N'Ka', 5, 3)
SET IDENTITY_INSERT [dbo].[nombres_comerciales] OFF
GO
SET IDENTITY_INSERT [dbo].[prioridades] ON 

INSERT [dbo].[prioridades] ([id_prioridad], [nombre_prioridad]) VALUES (1, N'Alta')
INSERT [dbo].[prioridades] ([id_prioridad], [nombre_prioridad]) VALUES (2, N'Medio')
INSERT [dbo].[prioridades] ([id_prioridad], [nombre_prioridad]) VALUES (3, N'Bajo')
SET IDENTITY_INSERT [dbo].[prioridades] OFF
GO
INSERT [dbo].[telefonos] ([nro_telefono], [nro_caracteristica], [tipo_doc_cliente], [nro_doc_cliente]) VALUES (1, 2, 1, 33232)
INSERT [dbo].[telefonos] ([nro_telefono], [nro_caracteristica], [tipo_doc_cliente], [nro_doc_cliente]) VALUES (1233, 1, 1, 22222222)
INSERT [dbo].[telefonos] ([nro_telefono], [nro_caracteristica], [tipo_doc_cliente], [nro_doc_cliente]) VALUES (123123, 1, 1, 22222222)
INSERT [dbo].[telefonos] ([nro_telefono], [nro_caracteristica], [tipo_doc_cliente], [nro_doc_cliente]) VALUES (123444, 1, 1, 121212)
INSERT [dbo].[telefonos] ([nro_telefono], [nro_caracteristica], [tipo_doc_cliente], [nro_doc_cliente]) VALUES (1222121, 2, 1, 121212)
GO
SET IDENTITY_INSERT [dbo].[tipo_caracteristica] ON 

INSERT [dbo].[tipo_caracteristica] ([id_caracteristica], [nombre_tipo]) VALUES (1, N'387')
INSERT [dbo].[tipo_caracteristica] ([id_caracteristica], [nombre_tipo]) VALUES (2, N'351')
INSERT [dbo].[tipo_caracteristica] ([id_caracteristica], [nombre_tipo]) VALUES (3, N'3492')
SET IDENTITY_INSERT [dbo].[tipo_caracteristica] OFF
GO
SET IDENTITY_INSERT [dbo].[tipo_doc_clientes] ON 

INSERT [dbo].[tipo_doc_clientes] ([id_doc_cliente], [nombre_tipo_doc]) VALUES (1, N'DNI')
INSERT [dbo].[tipo_doc_clientes] ([id_doc_cliente], [nombre_tipo_doc]) VALUES (2, N'Pasaporte')
SET IDENTITY_INSERT [dbo].[tipo_doc_clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([Id_Usuario], [nombre], [apellido], [password], [email], [legajo]) VALUES (1, N'Emilio', N'Pizarro', N'ejpc123', N'emilio@hotmail.com', 12121)
INSERT [dbo].[usuarios] ([Id_Usuario], [nombre], [apellido], [password], [email], [legajo]) VALUES (2, N'Francisco', N'Pizarro', N'pala', N'ejpc@gmail.com', 12121)
INSERT [dbo].[usuarios] ([Id_Usuario], [nombre], [apellido], [password], [email], [legajo]) VALUES (3, N'Lautaro', N'Martines', N'12', N'Lautaro@hotmail.com', 12121)
INSERT [dbo].[usuarios] ([Id_Usuario], [nombre], [apellido], [password], [email], [legajo]) VALUES (4, N'Lucas', N'Luciano', N'444', N'Lucas@hotmail.com', 12121)
INSERT [dbo].[usuarios] ([Id_Usuario], [nombre], [apellido], [password], [email], [legajo]) VALUES (5, N'Diego', N'Jimenez', N'papa', N'Diego@jimenez.com', 12121)
INSERT [dbo].[usuarios] ([Id_Usuario], [nombre], [apellido], [password], [email], [legajo]) VALUES (6, N'Insersion', N'SQL', N'jjjj', N'Insersion@hotmail.com', 12121)
INSERT [dbo].[usuarios] ([Id_Usuario], [nombre], [apellido], [password], [email], [legajo]) VALUES (9, N'Adriel', N'Coria', N'123456', N'Adriel@gmail.com', 12121)
INSERT [dbo].[usuarios] ([Id_Usuario], [nombre], [apellido], [password], [email], [legajo]) VALUES (10, N'Elias', N'Coria', N'123', N'eliascoria@gmail.com', 12121)
INSERT [dbo].[usuarios] ([Id_Usuario], [nombre], [apellido], [password], [email], [legajo]) VALUES (11, N'Paz', N'Boglione', N'12345', N'mpazCost@hmail.com', 12121)
INSERT [dbo].[usuarios] ([Id_Usuario], [nombre], [apellido], [password], [email], [legajo]) VALUES (12, N'Tomas', N'Giacobino', N'1234', N'tomas.giacobino@gmail.com', 14725)
INSERT [dbo].[usuarios] ([Id_Usuario], [nombre], [apellido], [password], [email], [legajo]) VALUES (13, N'Milagros', N'Arduino', N'123', N'mili@hotmail.com', 12121)
INSERT [dbo].[usuarios] ([Id_Usuario], [nombre], [apellido], [password], [email], [legajo]) VALUES (14, N'Luciano', N'Luciani', N'123', N'lcc@gmail.com', 12121)
INSERT [dbo].[usuarios] ([Id_Usuario], [nombre], [apellido], [password], [email], [legajo]) VALUES (18, N'Bruno', N'A', N'contra123', N'bruno@hotmail.com', 45678)
INSERT [dbo].[usuarios] ([Id_Usuario], [nombre], [apellido], [password], [email], [legajo]) VALUES (19, N'Emilio', N'Pizarro', N'123456', N'ejpc@hotmail.com', 78945)
INSERT [dbo].[usuarios] ([Id_Usuario], [nombre], [apellido], [password], [email], [legajo]) VALUES (20, N'Luis', N'Damiano', N'123456', N'luisD@gmail.com', 12121)
INSERT [dbo].[usuarios] ([Id_Usuario], [nombre], [apellido], [password], [email], [legajo]) VALUES (21, N'Emilio', N'Pizarro', N'43143270', N'emiliojpizarro@hotmail.com', 12121)
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[ventas] ON 

INSERT [dbo].[ventas] ([nro_factura], [tipo_doc_cliente], [nro_doc_cliente], [fecha], [legajo_empleado]) VALUES (18, 1, 33232, CAST(N'2022-10-26' AS Date), 12121)
INSERT [dbo].[ventas] ([nro_factura], [tipo_doc_cliente], [nro_doc_cliente], [fecha], [legajo_empleado]) VALUES (19, 1, 33232, CAST(N'2022-10-26' AS Date), 12121)
INSERT [dbo].[ventas] ([nro_factura], [tipo_doc_cliente], [nro_doc_cliente], [fecha], [legajo_empleado]) VALUES (20, 1, 33232, CAST(N'2022-10-26' AS Date), 12121)
INSERT [dbo].[ventas] ([nro_factura], [tipo_doc_cliente], [nro_doc_cliente], [fecha], [legajo_empleado]) VALUES (22, 1, 33232, CAST(N'2022-10-26' AS Date), 12121)
INSERT [dbo].[ventas] ([nro_factura], [tipo_doc_cliente], [nro_doc_cliente], [fecha], [legajo_empleado]) VALUES (23, 1, 33232, CAST(N'2022-10-27' AS Date), 12121)
INSERT [dbo].[ventas] ([nro_factura], [tipo_doc_cliente], [nro_doc_cliente], [fecha], [legajo_empleado]) VALUES (31, 1, 33232, CAST(N'2022-10-31' AS Date), 12121)
INSERT [dbo].[ventas] ([nro_factura], [tipo_doc_cliente], [nro_doc_cliente], [fecha], [legajo_empleado]) VALUES (32, 1, 33232, CAST(N'2022-10-31' AS Date), 12121)
INSERT [dbo].[ventas] ([nro_factura], [tipo_doc_cliente], [nro_doc_cliente], [fecha], [legajo_empleado]) VALUES (33, 1, 33232, CAST(N'2022-11-01' AS Date), 12121)
INSERT [dbo].[ventas] ([nro_factura], [tipo_doc_cliente], [nro_doc_cliente], [fecha], [legajo_empleado]) VALUES (34, 1, 33232, CAST(N'2022-11-01' AS Date), 12121)
INSERT [dbo].[ventas] ([nro_factura], [tipo_doc_cliente], [nro_doc_cliente], [fecha], [legajo_empleado]) VALUES (35, 1, 33232, CAST(N'2022-11-05' AS Date), 45678)
INSERT [dbo].[ventas] ([nro_factura], [tipo_doc_cliente], [nro_doc_cliente], [fecha], [legajo_empleado]) VALUES (36, 1, 33232, CAST(N'2022-11-05' AS Date), 45678)
INSERT [dbo].[ventas] ([nro_factura], [tipo_doc_cliente], [nro_doc_cliente], [fecha], [legajo_empleado]) VALUES (45, 1, 123123, CAST(N'2022-11-06' AS Date), 45678)
SET IDENTITY_INSERT [dbo].[ventas] OFF
GO
/****** Object:  Index [uc_autos_nroChasis]    Script Date: 14/11/2022 12:57:34 ******/
ALTER TABLE [dbo].[autos] ADD  CONSTRAINT [uc_autos_nroChasis] UNIQUE NONCLUSTERED 
(
	[nro_chasis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [uc_autos_nroMotor]    Script Date: 14/11/2022 12:57:34 ******/
ALTER TABLE [dbo].[autos] ADD  CONSTRAINT [uc_autos_nroMotor] UNIQUE NONCLUSTERED 
(
	[nro_motor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [uc_autos_patente]    Script Date: 14/11/2022 12:57:34 ******/
ALTER TABLE [dbo].[autos] ADD  CONSTRAINT [uc_autos_patente] UNIQUE NONCLUSTERED 
(
	[patente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[autos]  WITH CHECK ADD  CONSTRAINT [autos_condicion_fk] FOREIGN KEY([id_condicion])
REFERENCES [dbo].[condicion] ([id_condicion])
GO
ALTER TABLE [dbo].[autos] CHECK CONSTRAINT [autos_condicion_fk]
GO
ALTER TABLE [dbo].[autos]  WITH CHECK ADD  CONSTRAINT [autos_nombreComercial_fk] FOREIGN KEY([id_nombrecomercial])
REFERENCES [dbo].[nombres_comerciales] ([id_nombrecomercial])
GO
ALTER TABLE [dbo].[autos] CHECK CONSTRAINT [autos_nombreComercial_fk]
GO
ALTER TABLE [dbo].[caracteristicas]  WITH CHECK ADD  CONSTRAINT [tipo_caracteristicas_fk] FOREIGN KEY([tipo_caracteristica])
REFERENCES [dbo].[tipo_caracteristica] ([id_caracteristica])
GO
ALTER TABLE [dbo].[caracteristicas] CHECK CONSTRAINT [tipo_caracteristicas_fk]
GO
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [tipo_doc_cliente_fk] FOREIGN KEY([tipo_doc_cliente])
REFERENCES [dbo].[tipo_doc_clientes] ([id_doc_cliente])
GO
ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [tipo_doc_cliente_fk]
GO
ALTER TABLE [dbo].[detalle_caracteristicas_x_auto]  WITH CHECK ADD  CONSTRAINT [detalle_caractetisticas_x_autos_autos_fk] FOREIGN KEY([cod_serie_fabrica])
REFERENCES [dbo].[autos] ([cod_serie_fabrica])
GO
ALTER TABLE [dbo].[detalle_caracteristicas_x_auto] CHECK CONSTRAINT [detalle_caractetisticas_x_autos_autos_fk]
GO
ALTER TABLE [dbo].[detalle_caracteristicas_x_auto]  WITH CHECK ADD  CONSTRAINT [detalle_caractetisticas_x_autos_caracteristicas_fk] FOREIGN KEY([cod_caracteristica])
REFERENCES [dbo].[caracteristicas] ([cod_caracteristica])
GO
ALTER TABLE [dbo].[detalle_caracteristicas_x_auto] CHECK CONSTRAINT [detalle_caractetisticas_x_autos_caracteristicas_fk]
GO
ALTER TABLE [dbo].[detalle_encargo]  WITH CHECK ADD  CONSTRAINT [fk_cararacteristica] FOREIGN KEY([cod_caracteristica])
REFERENCES [dbo].[caracteristicas] ([cod_caracteristica])
GO
ALTER TABLE [dbo].[detalle_encargo] CHECK CONSTRAINT [fk_cararacteristica]
GO
ALTER TABLE [dbo].[detalle_encargo]  WITH CHECK ADD  CONSTRAINT [fk_encargo] FOREIGN KEY([nro_encargo])
REFERENCES [dbo].[encargo] ([nro_encargo])
GO
ALTER TABLE [dbo].[detalle_encargo] CHECK CONSTRAINT [fk_encargo]
GO
ALTER TABLE [dbo].[detalle_ventas]  WITH CHECK ADD  CONSTRAINT [detalle_ventas_autos_fk] FOREIGN KEY([cod_serie_fabrica])
REFERENCES [dbo].[autos] ([cod_serie_fabrica])
GO
ALTER TABLE [dbo].[detalle_ventas] CHECK CONSTRAINT [detalle_ventas_autos_fk]
GO
ALTER TABLE [dbo].[detalle_ventas]  WITH CHECK ADD  CONSTRAINT [detalle_ventas_ventas_fk] FOREIGN KEY([nro_factura])
REFERENCES [dbo].[ventas] ([nro_factura])
GO
ALTER TABLE [dbo].[detalle_ventas] CHECK CONSTRAINT [detalle_ventas_ventas_fk]
GO
ALTER TABLE [dbo].[empleados]  WITH CHECK ADD  CONSTRAINT [cargo_fk] FOREIGN KEY([cargo])
REFERENCES [dbo].[cargos_empleados] ([id_cargo])
GO
ALTER TABLE [dbo].[empleados] CHECK CONSTRAINT [cargo_fk]
GO
ALTER TABLE [dbo].[encargo]  WITH CHECK ADD  CONSTRAINT [fk_cliente] FOREIGN KEY([tipo_doc_cliente], [nro_doc_cliente])
REFERENCES [dbo].[clientes] ([tipo_doc_cliente], [nro_doc_cliente])
GO
ALTER TABLE [dbo].[encargo] CHECK CONSTRAINT [fk_cliente]
GO
ALTER TABLE [dbo].[encargo]  WITH CHECK ADD  CONSTRAINT [fk_legajo_empleado] FOREIGN KEY([legajo_empleado])
REFERENCES [dbo].[empleados] ([legajo_empleado])
GO
ALTER TABLE [dbo].[encargo] CHECK CONSTRAINT [fk_legajo_empleado]
GO
ALTER TABLE [dbo].[encargo]  WITH CHECK ADD  CONSTRAINT [fk_NombreComercial] FOREIGN KEY([id_nombrecomercial])
REFERENCES [dbo].[nombres_comerciales] ([id_nombrecomercial])
GO
ALTER TABLE [dbo].[encargo] CHECK CONSTRAINT [fk_NombreComercial]
GO
ALTER TABLE [dbo].[encargos]  WITH CHECK ADD  CONSTRAINT [FK__encargos__3587F3E0] FOREIGN KEY([tipo_doc_cliente], [nro_doc_cliente])
REFERENCES [dbo].[clientes] ([tipo_doc_cliente], [nro_doc_cliente])
GO
ALTER TABLE [dbo].[encargos] CHECK CONSTRAINT [FK__encargos__3587F3E0]
GO
ALTER TABLE [dbo].[encargos]  WITH CHECK ADD  CONSTRAINT [FK__encargos__legajo__37703C52] FOREIGN KEY([legajo_empleado])
REFERENCES [dbo].[empleados] ([legajo_empleado])
GO
ALTER TABLE [dbo].[encargos] CHECK CONSTRAINT [FK__encargos__legajo__37703C52]
GO
ALTER TABLE [dbo].[encargos]  WITH CHECK ADD  CONSTRAINT [fk_encargos_caracteristicas] FOREIGN KEY([cod_caracteristica])
REFERENCES [dbo].[tipo_caracteristica] ([id_caracteristica])
GO
ALTER TABLE [dbo].[encargos] CHECK CONSTRAINT [fk_encargos_caracteristicas]
GO
ALTER TABLE [dbo].[encargos]  WITH CHECK ADD  CONSTRAINT [FK_encargos_encargos] FOREIGN KEY([nro_encargo])
REFERENCES [dbo].[encargos] ([nro_encargo])
GO
ALTER TABLE [dbo].[encargos] CHECK CONSTRAINT [FK_encargos_encargos]
GO
ALTER TABLE [dbo].[encargos]  WITH CHECK ADD  CONSTRAINT [FK_encargos_nombres_comerciales] FOREIGN KEY([id_nombrecomercial])
REFERENCES [dbo].[nombres_comerciales] ([id_nombrecomercial])
GO
ALTER TABLE [dbo].[encargos] CHECK CONSTRAINT [FK_encargos_nombres_comerciales]
GO
ALTER TABLE [dbo].[encargos]  WITH CHECK ADD  CONSTRAINT [FK_encargos_prioridades] FOREIGN KEY([prioridad])
REFERENCES [dbo].[prioridades] ([id_prioridad])
GO
ALTER TABLE [dbo].[encargos] CHECK CONSTRAINT [FK_encargos_prioridades]
GO
ALTER TABLE [dbo].[encargos]  WITH CHECK ADD  CONSTRAINT [FK_encargos_tipo_doc_clientes] FOREIGN KEY([tipo_doc_cliente])
REFERENCES [dbo].[tipo_doc_clientes] ([id_doc_cliente])
GO
ALTER TABLE [dbo].[encargos] CHECK CONSTRAINT [FK_encargos_tipo_doc_clientes]
GO
ALTER TABLE [dbo].[nombres_comerciales]  WITH CHECK ADD  CONSTRAINT [id_marca_fk] FOREIGN KEY([id_marca])
REFERENCES [dbo].[marcas] ([id_marca])
GO
ALTER TABLE [dbo].[nombres_comerciales] CHECK CONSTRAINT [id_marca_fk]
GO
ALTER TABLE [dbo].[telefonos]  WITH CHECK ADD  CONSTRAINT [cliente_fk] FOREIGN KEY([tipo_doc_cliente], [nro_doc_cliente])
REFERENCES [dbo].[clientes] ([tipo_doc_cliente], [nro_doc_cliente])
GO
ALTER TABLE [dbo].[telefonos] CHECK CONSTRAINT [cliente_fk]
GO
ALTER TABLE [dbo].[telefonos]  WITH CHECK ADD  CONSTRAINT [nro_caracteristica_fk] FOREIGN KEY([nro_caracteristica])
REFERENCES [dbo].[caracteristicas_telefonicas] ([nro_caracteristica_telefonica])
GO
ALTER TABLE [dbo].[telefonos] CHECK CONSTRAINT [nro_caracteristica_fk]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [ventas_clietes_fk] FOREIGN KEY([tipo_doc_cliente], [nro_doc_cliente])
REFERENCES [dbo].[clientes] ([tipo_doc_cliente], [nro_doc_cliente])
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [ventas_clietes_fk]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [ventas_empleados_fk] FOREIGN KEY([legajo_empleado])
REFERENCES [dbo].[empleados] ([legajo_empleado])
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [ventas_empleados_fk]
GO
/****** Object:  StoredProcedure [dbo].[GetAnoFabricacion]    Script Date: 14/11/2022 12:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAnoFabricacion]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT año_fabricacion FROM autos WHERE autos.estado = 'false'
	GROUP BY autos.año_fabricacion

END
GO
/****** Object:  StoredProcedure [dbo].[GetAutosDisponibles]    Script Date: 14/11/2022 12:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAutosDisponibles]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @param INT


SELECT marcas.nombre, marcas.id_marca, 
	   nombres_comerciales.id_nombrecomercial,nombres_comerciales.nombre_comercial,
	   condicion.id_condicion, condicion.nombre_condicion,
	   gamas.id_gama, gamas.nombre_gama
	  
	FROM autos 
	INNER JOIN nombres_comerciales 
	On autos.id_nombrecomercial  = nombres_comerciales.id_nombrecomercial 
	INNER JOIN marcas on nombres_comerciales.id_marca = marcas.id_marca
	INNER JOIN gamas on nombres_comerciales.id_gama = gamas.id_gama
	INNER JOIN condicion on autos.id_condicion = condicion.id_condicion
	
	WHERE marcas.id_marca = @param and autos.estado = 'false'
	
	GROUP BY marcas.nombre, marcas.id_marca, 
			 nombres_comerciales.nombre_comercial, nombres_comerciales.id_nombrecomercial, 
			 gamas.id_gama, gamas.nombre_gama, 
			 condicion.id_condicion, condicion.nombre_condicion


END
GO
/****** Object:  StoredProcedure [dbo].[GetCondiciones]    Script Date: 14/11/2022 12:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetCondiciones]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		SELECT condicion.id_condicion, condicion.nombre_condicion
		FROM autos INNER JOIN condicion 
			On autos.id_condicion = condicion.id_condicion
		WHERE autos.estado = 'false'
		   
		GROUP BY condicion.id_condicion, condicion.nombre_condicion


END
GO
/****** Object:  StoredProcedure [dbo].[GetGamas]    Script Date: 14/11/2022 12:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetGamas]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		SELECT gamas.id_gama, gamas.nombre_gama
		FROM autos INNER JOIN nombres_comerciales
			On autos.id_nombrecomercial = nombres_comerciales.id_nombrecomercial
			INNER JOIN gamas ON nombres_comerciales.id_gama = gamas.id_gama
			
		WHERE autos.estado = 'false'
		   
		GROUP BY gamas.id_gama, gamas.nombre_gama

		   

	



END
GO
/****** Object:  StoredProcedure [dbo].[GetNombres]    Script Date: 14/11/2022 12:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetNombres]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT marcas.nombre, marcas.id_marca
	FROM autos INNER JOIN nombres_comerciales 
	On autos.id_nombrecomercial = nombres_comerciales.id_nombrecomercial
	INNER JOIN marcas on nombres_comerciales.id_marca = marcas.id_marca
	WHERE autos.estado = 'false'
	GROUP BY marcas.nombre, marcas.id_marca

END
GO
/****** Object:  StoredProcedure [dbo].[GetNombresComerciales]    Script Date: 14/11/2022 12:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetNombresComerciales]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT nombres_comerciales.nombre_comercial, nombres_comerciales.id_nombrecomercial
			FROM autos INNER JOIN nombres_comerciales 
			On autos.id_nombrecomercial = nombres_comerciales.id_nombrecomercial
			WHERE autos.estado = 'false'
		   
			GROUP BY nombres_comerciales.nombre_comercial, nombres_comerciales.id_nombrecomercial


END
GO
USE [master]
GO
ALTER DATABASE [BD3K3G03_2022] SET  READ_WRITE 
GO
