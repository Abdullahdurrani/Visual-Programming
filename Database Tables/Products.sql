USE [VP_CLASS]
GO

/****** Object:  Table [dbo].[Products]    Script Date: 11-Oct-21 1:00:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
	[Id] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
	[SubCategory] [nvarchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[Weight] [int] NOT NULL,
	[Color] [nvarchar](50) NOT NULL,
	[Items_Available] [int] NOT NULL
) ON [PRIMARY]
GO

