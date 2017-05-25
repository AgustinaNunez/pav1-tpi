USE [master]
GO
/****** Object:  Database [BD_CLOTTA]    Script Date: 25/05/2017 3:21:56 ******/
CREATE DATABASE [BD_CLOTTA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD_CLOTTA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BD_CLOTTA.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BD_CLOTTA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BD_CLOTTA_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BD_CLOTTA] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_CLOTTA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD_CLOTTA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD_CLOTTA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD_CLOTTA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD_CLOTTA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD_CLOTTA] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD_CLOTTA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD_CLOTTA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD_CLOTTA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD_CLOTTA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD_CLOTTA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD_CLOTTA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD_CLOTTA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD_CLOTTA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD_CLOTTA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD_CLOTTA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BD_CLOTTA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD_CLOTTA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD_CLOTTA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD_CLOTTA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD_CLOTTA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD_CLOTTA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD_CLOTTA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD_CLOTTA] SET RECOVERY FULL 
GO
ALTER DATABASE [BD_CLOTTA] SET  MULTI_USER 
GO
ALTER DATABASE [BD_CLOTTA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD_CLOTTA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD_CLOTTA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD_CLOTTA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BD_CLOTTA] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BD_CLOTTA]
GO
/****** Object:  Table [dbo].[bancos]    Script Date: 25/05/2017 3:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bancos](
	[id_banco] [int] NOT NULL,
	[nombre] [varchar](30) NULL,
	[telefono] [int] NULL,
 CONSTRAINT [pk_bancos] PRIMARY KEY CLUSTERED 
(
	[id_banco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[clientes]    Script Date: 25/05/2017 3:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[numero_documento] [varchar](20) NOT NULL,
	[tipo_documento] [int] NOT NULL,
	[nombre_cliente] [varchar](30) NULL,
	[apellido_cliente] [varchar](30) NULL,
	[telefono_cliente] [numeric](18, 0) NULL,
	[e_mail_cliente] [varchar](90) NULL,
 CONSTRAINT [pk_clientes] PRIMARY KEY CLUSTERED 
(
	[numero_documento] ASC,
	[tipo_documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[compras]    Script Date: 25/05/2017 3:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compras](
	[id_compra] [int] NOT NULL,
	[fecha_compra] [varchar](90) NULL,
	[hora_compra] [varchar](90) NULL,
	[monto] [float] NULL,
 CONSTRAINT [pk_compras] PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[cupon]    Script Date: 25/05/2017 3:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cupon](
	[id_cupon] [int] NOT NULL,
	[numero_lote] [int] NULL,
	[numero_autorizacion_online] [int] NULL,
	[precio] [float] NULL,
 CONSTRAINT [pk_cupon] PRIMARY KEY CLUSTERED 
(
	[id_cupon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[detalle_ventas]    Script Date: 25/05/2017 3:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_ventas](
	[id_venta] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[cantidad] [int] NULL,
	[precio_unitario] [float] NULL,
 CONSTRAINT [pk_detalle_ventas] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC,
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[detalles_compras]    Script Date: 25/05/2017 3:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalles_compras](
	[id_compra] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[cantidad] [int] NULL,
	[precio_unitario] [float] NULL,
 CONSTRAINT [pk_detalles_compras] PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC,
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[entidades_crediticias]    Script Date: 25/05/2017 3:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[entidades_crediticias](
	[id_entidad_crediticia] [int] NOT NULL,
	[nombre] [varchar](30) NULL,
	[telefono] [int] NULL,
 CONSTRAINT [pk_entdidad_crediticia] PRIMARY KEY CLUSTERED 
(
	[id_entidad_crediticia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[fabricas]    Script Date: 25/05/2017 3:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fabricas](
	[id_fabrica] [int] NOT NULL,
	[nombre] [varchar](30) NULL,
	[telefono] [varchar](30) NULL,
 CONSTRAINT [pk_fabricas] PRIMARY KEY CLUSTERED 
(
	[id_fabrica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[formas_pago]    Script Date: 25/05/2017 3:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[formas_pago](
	[id_forma_pago] [int] NOT NULL,
	[nombre] [varchar](20) NULL,
	[porcentaje] [float] NULL,
 CONSTRAINT [pk_formas_pago] PRIMARY KEY CLUSTERED 
(
	[id_forma_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[productos]    Script Date: 25/05/2017 3:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[id_producto] [int] NOT NULL,
	[descripcion] [varchar](100) NULL,
	[stock] [int] NULL,
	[precio_lista] [float] NULL,
	[id_rubro] [int] NULL,
	[id_fabrica] [int] NULL,
	[dado_de_baja] [bit] NULL,
 CONSTRAINT [pk_productos] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[rubros]    Script Date: 25/05/2017 3:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rubros](
	[id_rubro] [int] NOT NULL,
	[nombre] [varchar](30) NULL,
 CONSTRAINT [pk_rubros] PRIMARY KEY CLUSTERED 
(
	[id_rubro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipo_documento]    Script Date: 25/05/2017 3:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_documento](
	[id_tipo_documento] [int] NOT NULL,
	[nombre_tipo_documento] [varchar](10) NULL,
 CONSTRAINT [pk_tipo_documento] PRIMARY KEY CLUSTERED 
(
	[id_tipo_documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 25/05/2017 3:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_usuario] [varchar](30) NOT NULL,
	[nombre] [varchar](30) NULL,
	[apellido] [varchar](30) NULL,
	[contraseña] [varchar](10) NULL,
	[fecha_alta] [date] NULL,
 CONSTRAINT [pk_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ventas]    Script Date: 25/05/2017 3:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventas](
	[id_venta] [int] NOT NULL,
	[fecha_venta] [varchar](90) NULL,
	[hora_venta] [varchar](90) NULL,
	[id_usuario] [varchar](30) NULL,
	[numero_documento_cliente] [varchar](20) NULL,
	[tipo_documento_cliente] [int] NULL,
 CONSTRAINT [pk_ventas] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ventasXformas_pago]    Script Date: 25/05/2017 3:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventasXformas_pago](
	[id_venta] [int] NOT NULL,
	[id_forma_pago] [int] NOT NULL,
	[monto_vxfp] [float] NULL,
	[id_cupon] [int] NULL,
	[id_banco] [int] NULL,
	[id_entidad_crediticia] [int] NULL,
 CONSTRAINT [pk_ventas_forma_pago] PRIMARY KEY CLUSTERED 
(
	[id_forma_pago] ASC,
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [fk_tipo_doc] FOREIGN KEY([tipo_documento])
REFERENCES [dbo].[tipo_documento] ([id_tipo_documento])
GO
ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [fk_tipo_doc]
GO
ALTER TABLE [dbo].[detalle_ventas]  WITH CHECK ADD  CONSTRAINT [fk_producto_ventas] FOREIGN KEY([id_producto])
REFERENCES [dbo].[productos] ([id_producto])
GO
ALTER TABLE [dbo].[detalle_ventas] CHECK CONSTRAINT [fk_producto_ventas]
GO
ALTER TABLE [dbo].[detalle_ventas]  WITH CHECK ADD  CONSTRAINT [fk_venta] FOREIGN KEY([id_venta])
REFERENCES [dbo].[ventas] ([id_venta])
GO
ALTER TABLE [dbo].[detalle_ventas] CHECK CONSTRAINT [fk_venta]
GO
ALTER TABLE [dbo].[detalles_compras]  WITH CHECK ADD  CONSTRAINT [fk_compra] FOREIGN KEY([id_compra])
REFERENCES [dbo].[compras] ([id_compra])
GO
ALTER TABLE [dbo].[detalles_compras] CHECK CONSTRAINT [fk_compra]
GO
ALTER TABLE [dbo].[detalles_compras]  WITH CHECK ADD  CONSTRAINT [fk_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[productos] ([id_producto])
GO
ALTER TABLE [dbo].[detalles_compras] CHECK CONSTRAINT [fk_producto]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [fk_farbrica] FOREIGN KEY([id_fabrica])
REFERENCES [dbo].[fabricas] ([id_fabrica])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [fk_farbrica]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [fk_rubro] FOREIGN KEY([id_rubro])
REFERENCES [dbo].[rubros] ([id_rubro])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [fk_rubro]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [fk_cliente_venta] FOREIGN KEY([numero_documento_cliente], [tipo_documento_cliente])
REFERENCES [dbo].[clientes] ([numero_documento], [tipo_documento])
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [fk_cliente_venta]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [fk_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [fk_usuario]
GO
ALTER TABLE [dbo].[ventasXformas_pago]  WITH CHECK ADD  CONSTRAINT [fk_banco] FOREIGN KEY([id_banco])
REFERENCES [dbo].[bancos] ([id_banco])
GO
ALTER TABLE [dbo].[ventasXformas_pago] CHECK CONSTRAINT [fk_banco]
GO
ALTER TABLE [dbo].[ventasXformas_pago]  WITH CHECK ADD  CONSTRAINT [fk_cupon] FOREIGN KEY([id_cupon])
REFERENCES [dbo].[cupon] ([id_cupon])
GO
ALTER TABLE [dbo].[ventasXformas_pago] CHECK CONSTRAINT [fk_cupon]
GO
ALTER TABLE [dbo].[ventasXformas_pago]  WITH CHECK ADD  CONSTRAINT [fk_entidad] FOREIGN KEY([id_entidad_crediticia])
REFERENCES [dbo].[entidades_crediticias] ([id_entidad_crediticia])
GO
ALTER TABLE [dbo].[ventasXformas_pago] CHECK CONSTRAINT [fk_entidad]
GO
ALTER TABLE [dbo].[ventasXformas_pago]  WITH CHECK ADD  CONSTRAINT [fk_forma_pago_fp] FOREIGN KEY([id_forma_pago])
REFERENCES [dbo].[formas_pago] ([id_forma_pago])
GO
ALTER TABLE [dbo].[ventasXformas_pago] CHECK CONSTRAINT [fk_forma_pago_fp]
GO
ALTER TABLE [dbo].[ventasXformas_pago]  WITH CHECK ADD  CONSTRAINT [fk_venta_fp] FOREIGN KEY([id_venta])
REFERENCES [dbo].[ventas] ([id_venta])
GO
ALTER TABLE [dbo].[ventasXformas_pago] CHECK CONSTRAINT [fk_venta_fp]
GO
/****** Object:  StoredProcedure [dbo].[AUTOGENERARCODIGO]    Script Date: 25/05/2017 3:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AUTOGENERARCODIGO] (@CODIGO CHAR(10) OUTPUT)
AS
IF (SELECT COUNT(*) FROM fabricas)= 0
SET @CODIGO = '0'
ELSE
SET
@CODIGO = (SELECT MAX(id_fabrica) FROM fabricas) + 1
GO
/****** Object:  StoredProcedure [dbo].[AUTOGENERARCODIGO_compras]    Script Date: 25/05/2017 3:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AUTOGENERARCODIGO_compras] (@CODIGO CHAR(10) OUTPUT)
AS
IF (SELECT COUNT(*) FROM compras)= 0
SET @CODIGO = '0'
ELSE
SET
@CODIGO = (SELECT MAX(id_compra) FROM compras) + 1
GO
/****** Object:  StoredProcedure [dbo].[AUTOGENERARCODIGO_productos]    Script Date: 25/05/2017 3:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AUTOGENERARCODIGO_productos] (@CODIGO CHAR(10) OUTPUT)
AS
IF (SELECT COUNT(*) FROM productos)= 0
SET @CODIGO = '0'
ELSE
SET
@CODIGO = (SELECT MAX(id_producto) FROM productos) + 1
GO
/****** Object:  StoredProcedure [dbo].[AUTOGENERARCODIGO_ventas]    Script Date: 25/05/2017 3:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AUTOGENERARCODIGO_ventas] (@CODIGO CHAR(10) OUTPUT)
AS
IF (SELECT COUNT(*) FROM ventas)= 0
SET @CODIGO = '0'
ELSE
SET
@CODIGO = (SELECT MAX(id_venta) FROM ventas) + 1

GO
USE [master]
GO
ALTER DATABASE [BD_CLOTTA] SET  READ_WRITE 
GO
