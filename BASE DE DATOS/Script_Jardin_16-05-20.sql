USE [master]
GO
/****** Object:  Database [Jardin]    Script Date: 16/05/2020 11:20:30 p. m. ******/
CREATE DATABASE [Jardin]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Jardin', FILENAME = N'D:\Sql Server Express\MSSQL15.SQLEXPRESS\MSSQL\DATA\Jardin.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Jardin_log', FILENAME = N'D:\Sql Server Express\MSSQL15.SQLEXPRESS\MSSQL\DATA\Jardin_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Jardin] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Jardin].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Jardin] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Jardin] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Jardin] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Jardin] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Jardin] SET ARITHABORT OFF 
GO
ALTER DATABASE [Jardin] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Jardin] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Jardin] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Jardin] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Jardin] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Jardin] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Jardin] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Jardin] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Jardin] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Jardin] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Jardin] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Jardin] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Jardin] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Jardin] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Jardin] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Jardin] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Jardin] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Jardin] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Jardin] SET  MULTI_USER 
GO
ALTER DATABASE [Jardin] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Jardin] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Jardin] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Jardin] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Jardin] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Jardin] SET QUERY_STORE = OFF
GO
USE [Jardin]
GO
/****** Object:  User [Admininistrador]    Script Date: 16/05/2020 11:20:30 p. m. ******/
CREATE USER [Admininistrador] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Admin]    Script Date: 16/05/2020 11:20:30 p. m. ******/
CREATE USER [Admin] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[areas]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[areas](
	[id_area] [int] IDENTITY(1,1) NOT NULL,
	[nombre_area] [nchar](60) NOT NULL,
 CONSTRAINT [PK_areas] PRIMARY KEY CLUSTERED 
(
	[id_area] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bloques]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bloques](
	[id_bloque] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_bloque] [varchar](50) NOT NULL,
 CONSTRAINT [PK_bloques] PRIMARY KEY CLUSTERED 
(
	[id_bloque] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[conceptos_pago]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[conceptos_pago](
	[id_concepto_pago] [int] IDENTITY(1,1) NOT NULL,
	[concepto] [nchar](30) NOT NULL,
	[valor_pagar] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_conceptos_pago] PRIMARY KEY CLUSTERED 
(
	[id_concepto_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dias]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dias](
	[id_dia] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nchar](50) NOT NULL,
 CONSTRAINT [PK_dias] PRIMARY KEY CLUSTERED 
(
	[id_dia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estado_usuario]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estado_usuario](
	[id_estado] [int] NOT NULL,
	[descripcion_estado] [nchar](30) NOT NULL,
 CONSTRAINT [PK_estado_usuario] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estados_pago]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estados_pago](
	[id_estado_pago] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_pago] [nchar](20) NOT NULL,
 CONSTRAINT [PK_estados_pago] PRIMARY KEY CLUSTERED 
