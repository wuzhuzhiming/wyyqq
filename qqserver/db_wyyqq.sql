USE [master]
GO
/****** Object:  Database [db_wyyqq]    Script Date: 2018/4/18 17:08:58 ******/
CREATE DATABASE [db_wyyqq]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_wyyqq', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\db_wyyqq.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_wyyqq_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\db_wyyqq_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_wyyqq] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_wyyqq].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_wyyqq] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_wyyqq] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_wyyqq] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_wyyqq] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_wyyqq] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_wyyqq] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_wyyqq] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [db_wyyqq] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_wyyqq] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_wyyqq] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_wyyqq] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_wyyqq] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_wyyqq] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_wyyqq] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_wyyqq] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_wyyqq] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_wyyqq] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_wyyqq] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_wyyqq] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_wyyqq] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_wyyqq] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_wyyqq] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_wyyqq] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_wyyqq] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_wyyqq] SET  MULTI_USER 
GO
ALTER DATABASE [db_wyyqq] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_wyyqq] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_wyyqq] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_wyyqq] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [db_wyyqq]
GO
/****** Object:  Table [dbo].[t_group]    Script Date: 2018/4/18 17:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_group](
	[groupid] [int] IDENTITY(50000000,1) NOT NULL,
	[name] [varchar](20) NOT NULL,
	[head] [int] NOT NULL,
	[creater] [int] NOT NULL,
 CONSTRAINT [PK_t_group] PRIMARY KEY CLUSTERED 
(
	[groupid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_news]    Script Date: 2018/4/18 17:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_news](
	[userid] [int] NOT NULL,
	[news_type] [int] NOT NULL,
	[with_userid] [int] NOT NULL,
	[with_groupid] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[t_user]    Script Date: 2018/4/18 17:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_user](
	[userid] [int] IDENTITY(100000,1) NOT NULL,
	[account] [varchar](20) NOT NULL,
	[pass] [varchar](20) NOT NULL,
	[name] [varchar](20) NOT NULL,
	[sex] [int] NOT NULL,
	[head] [int] NOT NULL,
 CONSTRAINT [PK_t_user_1] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[t_group] ADD  CONSTRAINT [DF_t_group_creater]  DEFAULT ((0)) FOR [creater]
GO
ALTER TABLE [dbo].[t_news] ADD  CONSTRAINT [DF_t_news_userid]  DEFAULT ((0)) FOR [userid]
GO
ALTER TABLE [dbo].[t_news] ADD  CONSTRAINT [DF_t_news_news_type]  DEFAULT ((0)) FOR [news_type]
GO
ALTER TABLE [dbo].[t_news] ADD  CONSTRAINT [DF_t_news_with_userid]  DEFAULT ((0)) FOR [with_userid]
GO
ALTER TABLE [dbo].[t_news] ADD  CONSTRAINT [DF_t_news_groupid]  DEFAULT ((0)) FOR [with_groupid]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消息类型(1-好友申请2-加群申请)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N't_news', @level2type=N'COLUMN',@level2name=N'news_type'
GO
USE [master]
GO
ALTER DATABASE [db_wyyqq] SET  READ_WRITE 
GO
