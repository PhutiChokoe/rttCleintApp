USE [master]
GO
/****** Object:  Database [RttCients]    Script Date: 2017/07/24 7:58:55 AM ******/
CREATE DATABASE [RttCients] ON  PRIMARY 
( NAME = N'RttCients', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\RttCients.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RttCients_log', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\RttCients_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [RttCients] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RttCients].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RttCients] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RttCients] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RttCients] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RttCients] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RttCients] SET ARITHABORT OFF 
GO
ALTER DATABASE [RttCients] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RttCients] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [RttCients] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RttCients] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RttCients] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RttCients] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RttCients] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RttCients] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RttCients] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RttCients] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RttCients] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RttCients] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RttCients] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RttCients] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RttCients] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RttCients] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RttCients] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RttCients] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RttCients] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RttCients] SET  MULTI_USER 
GO
ALTER DATABASE [RttCients] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RttCients] SET DB_CHAINING OFF 
GO
USE [RttCients]
GO
/****** Object:  Table [dbo].[AddressDetails]    Script Date: 2017/07/24 7:58:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AddressDetails](
	[StreetAddressLine1] [varchar](150) NULL,
	[StreetAddressLine2] [varchar](150) NULL,
	[City] [varchar](50) NULL,
	[Province] [varchar](50) NULL,
	[PostalCode] [varchar](8) NULL,
	[ClientId] [uniqueidentifier] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ClientDetails]    Script Date: 2017/07/24 7:58:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ClientDetails](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [varchar](20) NULL,
	[Gender] [varchar](6) NULL,
	[Surname] [varchar](20) NULL,
	[IdNumber] [bigint] NULL,
 CONSTRAINT [PK_ClientDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ContactDetails]    Script Date: 2017/07/24 7:58:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ContactDetails](
	[Type] [varchar](50) NULL,
	[Number] [varchar](50) NULL,
	[ClientId] [uniqueidentifier] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [RttCients] SET  READ_WRITE 
GO
