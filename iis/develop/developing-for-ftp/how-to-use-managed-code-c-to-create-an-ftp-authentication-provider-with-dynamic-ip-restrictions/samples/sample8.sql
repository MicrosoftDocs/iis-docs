/****** Create the FtpAuthentication Database ******/

USE [master]
GO
CREATE DATABASE [FtpAuthentication] ON  PRIMARY 
( NAME = N'FtpAuthentication', FILENAME = N'c:\databases\FtpAuthentication.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FtpAuthentication_log', FILENAME = N'c:\databases\FtpAuthentication_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 COLLATE SQL_Latin1_General_CP1_CI_AS
GO
EXEC dbo.sp_dbcmptlevel @dbname=N'FtpAuthentication', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FtpAuthentication].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FtpAuthentication] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FtpAuthentication] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FtpAuthentication] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FtpAuthentication] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FtpAuthentication] SET ARITHABORT OFF 
GO
ALTER DATABASE [FtpAuthentication] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FtpAuthentication] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [FtpAuthentication] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FtpAuthentication] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FtpAuthentication] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FtpAuthentication] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FtpAuthentication] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FtpAuthentication] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FtpAuthentication] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FtpAuthentication] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FtpAuthentication] SET ENABLE_BROKER 
GO
ALTER DATABASE [FtpAuthentication] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FtpAuthentication] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FtpAuthentication] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FtpAuthentication] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FtpAuthentication] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FtpAuthentication] SET READ_WRITE 
GO
ALTER DATABASE [FtpAuthentication] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FtpAuthentication] SET MULTI_USER 
GO
ALTER DATABASE [FtpAuthentication] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FtpAuthentication] SET DB_CHAINING OFF 

/****** Create the Database Tables ******/

USE [FtpAuthentication]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BannedAddresses]') AND type in (N'U'))
BEGIN
CREATE TABLE [BannedAddresses](
    [IPAddress] [nvarchar](50) NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Failures]') AND type in (N'U'))
BEGIN
CREATE TABLE [Failures](
    [IPAddress] [nvarchar](50) NOT NULL,
    [FailureDateTime] [datetime] NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Users]') AND type in (N'U'))
BEGIN
CREATE TABLE [Users](
    [UID] [nvarchar](50) NOT NULL,
    [PWD] [nvarchar](50) NOT NULL,
    [Locked] [bit] NOT NULL
) ON [PRIMARY]
END