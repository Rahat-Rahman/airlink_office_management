/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2014 (12.0.2269)
    Source Database Engine Edition : Microsoft SQL Server Enterprise Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [AirlinkDb]    Script Date: 2/23/2018 12:50:03 PM ******/
CREATE DATABASE [AirlinkDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AirlinkDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\AirlinkDb.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AirlinkDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\AirlinkDb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AirlinkDb] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AirlinkDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AirlinkDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AirlinkDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AirlinkDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AirlinkDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AirlinkDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [AirlinkDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AirlinkDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AirlinkDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AirlinkDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AirlinkDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AirlinkDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AirlinkDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AirlinkDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AirlinkDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AirlinkDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AirlinkDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AirlinkDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AirlinkDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AirlinkDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AirlinkDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AirlinkDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AirlinkDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AirlinkDb] SET RECOVERY FULL 
GO
ALTER DATABASE [AirlinkDb] SET  MULTI_USER 
GO
ALTER DATABASE [AirlinkDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AirlinkDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AirlinkDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AirlinkDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [AirlinkDb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'AirlinkDb', N'ON'
GO
USE [AirlinkDb]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 2/23/2018 12:50:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeTable]    Script Date: 2/23/2018 12:50:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeTable](
	[Id] [nchar](30) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[DOB] [datetime] NOT NULL,
	[Designation] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](150) NOT NULL,
	[departmentId] [int] NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[ProfilePic] [nvarchar](100) NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EmployeeTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExportRequest]    Script Date: 2/23/2018 12:50:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExportRequest](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [int] NOT NULL,
	[ReceiverName] [nvarchar](100) NOT NULL,
	[ReceiverCountry] [nvarchar](100) NOT NULL,
	[ReceiverAddress] [nvarchar](300) NOT NULL,
	[ReceiverContactNo] [nvarchar](80) NOT NULL,
	[SenderName] [nvarchar](100) NOT NULL,
	[SenderAddress] [nvarchar](300) NOT NULL,
	[SenderContactNo] [nvarchar](50) NOT NULL,
	[ParcelType] [nvarchar](50) NOT NULL,
	[Medium] [nvarchar](50) NULL,
	[AirbillNo] [nvarchar](100) NULL,
 CONSTRAINT [PK_ExportRequest] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ImportRequest]    Script Date: 2/23/2018 12:50:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportRequest](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [int] NOT NULL,
	[SenderName] [nvarchar](100) NOT NULL,
	[SenderContactNo] [nvarchar](50) NOT NULL,
	[Medium] [nvarchar](50) NULL,
	[AirbillNo] [nvarchar](50) NULL,
	[ReceiverName] [nvarchar](100) NOT NULL,
	[ReceiverAddress] [nvarchar](300) NOT NULL,
	[ReceiverContact] [nvarchar](50) NOT NULL,
	[ParcelType] [nvarchar](50) NOT NULL,
	[IsArrived] [bit] NULL,
 CONSTRAINT [PK_ImportRequest] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rate]    Script Date: 2/23/2018 12:50:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rate](
	[RatesID] [int] IDENTITY(10,1) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[DHLRate] [int] NOT NULL,
	[TNTRate] [int] NOT NULL,
	[DPEXRate] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Rates] PRIMARY KEY CLUSTERED 
