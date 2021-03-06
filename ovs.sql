USE [master]
GO
/****** Object:  Database [ovs]    Script Date: 6/5/2014 9:42:24 PM ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'ovs')
BEGIN
CREATE DATABASE [ovs] ON  PRIMARY 
( NAME = N'ovs', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\ovs.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ovs_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\ovs_log.LDF' , SIZE = 768KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END

GO
ALTER DATABASE [ovs] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ovs].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ovs] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ovs] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ovs] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ovs] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ovs] SET ARITHABORT OFF 
GO
ALTER DATABASE [ovs] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ovs] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ovs] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ovs] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ovs] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ovs] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ovs] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ovs] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ovs] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ovs] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ovs] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ovs] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ovs] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ovs] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ovs] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ovs] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ovs] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ovs] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ovs] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ovs] SET  MULTI_USER 
GO
ALTER DATABASE [ovs] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ovs] SET DB_CHAINING OFF 
GO
USE [ovs]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[admin]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[admin](
	[votename] [varchar](50) NOT NULL,
	[startdate] [datetime] NULL,
	[enddate] [datetime] NULL,
	[voterid] [int] NULL,
 CONSTRAINT [PK_admin] PRIMARY KEY CLUSTERED 
(
	[votename] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[citycorporationvote]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[citycorporationvote]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[citycorporationvote](
	[voterid] [int] NOT NULL,
	[votearea] [varchar](50) NOT NULL,
	[votecount] [int] NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[citycorporationvoter]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[citycorporationvoter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[citycorporationvoter](
	[voterid] [int] NULL,
	[votearea] [varchar](50) NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ctgvote]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ctgvote]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ctgvote](
	[voterid] [int] NOT NULL,
	[votecount] [int] NOT NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ctgvoter]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ctgvoter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ctgvoter](
	[voterid] [int] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[History]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[History]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[History](
	[event] [varchar](255) NOT NULL,
	[dates] [datetime] NOT NULL,
 CONSTRAINT [PK_History] PRIMARY KEY CLUSTERED 
(
	[event] ASC,
	[dates] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[localvote]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[localvote]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[localvote](
	[voterid] [int] NOT NULL,
	[votecount] [int] NOT NULL,
 CONSTRAINT [PK_localvote] PRIMARY KEY CLUSTERED 
(
	[voterid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[localvoter]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[localvoter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[localvoter](
	[voterid] [int] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[pourashavavote]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pourashavavote]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[pourashavavote](
	[voterid] [int] NOT NULL,
	[votecount] [int] NOT NULL,
	[votearea] [varchar](50) NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pourashavavoter]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pourashavavoter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[pourashavavoter](
	[voterid] [int] NULL,
	[votearea] [varchar](50) NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[quickvote]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[quickvote]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[quickvote](
	[voterid] [int] NOT NULL,
	[votecount] [int] NOT NULL,
 CONSTRAINT [PK_quickvote] PRIMARY KEY CLUSTERED 
(
	[voterid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[quickvoter]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[quickvoter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[quickvoter](
	[voterid] [int] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[seatvote]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[seatvote]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[seatvote](
	[seatid] [int] NOT NULL,
	[seatname] [varchar](50) NOT NULL,
	[voterid] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[seatvoter]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[seatvoter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[seatvoter](
	[seatid] [int] NULL,
	[voterid] [int] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[standardvote]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[standardvote]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[standardvote](
	[votename] [varchar](50) NOT NULL,
	[votearea] [varchar](50) NOT NULL,
	[startdate] [datetime] NULL,
	[enddate] [datetime] NULL,
	[voterid] [int] NULL,
 CONSTRAINT [PK_standardvote] PRIMARY KEY CLUSTERED 
(
	[votename] ASC,
	[votearea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[team]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[team]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[team](
	[teamname] [varchar](50) NOT NULL,
	[voterid] [int] NOT NULL,
	[votecount] [int] NOT NULL,
	[seatcount] [int] NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[teammember]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[teammember]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[teammember](
	[teamname] [varchar](50) NOT NULL,
	[voterid] [int] NOT NULL,
	[seatid] [int] NOT NULL,
	[votecount] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[upojelavote]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[upojelavote]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[upojelavote](
	[voterid] [int] NOT NULL,
	[votecount] [int] NOT NULL,
	[votearea] [varchar](50) NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[upojelavoter]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[upojelavoter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[upojelavoter](
	[voterid] [int] NULL,
	[votearea] [varchar](50) NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[userinfo]    Script Date: 6/5/2014 9:42:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[userinfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[userinfo](
	[uname] [varchar](50) NULL,
	[password] [varchar](50) NOT NULL,
	[voterid] [int] NOT NULL,
	[fname] [varchar](50) NULL,
	[mname] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[contact] [varchar](50) NULL,
	[dob] [date] NULL,
	[doreg] [date] NULL,
	[bloodgroup] [varchar](5) NULL,
	[address] [varchar](255) NULL,
	[upojela] [varchar](50) NOT NULL,
	[pourashava] [varchar](50) NOT NULL,
	[citycorporation] [varchar](50) NOT NULL,
 CONSTRAINT [PK_userinfo] PRIMARY KEY CLUSTERED 
(
	[voterid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[admin] ([votename], [startdate], [enddate], [voterid]) VALUES (N'ctgvote', NULL, NULL, NULL)
INSERT [dbo].[admin] ([votename], [startdate], [enddate], [voterid]) VALUES (N'localvote', NULL, NULL, NULL)
INSERT [dbo].[admin] ([votename], [startdate], [enddate], [voterid]) VALUES (N'quickvote', CAST(0x0000A33501008330 AS DateTime), CAST(0x0000A33501040BE0 AS DateTime), 1)
INSERT [dbo].[admin] ([votename], [startdate], [enddate], [voterid]) VALUES (N'seatvote', CAST(0x0000A3330159FDD4 AS DateTime), CAST(0x0000A333015CE3A0 AS DateTime), 1)
INSERT [dbo].[History] ([event], [dates]) VALUES (N'5/24/2014 3:46:48 PM quickvote is finished', CAST(0x0000A33501040BE0 AS DateTime))
INSERT [dbo].[History] ([event], [dates]) VALUES (N'5/26/2014 3:49:23 PM localvote is finished', CAST(0x0000A3370104C184 AS DateTime))
INSERT [dbo].[History] ([event], [dates]) VALUES (N'5/26/2014 3:49:38 PM ctgvote is finished', CAST(0x0000A3370104D318 AS DateTime))
INSERT [dbo].[quickvote] ([voterid], [votecount]) VALUES (1, 3)
INSERT [dbo].[quickvote] ([voterid], [votecount]) VALUES (2, 0)
INSERT [dbo].[quickvote] ([voterid], [votecount]) VALUES (3, 1)
INSERT [dbo].[quickvoter] ([voterid]) VALUES (1)
INSERT [dbo].[quickvoter] ([voterid]) VALUES (2)
INSERT [dbo].[quickvoter] ([voterid]) VALUES (3)
INSERT [dbo].[quickvoter] ([voterid]) VALUES (4)
INSERT [dbo].[seatvote] ([seatid], [seatname], [voterid]) VALUES (1, N'Primeminister', NULL)
INSERT [dbo].[seatvote] ([seatid], [seatname], [voterid]) VALUES (2, N'Minister', NULL)
INSERT [dbo].[seatvote] ([seatid], [seatname], [voterid]) VALUES (3, N'Jogajog', NULL)
INSERT [dbo].[seatvote] ([seatid], [seatname], [voterid]) VALUES (4, N'Dak', NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'citycorporationvote', N'barisal', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'citycorporationvote', N'chittagong', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'citycorporationvote', N'comilla', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'citycorporationvote', N'gazipur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'citycorporationvote', N'khulna', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'citycorporationvote', N'narayangonj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'citycorporationvote', N'northdhaka', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'citycorporationvote', N'rajshahi', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'citycorporationvote', N'rangpur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'citycorporationvote', N'southdhaka', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'citycorporationvote', N'sylhet', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'akhaura', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'baghaichori', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'bajitpur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'bandarban', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'baroyarhat', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'bashkhali', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'boalmari', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'borura', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'bosurhat', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'brahmanbaria', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'chagolnaiya', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'chandanaish', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'chandila', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'chandpur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'chatkhil', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'chengarchor', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'chokoria', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'chouddagram', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'choumouhni', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'chunarughat', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'comilla', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'comilla sadar dokkhin', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'coxbazar', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'dagonvua', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'damuda', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'daudkandi', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'debiganj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'deowanganj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'dhamrai', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'dhonbari', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'dohar', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'durgapur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'faridganj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'faridpur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'feni', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'fulbaria', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'fulpur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'gazipur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'ghatail', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'ghorashal', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'goalondo', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'goforgao', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'gopalganj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'gopalpur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'gouripur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'hajiganj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'hatiya', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'homna', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'hosenpur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'ishwarganj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'islampur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'jajira', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'jamalpur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'kabirhat', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'kaliakoir', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'kalihati', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'kalokini', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'kanchon', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'karimganj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'kendua', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'khagrachori', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'kishorganj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'kochua', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'kodomrosul', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'kosba', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'kotalipara', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'kotiyadi', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'kuliachar', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'lakhsham', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'lama', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'lokkhipur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'madarganj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'madaripur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'madhobodhi', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'manikganj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'matiranga', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'maymansingh', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'melandaha', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'mirjapur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'mirkadim', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'mirsharai', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'modhupur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'modon', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'moheshkhali', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'mohonganj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'monohordhi', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'motolob', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'muksudhpur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'muktagacha', NULL, NULL, NULL)
GO
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'munshiganj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'nabinagar', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'nagarkanda', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'nalitabari', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'nandail', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'nangolkot', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'narayanganj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'narshingdhi', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'netrokona', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'noakhali', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'nokola', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'noria', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'pakuandia', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'pangsha', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'patiya', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'porshuram', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'raipur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'raipura', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'rajbari', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'ramgar', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'ramgonj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'ramgoti', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'rangamati', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'rangunia', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'raozan', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'sandwip', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'sathkania', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'savar', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'senbagh', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'shahrasti', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'sherpur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'shibchor', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'shibpur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'shoriotpur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'shorishabari', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'siddhirganj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'singhair', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'sitakundu', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'sokhipur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'sonagazi', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'sonaimuri', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'sonargao', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'sriborodi', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'sripur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'tangail', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'tarab', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'technaf', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'tongi', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'trishal', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'tungipara', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'valuka', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'vanga', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'vedorganj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'voyrob', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'pourashavavote', N'vuapur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'akhaura', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'ali kadam', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'anwara', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'ashuganj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'bancharampur', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'bandar(chittagong port)', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'bandarban sadar', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'banshkhali', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'bijoynagar', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'boalkhali', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'brahmanbaria', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'chandanaish', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'chandgaon', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'chandpur sadar', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'double morring', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'faridganj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'fatikchhari', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'haimchar', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'hathazari', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'haziganj', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'kachua', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'kasba', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'kotwali', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'lama', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'lohagara', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'matlab dakshin ', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'matlab uttar', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'mirsharai', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'nabinagar', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'naikhongchhari', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'nasirnagar', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'pahartali', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'panchlaish', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'patiya', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'rangunia', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'raozan', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'Rowangchhari', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'ruma', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'sandwip', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'sarail', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'satkania', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'shahrasti', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'sitakunda', NULL, NULL, NULL)
INSERT [dbo].[standardvote] ([votename], [votearea], [startdate], [enddate], [voterid]) VALUES (N'upojelavote', N'thanchi', NULL, NULL, NULL)
INSERT [dbo].[team] ([teamname], [voterid], [votecount], [seatcount]) VALUES (N'Hefazat', 1, 70, 30)
INSERT [dbo].[team] ([teamname], [voterid], [votecount], [seatcount]) VALUES (N'BNP', 2, 23, 11)
INSERT [dbo].[team] ([teamname], [voterid], [votecount], [seatcount]) VALUES (N'AL', 3, 10, 10)
INSERT [dbo].[team] ([teamname], [voterid], [votecount], [seatcount]) VALUES (N'JAMAT', 4, 34, 20)
INSERT [dbo].[teammember] ([teamname], [voterid], [seatid], [votecount]) VALUES (N'Hefazat', 1, 1, 50)
INSERT [dbo].[teammember] ([teamname], [voterid], [seatid], [votecount]) VALUES (N'BNP', 2, 1, 11)
INSERT [dbo].[teammember] ([teamname], [voterid], [seatid], [votecount]) VALUES (N'AL', 3, 1, 10)
INSERT [dbo].[teammember] ([teamname], [voterid], [seatid], [votecount]) VALUES (N'JAMAT', 4, 1, 20)
INSERT [dbo].[teammember] ([teamname], [voterid], [seatid], [votecount]) VALUES (N'Hefazat', 6, 2, 16)
INSERT [dbo].[teammember] ([teamname], [voterid], [seatid], [votecount]) VALUES (N'Hefazat', 7, 3, 4)
INSERT [dbo].[userinfo] ([uname], [password], [voterid], [fname], [mname], [email], [contact], [dob], [doreg], [bloodgroup], [address], [upojela], [pourashava], [citycorporation]) VALUES (N'zillur rahman', N'1', 1, NULL, NULL, NULL, NULL, CAST(0x04FC0A00 AS Date), NULL, NULL, NULL, N'raozan', N'raozan', N'chittagong')
INSERT [dbo].[userinfo] ([uname], [password], [voterid], [fname], [mname], [email], [contact], [dob], [doreg], [bloodgroup], [address], [upojela], [pourashava], [citycorporation]) VALUES (N'sanjida jahangir', N'2', 2, NULL, NULL, NULL, NULL, CAST(0x04FC0A00 AS Date), NULL, NULL, NULL, N'raozan', N'raozan', N'chittagong')
INSERT [dbo].[userinfo] ([uname], [password], [voterid], [fname], [mname], [email], [contact], [dob], [doreg], [bloodgroup], [address], [upojela], [pourashava], [citycorporation]) VALUES (N'saiful islam', N'3', 3, NULL, NULL, NULL, NULL, CAST(0x04FC0A00 AS Date), NULL, NULL, NULL, N'raozan', N'raozan', N'chittagong')
INSERT [dbo].[userinfo] ([uname], [password], [voterid], [fname], [mname], [email], [contact], [dob], [doreg], [bloodgroup], [address], [upojela], [pourashava], [citycorporation]) VALUES (N'naurin idris', N'4', 4, NULL, NULL, NULL, NULL, CAST(0x04FC0A00 AS Date), NULL, NULL, NULL, N'raozan', N'raozan', N'chittagong')
INSERT [dbo].[userinfo] ([uname], [password], [voterid], [fname], [mname], [email], [contact], [dob], [doreg], [bloodgroup], [address], [upojela], [pourashava], [citycorporation]) VALUES (N'fatema nasrin', N'5', 5, NULL, NULL, NULL, NULL, CAST(0x04FC0A00 AS Date), NULL, NULL, NULL, N'raozan', N'raozan', N'chittagong')
INSERT [dbo].[userinfo] ([uname], [password], [voterid], [fname], [mname], [email], [contact], [dob], [doreg], [bloodgroup], [address], [upojela], [pourashava], [citycorporation]) VALUES (NULL, N'13', 13, NULL, NULL, NULL, NULL, CAST(0x04FC0A00 AS Date), NULL, NULL, NULL, N'raozan', N'raozan', N'chittagong')
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_admin_userinfo]') AND parent_object_id = OBJECT_ID(N'[dbo].[admin]'))
ALTER TABLE [dbo].[admin]  WITH CHECK ADD  CONSTRAINT [FK_admin_userinfo] FOREIGN KEY([voterid])
REFERENCES [dbo].[userinfo] ([voterid])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_admin_userinfo]') AND parent_object_id = OBJECT_ID(N'[dbo].[admin]'))
ALTER TABLE [dbo].[admin] CHECK CONSTRAINT [FK_admin_userinfo]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_quickvote_userinfo]') AND parent_object_id = OBJECT_ID(N'[dbo].[quickvote]'))
ALTER TABLE [dbo].[quickvote]  WITH CHECK ADD  CONSTRAINT [FK_quickvote_userinfo] FOREIGN KEY([voterid])
REFERENCES [dbo].[userinfo] ([voterid])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_quickvote_userinfo]') AND parent_object_id = OBJECT_ID(N'[dbo].[quickvote]'))
ALTER TABLE [dbo].[quickvote] CHECK CONSTRAINT [FK_quickvote_userinfo]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_quickvoter_userinfo]') AND parent_object_id = OBJECT_ID(N'[dbo].[quickvoter]'))
ALTER TABLE [dbo].[quickvoter]  WITH CHECK ADD  CONSTRAINT [FK_quickvoter_userinfo] FOREIGN KEY([voterid])
REFERENCES [dbo].[userinfo] ([voterid])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_quickvoter_userinfo]') AND parent_object_id = OBJECT_ID(N'[dbo].[quickvoter]'))
ALTER TABLE [dbo].[quickvoter] CHECK CONSTRAINT [FK_quickvoter_userinfo]
GO
USE [master]
GO
ALTER DATABASE [ovs] SET  READ_WRITE 
GO
