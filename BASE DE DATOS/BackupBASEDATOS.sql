USE [Jardin]
GO
/****** Object:  User [Admin]    Script Date: 9/03/2020 9:22:14 p. m. ******/
CREATE USER [Admin] FOR LOGIN [Admin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Admininistrador]    Script Date: 9/03/2020 9:22:14 p. m. ******/
CREATE USER [Admininistrador] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[estados]    Script Date: 9/03/2020 9:22:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estados](
	[id] [nchar](10) NOT NULL,
	[estado] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_estados] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[perfiles]    Script Date: 9/03/2020 9:22:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[perfiles](
	[id] [nchar](10) NOT NULL,
	[tipoPerfil] [nchar](10) NOT NULL,
 CONSTRAINT [PK_perfiles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuariosLogin]    Script Date: 9/03/2020 9:22:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuariosLogin](
	[id] [int] NOT NULL,
	[nombreUsuario] [nvarchar](20) NOT NULL,
	[contrasena] [nvarchar](20) NOT NULL,
	[perfil] [nchar](10) NOT NULL,
	[estado] [nchar](10) NOT NULL,
 CONSTRAINT [PK_usuariosLogin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[estados] ([id], [estado]) VALUES (N'0         ', N'Inactivo')
GO
INSERT [dbo].[estados] ([id], [estado]) VALUES (N'1         ', N'Activo')
GO
INSERT [dbo].[perfiles] ([id], [tipoPerfil]) VALUES (N'1         ', N'Admin     ')
GO
INSERT [dbo].[perfiles] ([id], [tipoPerfil]) VALUES (N'2         ', N'Docente   ')
GO
INSERT [dbo].[perfiles] ([id], [tipoPerfil]) VALUES (N'3         ', N'Secretaria')
GO
INSERT [dbo].[usuariosLogin] ([id], [nombreUsuario], [contrasena], [perfil], [estado]) VALUES (2, N'danielAdmin', N'123456789', N'1         ', N'0         ')
GO
INSERT [dbo].[usuariosLogin] ([id], [nombreUsuario], [contrasena], [perfil], [estado]) VALUES (3, N'danielDocente', N'123456789', N'2         ', N'1         ')
GO
INSERT [dbo].[usuariosLogin] ([id], [nombreUsuario], [contrasena], [perfil], [estado]) VALUES (4, N'danielSecretario', N'123456789', N'3         ', N'1         ')
GO
ALTER TABLE [dbo].[perfiles]  WITH CHECK ADD  CONSTRAINT [FK_perfiles_perfiles] FOREIGN KEY([id])
REFERENCES [dbo].[perfiles] ([id])
GO
ALTER TABLE [dbo].[perfiles] CHECK CONSTRAINT [FK_perfiles_perfiles]
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultarUsuarioPorNombreUsuario]    Script Date: 9/03/2020 9:22:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ConsultarUsuarioPorNombreUsuario]
(
@nomUsuario varchar(30)
)
AS
BEGIN
SELECT nombreUsuario,contrasena,perfil,estado
FROM Jardin.dbo.usuariosLogin
WHERE nombreUsuario = @nomUsuario
END
GO
