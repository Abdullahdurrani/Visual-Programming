USE [master]
GO
/****** Object:  Database [VP_CLASS]    Script Date: 30-Oct-21 5:05:06 PM ******/
CREATE DATABASE [VP_CLASS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VP_CLASS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\VP_CLASS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VP_CLASS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\VP_CLASS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [VP_CLASS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VP_CLASS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VP_CLASS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VP_CLASS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VP_CLASS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VP_CLASS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VP_CLASS] SET ARITHABORT OFF 
GO
ALTER DATABASE [VP_CLASS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VP_CLASS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VP_CLASS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VP_CLASS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VP_CLASS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VP_CLASS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VP_CLASS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VP_CLASS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VP_CLASS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VP_CLASS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VP_CLASS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VP_CLASS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VP_CLASS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VP_CLASS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VP_CLASS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VP_CLASS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VP_CLASS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VP_CLASS] SET RECOVERY FULL 
GO
ALTER DATABASE [VP_CLASS] SET  MULTI_USER 
GO
ALTER DATABASE [VP_CLASS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VP_CLASS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VP_CLASS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VP_CLASS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VP_CLASS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VP_CLASS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'VP_CLASS', N'ON'
GO
ALTER DATABASE [VP_CLASS] SET QUERY_STORE = OFF
GO
USE [VP_CLASS]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 30-Oct-21 5:05:06 PM ******/
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
/****** Object:  Table [dbo].[Employees]    Script Date: 30-Oct-21 5:05:06 PM ******/
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
/****** Object:  Table [dbo].[Products]    Script Date: 30-Oct-21 5:05:06 PM ******/
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
/****** Object:  Table [dbo].[Students]    Script Date: 30-Oct-21 5:05:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Degree] [nvarchar](50) NOT NULL,
	[Department] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[CGPA] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 30-Oct-21 5:05:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[Id] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[CreditHours] [int] NOT NULL,
	[Department] [nvarchar](50) NOT NULL,
	[Teacher] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 30-Oct-21 5:05:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Education] [nvarchar](50) NOT NULL,
	[Department] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Designation] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 30-Oct-21 5:05:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](20) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Customers] ([Email], [First_Name], [Last_Name], [Phone], [Address], [City], [Balance], [Orders]) VALUES (N'abd', N'abd', N'bd', N'123', N'asda', N'asda', 55, 56)
GO
INSERT [dbo].[Employees] ([Email], [Name], [Cellphone], [Age], [Education], [Salary], [Department], [Position]) VALUES (N'', N'Form1', N'', N'0', N'', 0, N'', N'')
INSERT [dbo].[Employees] ([Email], [Name], [Cellphone], [Age], [Education], [Salary], [Department], [Position]) VALUES (N'abd@email', N'abdullah', N'1234', N'21', N'BS', 30, N'CS', N'Dev')
INSERT [dbo].[Employees] ([Email], [Name], [Cellphone], [Age], [Education], [Salary], [Department], [Position]) VALUES (N'obi@email', N'obi', N'456', N'21', N'BS', 40, N'GD', N'Graphics Designer')
GO
INSERT [dbo].[Products] ([Id], [Title], [Description], [Category], [SubCategory], [Price], [Weight], [Color], [Items_Available]) VALUES (1, N'asdasd', N'abca', N'asdas', N'wqeqw', 5, 5, N'grey', 12)
GO
INSERT [dbo].[Students] ([Id], [Name], [Email], [Degree], [Department], [Address], [CGPA]) VALUES (1, N'stude1', N'stud1@email', N'MSC', N'CS', N'rwp', 3.5)
GO
INSERT [dbo].[Subjects] ([Id], [Title], [CreditHours], [Department], [Teacher]) VALUES (1, N'Visual Programming', 4, N'CS', N'Sir Zain')
INSERT [dbo].[Subjects] ([Id], [Title], [CreditHours], [Department], [Teacher]) VALUES (2, N'AI', 3, N'AI', N'abcad')
GO
INSERT [dbo].[Teachers] ([Id], [Name], [Email], [Education], [Department], [Address], [Designation]) VALUES (1, N'abc', N'abc@email', N'BS', N'CS', N'Isb', N'Prof')
INSERT [dbo].[Teachers] ([Id], [Name], [Email], [Education], [Department], [Address], [Designation]) VALUES (2, N'qwe', N'qwe@email', N'MS', N'GD', N'Rwp', N'Ast Prof')
GO
INSERT [dbo].[Users] ([FirstName], [LastName], [Email]) VALUES (N'abd', N'abd@email', N'123')
INSERT [dbo].[Users] ([FirstName], [LastName], [Email]) VALUES (N'abdullah', N'abdullah@email', N'123')
INSERT [dbo].[Users] ([FirstName], [LastName], [Email]) VALUES (N'ahti', N'mughl', N'ahti@email')
INSERT [dbo].[Users] ([FirstName], [LastName], [Email]) VALUES (N'zubi', N'quershi', N'zubs@email')
GO
USE [master]
GO
ALTER DATABASE [VP_CLASS] SET  READ_WRITE 
GO
