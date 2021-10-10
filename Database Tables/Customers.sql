USE [VP_CLASS]
GO

/****** Object:  Table [dbo].[Customers]    Script Date: 11-Oct-21 12:59:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customers](
	[Email] [nvarchar](50) NOT NULL,
	[First_Name] [nvarchar](50) NOT NULL,
	[Last_Name] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Balance] [int] NOT NULL,
	[Orders] [int] NOT NULL
) ON [PRIMARY]
GO

