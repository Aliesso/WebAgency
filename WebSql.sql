USE [K102AgencyDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10.02.2021 22:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Blogs]    Script Date: 10.02.2021 22:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blogs](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Header] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[PublishingDate] [datetime2](7) NOT NULL,
	[PhotoUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_Blogs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 10.02.2021 22:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PhotoUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Portfolios]    Script Date: 10.02.2021 22:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Portfolios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Header] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[PhotoUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_Portfolios] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Section1]    Script Date: 10.02.2021 22:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Section1](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SubHeader] [nvarchar](max) NULL,
	[Header] [nvarchar](max) NULL,
	[WorkArea] [nvarchar](max) NULL,
	[PhotoUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_Section1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SectionAbouts]    Script Date: 10.02.2021 22:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SectionAbouts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PhotoUrl] [nvarchar](max) NULL,
	[Header] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_SectionAbouts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SectionServices]    Script Date: 10.02.2021 22:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SectionServices](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Header] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Icon] [nvarchar](max) NULL,
 CONSTRAINT [PK_SectionServices] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Testimonials]    Script Date: 10.02.2021 22:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Testimonials](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PhotoUrl] [nvarchar](max) NULL,
	[Fullname] [nvarchar](max) NULL,
	[WorkArea] [nvarchar](max) NULL,
	[Rating] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Testimonials] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210128094731_Initial', N'5.0.2')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210202065529_DescriptionInTestimonial', N'5.0.2')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210209072734_Add', N'5.0.2')
GO
SET IDENTITY_INSERT [dbo].[Blogs] ON 

INSERT [dbo].[Blogs] ([ID], [Header], [Description], [PublishingDate], [PhotoUrl]) VALUES (4, N'Masqalanma', N'Şəkil 28 May metro stansiyasında çəkilib', CAST(N'2021-02-09T00:00:00.0000000' AS DateTime2), N'/img/blog/b1.jpg')
INSERT [dbo].[Blogs] ([ID], [Header], [Description], [PublishingDate], [PhotoUrl]) VALUES (9, N'Masqavı Düzgün Tax!', N'Şəkil Nəriman Nərimanov metro stansiyasında çəkilib', CAST(N'2021-02-10T00:00:00.0000000' AS DateTime2), N'/img/blog/b2.jpg')
INSERT [dbo].[Blogs] ([ID], [Header], [Description], [PublishingDate], [PhotoUrl]) VALUES (12, N'Coronadan uzaq dur', N'Şəkil İçəri şəhərdə çəkilib', CAST(N'2021-02-11T00:00:00.0000000' AS DateTime2), N'/img/blog/b3.jpg')
SET IDENTITY_INSERT [dbo].[Blogs] OFF
GO
SET IDENTITY_INSERT [dbo].[Portfolios] ON 

INSERT [dbo].[Portfolios] ([ID], [Header], [Description], [PhotoUrl]) VALUES (1, N'Cyber Design', N'Art,Walpaper', N'/img/portfolio/CD1.png')
INSERT [dbo].[Portfolios] ([ID], [Header], [Description], [PhotoUrl]) VALUES (2, N'Cyber Design', N'Art,Walpaper', N'/img/portfolio/CD2.jpg')
INSERT [dbo].[Portfolios] ([ID], [Header], [Description], [PhotoUrl]) VALUES (3, N'Cyber Design', N'Art,Walpaper', N'/img/portfolio/CD3.jpg')
INSERT [dbo].[Portfolios] ([ID], [Header], [Description], [PhotoUrl]) VALUES (4, N'Cyber Design', N'Art,Walpaper', N'/img/portfolio/CD4.jpg')
INSERT [dbo].[Portfolios] ([ID], [Header], [Description], [PhotoUrl]) VALUES (5, N'Cyber Design', N'Art,Walpaper', N'/img/portfolio/CD5.jpg')
INSERT [dbo].[Portfolios] ([ID], [Header], [Description], [PhotoUrl]) VALUES (6, N'Cyber Design', N'Art,Walpaper', N'/img/portfolio/CD6.jpg')
INSERT [dbo].[Portfolios] ([ID], [Header], [Description], [PhotoUrl]) VALUES (7, N'Cyber Design', N'Art,Walpaper', N'/img/portfolio/CD7.jpg')
SET IDENTITY_INSERT [dbo].[Portfolios] OFF
GO
SET IDENTITY_INSERT [dbo].[Section1] ON 

INSERT [dbo].[Section1] ([ID], [SubHeader], [Header], [WorkArea], [PhotoUrl]) VALUES (1, N'By Aliesso', N'Xoş Gəlidin Cyber', N'Developer', N'94095dc2-7cd1-477a-8fe6-607fc455afa6_Cyberpunk 2077 Keanu John Wick iPhone Wallpaper - iPhone Wallpapers.jpg')
SET IDENTITY_INSERT [dbo].[Section1] OFF
GO
SET IDENTITY_INSERT [dbo].[SectionAbouts] ON 

INSERT [dbo].[SectionAbouts] ([ID], [PhotoUrl], [Header], [Description]) VALUES (1, N'/img/cyberabout.jpg', N'Aliesso', N'İşimiz hoqqa verməkdir')
SET IDENTITY_INSERT [dbo].[SectionAbouts] OFF
GO
SET IDENTITY_INSERT [dbo].[SectionServices] ON 

INSERT [dbo].[SectionServices] ([ID], [Header], [Description], [Icon]) VALUES (1, N'Web Developer', N'Hər cür sayt bizdə', N'/img/services/s1.png')
INSERT [dbo].[SectionServices] ([ID], [Header], [Description], [Icon]) VALUES (2, N'Ux Design', N'Dizayn bizdən soruşun', N'/img/services/s2.png')
INSERT [dbo].[SectionServices] ([ID], [Header], [Description], [Icon]) VALUES (3, N'Wordpress Developer', N'Wordpressi bizdən soruşun', N'/img/services/s3.png')
SET IDENTITY_INSERT [dbo].[SectionServices] OFF
GO
SET IDENTITY_INSERT [dbo].[Testimonials] ON 

INSERT [dbo].[Testimonials] ([ID], [PhotoUrl], [Fullname], [WorkArea], [Rating], [Description]) VALUES (2, N'/img/blog/popular-post/post8.jpg', N'Aliesso', N'Web Developer', 5, N'Developer olmaq üçün oturub layihə işləmək lazımdır.')
INSERT [dbo].[Testimonials] ([ID], [PhotoUrl], [Fullname], [WorkArea], [Rating], [Description]) VALUES (3, N'/img/blog/popular-post/post9.jpg', N'Jasmin', N'Fronted', 3, N'html css javascript öyrən getdi ömrüvün axrına kimi.')
SET IDENTITY_INSERT [dbo].[Testimonials] OFF
GO
