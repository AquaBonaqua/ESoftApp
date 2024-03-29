USE [eSoft]
GO
/****** Object:  Table [dbo].[Coef]    Script Date: 19.09.2019 17:12:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coef](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Analysis] [decimal](10, 2) NOT NULL,
	[Deployment] [decimal](10, 2) NOT NULL,
	[Support] [decimal](10, 2) NOT NULL,
	[Time] [decimal](10, 2) NOT NULL,
	[Difficulty] [decimal](10, 2) NOT NULL,
	[Transfer] [decimal](10, 2) NOT NULL,
	[GradeCoefId] [int] NOT NULL,
 CONSTRAINT [PK_Coef] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Executor]    Script Date: 19.09.2019 17:12:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Executor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NULL,
	[GradeId] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[ManagerId] [int] NULL,
	[IV] [nvarchar](max) NULL,
	[V] [nvarchar](max) NULL,
 CONSTRAINT [PK_Executor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 19.09.2019 17:12:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Grade_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GradeCoef]    Script Date: 19.09.2019 17:12:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GradeCoef](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Junior] [decimal](10, 2) NOT NULL,
	[Middle] [decimal](10, 2) NOT NULL,
	[Senior] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_Grade] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kind]    Script Date: 19.09.2019 17:12:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kind](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Kind] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 19.09.2019 17:12:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NOT NULL,
	[CoefId] [int] NOT NULL,
	[IV] [nvarchar](max) NULL,
	[V] [nvarchar](max) NULL,
 CONSTRAINT [PK_Manager] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 19.09.2019 17:12:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Task]    Script Date: 19.09.2019 17:12:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Task](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Difficulty] [int] NOT NULL,
	[StatusId] [int] NOT NULL,
	[KindId] [int] NOT NULL,
	[StartTime] [datetime] NULL,
	[FinishTime] [datetime] NULL,
	[CompleteDate] [date] NULL,
	[CompletePeriod] [int] NULL,
	[CompleteTime] [int] NULL,
	[Info] [nvarchar](max) NULL,
	[ExecutorId] [int] NULL,
 CONSTRAINT [PK_Task] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Coef] ON 

INSERT [dbo].[Coef] ([Id], [Analysis], [Deployment], [Support], [Time], [Difficulty], [Transfer], [GradeCoefId]) VALUES (1, CAST(0.80 AS Decimal(10, 2)), CAST(0.71 AS Decimal(10, 2)), CAST(0.40 AS Decimal(10, 2)), CAST(1.95 AS Decimal(10, 2)), CAST(2.56 AS Decimal(10, 2)), CAST(1.88 AS Decimal(10, 2)), 1)
INSERT [dbo].[Coef] ([Id], [Analysis], [Deployment], [Support], [Time], [Difficulty], [Transfer], [GradeCoefId]) VALUES (2, CAST(0.80 AS Decimal(10, 2)), CAST(0.50 AS Decimal(10, 2)), CAST(0.20 AS Decimal(10, 2)), CAST(1.50 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), CAST(195.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Coef] ([Id], [Analysis], [Deployment], [Support], [Time], [Difficulty], [Transfer], [GradeCoefId]) VALUES (3, CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)), CAST(0.20 AS Decimal(10, 2)), CAST(3.40 AS Decimal(10, 2)), CAST(2.90 AS Decimal(10, 2)), CAST(250.00 AS Decimal(10, 2)), 3)
SET IDENTITY_INSERT [dbo].[Coef] OFF
SET IDENTITY_INSERT [dbo].[Executor] ON 

INSERT [dbo].[Executor] ([Id], [Login], [Password], [GradeId], [Name], [ManagerId], [IV], [V]) VALUES (1, N'galiulina', N'galiulina', 1, N'Галиуллина Альбина  Нафисовна', 1, NULL, NULL)
INSERT [dbo].[Executor] ([Id], [Login], [Password], [GradeId], [Name], [ManagerId], [IV], [V]) VALUES (2, N'kudryashov', N'kudryashov', 2, N'Кудряшов Александр  Витальевич', 1, NULL, NULL)
INSERT [dbo].[Executor] ([Id], [Login], [Password], [GradeId], [Name], [ManagerId], [IV], [V]) VALUES (3, N'velizhanina', N'velizhanina', 3, N'Велижанина Светлана  Николаевна', 2, NULL, NULL)
INSERT [dbo].[Executor] ([Id], [Login], [Password], [GradeId], [Name], [ManagerId], [IV], [V]) VALUES (4, N'plotnikova', N'plotnikova', 1, N'Плотникова Алевтина  Валентиновна', 2, NULL, NULL)
INSERT [dbo].[Executor] ([Id], [Login], [Password], [GradeId], [Name], [ManagerId], [IV], [V]) VALUES (5, N'malcev', N'malcev', 2, N'Мальцев Александр  Сергеевич', 2, NULL, NULL)
INSERT [dbo].[Executor] ([Id], [Login], [Password], [GradeId], [Name], [ManagerId], [IV], [V]) VALUES (6, N'morozova', N'morozova', 1, N'Морозова Екатерина  Владимировна', 3, NULL, NULL)
INSERT [dbo].[Executor] ([Id], [Login], [Password], [GradeId], [Name], [ManagerId], [IV], [V]) VALUES (7, N'pyankova', N'pyankova', 1, N'Пьянкова Анастасия  Борисовна', 3, NULL, NULL)
INSERT [dbo].[Executor] ([Id], [Login], [Password], [GradeId], [Name], [ManagerId], [IV], [V]) VALUES (14, N'dima', N'YMuBV8nq8T8Hn60qY4IwCA==', 1, NULL, NULL, N'9ly7b8srwg6lhbuz', N'po1aar59z3vqhuo0u79v2tjdg7w0f6ml')
SET IDENTITY_INSERT [dbo].[Executor] OFF
SET IDENTITY_INSERT [dbo].[Grade] ON 

INSERT [dbo].[Grade] ([Id], [Name]) VALUES (1, N'Junior')
INSERT [dbo].[Grade] ([Id], [Name]) VALUES (2, N'Middle')
INSERT [dbo].[Grade] ([Id], [Name]) VALUES (3, N'Senior')
SET IDENTITY_INSERT [dbo].[Grade] OFF
SET IDENTITY_INSERT [dbo].[GradeCoef] ON 

INSERT [dbo].[GradeCoef] ([Id], [Junior], [Middle], [Senior]) VALUES (1, CAST(10600.00 AS Decimal(10, 2)), CAST(20000.00 AS Decimal(10, 2)), CAST(30000.00 AS Decimal(10, 2)))
INSERT [dbo].[GradeCoef] ([Id], [Junior], [Middle], [Senior]) VALUES (2, CAST(12000.00 AS Decimal(10, 2)), CAST(24000.00 AS Decimal(10, 2)), CAST(36000.00 AS Decimal(10, 2)))
INSERT [dbo].[GradeCoef] ([Id], [Junior], [Middle], [Senior]) VALUES (3, CAST(5000.00 AS Decimal(10, 2)), CAST(15000.00 AS Decimal(10, 2)), CAST(30000.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[GradeCoef] OFF
SET IDENTITY_INSERT [dbo].[Kind] ON 

INSERT [dbo].[Kind] ([Id], [Name]) VALUES (1, N'Analysis')
INSERT [dbo].[Kind] ([Id], [Name]) VALUES (2, N'Deployment')
INSERT [dbo].[Kind] ([Id], [Name]) VALUES (3, N'Support')
SET IDENTITY_INSERT [dbo].[Kind] OFF
SET IDENTITY_INSERT [dbo].[Manager] ON 

INSERT [dbo].[Manager] ([Id], [Login], [Password], [Name], [CoefId], [IV], [V]) VALUES (1, N'kukleva', N'oxjWU4wJSY31myZ9w8GD3w==', N'Куклева Дарья  Владимировна', 1, NULL, NULL)
INSERT [dbo].[Manager] ([Id], [Login], [Password], [Name], [CoefId], [IV], [V]) VALUES (2, N'kremlev', N'O9PYaep5Lr4IPYslyZWNfQ==', N'Кремлев Владислав  Юрьевич', 2, NULL, NULL)
INSERT [dbo].[Manager] ([Id], [Login], [Password], [Name], [CoefId], [IV], [V]) VALUES (3, N'kuklev', N'OqZ4d2xfRQ085cMBrUo61Q==', N'Лавринов Андрей  Борисович', 3, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Manager] OFF
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([Id], [Name]) VALUES (1, N'Plan')
INSERT [dbo].[Status] ([Id], [Name]) VALUES (2, N'Execute')
INSERT [dbo].[Status] ([Id], [Name]) VALUES (3, N'Finish')
INSERT [dbo].[Status] ([Id], [Name]) VALUES (4, N'Cancel')
SET IDENTITY_INSERT [dbo].[Status] OFF
INSERT [dbo].[Task] ([Id], [Name], [Difficulty], [StatusId], [KindId], [StartTime], [FinishTime], [CompleteDate], [CompletePeriod], [CompleteTime], [Info], [ExecutorId]) VALUES (4, N'Подготовить коммерческое предложение для "Евросеть"', 45, 2, 2, NULL, NULL, CAST(N'2019-09-20' AS Date), 13, 20000, N'Задача 4', 2)
INSERT [dbo].[Task] ([Id], [Name], [Difficulty], [StatusId], [KindId], [StartTime], [FinishTime], [CompleteDate], [CompletePeriod], [CompleteTime], [Info], [ExecutorId]) VALUES (5, N'Подготовить коммерческое предложение для "Дикси"', 35, 1, 2, NULL, NULL, NULL, NULL, NULL, N'Задача 5', 3)
INSERT [dbo].[Task] ([Id], [Name], [Difficulty], [StatusId], [KindId], [StartTime], [FinishTime], [CompleteDate], [CompletePeriod], [CompleteTime], [Info], [ExecutorId]) VALUES (6, N'Установка оборудования для "ООО Магнит"', 32, 1, 2, NULL, NULL, NULL, NULL, NULL, N'Задача 6', 4)
INSERT [dbo].[Task] ([Id], [Name], [Difficulty], [StatusId], [KindId], [StartTime], [FinishTime], [CompleteDate], [CompletePeriod], [CompleteTime], [Info], [ExecutorId]) VALUES (7, N'Установка оборудования для "Бристоль"', 24, 1, 2, NULL, NULL, NULL, NULL, NULL, N'Задача 7', 5)
INSERT [dbo].[Task] ([Id], [Name], [Difficulty], [StatusId], [KindId], [StartTime], [FinishTime], [CompleteDate], [CompletePeriod], [CompleteTime], [Info], [ExecutorId]) VALUES (8, N'Отправить пригласительные письма потенциальным клиентам', 15, 1, 2, NULL, NULL, NULL, NULL, NULL, N'Задача 8', 6)
INSERT [dbo].[Task] ([Id], [Name], [Difficulty], [StatusId], [KindId], [StartTime], [FinishTime], [CompleteDate], [CompletePeriod], [CompleteTime], [Info], [ExecutorId]) VALUES (9, N'Отработать возражения от "Пчелки"', 34, 1, 2, NULL, NULL, NULL, NULL, NULL, N'Задача 9', 7)
ALTER TABLE [dbo].[Coef]  WITH CHECK ADD  CONSTRAINT [FK_Coef_GradeCoef] FOREIGN KEY([GradeCoefId])
REFERENCES [dbo].[GradeCoef] ([Id])
GO
ALTER TABLE [dbo].[Coef] CHECK CONSTRAINT [FK_Coef_GradeCoef]
GO
ALTER TABLE [dbo].[Executor]  WITH CHECK ADD  CONSTRAINT [FK_Executor_Grade] FOREIGN KEY([GradeId])
REFERENCES [dbo].[Grade] ([Id])
GO
ALTER TABLE [dbo].[Executor] CHECK CONSTRAINT [FK_Executor_Grade]
GO
ALTER TABLE [dbo].[Executor]  WITH CHECK ADD  CONSTRAINT [FK_Executor_Manager] FOREIGN KEY([ManagerId])
REFERENCES [dbo].[Manager] ([Id])
GO
ALTER TABLE [dbo].[Executor] CHECK CONSTRAINT [FK_Executor_Manager]
GO
ALTER TABLE [dbo].[Manager]  WITH CHECK ADD  CONSTRAINT [FK_Manager_Coef] FOREIGN KEY([CoefId])
REFERENCES [dbo].[Coef] ([Id])
GO
ALTER TABLE [dbo].[Manager] CHECK CONSTRAINT [FK_Manager_Coef]
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_Executor] FOREIGN KEY([ExecutorId])
REFERENCES [dbo].[Executor] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Executor]
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_Kind] FOREIGN KEY([KindId])
REFERENCES [dbo].[Kind] ([Id])
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Kind]
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Status]
GO
