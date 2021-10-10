USE [VP_CLASS]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 11-Oct-21 1:00:07 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[Email] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Cellphone] [nvarchar](20) NOT NULL,
	[Age] [nvarchar](50) NOT NULL,
	[Education] [nvarchar](50) NOT NULL,
	[Salary] [int] NOT NULL,
	[Department] [nvarchar](50) NOT NULL,
	[Position] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO

