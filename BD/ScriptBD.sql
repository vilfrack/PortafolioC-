USE [portafolio]
GO
/****** Object:  Table [dbo].[backend]    Script Date: 18/09/2016 22:21:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[backend](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[porcentaje] [int] NULL,
 CONSTRAINT [PK_backend] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[frontend]    Script Date: 18/09/2016 22:21:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[frontend](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[porcentaje] [int] NULL,
 CONSTRAINT [PK_frontend] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[login]    Script Date: 18/09/2016 22:21:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[login](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[id_perfil] [int] NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[master_portafolio]    Script Date: 18/09/2016 22:21:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[master_portafolio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_portafolio] [int] NULL,
	[id_backend] [int] NULL,
	[id_fronend] [int] NULL,
 CONSTRAINT [PK_master_portafolio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[perfil]    Script Date: 18/09/2016 22:21:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[perfil](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[portada] [varchar](100) NULL,
	[presentacion] [varchar](100) NULL,
	[id_follow] [int] NULL,
 CONSTRAINT [PK_perfil] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[portafolio]    Script Date: 18/09/2016 22:21:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[portafolio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[ruta] [varchar](max) NULL,
	[img] [varchar](100) NULL,
 CONSTRAINT [PK_portafolio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[backend] ON 

INSERT [dbo].[backend] ([id], [descripcion], [porcentaje]) VALUES (42, N'HOW', NULL)
INSERT [dbo].[backend] ([id], [descripcion], [porcentaje]) VALUES (1031, N'prueba', 12)
SET IDENTITY_INSERT [dbo].[backend] OFF
SET IDENTITY_INSERT [dbo].[frontend] ON 

INSERT [dbo].[frontend] ([id], [descripcion], [porcentaje]) VALUES (9, N'sd', NULL)
INSERT [dbo].[frontend] ([id], [descripcion], [porcentaje]) VALUES (10, N'c', NULL)
INSERT [dbo].[frontend] ([id], [descripcion], [porcentaje]) VALUES (20, N'qweqe', NULL)
INSERT [dbo].[frontend] ([id], [descripcion], [porcentaje]) VALUES (1009, N'prueba', 10)
INSERT [dbo].[frontend] ([id], [descripcion], [porcentaje]) VALUES (1010, N'prueba', 0)
SET IDENTITY_INSERT [dbo].[frontend] OFF
SET IDENTITY_INSERT [dbo].[login] ON 

INSERT [dbo].[login] ([id], [login], [password], [id_perfil]) VALUES (1, N'juan', N'villa', NULL)
SET IDENTITY_INSERT [dbo].[login] OFF
SET IDENTITY_INSERT [dbo].[perfil] ON 

INSERT [dbo].[perfil] ([id], [portada], [presentacion], [id_follow]) VALUES (1, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[perfil] OFF
SET IDENTITY_INSERT [dbo].[portafolio] ON 

INSERT [dbo].[portafolio] ([id], [descripcion], [ruta], [img]) VALUES (4, N'prueba', N'www.github.com', N'Android Wallpapers1.png')
INSERT [dbo].[portafolio] ([id], [descripcion], [ruta], [img]) VALUES (5, N'prueba', N'www.github.com', N'Android Wallpapers1.png')
INSERT [dbo].[portafolio] ([id], [descripcion], [ruta], [img]) VALUES (6, N'prueba', N'www.github.com', N'Android Wallpapers1.png')
SET IDENTITY_INSERT [dbo].[portafolio] OFF
ALTER TABLE [dbo].[login]  WITH CHECK ADD  CONSTRAINT [FK_login_login] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[perfil] ([id])
GO
ALTER TABLE [dbo].[login] CHECK CONSTRAINT [FK_login_login]
GO
ALTER TABLE [dbo].[master_portafolio]  WITH CHECK ADD  CONSTRAINT [FK_master_portafolio_backend] FOREIGN KEY([id_backend])
REFERENCES [dbo].[backend] ([id])
GO
ALTER TABLE [dbo].[master_portafolio] CHECK CONSTRAINT [FK_master_portafolio_backend]
GO
ALTER TABLE [dbo].[master_portafolio]  WITH CHECK ADD  CONSTRAINT [FK_master_portafolio_frontend] FOREIGN KEY([id_fronend])
REFERENCES [dbo].[frontend] ([id])
GO
ALTER TABLE [dbo].[master_portafolio] CHECK CONSTRAINT [FK_master_portafolio_frontend]
GO
ALTER TABLE [dbo].[master_portafolio]  WITH CHECK ADD  CONSTRAINT [FK_master_portafolio_portafolio1] FOREIGN KEY([id_portafolio])
REFERENCES [dbo].[portafolio] ([id])
GO
ALTER TABLE [dbo].[master_portafolio] CHECK CONSTRAINT [FK_master_portafolio_portafolio1]
GO
