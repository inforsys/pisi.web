USE [master]
GO
/****** Object:  Database [pisidata]    Script Date: 01/28/2013 16:43:45 ******/
CREATE DATABASE [pisidata] ON  PRIMARY 
( NAME = N'pisidata', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\pisidata.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'pisidata_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\pisidata_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [pisidata] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pisidata].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pisidata] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [pisidata] SET ANSI_NULLS OFF
GO
ALTER DATABASE [pisidata] SET ANSI_PADDING OFF
GO
ALTER DATABASE [pisidata] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [pisidata] SET ARITHABORT OFF
GO
ALTER DATABASE [pisidata] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [pisidata] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [pisidata] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [pisidata] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [pisidata] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [pisidata] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [pisidata] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [pisidata] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [pisidata] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [pisidata] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [pisidata] SET  DISABLE_BROKER
GO
ALTER DATABASE [pisidata] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [pisidata] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [pisidata] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [pisidata] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [pisidata] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [pisidata] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [pisidata] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [pisidata] SET  READ_WRITE
GO
ALTER DATABASE [pisidata] SET RECOVERY SIMPLE
GO
ALTER DATABASE [pisidata] SET  MULTI_USER
GO
ALTER DATABASE [pisidata] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [pisidata] SET DB_CHAINING OFF
GO
USE [pisidata]
GO
/****** Object:  Table [dbo].[tblPeriod]    Script Date: 01/28/2013 16:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPeriod](
	[PeriodId] [nvarchar](10) NOT NULL,
	[PeriodName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblPeriod] PRIMARY KEY CLUSTERED 
(
	[PeriodId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMonth]    Script Date: 01/28/2013 16:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMonth](
	[MonthID] [varchar](6) NOT NULL,
	[MonSumID] [varchar](10) NULL,
	[monName] [varchar](20) NOT NULL,
	[monDay] [smallint] NULL,
	[monHoliday] [smallint] NULL,
	[monMemo] [varchar](50) NULL,
	[monClose] [bit] NOT NULL,
	[monQTY] [decimal](24, 6) NULL,
	[monBonus] [bit] NOT NULL,
	[monExclude] [bit] NULL,
	[Computer] [varchar](20) NULL,
	[Operator] [varchar](20) NULL,
	[LastUpdate] [datetime] NULL,
 CONSTRAINT [aaaaatblMonth_PK] PRIMARY KEY NONCLUSTERED 
(
	[MonthID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 01/28/2013 16:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEmployee](
	[EmployeeID] [varchar](10) NOT NULL,
	[DepartmentID] [varchar](10) NOT NULL,
	[ClassificationID] [varchar](5) NOT NULL,
	[LANID] [varchar](10) NULL,
	[CategoryID] [varchar](5) NOT NULL,
	[DivisionID] [varchar](5) NULL,
	[empIndirectLabour] [bit] NOT NULL,
	[empRanking] [varchar](50) NULL,
	[empName] [varchar](40) NULL,
	[empNickName] [varchar](50) NULL,
	[DesignationID] [varchar](5) NULL,
	[empAddress] [varchar](150) NULL,
	[empBirthPlace] [varchar](50) NULL,
	[empBirthDate] [datetime] NULL,
	[empNPWP] [varchar](25) NULL,
	[MaritalID] [varchar](5) NULL,
	[empJoin] [datetime] NULL,
	[empAkhirPercobaan] [datetime] NULL,
	[empContract] [datetime] NULL,
	[empAkhirKontrak] [datetime] NULL,
	[empResigned] [datetime] NULL,
	[empAlasanBerhenti] [varchar](225) NULL,
	[Daily] [bit] NOT NULL,
	[empBase] [decimal](24, 6) NULL,
	[SexID] [varchar](1) NOT NULL,
	[empHeight] [int] NULL,
	[empWeight] [int] NULL,
	[PlaceofHire] [varchar](50) NULL,
	[RecruitedBy] [varchar](50) NULL,
	[empPhone] [varchar](30) NULL,
	[empAssureDate] [datetime] NULL,
	[empAssurance] [varchar](20) NULL,
	[empJKM] [bit] NOT NULL,
	[empJKKesehatan] [bit] NOT NULL,
	[empJKK] [bit] NOT NULL,
	[empJHTco] [bit] NOT NULL,
	[empJHTemp] [bit] NOT NULL,
	[empAccount] [varchar](20) NULL,
	[empPersenBank] [varchar](50) NULL,
	[empPrestasiKerja] [varchar](255) NULL,
	[ReligionID] [varchar](5) NULL,
	[empLastEducation] [varchar](100) NULL,
	[empPrevEmp] [varchar](50) NULL,
	[empPrevAddress] [varchar](225) NULL,
	[RaceID] [varchar](5) NULL,
	[empStaffMemo] [varchar](20) NULL,
	[empNote] [varchar](4000) NULL,
	[empConfirmed] [datetime] NULL,
	[empKTP] [varchar](30) NULL,
	[SectionID] [varchar](10) NULL,
	[Card No] [varchar](20) NULL,
	[ApplicantID] [int] NULL,
	[empUniform] [varchar](50) NULL,
	[empShoes] [varchar](50) NULL,
	[empVeilJilbab] [varchar](50) NULL,
	[LockerID] [varchar](20) NULL,
	[empSuperior] [varchar](10) NULL,
	[EducationID] [smallint] NULL,
	[empPhoto] [varchar](1) NULL,
	[empCurrShift] [varchar](5) NULL,
	[MealGroupID] [varchar](50) NULL,
	[empZip] [varchar](12) NULL,
	[empBlood] [varchar](3) NULL,
	[WifeID] [varchar](5) NULL,
	[empPager] [varchar](30) NULL,
	[empBaseDate] [datetime] NULL,
	[CurrencyID] [varchar](3) NOT NULL,
	[PaymentID] [varchar](1) NOT NULL,
	[BankID] [varchar](8) NULL,
	[IdentificationID] [smallint] NULL,
	[empIdentNumber] [varchar](50) NULL,
	[NationalityID] [varchar](5) NULL,
	[empExpatriate] [bit] NOT NULL,
	[empTaxArticle26] [bit] NOT NULL,
	[empNomorBuktiPPH26] [varchar](50) NULL,
	[empTglBuktiPPH26] [datetime] NULL,
	[RecruitmentID] [varchar](10) NULL,
	[empKelurahan] [varchar](20) NULL,
	[empKecamatan] [varchar](20) NULL,
	[empsalaryType] [smallint] NULL,
	[empPostal] [varchar](5) NULL,
	[PaidID] [smallint] NULL,
	[LastBal] [decimal](24, 6) NULL,
	[LastPostLeave] [datetime] NULL,
	[LeaQty] [decimal](24, 6) NULL,
	[EmpvalidThru] [datetime] NULL,
	[TransportID] [smallint] NULL,
	[MealID] [smallint] NULL,
	[GroupID] [varchar](5) NULL,
	[empBaseOld] [decimal](24, 6) NULL,
	[DormitoryID] [varchar](10) NULL,
	[EmpmentStatusID] [varchar](5) NULL,
	[TaxID] [smallint] NULL,
	[JobStatusID] [varchar](5) NULL,
	[empHobby] [varchar](50) NULL,
	[LanguageID] [int] NULL,
	[LevelID] [varchar](10) NULL,
	[empCatTax] [smallint] NULL,
	[ClusterID] [varchar](5) NULL,
	[empStatus] [smallint] NULL,
	[Computer] [varchar](20) NULL,
	[Operator] [varchar](20) NULL,
	[LastUpdate] [datetime] NULL,
	[MaritalIDHR] [varchar](50) NULL,
	[empHRNumChild] [int] NULL,
	[empNPWPName] [nvarchar](50) NULL,
	[BankID2nd] [nvarchar](8) NULL,
	[empBankPercent2nd] [decimal](5, 4) NULL,
	[empBankPercent] [decimal](5, 4) NULL,
	[empAccount2nd] [char](10) NULL,
	[empCcyPct1st] [decimal](5, 4) NULL,
	[CurrencyID2nd] [nvarchar](3) NULL,
	[empCcyPct2nd] [decimal](5, 4) NULL,
	[empDesignation] [nvarchar](50) NULL,
	[empMobile] [nvarchar](20) NULL,
	[TglMasukJamsostek] [datetime] NULL,
	[tglNoticeResign] [datetime] NULL,
	[empWarning] [bit] NULL,
	[tglNoticeBook] [datetime] NULL,
 CONSTRAINT [PK_tblEmployee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblUserVerification]    Script Date: 01/28/2013 16:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUserVerification](
	[EmployeeId] [varchar](10) NOT NULL,
	[VeryficationKey] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tblUserVerification] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC,
	[VeryficationKey] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_tblUserVerification_tblEmployee]    Script Date: 01/28/2013 16:43:45 ******/
ALTER TABLE [dbo].[tblUserVerification]  WITH CHECK ADD  CONSTRAINT [FK_tblUserVerification_tblEmployee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[tblEmployee] ([EmployeeID])
GO
ALTER TABLE [dbo].[tblUserVerification] CHECK CONSTRAINT [FK_tblUserVerification_tblEmployee]
GO
