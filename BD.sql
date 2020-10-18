USE [Database]
GO
/****** Object:  StoredProcedure [dbo].[ReporteInscripciones]    Script Date: 18/10/2020 10:50:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteInscripciones]
@inicio datetime,
@fin datetime,
@curso int,
@inscripto int,
@responsable int
AS

DECLARE @cur varchar(30)
Set @cur=(Select nombre
			from cursos
			where id_curso=@curso)
DECLARE @ins varchar(30)
Set @ins=(Select usuario
			from usuarios
			where id_usuario=@inscripto)
DECLARE @res varchar(30)
Set @res=(Select usuario
			from usuarios
			where id_usuario=@responsable)


IF(@res IS NULL)
	IF(@ins IS NULL)
		IF(@cur IS NULL)
			BEGIN
				select H.id_historial 'Id',H.descripcion 'Descripcion',H.fecha 'Fecha',U.usuario  'Inscripto',C.nombre  'Curso',H.responsable  'Funcionario' 
				from HistorialInscripciones H,Usuarios U,Cursos C
				where H.id_inscripto=U.id_usuario and
				h.id_curso=C.id_curso 
				and H.fecha BETWEEN @inicio and @fin			
			END;
		ELSE
			BEGIN
				select H.id_historial 'Id',H.descripcion 'Descripcion',H.fecha 'Fecha',U.usuario  'Inscripto',C.nombre  'Curso',H.responsable  'Funcionario' 
				from HistorialInscripciones H,Usuarios U,Cursos C
				where H.id_inscripto=U.id_usuario and
				h.id_curso=C.id_curso 
				and H.fecha BETWEEN @inicio and @fin	
				and C.nombre=@cur		
			END;

	ELSE
		BEGIN
			select H.id_historial 'Id',H.descripcion 'Descripcion',H.fecha 'Fecha',U.usuario  'Inscripto',C.nombre  'Curso',H.responsable  'Funcionario' 
			from HistorialInscripciones H,Usuarios U,Cursos C
			where H.id_inscripto=U.id_usuario and
			h.id_curso=C.id_curso 
			and H.fecha BETWEEN @inicio and @fin
			and U.usuario like @ins	
		END;
ELSE
	IF(@ins IS NULL)
		IF(@cur IS NULL)
			BEGIN
				select H.id_historial 'Id',H.descripcion 'Descripcion',H.fecha 'Fecha',U.usuario  'Inscripto',C.nombre  'Curso',H.responsable  'Funcionario' 
				from HistorialInscripciones H,Usuarios U,Cursos C
				where H.id_inscripto=U.id_usuario and
				h.id_curso=C.id_curso 
				and H.fecha BETWEEN @inicio and @fin	
				and H.responsable like @res		
			END;
		ELSE
			BEGIN
				select H.id_historial 'Id',H.descripcion 'Descripcion',H.fecha 'Fecha',U.usuario  'Inscripto',C.nombre  'Curso',H.responsable  'Funcionario' 
				from HistorialInscripciones H,Usuarios U,Cursos C
				where H.id_inscripto=U.id_usuario and
				h.id_curso=C.id_curso 
				and H.fecha BETWEEN @inicio and @fin	
				and H.responsable like @res	
				and C.nombre=@cur		
			END;

	ELSE
		IF(@curso IS NULL)
			BEGIN
				select H.id_historial 'Id',H.descripcion 'Descripcion',H.fecha 'Fecha',U.usuario  'Inscripto',C.nombre  'Curso',H.responsable  'Funcionario' 
				from HistorialInscripciones H,Usuarios U,Cursos C
				where H.id_inscripto=U.id_usuario and
				h.id_curso=C.id_curso 
				and H.fecha BETWEEN @inicio and @fin	
				and H.responsable like @res		
				and U.usuario like @ins	
			END;
		ELSE
			BEGIN
				select H.id_historial 'Id',H.descripcion 'Descripcion',H.fecha 'Fecha',U.usuario  'Inscripto',C.nombre  'Curso',H.responsable  'Funcionario' 
				from HistorialInscripciones H,Usuarios U,Cursos C
				where H.id_inscripto=U.id_usuario and
				h.id_curso=C.id_curso 
				and H.fecha BETWEEN @inicio and @fin	
				and H.responsable like @res		
				and U.usuario like @ins
				and C.nombre=@cur		
			END;
		


GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 18/10/2020 10:50:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categorias](
	[id_categoria] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [nvarchar](50) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 18/10/2020 10:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cursos](
	[id_curso] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [nvarchar](50) NULL,
	[fecha_vigencia] [datetime] NULL,
	[id_categoria] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Cursos] PRIMARY KEY CLUSTERED 
(
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HistorialInscripciones]    Script Date: 18/10/2020 10:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HistorialInscripciones](
	[id_historial] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[fecha] [datetime] NULL,
	[id_inscripto] [int] NULL,
	[id_curso] [int] NULL,
	[responsable] [varchar](50) NULL,
 CONSTRAINT [PK_HistorialInscripciones] PRIMARY KEY CLUSTERED 
(
	[id_historial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Objetivos]    Script Date: 18/10/2020 10:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Objetivos](
	[id_objetivo] [int] NOT NULL,
	[nombre_corto] [varchar](50) NULL,
	[nombre_largo] [varchar](100) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Objetivos] PRIMARY KEY CLUSTERED 
(
	[id_objetivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ObjetivosCursos]    Script Date: 18/10/2020 10:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ObjetivosCursos](
	[id_objetivo] [int] NOT NULL,
	[id_curso] [int] NOT NULL,
	[puntos] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_ObjetivosCursos] PRIMARY KEY CLUSTERED 
(
	[id_objetivo] ASC,
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 18/10/2020 10:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Perfiles](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Perfiles] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 18/10/2020 10:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_perfil] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[estado] [varchar](1) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UsuariosCurso]    Script Date: 18/10/2020 10:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UsuariosCurso](
	[id_usuario] [int] NOT NULL,
	[id_curso] [int] NOT NULL,
	[puntuacion] [int] NULL,
	[observaciones] [varchar](150) NULL,
	[fecha_inicio] [datetime] NULL,
	[fecha_fin] [datetime] NULL,
 CONSTRAINT [PK_UsuariosCurso] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UsuariosCursoAvance]    Script Date: 18/10/2020 10:50:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosCursoAvance](
	[id_usuario] [int] NOT NULL,
	[id_curso] [int] NOT NULL,
	[inicio] [datetime] NOT NULL,
	[fin] [datetime] NULL,
	[porc_avance] [int] NULL,
 CONSTRAINT [PK_UsuariosCursoAvance] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[id_curso] ASC,
	[inicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Perfiles] ADD  CONSTRAINT [DF_Perfiles_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Cursos_Categorias] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categorias] ([id_categoria])
GO
ALTER TABLE [dbo].[Cursos] CHECK CONSTRAINT [FK_Cursos_Categorias]
GO
ALTER TABLE [dbo].[HistorialInscripciones]  WITH CHECK ADD  CONSTRAINT [FK_HistorialInscripciones_Cursos] FOREIGN KEY([id_curso])
REFERENCES [dbo].[Cursos] ([id_curso])
GO
ALTER TABLE [dbo].[HistorialInscripciones] CHECK CONSTRAINT [FK_HistorialInscripciones_Cursos]
GO
ALTER TABLE [dbo].[HistorialInscripciones]  WITH CHECK ADD  CONSTRAINT [FK_HistorialInscripciones_Usuarios] FOREIGN KEY([id_inscripto])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[HistorialInscripciones] CHECK CONSTRAINT [FK_HistorialInscripciones_Usuarios]
GO
ALTER TABLE [dbo].[ObjetivosCursos]  WITH CHECK ADD  CONSTRAINT [FK_ObjetivosCursos_Cursos] FOREIGN KEY([id_curso])
REFERENCES [dbo].[Cursos] ([id_curso])
GO
ALTER TABLE [dbo].[ObjetivosCursos] CHECK CONSTRAINT [FK_ObjetivosCursos_Cursos]
GO
ALTER TABLE [dbo].[ObjetivosCursos]  WITH CHECK ADD  CONSTRAINT [FK_ObjetivosCursos_Objetivos] FOREIGN KEY([id_objetivo])
REFERENCES [dbo].[Objetivos] ([id_objetivo])
GO
ALTER TABLE [dbo].[ObjetivosCursos] CHECK CONSTRAINT [FK_ObjetivosCursos_Objetivos]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Perfiles]
GO
ALTER TABLE [dbo].[UsuariosCurso]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosCurso_Cursos] FOREIGN KEY([id_curso])
REFERENCES [dbo].[Cursos] ([id_curso])
GO
ALTER TABLE [dbo].[UsuariosCurso] CHECK CONSTRAINT [FK_UsuariosCurso_Cursos]
GO
ALTER TABLE [dbo].[UsuariosCurso]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosCurso_Usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[UsuariosCurso] CHECK CONSTRAINT [FK_UsuariosCurso_Usuarios]
GO
ALTER TABLE [dbo].[UsuariosCursoAvance]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosCursoAvance_UsuariosCurso] FOREIGN KEY([id_usuario], [id_curso])
REFERENCES [dbo].[UsuariosCurso] ([id_usuario], [id_curso])
GO
ALTER TABLE [dbo].[UsuariosCursoAvance] CHECK CONSTRAINT [FK_UsuariosCursoAvance_UsuariosCurso]
GO