(
	[RatesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([Id], [Name]) VALUES (1, N'Admin')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (2, N'Export and Import')
SET IDENTITY_INSERT [dbo].[Department] OFF
INSERT [dbo].[EmployeeTable] ([Id], [Name], [DOB], [Designation], [Email], [departmentId], [Username], [ProfilePic], [Password]) VALUES (N'1-1                           ', N'Md Shiefuzzaman', CAST(N'1984-10-09T00:00:00.000' AS DateTime), N'CEO', N'saif_vues@aiub.edu', 1, N'Saiff', N'pic1.jpg', N'saif')
INSERT [dbo].[EmployeeTable] ([Id], [Name], [DOB], [Designation], [Email], [departmentId], [Username], [ProfilePic], [Password]) VALUES (N'1-2                           ', N'Rahat', CAST(N'1996-08-13T00:00:00.000' AS DateTime), N'Export Executive', N'rahatrm13@gmail.com', 2, N'Rahat', N'fff.jpg', N'rahat')
SET IDENTITY_INSERT [dbo].[ExportRequest] ON 

INSERT [dbo].[ExportRequest] ([Id], [Status], [ReceiverName], [ReceiverCountry], [ReceiverAddress], [ReceiverContactNo], [SenderName], [SenderAddress], [SenderContactNo], [ParcelType], [Medium], [AirbillNo]) VALUES (15, 3, N'Bony', N'USA', N'Newyork', N'0155889966', N'Akif', N'125 dohs', N'0178236589', N'Box', NULL, NULL)
INSERT [dbo].[ExportRequest] ([Id], [Status], [ReceiverName], [ReceiverCountry], [ReceiverAddress], [ReceiverContactNo], [SenderName], [SenderAddress], [SenderContactNo], [ParcelType], [Medium], [AirbillNo]) VALUES (16, 3, N'abcd', N'Usa', N'new street', N'05589652', N'Rahatt', N'32/da', N'014785236', N'box', NULL, NULL)
INSERT [dbo].[ExportRequest] ([Id], [Status], [ReceiverName], [ReceiverCountry], [ReceiverAddress], [ReceiverContactNo], [SenderName], [SenderAddress], [SenderContactNo], [ParcelType], [Medium], [AirbillNo]) VALUES (18, 2, N'asdc', N'yyyy', N'rty', N'yyyy', N'wer', N'aser', N'1458', N'vas', N'DHL', N'124569')
INSERT [dbo].[ExportRequest] ([Id], [Status], [ReceiverName], [ReceiverCountry], [ReceiverAddress], [ReceiverContactNo], [SenderName], [SenderAddress], [SenderContactNo], [ParcelType], [Medium], [AirbillNo]) VALUES (19, 2, N'asd', N'yyyy', N'rty', N'01552233669', N'wer', N'aser', N'1458', N'vas', NULL, NULL)
INSERT [dbo].[ExportRequest] ([Id], [Status], [ReceiverName], [ReceiverCountry], [ReceiverAddress], [ReceiverContactNo], [SenderName], [SenderAddress], [SenderContactNo], [ParcelType], [Medium], [AirbillNo]) VALUES (20, 2, N'Joy', N'USA', N'56 Down Town', N'223355999', N'Akif', N'Mirpur Dohs', N'0152266998', N'Garments', N'DHL', NULL)
INSERT [dbo].[ExportRequest] ([Id], [Status], [ReceiverName], [ReceiverCountry], [ReceiverAddress], [ReceiverContactNo], [SenderName], [SenderAddress], [SenderContactNo], [ParcelType], [Medium], [AirbillNo]) VALUES (21, 1, N'Root', N'Canada', N'8 Park Street', N'55697236', N'Sumaiya', N'Mohakhali', N'01752363658', N'Garments', N'DPEX', NULL)
INSERT [dbo].[ExportRequest] ([Id], [Status], [ReceiverName], [ReceiverCountry], [ReceiverAddress], [ReceiverContactNo], [SenderName], [SenderAddress], [SenderContactNo], [ParcelType], [Medium], [AirbillNo]) VALUES (22, 2, N'errrr', N'bd', N'tttt4444', N'444', N'rrr', N'ttt', N'tttt', N'tech', N'DHL', NULL)
INSERT [dbo].[ExportRequest] ([Id], [Status], [ReceiverName], [ReceiverCountry], [ReceiverAddress], [ReceiverContactNo], [SenderName], [SenderAddress], [SenderContactNo], [ParcelType], [Medium], [AirbillNo]) VALUES (23, 3, N'abir', N'bd', N'ggggg', N'hhhhh', N'jjj', N'jjj', N'jjj', N'ab', N'', NULL)
INSERT [dbo].[ExportRequest] ([Id], [Status], [ReceiverName], [ReceiverCountry], [ReceiverAddress], [ReceiverContactNo], [SenderName], [SenderAddress], [SenderContactNo], [ParcelType], [Medium], [AirbillNo]) VALUES (24, 1, N'aaaa', N'rrrrrr', N'aaaaa', N'rrrr', N'eeee', N'dddddd', N'dddddd', N'ggg', N'ggggg', NULL)
SET IDENTITY_INSERT [dbo].[ExportRequest] OFF
SET IDENTITY_INSERT [dbo].[ImportRequest] ON 

INSERT [dbo].[ImportRequest] ([Id], [Status], [SenderName], [SenderContactNo], [Medium], [AirbillNo], [ReceiverName], [ReceiverAddress], [ReceiverContact], [ParcelType], [IsArrived]) VALUES (6, 2, N'aserf', N'14jkk', N'dddddd', N'12', N'haja', N'aaaa', N'21452', N'mobb', NULL)
INSERT [dbo].[ImportRequest] ([Id], [Status], [SenderName], [SenderContactNo], [Medium], [AirbillNo], [ReceiverName], [ReceiverAddress], [ReceiverContact], [ParcelType], [IsArrived]) VALUES (7, 2, N'Kazi', N'45896366', N'DHL', N'36504589632', N'Ornob', N'Wareless', N'01553458565', N'Tech', NULL)
INSERT [dbo].[ImportRequest] ([Id], [Status], [SenderName], [SenderContactNo], [Medium], [AirbillNo], [ReceiverName], [ReceiverAddress], [ReceiverContact], [ParcelType], [IsArrived]) VALUES (8, 2, N'Ron', N'47856932', N'UPS', N'12563215478', N'Rafsan', N'Bashundhara', N'014785555555', N'Garments', NULL)
INSERT [dbo].[ImportRequest] ([Id], [Status], [SenderName], [SenderContactNo], [Medium], [AirbillNo], [ReceiverName], [ReceiverAddress], [ReceiverContact], [ParcelType], [IsArrived]) VALUES (9, 1, N'Rozy', N'458962145369', N'', N'', N'Eishika', N'Nikunjo', N'01478569', N'Documents', NULL)
INSERT [dbo].[ImportRequest] ([Id], [Status], [SenderName], [SenderContactNo], [Medium], [AirbillNo], [ReceiverName], [ReceiverAddress], [ReceiverContact], [ParcelType], [IsArrived]) VALUES (10, 2, N'Rony', N'47856932', N'DHL', N'12563215478', N'Rafsan', N'Bashundhara', N'014785555555', N'Garments', NULL)
SET IDENTITY_INSERT [dbo].[ImportRequest] OFF
SET IDENTITY_INSERT [dbo].[Rate] ON 

INSERT [dbo].[Rate] ([RatesID], [Country], [DHLRate], [TNTRate], [DPEXRate]) VALUES (10, N'India', 800, 700, 600)
INSERT [dbo].[Rate] ([RatesID], [Country], [DHLRate], [TNTRate], [DPEXRate]) VALUES (11, N'Australia', 2250, 2200, 2100)
INSERT [dbo].[Rate] ([RatesID], [Country], [DHLRate], [TNTRate], [DPEXRate]) VALUES (12, N'HongKong', 1800, 1700, 1500)
INSERT [dbo].[Rate] ([RatesID], [Country], [DHLRate], [TNTRate], [DPEXRate]) VALUES (13, N'Singapore', 1900, 1700, 1500)
INSERT [dbo].[Rate] ([RatesID], [Country], [DHLRate], [TNTRate], [DPEXRate]) VALUES (14, N'USA', 2600, 2400, 2400)
INSERT [dbo].[Rate] ([RatesID], [Country], [DHLRate], [TNTRate], [DPEXRate]) VALUES (15, N'Canada', 2300, 2300, 2000)
INSERT [dbo].[Rate] ([RatesID], [Country], [DHLRate], [TNTRate], [DPEXRate]) VALUES (16, N'UK', 1800, 1600, 1600)
INSERT [dbo].[Rate] ([RatesID], [Country], [DHLRate], [TNTRate], [DPEXRate]) VALUES (17, N'China', 1400, 1500, 1200)
SET IDENTITY_INSERT [dbo].[Rate] OFF
ALTER TABLE [dbo].[EmployeeTable]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeTable_Department] FOREIGN KEY([departmentId])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[EmployeeTable] CHECK CONSTRAINT [FK_EmployeeTable_Department]
GO
USE [master]
GO
ALTER DATABASE [AirlinkDb] SET  READ_WRITE 
GO
