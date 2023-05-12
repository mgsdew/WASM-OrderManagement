
USE [dbOrderMgt]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/12/2023 6:23:47 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Element]    Script Date: 5/12/2023 6:23:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Element](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[WindowId] [int] NOT NULL,
	[ElementTypeId] [int] NOT NULL,
	[Width] [decimal](18, 2) NOT NULL,
	[Height] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Element] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ElementType]    Script Date: 5/12/2023 6:23:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ElementType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ElementType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 5/12/2023 6:23:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[StateId] [int] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[State]    Script Date: 5/12/2023 6:23:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[State](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Window]    Script Date: 5/12/2023 6:23:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Window](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[QuantityOfWindows] [int] NOT NULL,
	[TotalSubElements] [int] NOT NULL,
 CONSTRAINT [PK_Window] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230328033000_InitialCreate', N'7.0.4')
GO
SET IDENTITY_INSERT [dbo].[ElementType] ON 
GO
INSERT [dbo].[ElementType] ([Id], [Name]) VALUES (1, N'Doors')
GO
INSERT [dbo].[ElementType] ([Id], [Name]) VALUES (2, N'Window')
GO
INSERT [dbo].[ElementType] ([Id], [Name]) VALUES (1002, N'test - 1')
GO
INSERT [dbo].[ElementType] ([Id], [Name]) VALUES (2002, N'test - 02')
GO
INSERT [dbo].[ElementType] ([Id], [Name]) VALUES (2003, N'test - 03')
GO
INSERT [dbo].[ElementType] ([Id], [Name]) VALUES (2004, N'test - 04')
GO
INSERT [dbo].[ElementType] ([Id], [Name]) VALUES (2005, N'test - 09')
GO
INSERT [dbo].[ElementType] ([Id], [Name]) VALUES (2006, N'test -10')
GO
INSERT [dbo].[ElementType] ([Id], [Name]) VALUES (2007, N'test -110')
GO
INSERT [dbo].[ElementType] ([Id], [Name]) VALUES (2008, N'test - 12')
GO
INSERT [dbo].[ElementType] ([Id], [Name]) VALUES (2009, N'test -12')
GO
INSERT [dbo].[ElementType] ([Id], [Name]) VALUES (2010, N'test -13')
GO
SET IDENTITY_INSERT [dbo].[ElementType] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 
GO
INSERT [dbo].[Order] ([Id], [Name], [StateId]) VALUES (2, N'New York Building 1', 1)
GO
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[State] ON 
GO
INSERT [dbo].[State] ([Id], [Name]) VALUES (1, N'NY 00')
GO
INSERT [dbo].[State] ([Id], [Name]) VALUES (2, N'Dhaka')
GO
INSERT [dbo].[State] ([Id], [Name]) VALUES (3, N'Test - 01')
GO
INSERT [dbo].[State] ([Id], [Name]) VALUES (4, N'test - 2')
GO
SET IDENTITY_INSERT [dbo].[State] OFF
GO
/****** Object:  Index [IX_Element_ElementTypeId]    Script Date: 5/12/2023 6:23:47 PM ******/
CREATE NONCLUSTERED INDEX [IX_Element_ElementTypeId] ON [dbo].[Element]
(
	[ElementTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Element_WindowId]    Script Date: 5/12/2023 6:23:47 PM ******/
CREATE NONCLUSTERED INDEX [IX_Element_WindowId] ON [dbo].[Element]
(
	[WindowId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Order_StateId]    Script Date: 5/12/2023 6:23:47 PM ******/
CREATE NONCLUSTERED INDEX [IX_Order_StateId] ON [dbo].[Order]
(
	[StateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Window_OrderId]    Script Date: 5/12/2023 6:23:47 PM ******/
CREATE NONCLUSTERED INDEX [IX_Window_OrderId] ON [dbo].[Window]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Element]  WITH CHECK ADD  CONSTRAINT [FK_Element_ElementType_ElementTypeId] FOREIGN KEY([ElementTypeId])
REFERENCES [dbo].[ElementType] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Element] CHECK CONSTRAINT [FK_Element_ElementType_ElementTypeId]
GO
ALTER TABLE [dbo].[Element]  WITH CHECK ADD  CONSTRAINT [FK_Element_Window_WindowId] FOREIGN KEY([WindowId])
REFERENCES [dbo].[Window] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Element] CHECK CONSTRAINT [FK_Element_Window_WindowId]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_State_StateId] FOREIGN KEY([StateId])
REFERENCES [dbo].[State] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_State_StateId]
GO
ALTER TABLE [dbo].[Window]  WITH CHECK ADD  CONSTRAINT [FK_Window_Order_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Window] CHECK CONSTRAINT [FK_Window_Order_OrderId]
GO
USE [master]
GO
ALTER DATABASE [dbOrderMgt] SET  READ_WRITE 
GO
