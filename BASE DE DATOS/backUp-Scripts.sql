USE [Jardin]
GO
/****** Object:  Table [dbo].[areas]    Script Date: 28/03/2020 2:39:56 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[areas](
	[id_area] [int] IDENTITY(1,1) NOT NULL,
	[nombre_area] [nchar](30) NOT NULL,
 CONSTRAINT [PK_areas] PRIMARY KEY CLUSTERED 
(
	[id_area] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[conceptos_pago]    Script Date: 28/03/2020 2:39:56 p. m. ******/
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
/****** Object:  Table [dbo].[estado_usuario]    Script Date: 28/03/2020 2:39:56 p. m. ******/
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
/****** Object:  Table [dbo].[estudiantes]    Script Date: 28/03/2020 2:39:56 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estudiantes](
	[id_alumno] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [nchar](50) NOT NULL,
	[apellidos] [nchar](50) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[acudiente] [nchar](50) NOT NULL,
	[direccion] [nchar](50) NOT NULL,
	[telefono] [nchar](50) NOT NULL,
	[correo] [nchar](50) NOT NULL,
	[observacion] [nchar](50) NOT NULL,
	[ocupacion_acudiente] [nchar](50) NOT NULL,
	[fecha_creacion] [date] NOT NULL,
	[fecha_modificacion] [date] NOT NULL,
	[grupo_id] [int] NOT NULL,
 CONSTRAINT [PK_estudiantes] PRIMARY KEY CLUSTERED 
(
	[id_alumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[grados]    Script Date: 28/03/2020 2:39:56 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grados](
	[id_grado] [int] IDENTITY(1,1) NOT NULL,
	[nombre_grado] [nchar](30) NOT NULL,
 CONSTRAINT [PK_grados] PRIMARY KEY CLUSTERED 
(
	[id_grado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[grupos]    Script Date: 28/03/2020 2:39:56 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grupos](
	[id_grupo] [int] IDENTITY(1,1) NOT NULL,
	[nombre_grupo] [nchar](30) NOT NULL,
	[id_grado] [int] NOT NULL,
	[cantidad_alumnos] [int] NOT NULL,
	[id_usuario_docente] [int] NOT NULL,
	[fecha_modificacion] [date] NOT NULL,
 CONSTRAINT [PK_grupos] PRIMARY KEY CLUSTERED 
(
	[id_grupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login_usuario]    Script Date: 28/03/2020 2:39:56 p. m. ******/
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
/****** Object:  Table [dbo].[materias]    Script Date: 28/03/2020 2:39:56 p. m. ******/
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
/****** Object:  Table [dbo].[pagos]    Script Date: 28/03/2020 2:39:56 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pagos](
	[id_pago] [int] IDENTITY(1,1) NOT NULL,
	[abono] [decimal](18, 0) NOT NULL,
	[saldo_pendiente] [decimal](18, 0) NOT NULL,
	[id_concepto_pago] [int] NOT NULL,
	[fecha_creacion] [date] NOT NULL,
	[fecha_modificacion] [date] NOT NULL,
	[id_estudiante] [int] NOT NULL,
 CONSTRAINT [PK_pagos] PRIMARY KEY CLUSTERED 
(
	[id_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[perfiles_usuario]    Script Date: 28/03/2020 2:39:56 p. m. ******/
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
/****** Object:  Table [dbo].[usuarios]    Script Date: 28/03/2020 2:39:56 p. m. ******/
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
ALTER TABLE [dbo].[grupos]  WITH CHECK ADD  CONSTRAINT [FK_grupos_usuarios] FOREIGN KEY([id_usuario_docente])
REFERENCES [dbo].[usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[grupos] CHECK CONSTRAINT [FK_grupos_usuarios]
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
ALTER TABLE [dbo].[pagos]  WITH CHECK ADD  CONSTRAINT [FK_pagos_estudiantes] FOREIGN KEY([id_estudiante])
REFERENCES [dbo].[estudiantes] ([id_alumno])
GO
ALTER TABLE [dbo].[pagos] CHECK CONSTRAINT [FK_pagos_estudiantes]
GO
/****** Object:  StoredProcedure [dbo].[pa_actualizarUsuario]    Script Date: 28/03/2020 2:39:56 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[pa_consultarLoginUsuario]    Script Date: 28/03/2020 2:39:56 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[pa_consultarUsuario]    Script Date: 28/03/2020 2:39:56 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[pa_insertarUsuario]    Script Date: 28/03/2020 2:39:56 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[pa_ListarUsuarios]    Script Date: 28/03/2020 2:39:56 p. m. ******/
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
