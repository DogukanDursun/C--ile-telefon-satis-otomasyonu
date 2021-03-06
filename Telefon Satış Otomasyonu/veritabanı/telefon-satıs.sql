USE [telefonsatış]
GO
/****** Object:  Table [dbo].[il]    Script Date: 27.05.2022 13:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[il](
	[il_id] [int] IDENTITY(1,1) NOT NULL,
	[iller] [nvarchar](20) NULL,
 CONSTRAINT [PK_il] PRIMARY KEY CLUSTERED 
(
	[il_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ilceler]    Script Date: 27.05.2022 13:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ilceler](
	[ilce_id] [int] IDENTITY(1,1) NOT NULL,
	[ilce] [nvarchar](50) NOT NULL,
	[il_no] [int] NOT NULL,
 CONSTRAINT [PK_ilceler] PRIMARY KEY CLUSTERED 
(
	[ilce_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marka]    Script Date: 27.05.2022 13:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marka](
	[Marka_id] [int] IDENTITY(1,1) NOT NULL,
	[Marka_adı] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Marka] PRIMARY KEY CLUSTERED 
(
	[Marka_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Model]    Script Date: 27.05.2022 13:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Model](
	[Model_id] [int] IDENTITY(1,1) NOT NULL,
	[Model_adı] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Model] PRIMARY KEY CLUSTERED 
(
	[Model_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[müsteri]    Script Date: 27.05.2022 13:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[müsteri](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kullanıcıadı] [nvarchar](20) NOT NULL,
	[Adısoyadı] [nvarchar](20) NOT NULL,
	[telno] [int] NULL,
	[email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_müsteri_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[satış]    Script Date: 27.05.2022 13:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[satış](
	[satışid] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_satış] PRIMARY KEY CLUSTERED 
(
	[satışid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[telefon]    Script Date: 27.05.2022 13:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[telefon](
	[IMEI] [int] NOT NULL,
	[Marka] [nvarchar](50) NOT NULL,
	[Model] [nvarchar](50) NOT NULL,
	[Depolama] [nvarchar](50) NOT NULL,
	[Ram] [nvarchar](50) NOT NULL,
	[Batarya] [nvarchar](50) NOT NULL,
	[Ekran] [nvarchar](50) NOT NULL,
	[Kamera] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_telefon] PRIMARY KEY CLUSTERED 
(
	[IMEI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[yönetici]    Script Date: 27.05.2022 13:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[yönetici](
	[kullanıcıadı] [nvarchar](20) NOT NULL,
	[sifre] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_yönetici] PRIMARY KEY CLUSTERED 
(
	[kullanıcıadı] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[il]  WITH CHECK ADD  CONSTRAINT [FK_il_müsteri] FOREIGN KEY([il_id])
REFERENCES [dbo].[müsteri] ([id])
GO
ALTER TABLE [dbo].[il] CHECK CONSTRAINT [FK_il_müsteri]
GO
ALTER TABLE [dbo].[ilceler]  WITH CHECK ADD  CONSTRAINT [FK_ilceler_müsteri] FOREIGN KEY([ilce_id])
REFERENCES [dbo].[müsteri] ([id])
GO
ALTER TABLE [dbo].[ilceler] CHECK CONSTRAINT [FK_ilceler_müsteri]
GO
ALTER TABLE [dbo].[Model]  WITH CHECK ADD  CONSTRAINT [FK_Model_telefon] FOREIGN KEY([Model_id])
REFERENCES [dbo].[telefon] ([IMEI])
GO
ALTER TABLE [dbo].[Model] CHECK CONSTRAINT [FK_Model_telefon]
GO
ALTER TABLE [dbo].[telefon]  WITH CHECK ADD  CONSTRAINT [FK_telefon_Marka] FOREIGN KEY([IMEI])
REFERENCES [dbo].[Marka] ([Marka_id])
GO
ALTER TABLE [dbo].[telefon] CHECK CONSTRAINT [FK_telefon_Marka]
GO
ALTER TABLE [dbo].[telefon]  WITH CHECK ADD  CONSTRAINT [FK_telefon_satış] FOREIGN KEY([IMEI])
REFERENCES [dbo].[satış] ([satışid])
GO
ALTER TABLE [dbo].[telefon] CHECK CONSTRAINT [FK_telefon_satış]
GO
