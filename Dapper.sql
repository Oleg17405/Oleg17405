USE [master]
GO
/****** Object:  Database [DapperTest]    Script Date: 20.05.2024 14:35:20 ******/
CREATE DATABASE [DapperTest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DapperTest', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.OLEGSQL2\MSSQL\DATA\DapperTest.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DapperTest_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.OLEGSQL2\MSSQL\DATA\DapperTest_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DapperTest] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DapperTest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DapperTest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DapperTest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DapperTest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DapperTest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DapperTest] SET ARITHABORT OFF 
GO
ALTER DATABASE [DapperTest] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DapperTest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DapperTest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DapperTest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DapperTest] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DapperTest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DapperTest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DapperTest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DapperTest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DapperTest] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DapperTest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DapperTest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DapperTest] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DapperTest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DapperTest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DapperTest] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DapperTest] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DapperTest] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DapperTest] SET  MULTI_USER 
GO
ALTER DATABASE [DapperTest] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DapperTest] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DapperTest] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DapperTest] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DapperTest] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DapperTest] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DapperTest] SET QUERY_STORE = OFF
GO
USE [DapperTest]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 20.05.2024 14:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[id_Product] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[id_Product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 20.05.2024 14:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id_User] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id_User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([id_Product], [Name], [Price]) VALUES (1, N'HHD', 150)
INSERT [dbo].[Products] ([id_Product], [Name], [Price]) VALUES (3, N'CD Disk', 200)
INSERT [dbo].[Products] ([id_Product], [Name], [Price]) VALUES (4, N'RAM', 500)
INSERT [dbo].[Products] ([id_Product], [Name], [Price]) VALUES (5, N'ROM', 2000)
INSERT [dbo].[Products] ([id_Product], [Name], [Price]) VALUES (7, N'SSD', 5000)
INSERT [dbo].[Products] ([id_Product], [Name], [Price]) VALUES (8, N'Motherboard', 10000)
INSERT [dbo].[Products] ([id_Product], [Name], [Price]) VALUES (9, N'Monitor', 8000)
INSERT [dbo].[Products] ([id_Product], [Name], [Price]) VALUES (10, N'Keyboard', 18000)
INSERT [dbo].[Products] ([id_Product], [Name], [Price]) VALUES (11, N'Mouse', 15000)
INSERT [dbo].[Products] ([id_Product], [Name], [Price]) VALUES (12, N'GraphicsCard', 10000)
INSERT [dbo].[Products] ([id_Product], [Name], [Price]) VALUES (13, N'SoundCard', 4000)
INSERT [dbo].[Products] ([id_Product], [Name], [Price]) VALUES (14, N'NIC', 10000)
INSERT [dbo].[Products] ([id_Product], [Name], [Price]) VALUES (15, N'CPU', 12000)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id_User], [Login], [Password], [Name]) VALUES (1, N'User1', N'1234', N'Oleg')
INSERT [dbo].[Users] ([id_User], [Login], [Password], [Name]) VALUES (2, N'User2', N'ssa', N'Nik')
INSERT [dbo].[Users] ([id_User], [Login], [Password], [Name]) VALUES (3, N'User3', N'Man', N'Aleksandr')
INSERT [dbo].[Users] ([id_User], [Login], [Password], [Name]) VALUES (4, N'User4', N'321', N'Mikhail')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
USE [master]
GO
ALTER DATABASE [DapperTest] SET  READ_WRITE 
GO
