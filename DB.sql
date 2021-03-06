USE [master]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE ReporteUsuariosXCurso
@inicio datetime,
@fin datetime,
@curso int,
@inscripto int
AS
DECLARE @cur varchar(30)
Set @cur=(Select nombre
			from cursos
			where id_curso=@curso)
DECLARE @ins varchar(30)
Set @ins=(Select usuario
			from usuarios
			where id_usuario=@inscripto)

BEGIN
--SI LA FECHA ES NULA
	if(@inicio is null)
	--SI CURSO ES NULO
		if(@cur is null)
			--ES INSCRIPTO  NULO
			if(@ins is null)
				BEGIN
					SELECT U.usuario "Usuario",C.nombre "Curso",UC.puntuacion "Puntuacion",UC.observaciones "Observaciones",UC.fecha_Inicio "Inicio",UC.Fecha_fin "Fin"
					FROM UsuariosCurso UC,Cursos C,Usuarios U
					WHERE UC.id_usuario=U.id_usuario
					AND UC.id_curso=C.id_curso
				END;

			--INSCRIPTO NO ES NULO
			else
				BEGIN
					SELECT U.usuario "Usuario",C.nombre "Curso",UC.puntuacion "Puntuacion",UC.observaciones "Observaciones",UC.fecha_Inicio "Inicio",UC.Fecha_fin "Fin"
					FROM UsuariosCurso UC,Cursos C,Usuarios U
					WHERE UC.id_usuario=U.id_usuario
					AND UC.id_curso=C.id_curso
					AND U.usuario=@ins
				END;
			
	--EL CURSO NO ES NULO
		else
			--ES INSCRIPTO  NULO
			if(@ins is null)
				BEGIN
					SELECT U.usuario "Usuario",C.nombre "Curso",UC.puntuacion "Puntuacion",UC.observaciones "Observaciones",UC.fecha_Inicio "Inicio",UC.Fecha_fin "Fin"
					FROM UsuariosCurso UC,Cursos C,Usuarios U
					WHERE UC.id_usuario=U.id_usuario
					AND UC.id_curso=C.id_curso
					AND C.nombre=@cur
				END;

			--INSCRIPTO NO ES NULO
			else
				BEGIN
					SELECT U.usuario "Usuario",C.nombre "Curso",UC.puntuacion "Puntuacion",UC.observaciones "Observaciones",UC.fecha_Inicio "Inicio",UC.Fecha_fin "Fin"
					FROM UsuariosCurso UC,Cursos C,Usuarios U
					WHERE UC.id_usuario=U.id_usuario
					AND UC.id_curso=C.id_curso
					AND U.usuario=@ins
					AND C.nombre=@cur
				END;
--LA FECHA NO ES NULA
	else
	--SI CURSO ES NULO
		if(@cur is null)
			--ES INSCRIPTO  NULO
			if(@ins is null)
				BEGIN
					SELECT U.usuario "Usuario",C.nombre "Curso",UC.puntuacion "Puntuacion",UC.observaciones "Observaciones",UC.fecha_Inicio "Inicio",UC.Fecha_fin "Fin"
					FROM UsuariosCurso UC,Cursos C,Usuarios U
					WHERE UC.id_usuario=U.id_usuario
					AND UC.id_curso=C.id_curso
					and UC.fecha_inicio >= @inicio 
					and UC.fecha_fin <= @fin
					
				END;

			--INSCRIPTO NO ES NULO
			else
				BEGIN
					SELECT U.usuario "Usuario",C.nombre "Curso",UC.puntuacion "Puntuacion",UC.observaciones "Observaciones",UC.fecha_Inicio "Inicio",UC.Fecha_fin "Fin"
					FROM UsuariosCurso UC,Cursos C,Usuarios U
					WHERE UC.id_usuario=U.id_usuario
					AND UC.id_curso=C.id_curso
					AND U.usuario=@ins
					and UC.fecha_inicio >= @inicio 
					and UC.fecha_fin <= @fin
				END;
			
	--EL CURSO NO ES NULO
		else
			--ES INSCRIPTO  NULO
			if(@ins is null)
				BEGIN
					SELECT U.usuario "Usuario",C.nombre "Curso",UC.puntuacion "Puntuacion",UC.observaciones "Observaciones",UC.fecha_Inicio "Inicio",UC.Fecha_fin "Fin"
					FROM UsuariosCurso UC,Cursos C,Usuarios U
					WHERE UC.id_usuario=U.id_usuario
					AND UC.id_curso=C.id_curso
					AND C.nombre=@cur
					and UC.fecha_inicio >= @inicio 
					and UC.fecha_fin <= @fin
				END;

			--INSCRIPTO NO ES NULO
			else
				BEGIN
					SELECT U.usuario "Usuario",C.nombre "Curso",UC.puntuacion "Puntuacion",UC.observaciones "Observaciones",UC.fecha_Inicio "Inicio",UC.Fecha_fin "Fin"
					FROM UsuariosCurso UC,Cursos C,Usuarios U
					WHERE UC.id_usuario=U.id_usuario
					AND UC.id_curso=C.id_curso
					AND U.usuario=@ins
					AND C.nombre=@cur
					and UC.fecha_inicio >= @inicio 
					and UC.fecha_fin <= @fin
				END;