(
	[id_estado_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estudiantes]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estudiantes](
	[id_alumno] [int] IDENTITY(1,1) NOT NULL,
	[documento] [nchar](50) NOT NULL,
	[nombres] [nchar](50) NOT NULL,
	[apellidos] [nchar](50) NOT NULL,
	[fecha_nacimiento] [nchar](50) NOT NULL,
	[acudiente] [nchar](50) NOT NULL,
	[direccion] [nchar](50) NOT NULL,
	[telefono] [nchar](50) NOT NULL,
	[correo] [nchar](50) NOT NULL,
	[observacion] [nchar](50) NOT NULL,
	[ocupacion_acudiente] [nchar](50) NOT NULL,
	[fecha_creacion] [datetime] NOT NULL,
	[fecha_modificacion] [datetime] NOT NULL,
	[grupo_id] [int] NULL,
 CONSTRAINT [PK_estudiantes] PRIMARY KEY CLUSTERED 
(
	[id_alumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[grados]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grados](
	[id_grado] [int] IDENTITY(1,1) NOT NULL,
	[nombre_grado] [nchar](30) NOT NULL,
	[cantidad_grupos] [int] NULL,
 CONSTRAINT [PK_grados] PRIMARY KEY CLUSTERED 
(
	[id_grado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[grupos]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grupos](
	[id_grupo] [int] IDENTITY(1,1) NOT NULL,
	[nombre_grupo] [nchar](30) NOT NULL,
	[id_grado] [int] NOT NULL,
	[cantidad_alumnos] [int] NOT NULL,
	[fecha_modificacion] [datetime] NULL,
	[fecha_creacion] [datetime] NULL,
	[id_docente] [int] NULL,
	[id_salon] [int] NULL,
 CONSTRAINT [PK_grupos] PRIMARY KEY CLUSTERED 
(
	[id_grupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[horario]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[horario](
	[id_horario] [int] IDENTITY(1,1) NOT NULL,
	[id_bloque] [int] NOT NULL,
	[id_materia] [int] NOT NULL,
	[id_grupo] [int] NOT NULL,
	[id_dia] [int] NULL,
 CONSTRAINT [PK_horario] PRIMARY KEY CLUSTERED 
(
	[id_horario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login_usuario]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login_usuario](
	[id_login] [int] IDENTITY(1,1) NOT NULL,
	[login] [nchar](30) NOT NULL,
	[password] [nchar](30) NOT NULL,
	[perfil] [int] NOT NULL,
	[estado] [int] NOT NULL,
	[pk_id_usuario] [int] NOT NULL,
	[fecha_creacion] [date] NULL,
	[fecha_modificacion] [date] NULL,
 CONSTRAINT [PK_login_usuario] PRIMARY KEY CLUSTERED 
(
	[id_login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[materias]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materias](
	[id_materia] [int] IDENTITY(1,1) NOT NULL,
	[nombre_materia] [nchar](30) NOT NULL,
	[id_area] [int] NOT NULL,
	[carga_horaria] [int] NOT NULL,
 CONSTRAINT [PK_materias] PRIMARY KEY CLUSTERED 
(
	[id_materia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[notas]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[notas](
	[id_nota] [int] IDENTITY(1,1) NOT NULL,
	[id_alumno] [int] NOT NULL,
	[id_materia] [int] NOT NULL,
	[periodo] [nchar](30) NOT NULL,
	[nota] [decimal](4, 1) NOT NULL,
	[valoracion] [nchar](30) NOT NULL,
 CONSTRAINT [PK_notas] PRIMARY KEY CLUSTERED 
(
	[id_nota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pagos]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pagos](
	[id_pago] [int] IDENTITY(1,1) NOT NULL,
	[abono] [decimal](18, 0) NOT NULL,
	[saldo_pendiente] [decimal](18, 0) NOT NULL,
	[id_concepto_pago] [int] NOT NULL,
	[anioPago] [nchar](10) NULL,
	[mesPago] [nchar](30) NULL,
	[id_estado_pago] [int] NULL,
	[fecha_creacion] [datetime] NULL,
	[fecha_modificacion] [datetime] NULL,
	[id_estudiante] [int] NOT NULL,
 CONSTRAINT [PK_pagos] PRIMARY KEY CLUSTERED 
(
	[id_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[perfiles_usuario]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[perfiles_usuario](
	[id_perfil] [int] NOT NULL,
	[descripcion_perfil] [nchar](30) NOT NULL,
 CONSTRAINT [PK_perfiles_usuario] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[periodo]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[periodo](
	[id_periodo] [int] IDENTITY(1,1) NOT NULL,
	[anio] [nchar](20) NOT NULL,
	[numero_periodo] [nchar](20) NOT NULL,
	[estado] [int] NOT NULL,
 CONSTRAINT [PK_periodo] PRIMARY KEY CLUSTERED 
(
	[id_periodo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[salones]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salones](
	[id_salon] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nchar](30) NOT NULL,
 CONSTRAINT [PK_salones] PRIMARY KEY CLUSTERED 
(
	[id_salon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[documento] [nchar](30) NOT NULL,
	[nombres] [nchar](50) NOT NULL,
	[apellidos] [nchar](50) NOT NULL,
	[direccion] [nchar](50) NOT NULL,
	[telefono] [nchar](30) NOT NULL,
	[correo] [nchar](50) NOT NULL,
	[observacion] [nchar](50) NOT NULL,
	[fecha_creacion] [date] NULL,
	[fecha_modificacion] [date] NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[estados_pago]  WITH CHECK ADD  CONSTRAINT [FK_estados_pago_estados_pago] FOREIGN KEY([id_estado_pago])
REFERENCES [dbo].[estados_pago] ([id_estado_pago])
GO
ALTER TABLE [dbo].[estados_pago] CHECK CONSTRAINT [FK_estados_pago_estados_pago]
GO
ALTER TABLE [dbo].[estudiantes]  WITH CHECK ADD  CONSTRAINT [FK_estudiantes_grupos] FOREIGN KEY([grupo_id])
REFERENCES [dbo].[grupos] ([id_grupo])
GO
ALTER TABLE [dbo].[estudiantes] CHECK CONSTRAINT [FK_estudiantes_grupos]
GO
ALTER TABLE [dbo].[grupos]  WITH CHECK ADD  CONSTRAINT [FK_grupos_grados] FOREIGN KEY([id_grado])
REFERENCES [dbo].[grados] ([id_grado])
GO
ALTER TABLE [dbo].[grupos] CHECK CONSTRAINT [FK_grupos_grados]
GO
ALTER TABLE [dbo].[login_usuario]  WITH CHECK ADD  CONSTRAINT [FK_login_usuario_estado_usuario] FOREIGN KEY([estado])
REFERENCES [dbo].[estado_usuario] ([id_estado])
GO
ALTER TABLE [dbo].[login_usuario] CHECK CONSTRAINT [FK_login_usuario_estado_usuario]
GO
ALTER TABLE [dbo].[login_usuario]  WITH CHECK ADD  CONSTRAINT [FK_login_usuario_perfiles_usuario] FOREIGN KEY([perfil])
REFERENCES [dbo].[perfiles_usuario] ([id_perfil])
GO
ALTER TABLE [dbo].[login_usuario] CHECK CONSTRAINT [FK_login_usuario_perfiles_usuario]
GO
ALTER TABLE [dbo].[login_usuario]  WITH CHECK ADD  CONSTRAINT [FK_login_usuario_usuarios] FOREIGN KEY([pk_id_usuario])
REFERENCES [dbo].[usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[login_usuario] CHECK CONSTRAINT [FK_login_usuario_usuarios]
GO
ALTER TABLE [dbo].[materias]  WITH CHECK ADD  CONSTRAINT [FK_materias_areas] FOREIGN KEY([id_area])
REFERENCES [dbo].[areas] ([id_area])
GO
ALTER TABLE [dbo].[materias] CHECK CONSTRAINT [FK_materias_areas]
GO
ALTER TABLE [dbo].[pagos]  WITH CHECK ADD  CONSTRAINT [FK_pagos_conceptos_pago] FOREIGN KEY([id_concepto_pago])
REFERENCES [dbo].[conceptos_pago] ([id_concepto_pago])
GO
ALTER TABLE [dbo].[pagos] CHECK CONSTRAINT [FK_pagos_conceptos_pago]
GO
ALTER TABLE [dbo].[pagos]  WITH CHECK ADD  CONSTRAINT [FK_pagos_estados_pago] FOREIGN KEY([id_estado_pago])
REFERENCES [dbo].[estados_pago] ([id_estado_pago])
GO
ALTER TABLE [dbo].[pagos] CHECK CONSTRAINT [FK_pagos_estados_pago]
GO
ALTER TABLE [dbo].[pagos]  WITH CHECK ADD  CONSTRAINT [FK_pagos_estudiantes] FOREIGN KEY([id_estudiante])
REFERENCES [dbo].[estudiantes] ([id_alumno])
GO
ALTER TABLE [dbo].[pagos] CHECK CONSTRAINT [FK_pagos_estudiantes]
GO
/****** Object:  StoredProcedure [dbo].[pa_actualizarEstudiante]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_actualizarEstudiante]

@id INT,
@documento VARCHAR(50),
@nombres VARCHAR(50),
@apellidos VARCHAR(50),
@fechaNacimiento VARCHAR(50),
@acudiente VARCHAR(50),
@direccion VARCHAR(50),
@telefono VARCHAR(50),
@mail VARCHAR(50),
@observacion VARCHAR(50), 
@ocupacionAcudiente VARCHAR(50)

AS

BEGIN

UPDATE estudiantes
SET documento = @documento,nombres=@nombres,apellidos=@apellidos,fecha_nacimiento=@fechaNacimiento,
	acudiente=@acudiente,direccion=@direccion,telefono=@telefono,correo=@mail,
	observacion=@observacion,ocupacion_acudiente=@ocupacionAcudiente,fecha_modificacion=SYSDATETIME()
WHERE id_alumno = @id

END
GO
/****** Object:  StoredProcedure [dbo].[pa_actualizarUsuario]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_actualizarUsuario]

@id_usuario INT,
@documento VARCHAR(30),
@nombres VARCHAR(50),
@apellidos VARCHAR(50),
@direccion VARCHAR(50),
@telefono VARCHAR(50),
@mail VARCHAR(50),
@observacion VARCHAR(50),
@loginUser VARCHAR(30),
@password VARCHAR(30),
@perfil INT,
@estado INT

AS

DECLARE

@id_login_usuario INT

BEGIN

UPDATE usuarios
SET documento = @documento,nombres=@nombres,apellidos=@apellidos,
	direccion=@direccion,telefono=@telefono,correo=@mail,observacion=@observacion
WHERE id_usuario = @id_usuario 

SELECT @id_login_usuario = lu.pk_id_usuario 
FROM login_usuario AS lu
	RIGHT JOIN usuarios AS u
		ON lu.pk_id_usuario = u.id_usuario
WHERE lu.pk_id_usuario = @id_usuario 

UPDATE login_usuario
SET login = @loginUser,password=@password,perfil=@perfil,estado=@estado
WHERE id_login = @id_login_usuario

END
GO
/****** Object:  StoredProcedure [dbo].[pa_asignarGrupoEstudiante]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_asignarGrupoEstudiante]

@id INT,
@grupo INT

AS

BEGIN

UPDATE estudiantes
SET grupo_id = @grupo,
	fecha_modificacion = SYSDATETIME()
WHERE id_alumno = @id

END 
GO
/****** Object:  StoredProcedure [dbo].[pa_buscarDocenteEngrupo]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_buscarDocenteEngrupo]

@id_docente INT

AS

BEGIN

SELECT id_docente
FROM grupos
WHERE id_docente = @id_docente

END
GO
/****** Object:  StoredProcedure [dbo].[pa_buscarSalonEngrupo]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_buscarSalonEngrupo]

@id_salon INT

AS

BEGIN

SELECT id_salon
FROM grupos
WHERE id_salon = @id_salon

END
GO
/****** Object:  StoredProcedure [dbo].[pa_consultaGrupoPorNombre]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_consultaGrupoPorNombre]

@nombreGrupo VARCHAR(50)

AS

BEGIN 

SELECT nombre_grupo,cantidad_alumnos,id_grado,id_docente,id_salon
FROM grupos
WHERE nombre_grupo = @nombreGrupo

END
GO
/****** Object:  StoredProcedure [dbo].[pa_consultarDocentes]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_consultarDocentes]

AS

BEGIN


SELECT u.id_usuario, u.nombres, u.apellidos
FROM usuarios AS u
RIGHT JOIN login_usuario AS lu
 ON u.id_usuario = lu.pk_id_usuario
WHERE lu.perfil = 2


END
GO
/****** Object:  StoredProcedure [dbo].[pa_consultarEstudianteGrupo]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_consultarEstudianteGrupo]

@documento VARCHAR(50)

AS

BEGIN

SELECT es.id_alumno,es.documento,es.nombres,es.apellidos,g.nombre_grupo
FROM estudiantes AS es
INNER JOIN grupos AS g
	ON es.grupo_id = g.id_grupo
WHERE es.documento = @documento

END
GO
/****** Object:  StoredProcedure [dbo].[pa_consultarEstudiantePago]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_consultarEstudiantePago]

@documento VARCHAR(50)

AS

BEGIN

SELECT es.documento,es.nombres,es.apellidos
FROM estudiantes AS es
WHERE es.documento = @documento
 
END 
GO
/****** Object:  StoredProcedure [dbo].[pa_consultarLoginUsuario]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_consultarLoginUsuario]
    @nomUsuario varchar(30)
AS   

SELECT login,password,perfil,estado
FROM Jardin.dbo.login_usuario
WHERE login = @nomUsuario 
GO
/****** Object:  StoredProcedure [dbo].[pa_consultarUsuario]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_consultarUsuario]

@docUsuario varchar(30)

AS

BEGIN 

SELECT  u.id_usuario,
		u.documento,
		u.nombres,
		u.apellidos,
		u.direccion,
		u.telefono,
		u.correo,
		u.observacion,
		lu.login,
		lu.password,
		lu.perfil,
		lu.estado

FROM usuarios u
JOIN login_usuario lu
	ON u.id_usuario = lu.pk_id_usuario
WHERE u.documento = @docUsuario

END

GO
/****** Object:  StoredProcedure [dbo].[pa_contarBloquesPorMateriaDia]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pa_contarBloquesPorMateriaDia]

@idMateria INT,
@idGrupo INT,
@idDia INT

AS 

BEGIN

SELECT COUNT(id_bloque) AS total_bloques_dia
FROM horario
WHERE id_materia = @idMateria AND id_grupo = @idGrupo AND id_dia=@idDia

END
GO
/****** Object:  StoredProcedure [dbo].[pa_contarBloquesPorMateriaSemana]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pa_contarBloquesPorMateriaSemana]

@idMateria INT,
@idGrupo INT

AS 

BEGIN

SELECT COUNT(id_bloque) AS total_bloques_semana
FROM horario
WHERE id_materia = @idMateria AND id_grupo = @idGrupo

END
GO
/****** Object:  StoredProcedure [dbo].[pa_contarEstuiantesGrupo]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_contarEstuiantesGrupo]

@grupo int

AS

BEGIN

SELECT count(grupo_id) AS totalGrupo
FROM estudiantes
WHERE grupo_id = @grupo

END 
GO
/****** Object:  StoredProcedure [dbo].[pa_contarGruposPorGrado]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_contarGruposPorGrado]

@id_grado INT

AS

BEGIN 

SELECT COUNT(id_grado) AS totalGrupo
FROM grupos
WHERE id_grado = @id_grado

END

GO
/****** Object:  StoredProcedure [dbo].[pa_insertarEstudiante]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_insertarEstudiante]

@documento VARCHAR(50),
@nombres VARCHAR(50),
@apellidos VARCHAR(50),
@fechaNacimiento VARCHAR(50),
@acudiente VARCHAR(50),
@direccion VARCHAR(50),
@telefono VARCHAR(50),
@mail VARCHAR(50),
@observacion VARCHAR(50), 
@ocupacionAcudiente VARCHAR(50)

AS 

BEGIN 

DECLARE

@id_estudiante INT,
@valorConceptoPagoMatricula INT,
@valorConceptoPension INT

INSERT INTO estudiantes(documento,nombres,apellidos,fecha_nacimiento,acudiente,direccion
                        ,telefono,correo,observacion,ocupacion_acudiente,fecha_creacion,fecha_modificacion,grupo_id)
VALUES (@documento,@nombres,@apellidos,@fechaNacimiento,@acudiente,@direccion,@telefono,@mail,@observacion,@ocupacionAcudiente,
        SYSDATETIME(),'',1)

SELECT @id_estudiante = id_alumno
FROM estudiantes
WHERE documento = @documento

SELECT @valorConceptoPagoMatricula = valor_pagar
FROM conceptos_pago
WHERE id_concepto_pago = 1


SELECT @valorConceptoPension = valor_pagar
FROM conceptos_pago
WHERE id_concepto_pago = 2


INSERT INTO pagos(abono,saldo_pendiente,id_concepto_pago,fecha_creacion,id_estudiante)
VALUES (0,@valorConceptoPagoMatricula,1,SYSDATETIME(),@id_estudiante)

INSERT INTO pagos(abono,saldo_pendiente,id_concepto_pago,fecha_creacion,id_estudiante)
VALUES (0,@valorConceptoPension,2,SYSDATETIME(),@id_estudiante)

END 
GO
/****** Object:  StoredProcedure [dbo].[pa_insertarGrupo]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_insertarGrupo]

@nombreGrupo VARCHAR(50),
@idGrado INT,
@cantidadAlumnos INT,
@docente INT,
@salon INT

AS

BEGIN 

INSERT INTO grupos(nombre_grupo,id_grado,cantidad_alumnos,fecha_creacion, id_docente, id_salon)
VALUES (@nombreGrupo,@idGrado,@cantidadAlumnos,SYSDATETIME(),@docente, @salon)

END
GO
/****** Object:  StoredProcedure [dbo].[pa_insertarHorario]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_insertarHorario]

@idBloque INT,
@idMateria INT,
@idGrupo INT,
@idDia INT

AS

BEGIN

INSERT INTO horario(id_bloque,id_materia,id_grupo,id_dia)
VALUES (@idBloque,@idMateria,@idGrupo,@idDia)

END
GO
/****** Object:  StoredProcedure [dbo].[pa_insertarNota]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_insertarNota]

@idAlumno INT,
@idPeriodo VARCHAR(15),
@idMateria INT,
@Nota DECIMAL(4,1),
@valoracion VARCHAR(40)

AS

BEGIN 

INSERT INTO notas(id_alumno,id_materia,periodo,nota,valoracion)
VALUES (@idAlumno,@idMateria,@idPeriodo,@Nota,@valoracion)

END
GO
/****** Object:  StoredProcedure [dbo].[pa_insertarPago]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_insertarPago]

@conceptoPago INT,
@abono INT,
@estudiante VARCHAR(30),
@anioPago VARCHAR(20),
@mesPago VARCHAR(30)

AS

DECLARE 

@idEstudiante INT,
@id_ultimoPago INT,
@saldoPendiente INT

BEGIN

/*Obtener id estudiante*/

SELECT @idEstudiante = id_alumno
FROM estudiantes 
WHERE documento = @estudiante

/*Obtener el pago mas reciente por concepto*/

SELECT TOP 1 @saldoPendiente = saldo_pendiente
FROM pagos
WHERE (id_concepto_pago = @conceptoPago AND id_estudiante = @idEstudiante AND anioPago = @anioPago AND mesPago = @mesPago) 
	OR (id_concepto_pago = @conceptoPago AND id_estudiante = @idEstudiante AND anioPago IS NULL AND mesPago IS NULL)
ORDER BY id_pago DESC

INSERT INTO pagos(abono,saldo_pendiente,id_concepto_pago,anioPago,mesPago,id_estado_pago,fecha_creacion,id_estudiante) 
VALUES (@abono,@saldoPendiente-@abono,@conceptoPago,@anioPago,@mesPago,2,SYSDATETIME(),@idEstudiante)

END
GO
/****** Object:  StoredProcedure [dbo].[pa_insertarUsuario]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_insertarUsuario]

@documento VARCHAR(30),
@nombres VARCHAR(50),
@apellidos VARCHAR(50),
@direccion VARCHAR(50),
@telefono VARCHAR(50),
@mail VARCHAR(50),
@observacion VARCHAR(50),
@loginUser VARCHAR(30),
@password VARCHAR(30),
@perfil INT,
@estado INT

AS
DECLARE

@consultaIdUsuario INT

BEGIN

INSERT INTO usuarios (documento,nombres,apellidos,direccion,telefono,correo,observacion)
VALUES (@documento,@nombres,@apellidos,@direccion,@telefono,@mail,@observacion)

SELECT @consultaIdUsuario = id_usuario FROM usuarios WHERE documento = @documento

INSERT INTO login_usuario (login,password,perfil,estado,pk_id_usuario)
VALUES (@loginUser,@password,@perfil,@estado,@consultaIdUsuario)

END
GO
/****** Object:  StoredProcedure [dbo].[pa_ListarAreas]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_ListarAreas]

AS

BEGIN 

SELECT nombre_area
FROM areas

END

GO
/****** Object:  StoredProcedure [dbo].[pa_listarBloques]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_listarBloques]

AS

BEGIN

SELECT descripcion_bloque
FROM bloques

END
GO
/****** Object:  StoredProcedure [dbo].[pa_ListarConceptosPago]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_ListarConceptosPago]

AS

BEGIN

SELECT concepto
FROM conceptos_pago

END 

GO
/****** Object:  StoredProcedure [dbo].[pa_ListarDias]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_ListarDias]

AS
BEGIN

SELECT descripcion
FROM dias

END
GO
/****** Object:  StoredProcedure [dbo].[pa_ListarEstudiantes]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_ListarEstudiantes]

AS

BEGIN

SELECT id_alumno,documento,nombres,apellidos,fecha_nacimiento,acudiente,direccion,telefono,
		correo,observacion,ocupacion_acudiente
FROM estudiantes

END 
GO
/****** Object:  StoredProcedure [dbo].[pa_listarEstudiantesPorGrupo]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_listarEstudiantesPorGrupo]

@idGrupo INT

AS

BEGIN 

SELECT id_alumno, nombres, apellidos
FROM estudiantes
WHERE grupo_id = @idGrupo

END
GO
/****** Object:  StoredProcedure [dbo].[pa_ListarGrados]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_ListarGrados]

AS

BEGIN 

SELECT nombre_grado
FROM grados

END

GO
/****** Object:  StoredProcedure [dbo].[pa_ListarGrupos]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_ListarGrupos]

AS

BEGIN

SELECT id_grupo,nombre_grupo
FROM grupos

END 

GO
/****** Object:  StoredProcedure [dbo].[pa_ListarGruposEstudiantes]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_ListarGruposEstudiantes]

AS

BEGIN

SELECT es.id_alumno,es.documento,es.nombres,es.apellidos,g.nombre_grupo
FROM estudiantes AS es
INNER JOIN grupos AS g
	ON es.grupo_id = g.id_grupo

END
GO
/****** Object:  StoredProcedure [dbo].[pa_ListarGruposPorGrado]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_ListarGruposPorGrado]

@idGrado INT

AS

BEGIN

SELECT id_grupo,nombre_grupo
FROM grupos
INNER JOIN grados
 ON grupos.id_grado = grados.id_grado
WHERE grados.id_grado = @idGrado

END
GO
/****** Object:  StoredProcedure [dbo].[pa_ListarMaterias]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_ListarMaterias]

AS

BEGIN

SELECT nombre_materia
FROM materias

END
GO
/****** Object:  StoredProcedure [dbo].[pa_ListarMateriasConID]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_ListarMateriasConID]

AS

BEGIN

SELECT id_materia,nombre_materia
FROM materias

END
GO
/****** Object:  StoredProcedure [dbo].[pa_ListarMateriasPorArea]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_ListarMateriasPorArea]

@idArea INT

AS

BEGIN 

SELECT nombre_materia
FROM materias AS m
INNER JOIN areas AS a
  ON m.id_area = a.id_area
WHERE a.id_area = @idArea

END

GO
/****** Object:  StoredProcedure [dbo].[pa_listarNotas]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_listarNotas]

@idestudiante INT

AS

BEGIN

SELECT n.id_materia,m.nombre_materia,n.nota,n.valoracion
FROM notas AS n
JOIN materias AS m
ON n.id_materia = m.id_materia
WHERE n.id_alumno = @idestudiante

END
GO
/****** Object:  StoredProcedure [dbo].[pa_listarPagosAprobados]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_listarPagosAprobados]

@documentoEstudiante VARCHAR(30)

AS

DECLARE 

@idEstudiante INT

BEGIN

SELECT @idEstudiante=id_alumno
FROM estudiantes
WHERE documento = @documentoEstudiante

SELECT cp.concepto,p.anioPago,p.mesPago,p.abono,p.saldo_pendiente,ep.descripcion_pago
FROM pagos AS p
INNER JOIN conceptos_pago AS cp
 ON p.id_concepto_pago = cp.id_concepto_pago
INNER JOIN estados_pago AS ep
 ON p.id_estado_pago = ep.id_estado_pago
WHERE p.id_estudiante = @idEstudiante AND p.id_estado_pago = 2

END
GO
/****** Object:  StoredProcedure [dbo].[pa_listarPagosAprobadosPorAnio]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_listarPagosAprobadosPorAnio]

@documentoEstudiante VARCHAR(30),
@anio VARCHAR(10)

AS

DECLARE 

@idEstudiante INT

BEGIN

SELECT @idEstudiante=id_alumno
FROM estudiantes
WHERE documento = @documentoEstudiante

SELECT cp.concepto,p.anioPago,p.mesPago,p.abono,p.saldo_pendiente,ep.descripcion_pago
FROM pagos AS p
INNER JOIN conceptos_pago AS cp
 ON p.id_concepto_pago = cp.id_concepto_pago
INNER JOIN estados_pago AS ep
 ON p.id_estado_pago = ep.id_estado_pago
WHERE p.id_estudiante = @idEstudiante AND p.id_estado_pago = 2 AND anioPago=@anio

END
GO
/****** Object:  StoredProcedure [dbo].[pa_ListarPeriodosActivos]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_ListarPeriodosActivos]

AS

BEGIN

SELECT p.id_periodo,p.anio,p.numero_periodo
FROM periodo AS p
WHERE p.estado = 1


END
GO
/****** Object:  StoredProcedure [dbo].[pa_listarsalones]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_listarsalones]

AS

BEGIN

SELECT descripcion 
FROM salones

END
GO
/****** Object:  StoredProcedure [dbo].[pa_ListarUsuarios]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_ListarUsuarios] 

AS

SELECT  u.id_usuario,
		u.documento,
		u.nombres,
		u.apellidos,
		u.direccion,
		u.telefono,
		u.correo,
		u.observacion,
		lu.login,
		lu.password,
		lu.perfil,
		lu.estado

FROM usuarios u
JOIN login_usuario lu
	ON u.id_usuario = lu.pk_id_usuario

GO
/****** Object:  StoredProcedure [dbo].[pa_modificarGrupo]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_modificarGrupo]

@nombreGrupo VARCHAR(50),
@nombreAnterior VARCHAR(50),
@idGrado INT,
@cantidadAlumnos INT,
@docente INT,
@salon INT

AS

DECLARE

@id_grupo INT

BEGIN 

SELECT @id_grupo=id_grupo
FROM grupos
WHERE nombre_grupo = @nombreAnterior

UPDATE grupos
SET nombre_grupo = @nombreGrupo,
    id_grado = @idGrado,
	cantidad_alumnos = @cantidadAlumnos,
	fecha_modificacion =  SYSDATETIME(),
	id_docente = @docente,
	id_salon = @salon
WHERE id_grupo = @id_grupo

END
GO
/****** Object:  StoredProcedure [dbo].[pa_modificarNota]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_modificarNota]

@idAlumno INT,
@idPeriodo VARCHAR(15),
@idMateria INT,
@Nota DECIMAL(4,1),
@valoracion VARCHAR(40)

AS

BEGIN

UPDATE notas
SET nota = @Nota, valoracion = @valoracion
WHERE id_nota = (SELECT id_nota FROM notas WHERE id_alumno=@idAlumno AND periodo=@idPeriodo AND id_materia = @idMateria)

END
GO
/****** Object:  StoredProcedure [dbo].[pa_obtenerDiaBloque]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pa_obtenerDiaBloque]

@idDia INT,
@idBloque INT

AS 

BEGIN

SELECT id_horario
FROM horario
WHERE id_dia = @idDia AND id_bloque = @idBloque

END
GO
/****** Object:  StoredProcedure [dbo].[pa_obtenerIntensidadHorariaMateria]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pa_obtenerIntensidadHorariaMateria]

@idMateria INT

AS 

BEGIN

SELECT carga_horaria
FROM materias
WHERE id_materia = @idMateria

END
GO
/****** Object:  StoredProcedure [dbo].[pa_obtenerPagoTotalConcepto]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pa_obtenerPagoTotalConcepto]

@documentoEstudiante VARCHAR(30),
@concepto INT,
@anio VARCHAR(10),
@mes VARCHAR(50)

AS

DECLARE 
@id_estudiante INT

BEGIN

SELECT @id_estudiante=id_alumno
FROM estudiantes
WHERE documento = @documentoEstudiante

SELECT CASE
	   WHEN SUM(abono) IS NULL THEN 0
       ELSE SUM(abono)
       END AS totalPago
FROM pagos
WHERE (id_estudiante = @id_estudiante AND  id_concepto_pago=@concepto AND anioPago = @anio AND mesPago = @mes AND id_estado_pago = 2)
	

END
GO
/****** Object:  StoredProcedure [dbo].[pa_obtenerTotalBloquesDia]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pa_obtenerTotalBloquesDia]

@idDia INT

AS 

BEGIN

SELECT COUNT(id_bloque) AS total_bloques_dia
FROM horario
WHERE id_dia = @idDia

END
GO
/****** Object:  StoredProcedure [dbo].[pa_obtenerTotalMaterias]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_obtenerTotalMaterias]

AS

BEGIN

SELECT COUNT(id_materia) AS totalMaterias
FROM materias


END
GO
/****** Object:  StoredProcedure [dbo].[pa_obtenerValorConcepto]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_obtenerValorConcepto]

@concepto INT

AS

BEGIN

SELECT valor_pagar AS valorConcepto
FROM conceptos_pago 
WHERE id_concepto_pago = @concepto 

END
GO
/****** Object:  StoredProcedure [dbo].[pa_pintarHorario]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_pintarHorario]

@idGrupo INT

AS
BEGIN

SELECT b.descripcion_bloque,m.nombre_materia,g.nombre_grupo,d.descripcion
FROM horario AS h
RIGHT JOIN bloques AS b
	ON h.id_bloque = b.id_bloque
RIGHT JOIN materias AS m
	ON h.id_materia = m.id_materia
RIGHT JOIN grupos AS g
	ON h.id_grupo = g.id_grupo
RIGHT JOIN dias AS d
	ON h.id_dia = d.id_dia
WHERE g.id_grupo = @idGrupo

END
GO
/****** Object:  StoredProcedure [dbo].[pa_traerCantidadAlumnosEnGrupo]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_traerCantidadAlumnosEnGrupo]

@id_grupo INT

AS

BEGIN

SELECT cantidad_alumnos
FROM grupos
WHERE id_grupo = @id_grupo

END 

GO
/****** Object:  StoredProcedure [dbo].[pa_validarExisteciaHoarario]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pa_validarExisteciaHoarario]

@idBloque INT,
@idMateria INT,
@idGrupo INT,
@idDia INT

AS 

BEGIN

SELECT id_horario 
FROM horario
WHERE id_bloque = @idBloque AND id_materia = @idMateria AND id_grupo = @idGrupo AND id_dia=@idDia

END
GO
/****** Object:  StoredProcedure [dbo].[pa_validarexistenciaNota]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pa_validarexistenciaNota]

@idestudiante INT,
@idMateria INT,
@periodo VARCHAR(30)

AS

BEGIN

SELECT COUNT(id_nota) AS numero_registros
FROM notas
WHERE id_alumno = @idestudiante AND id_materia = @idMateria AND periodo = @periodo

END
GO
/****** Object:  StoredProcedure [dbo].[traerCantidadGrupos]    Script Date: 16/05/2020 11:20:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[traerCantidadGrupos]

@id_grado INT

AS

BEGIN

SELECT cantidad_grupos
FROM grados
WHERE id_grado = @id_grado

END 

GO
USE [master]
GO
ALTER DATABASE [Jardin] SET  READ_WRITE 
GO
