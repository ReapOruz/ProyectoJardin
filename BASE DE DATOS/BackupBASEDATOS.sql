USE [Jardin]
GO
/****** Object:  User [Admin]    Script Date: 8/03/2020 7:59:47 p. m. ******/
CREATE USER [Admin] FOR LOGIN [Admin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Admininistrador]    Script Date: 8/03/2020 7:59:47 p. m. ******/
CREATE USER [Admininistrador] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 8/03/2020 7:59:47 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[usuario] [nvarchar](20) NOT NULL,
	[contrasena] [nvarchar](20) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[usuarios] ([usuario], [contrasena]) VALUES (N'daniel1', N'123456')
GO
INSERT [dbo].[usuarios] ([usuario], [contrasena]) VALUES (N'prueba2', N'34566677')
GO
/****** Object:  StoredProcedure [dbo].[sp_ConsultarUsuarioPorNombreUsuario]    Script Date: 8/03/2020 7:59:48 p. m. ******/
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
SELECT usuario,contrasena
FROM Jardin.dbo.usuarios
WHERE usuario = @nomUsuario
END
GO