END;

GO
/****** Object:  StoredProcedure [dbo].[ReporteAvances]    Script Date: 19/10/2020 23:16:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[ReporteAvances]
@curso int,
@inscripto int
AS

DECLARE @cur varchar(30)
Set @cur=(Select nombre
			from cursos
			where id_curso=@curso)
DECLARE @ins varchar(30)
Set @ins=(Select usuario
			from usuarios
			where id_usuario=@inscripto)
begin
	if(@cur is null)
		if(@ins is null)
			begin
				select U.usuario,C.nombre,Ca.inicio,Ca.fin,Ca.porc_avance 
				from UsuariosCursoAvance Ca,Cursos C,Usuarios U
				where Ca.id_curso=C.id_curso and
				Ca.id_usuario=U.id_usuario 
			end;
		else
			begin
				select U.usuario,C.nombre,Ca.inicio,Ca.fin,Ca.porc_avance 
				from UsuariosCursoAvance Ca,Cursos C,Usuarios U
				where Ca.id_curso=C.id_curso and
				Ca.id_usuario=U.id_usuario 
				and U.usuario=@ins;
			end;
	else
		if(@ins is null)
			begin
				select U.usuario,C.nombre,Ca.inicio,Ca.fin,Ca.porc_avance 
				from UsuariosCursoAvance Ca,Cursos C,Usuarios U
				where Ca.id_curso=C.id_curso and
				Ca.id_usuario=U.id_usuario 
				and C.nombre=@cur;
			end;
		else
			begin
				select U.usuario,C.nombre,Ca.inicio,Ca.fin,Ca.porc_avance 
				from UsuariosCursoAvance Ca,Cursos C,Usuarios U
				where Ca.id_curso=C.id_curso and
				Ca.id_usuario=U.id_usuario 
				and U.usuario=@ins
				and C.nombre=@cur;
			end;
		
end;

GO
/****** Object:  StoredProcedure [dbo].[ReporteInscripciones]    Script Date: 19/10/2020 23:16:19 ******/
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
		IF(@cur IS NULL)
			BEGIN
				select H.id_historial 'Id',H.descripcion 'Descripcion',H.fecha 'Fecha',U.usuario  'Inscripto',C.nombre  'Curso',H.responsable  'Funcionario' 
				from HistorialInscripciones H,Usuarios U,Cursos C
				where H.id_inscripto=U.id_usuario and
				h.id_curso=C.id_curso 
				and H.fecha BETWEEN @inicio and @fin
				and U.usuario=@ins			
			END;
		ELSE
			BEGIN
				select H.id_historial 'Id',H.descripcion 'Descripcion',H.fecha 'Fecha',U.usuario  'Inscripto',C.nombre  'Curso',H.responsable  'Funcionario' 
				from HistorialInscripciones H,Usuarios U,Cursos C
				where H.id_inscripto=U.id_usuario and
				h.id_curso=C.id_curso 
				and H.fecha BETWEEN @inicio and @fin	
				and C.nombre=@cur	
				and U.usuario=@ins		
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
/****** Object:  Table [dbo].[Categorias]    Script Date: 13/10/2020 19:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[Cursos]    Script Date: 13/10/2020 19:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[HistorialInscripciones]    Script Date: 13/10/2020 19:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[Objetivos]    Script Date: 13/10/2020 19:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[ObjetivosCursos]    Script Date: 13/10/2020 19:26:32 ******/
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
/****** Object:  Table [dbo].[Perfiles]    Script Date: 13/10/2020 19:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[Usuarios]    Script Date: 13/10/2020 19:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[UsuariosCurso]    Script Date: 13/10/2020 19:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[UsuariosCursoAvance]    Script Date: 13/10/2020 19:26:32 ******/
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
INSERT [dbo].[Categorias] ([id_categoria], [nombre], [descripcion], [borrado]) VALUES (0, N'Ciencias Basicas', N'aaaaaaa', 0)
INSERT [dbo].[Categorias] ([id_categoria], [nombre], [descripcion], [borrado]) VALUES (1, N'Informatica', N'aaaaaaa', 0)
INSERT [dbo].[Categorias] ([id_categoria], [nombre], [descripcion], [borrado]) VALUES (2, N'Ciencias Sociales', N'aaaaaaa', 0)
INSERT [dbo].[Categorias] ([id_categoria], [nombre], [descripcion], [borrado]) VALUES (3, N'Politicas', N'polssssssssssssss', 1)
INSERT [dbo].[Categorias] ([id_categoria], [nombre], [descripcion], [borrado]) VALUES (54, N'Categoria3', N'categoria n 3', 1)
GO
INSERT [dbo].[Cursos] ([id_curso], [nombre], [descripcion], [fecha_vigencia], [id_categoria], [borrado]) VALUES (0, N'Matematica 2', N'holaaaaaaaa', CAST(N'2020-09-15T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Cursos] ([id_curso], [nombre], [descripcion], [fecha_vigencia], [id_categoria], [borrado]) VALUES (1, N'Fisica II', N'hhhhhhhhhhhh', CAST(N'2020-09-10T00:00:00.000' AS DateTime), 0, 0)
INSERT [dbo].[Cursos] ([id_curso], [nombre], [descripcion], [fecha_vigencia], [id_categoria], [borrado]) VALUES (2, N'Historia', N'historiaaaaa', CAST(N'2020-02-13T00:00:00.000' AS DateTime), 2, 0)
INSERT [dbo].[Cursos] ([id_curso], [nombre], [descripcion], [fecha_vigencia], [id_categoria], [borrado]) VALUES (3, N'Programacion C', N'fafafasfasfweq', CAST(N'2020-09-15T00:00:00.000' AS DateTime), 1, 0)
INSERT [dbo].[Cursos] ([id_curso], [nombre], [descripcion], [fecha_vigencia], [id_categoria], [borrado]) VALUES (4, N'Quimica', N'adwwerqwqrqrrqrqwrqw', CAST(N'2020-09-15T00:00:00.000' AS DateTime), 0, 1)
INSERT [dbo].[Cursos] ([id_curso], [nombre], [descripcion], [fecha_vigencia], [id_categoria], [borrado]) VALUES (67, N'Geografia', N'geo', CAST(N'2020-09-17T00:00:00.000' AS DateTime), 2, 1)
GO
SET IDENTITY_INSERT [dbo].[HistorialInscripciones] ON 

INSERT [dbo].[HistorialInscripciones] ([id_historial], [descripcion], [fecha], [id_inscripto], [id_curso], [responsable]) VALUES (1, N'Nueva inscripcion', CAST(N'2020-10-13T17:11:40.760' AS DateTime), 5, 1, N'fran')
INSERT [dbo].[HistorialInscripciones] ([id_historial], [descripcion], [fecha], [id_inscripto], [id_curso], [responsable]) VALUES (2, N'Nueva inscripcion', CAST(N'2020-10-13T17:13:37.757' AS DateTime), 1, 3, N'fran')
INSERT [dbo].[HistorialInscripciones] ([id_historial], [descripcion], [fecha], [id_inscripto], [id_curso], [responsable]) VALUES (3, N'Eliminacion de inscripcion', CAST(N'2020-10-13T17:27:06.427' AS DateTime), 4, 2, N'fran')
INSERT [dbo].[HistorialInscripciones] ([id_historial], [descripcion], [fecha], [id_inscripto], [id_curso], [responsable]) VALUES (4, N'Eliminacion de inscripcion', CAST(N'2020-10-13T17:27:11.730' AS DateTime), 1, 2, N'fran')
INSERT [dbo].[HistorialInscripciones] ([id_historial], [descripcion], [fecha], [id_inscripto], [id_curso], [responsable]) VALUES (5, N'Modificacion de inscripcion', CAST(N'2020-10-13T17:27:41.397' AS DateTime), 1, 3, N'fran')
INSERT [dbo].[HistorialInscripciones] ([id_historial], [descripcion], [fecha], [id_inscripto], [id_curso], [responsable]) VALUES (6, N'Nueva inscripcion', CAST(N'2020-10-13T17:29:39.213' AS DateTime), 2, 2, N'Tester Ariel')
INSERT [dbo].[HistorialInscripciones] ([id_historial], [descripcion], [fecha], [id_inscripto], [id_curso], [responsable]) VALUES (7, N'Modificacion de inscripcion', CAST(N'2020-10-13T17:37:35.910' AS DateTime), 2, 2, N'fran')
INSERT [dbo].[HistorialInscripciones] ([id_historial], [descripcion], [fecha], [id_inscripto], [id_curso], [responsable]) VALUES (8, N'Nueva inscripcion', CAST(N'2020-10-13T17:44:29.660' AS DateTime), 8, 0, N'fran')
INSERT [dbo].[HistorialInscripciones] ([id_historial], [descripcion], [fecha], [id_inscripto], [id_curso], [responsable]) VALUES (9, N'Eliminacion de inscripcion', CAST(N'2020-10-13T17:47:26.823' AS DateTime), 2, 3, N'fran')
SET IDENTITY_INSERT [dbo].[HistorialInscripciones] OFF
GO
INSERT [dbo].[Objetivos] ([id_objetivo], [nombre_corto], [nombre_largo], [borrado]) VALUES (0, N'Objetivo1', N'Obje1', 1)
INSERT [dbo].[Objetivos] ([id_objetivo], [nombre_corto], [nombre_largo], [borrado]) VALUES (1, N'Obje2.', N'Objetivo2', 1)
INSERT [dbo].[Objetivos] ([id_objetivo], [nombre_corto], [nombre_largo], [borrado]) VALUES (4, N'Obje5', N'Objetivo4', 0)
INSERT [dbo].[Objetivos] ([id_objetivo], [nombre_corto], [nombre_largo], [borrado]) VALUES (5, N'Obje5', N'Objetivo5', 0)
GO
SET IDENTITY_INSERT [dbo].[Perfiles] ON 

INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (1, N'Administrador', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (2, N'Tester', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (3, N'Desarrollador', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (4, N'Responsable de Reportes', 0)
SET IDENTITY_INSERT [dbo].[Perfiles] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (1, 1, N'administrador', N'12345', N'admin@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (2, 2, N'Tester Ariel', N'12345', N'ariel@gmail.com', N'N', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (4, 3, N'Tester Miguel', N'12345', N'miguel@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (5, 2, N'Tester Ana', N'12345', N'ana@gmail.com', N'N', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (6, 3, N'Tester Diego', N'12345', N'diego@gmail.com', N'N', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (7, 4, N'Tester Micaela', N'12345', N'mica@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (8, 3, N'fran', N'12345', N'fran@fran', N'S', 0)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin]) VALUES (1, 3, 4, N'bien', CAST(N'2020-10-13T00:00:00.000' AS DateTime), CAST(N'2020-09-15T00:00:00.000' AS DateTime))
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin]) VALUES (2, 1, 3, N'rrrrr', CAST(N'2020-09-30T00:00:00.000' AS DateTime), CAST(N'2020-09-10T00:00:00.000' AS DateTime))
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin]) VALUES (2, 2, 5, N'mal', CAST(N'2020-10-13T00:00:00.000' AS DateTime), CAST(N'2020-02-13T00:00:00.000' AS DateTime))
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin]) VALUES (5, 1, 4, N'rwrwrwwrwrwrw', CAST(N'2020-10-13T00:00:00.000' AS DateTime), CAST(N'2020-09-10T00:00:00.000' AS DateTime))
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin]) VALUES (8, 0, 4, N'wwwwwwwwwwww', CAST(N'2020-09-30T00:00:00.000' AS DateTime), CAST(N'2020-09-15T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [inicio], [fin], [porc_avance]) VALUES (1, 3, CAST(N'2020-10-13T00:00:00.000' AS DateTime), CAST(N'2020-09-15T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [inicio], [fin], [porc_avance]) VALUES (2, 1, CAST(N'2020-10-12T00:00:00.000' AS DateTime), CAST(N'2020-09-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [inicio], [fin], [porc_avance]) VALUES (2, 2, CAST(N'2020-10-13T00:00:00.000' AS DateTime), CAST(N'2020-02-13T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [inicio], [fin], [porc_avance]) VALUES (5, 1, CAST(N'2020-10-13T00:00:00.000' AS DateTime), CAST(N'2020-09-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [inicio], [fin], [porc_avance]) VALUES (8, 0, CAST(N'2020-09-30T00:00:00.000' AS DateTime), CAST(N'2020-09-15T00:00:00.000' AS DateTime), 1)
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
