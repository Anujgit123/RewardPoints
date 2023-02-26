USE [RewardPoints]
GO
/****** Object:  Table [dbo].[RewardPoints]    Script Date: 26-02-2023 20:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RewardPoints](
	[CustomerID] [int] NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[Month] [nvarchar](20) NOT NULL,
	[Transaction] [decimal](18, 2) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[ModifiedBy] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[RewardPoints] ([CustomerID], [CustomerName], [Month], [Transaction], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy]) VALUES (1, N'John', N'January', CAST(70.00 AS Decimal(18, 2)), CAST(N'2023-02-26T20:07:01.657' AS DateTime), CAST(N'2023-02-26T20:07:01.657' AS DateTime), N'Admin', N'Admin')
GO
INSERT [dbo].[RewardPoints] ([CustomerID], [CustomerName], [Month], [Transaction], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy]) VALUES (1, N'John', N'February', CAST(120.00 AS Decimal(18, 2)), CAST(N'2023-02-26T20:07:29.927' AS DateTime), CAST(N'2023-02-26T20:07:29.927' AS DateTime), N'Admin', N'Admin')
GO
INSERT [dbo].[RewardPoints] ([CustomerID], [CustomerName], [Month], [Transaction], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy]) VALUES (1, N'John', N'March', CAST(250.00 AS Decimal(18, 2)), CAST(N'2023-02-26T20:07:47.090' AS DateTime), CAST(N'2023-02-26T20:07:47.090' AS DateTime), N'Admin', N'Admin')
GO
INSERT [dbo].[RewardPoints] ([CustomerID], [CustomerName], [Month], [Transaction], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy]) VALUES (2, N'David', N'January', CAST(80.00 AS Decimal(18, 2)), CAST(N'2023-02-26T20:08:08.003' AS DateTime), CAST(N'2023-02-26T20:08:08.003' AS DateTime), N'Admin', N'Admin')
GO
INSERT [dbo].[RewardPoints] ([CustomerID], [CustomerName], [Month], [Transaction], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy]) VALUES (2, N'David', N'February', CAST(300.00 AS Decimal(18, 2)), CAST(N'2023-02-26T20:08:51.847' AS DateTime), CAST(N'2023-02-26T20:08:51.847' AS DateTime), N'Admin', N'Admin')
GO
INSERT [dbo].[RewardPoints] ([CustomerID], [CustomerName], [Month], [Transaction], [CreatedDate], [ModifiedDate], [CreatedBy], [ModifiedBy]) VALUES (2, N'David', N'March', CAST(600.00 AS Decimal(18, 2)), CAST(N'2023-02-26T20:09:07.990' AS DateTime), CAST(N'2023-02-26T20:09:07.990' AS DateTime), N'Admin', N'Admin')
GO
