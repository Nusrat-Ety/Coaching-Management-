USE [master]
GO
/****** Object:  Database [CAC]    Script Date: 02-Nov-19 03:28:22 PM ******/
CREATE DATABASE [CAC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CAC', FILENAME = N'H:\Important Software Installed\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\CAC.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CAC_log', FILENAME = N'H:\Important Software Installed\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\CAC_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CAC] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CAC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CAC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CAC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CAC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CAC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CAC] SET ARITHABORT OFF 
GO
ALTER DATABASE [CAC] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CAC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CAC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CAC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CAC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CAC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CAC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CAC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CAC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CAC] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CAC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CAC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CAC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CAC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CAC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CAC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CAC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CAC] SET RECOVERY FULL 
GO
ALTER DATABASE [CAC] SET  MULTI_USER 
GO
ALTER DATABASE [CAC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CAC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CAC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CAC] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CAC] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CAC', N'ON'
GO
ALTER DATABASE [CAC] SET QUERY_STORE = OFF
GO
USE [CAC]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 02-Nov-19 03:28:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 02-Nov-19 03:28:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ClassId] [int] IDENTITY(1,1) NOT NULL,
	[ClassName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[ClassId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 02-Nov-19 03:28:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CourseId] [int] IDENTITY(1,1) NOT NULL,
	[CourseName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 02-Nov-19 03:28:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[FatherName] [nvarchar](50) NOT NULL,
	[MotherName] [nvarchar](50) NOT NULL,
	[DOB] [date] NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[Contact] [int] NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[TuitionFee] [int] NOT NULL,
	[PayAmount] [int] NULL,
	[DueAmount] [int] NULL,
	[PaymentStatus] [int] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentAttendance]    Script Date: 02-Nov-19 03:28:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentAttendance](
	[S_Id] [int] IDENTITY(1,1) NOT NULL,
	[S_Name] [nvarchar](50) NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_StudentAttendance] PRIMARY KEY CLUSTERED 
(
	[S_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 02-Nov-19 03:28:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[TeacherId] [int] IDENTITY(1,1) NOT NULL,
	[TeacherName] [nvarchar](50) NOT NULL,
	[Contact] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Salary] [int] NULL,
	[PaidAmount] [int] NULL,
	[Payment_Status] [int] NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeacherAttendance]    Script Date: 02-Nov-19 03:28:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeacherAttendance](
	[T_Id] [int] IDENTITY(1,1) NOT NULL,
	[T_Name] [nvarchar](50) NOT NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_TeacherAttendance] PRIMARY KEY CLUSTERED 
(
	[T_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([AdminId], [Name], [Email], [Password]) VALUES (1, N'ety', N'ety@gmail.com', N'1')
SET IDENTITY_INSERT [dbo].[Admin] OFF
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([StudentId], [StudentName], [FatherName], [MotherName], [DOB], [Gender], [Address], [Contact], [Email], [Password], [TuitionFee], [PayAmount], [DueAmount], [PaymentStatus]) VALUES (1, N'Rahman', N'FFF', N'MMM', CAST(N'2019-11-01' AS Date), N'Male', N'Uttara', 33333, N'rahman@gmail.com', N'3', 1000, 500, 500, 500)
SET IDENTITY_INSERT [dbo].[Student] OFF
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [Contact], [Address], [Email], [Password], [Salary], [PaidAmount], [Payment_Status]) VALUES (1, N'Akash', N'2222', N'Uttara', N'akash@gmail.com', N'2', 500, 0, 500)
SET IDENTITY_INSERT [dbo].[Teacher] OFF
USE [master]
GO
ALTER DATABASE [CAC] SET  READ_WRITE 
GO
