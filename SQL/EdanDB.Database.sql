USE [master]
GO
/****** Object:  Database [EdanDB]    Script Date: 4/28/2021 6:26:24 PM ******/
CREATE DATABASE [EdanDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EdanDB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\EdanDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EdanDB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\EdanDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EdanDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EdanDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EdanDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EdanDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EdanDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EdanDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EdanDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [EdanDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EdanDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EdanDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EdanDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EdanDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EdanDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EdanDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EdanDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EdanDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EdanDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EdanDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EdanDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EdanDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EdanDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EdanDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EdanDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EdanDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EdanDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EdanDB] SET  MULTI_USER 
GO
ALTER DATABASE [EdanDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EdanDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EdanDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EdanDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [EdanDB] SET  READ_WRITE 
GO
