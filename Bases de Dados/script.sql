USE [master]
GO
/****** Object:  Database [DEC2019_77aef15d1c0b41d78e04564910ea7547]    Script Date: 21/03/2020 11:35:11 ******/
CREATE DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dec2019.mdf', FILENAME = N'C:\CADS\Databases\dec2019.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dec2019_log.ldf', FILENAME = N'C:\CADS\Databases\dec2019_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DEC2019_77aef15d1c0b41d78e04564910ea7547].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET ARITHABORT OFF 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET  MULTI_USER 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET QUERY_STORE = OFF
GO
USE [DEC2019_77aef15d1c0b41d78e04564910ea7547]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [DEC2019_77aef15d1c0b41d78e04564910ea7547]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 21/03/2020 11:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplicationPermissions]    Script Date: 21/03/2020 11:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationPermissions](
	[ApplicationPermissionId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.ApplicationPermissions] PRIMARY KEY CLUSTERED 
(
	[ApplicationPermissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplicationRolePermission]    Script Date: 21/03/2020 11:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationRolePermission](
	[ApplicationRoleId] [uniqueidentifier] NOT NULL,
	[ApplicationPermissionId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.ApplicationRolePermission] PRIMARY KEY CLUSTERED 
(
	[ApplicationRoleId] ASC,
	[ApplicationPermissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplicationRoles]    Script Date: 21/03/2020 11:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationRoles](
	[ApplicationRoleId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Configuration_ConfigurationId] [bit] NULL,
 CONSTRAINT [PK_dbo.ApplicationRoles] PRIMARY KEY CLUSTERED 
(
	[ApplicationRoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 21/03/2020 11:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 21/03/2020 11:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 21/03/2020 11:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [uniqueidentifier] NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 21/03/2020 11:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [uniqueidentifier] NOT NULL,
	[DisplayName] [nvarchar](max) NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 21/03/2020 11:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [nvarchar](128) NOT NULL,
	[Secret] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Active] [bit] NOT NULL,
	[RefreshTokenLifetime] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Clients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConfigurationLogs]    Script Date: 21/03/2020 11:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConfigurationLogs](
	[ConfigurationLogId] [uniqueidentifier] NOT NULL,
	[ConfigurationId] [bit] NOT NULL,
	[CreatedWhen] [datetime] NOT NULL,
	[CreatedOnDevice] [nvarchar](max) NULL,
	[AppliedWhen] [datetime] NOT NULL,
	[AppliedById] [uniqueidentifier] NOT NULL,
	[CommandKey] [nvarchar](450) NULL,
	[CommandType] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.ConfigurationLogs] PRIMARY KEY CLUSTERED 
(
	[ConfigurationLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Configurations]    Script Date: 21/03/2020 11:35:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Configurations](
	[ConfigurationId] [bit] NOT NULL,
	[ContractReferencePrefix] [nvarchar](max) NULL,
	[ContractReferenceSuffix] [nvarchar](max) NULL,
	[ContractReferenceLength] [int] NOT NULL,
	[NextContractReference] [int] NOT NULL,
	[SiteReferencePrefix] [nvarchar](max) NULL,
	[SiteReferenceSuffix] [nvarchar](max) NULL,
	[SiteReferenceLength] [int] NOT NULL,
	[NextSiteReference] [int] NOT NULL,
	[CustomerReferencePrefix] [nvarchar](max) NULL,
	[CustomerReferenceSuffix] [nvarchar](max) NULL,
	[CustomerReferenceLength] [int] NOT NULL,
	[NextCustomerReference] [int] NOT NULL,
	[CurrencySymbol] [nvarchar](max) NULL,
	[SchemaVersion] [datetime] NOT NULL,
	[NewContractStatus_ContractStatusId] [uniqueidentifier] NULL,
	[NewCustomerStatus_CustomerStatusId] [uniqueidentifier] NULL,
	[NewScaffoldStatus_ScaffoldStatusId] [uniqueidentifier] NULL,
	[NewSiteStatus_SiteStatusId] [uniqueidentifier] NULL,
	[ScaffoldReferencePrefix] [nvarchar](max) NOT NULL,
	[ScaffoldReferenceSuffix] [nvarchar](max) NOT NULL,
	[ScaffoldReferenceLength] [int] NOT NULL,
	[CompanyName] [nvarchar](max) NULL,
	[CompanyAddress] [nvarchar](max) NULL,
	[Latitude] [float] NULL,
	[Longitude] [float] NULL,
	[EmailAddress] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[WebConsoleSetupComplete] [bit] NOT NULL,
	[DepotsEnabled] [bit] NOT NULL,
	[MediaReferenceId] [uniqueidentifier] NULL,
	[NewInspectionDefectStatus_DefectStatusId] [uniqueidentifier] NULL,
	[EstimationMethod] [int] NOT NULL,
	[PeriodType] [int] NOT NULL,
	[FirstPeriodStartDate] [datetime] NULL,
 CONSTRAINT [PK_dbo.Configurations] PRIMARY KEY CLUSTERED 
(
	[ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactTypes]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactTypes](
	[ContactTypeId] [uniqueidentifier] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.ContactTypes] PRIMARY KEY CLUSTERED 
(
	[ContactTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractContacts]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractContacts](
	[ContractContactId] [uniqueidentifier] NOT NULL,
	[ContactName] [nvarchar](max) NULL,
	[EmailAddress] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[ContractId] [uniqueidentifier] NOT NULL,
	[ReceiveInspectionReports] [bit] NOT NULL,
	[IsInactive] [bit] NOT NULL,
	[ReportSubscriptionTypes] [int] NOT NULL,
	[ScheduleType] [int] NOT NULL,
	[ScheduledReportStartDate] [datetime] NULL,
	[ContactTypeId] [uniqueidentifier] NULL,
	[NextScheduledReportTime] [datetime] NULL,
	[ScheduledReportsInterval] [time](7) NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[ReportSubscriptionId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.ContractContacts] PRIMARY KEY CLUSTERED 
(
	[ContractContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractLogs]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractLogs](
	[ContractLogId] [uniqueidentifier] NOT NULL,
	[ContractId] [uniqueidentifier] NOT NULL,
	[CreatedWhen] [datetime] NOT NULL,
	[CreatedOnDevice] [nvarchar](max) NULL,
	[AppliedWhen] [datetime] NOT NULL,
	[AppliedById] [uniqueidentifier] NOT NULL,
	[CommandKey] [nvarchar](450) NULL,
	[CommandType] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.ContractLogs] PRIMARY KEY CLUSTERED 
(
	[ContractLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contracts]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contracts](
	[ContractId] [uniqueidentifier] NOT NULL,
	[ContractReference] [nvarchar](max) NULL,
	[SiteId] [uniqueidentifier] NOT NULL,
	[IsPrincipalContract] [bit] NOT NULL,
	[CustomerId] [uniqueidentifier] NOT NULL,
	[ContractStatusId] [uniqueidentifier] NOT NULL,
	[IsCustomerNotPresent] [bit] NOT NULL,
	[CreationDate] [datetime] NULL,
	[IsScheduleRatesAgreed] [bit] NOT NULL,
	[CanSubmitDocumentsWithoutSignature] [bit] NOT NULL,
	[ContractInspectionStatus] [int] NOT NULL,
	[ContractTypeId] [uniqueidentifier] NULL,
	[IsCameraAllowed] [bit] NOT NULL,
	[AllowDismantleWithoutOffhire] [bit] NOT NULL,
	[ContractName] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Contracts] PRIMARY KEY CLUSTERED 
(
	[ContractId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractScaffoldDiary]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractScaffoldDiary](
	[ScaffoldDiaryId] [uniqueidentifier] NOT NULL,
	[State] [int] NOT NULL,
	[Reason] [nvarchar](max) NULL,
	[ResumeDate] [datetime] NULL,
 CONSTRAINT [PK_dbo.ContractScaffoldDiary] PRIMARY KEY CLUSTERED 
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractStatus]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractStatus](
	[ContractStatusId] [uniqueidentifier] NOT NULL,
	[IsClosed] [bit] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.ContractStatus] PRIMARY KEY CLUSTERED 
(
	[ContractStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractTypes]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractTypes](
	[ContractTypeId] [uniqueidentifier] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.ContractTypes] PRIMARY KEY CLUSTERED 
(
	[ContractTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerLogs]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerLogs](
	[CustomerLogId] [uniqueidentifier] NOT NULL,
	[CustomerId] [uniqueidentifier] NOT NULL,
	[CreatedWhen] [datetime] NOT NULL,
	[CreatedOnDevice] [nvarchar](max) NULL,
	[AppliedWhen] [datetime] NOT NULL,
	[AppliedById] [uniqueidentifier] NOT NULL,
	[CommandKey] [nvarchar](450) NULL,
	[CommandType] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.CustomerLogs] PRIMARY KEY CLUSTERED 
(
	[CustomerLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [uniqueidentifier] NOT NULL,
	[CustomerName] [nvarchar](max) NULL,
	[CustomerReference] [nvarchar](max) NULL,
	[CustomerStatusId] [uniqueidentifier] NOT NULL,
	[ApprovalExpires] [datetime] NULL,
	[CustomerImage_MediaReferenceId] [uniqueidentifier] NULL,
	[Latitude] [float] NULL,
	[Longitude] [float] NULL,
	[CustomerAddress] [nvarchar](max) NULL,
	[EmailAddress] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[Website] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerSignatures]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerSignatures](
	[CustomerSignatureId] [uniqueidentifier] NOT NULL,
	[ContractContactId] [uniqueidentifier] NOT NULL,
	[DataPath] [nvarchar](max) NULL,
	[When] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.CustomerSignatures] PRIMARY KEY CLUSTERED 
(
	[CustomerSignatureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerStatus]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerStatus](
	[CustomerStatusId] [uniqueidentifier] NOT NULL,
	[IsInactive] [bit] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.CustomerStatus] PRIMARY KEY CLUSTERED 
(
	[CustomerStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DefectTypes]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DefectTypes](
	[DefectTypeId] [uniqueidentifier] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.DefectTypes] PRIMARY KEY CLUSTERED 
(
	[DefectTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DesignTypes]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DesignTypes](
	[DesignTypeId] [uniqueidentifier] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.DesignTypes] PRIMARY KEY CLUSTERED 
(
	[DesignTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Devices]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Devices](
	[DeviceId] [int] IDENTITY(1,1) NOT NULL,
	[DeviceIdentifier] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Devices] PRIMARY KEY CLUSTERED 
(
	[DeviceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diary]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diary](
	[ScaffoldDiaryId] [uniqueidentifier] NOT NULL,
	[Notes] [nvarchar](max) NULL,
	[PercentageStanding] [int] NOT NULL,
	[DiaryCategoryId] [uniqueidentifier] NULL,
	[StandingTonnage] [decimal](18, 2) NULL,
 CONSTRAINT [PK_dbo.Diary] PRIMARY KEY CLUSTERED 
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiaryCategories]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiaryCategories](
	[DiaryCategoryId] [uniqueidentifier] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.DiaryCategories] PRIMARY KEY CLUSTERED 
(
	[DiaryCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiaryMediaReferences]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiaryMediaReferences](
	[Diary_ScaffoldDiaryId] [uniqueidentifier] NOT NULL,
	[MediaReference_MediaReferenceId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.DiaryMediaReferences] PRIMARY KEY CLUSTERED 
(
	[Diary_ScaffoldDiaryId] ASC,
	[MediaReference_MediaReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dimensions]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dimensions](
	[DimensionId] [uniqueidentifier] NOT NULL,
	[VariationId] [uniqueidentifier] NULL,
	[ScaffoldId] [uniqueidentifier] NULL,
	[Description] [nvarchar](max) NULL,
	[Quantity] [nvarchar](max) NULL,
	[Length] [nvarchar](max) NULL,
	[Width] [nvarchar](max) NULL,
	[Height] [nvarchar](max) NULL,
	[HeightBand] [nvarchar](max) NULL,
	[TotalNumberOfLift] [nvarchar](max) NULL,
	[TotalNumberOfBoardedLift] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Dimensions] PRIMARY KEY CLUSTERED 
(
	[DimensionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DismantleLogs]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DismantleLogs](
	[DismantleLogId] [uniqueidentifier] NOT NULL,
	[DismantleId] [uniqueidentifier] NOT NULL,
	[CreatedWhen] [datetime] NOT NULL,
	[CreatedOnDevice] [nvarchar](max) NULL,
	[AppliedWhen] [datetime] NOT NULL,
	[AppliedById] [uniqueidentifier] NOT NULL,
	[CommandKey] [nvarchar](450) NULL,
	[CommandType] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.DismantleLogs] PRIMARY KEY CLUSTERED 
(
	[DismantleLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dismantles]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dismantles](
	[DismantleId] [uniqueidentifier] NOT NULL,
	[Notes] [nvarchar](max) NULL,
	[When] [datetime] NULL,
 CONSTRAINT [PK_dbo.Dismantles] PRIMARY KEY CLUSTERED 
(
	[DismantleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DismantleScaffoldDiary]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DismantleScaffoldDiary](
	[ScaffoldDiaryId] [uniqueidentifier] NOT NULL,
	[DismantleId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.DismantleScaffoldDiary] PRIMARY KEY CLUSTERED 
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmailJobs]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailJobs](
	[EmailJobId] [uniqueidentifier] NOT NULL,
	[ModulePrimaryKeyId] [uniqueidentifier] NULL,
	[ContractContactId] [uniqueidentifier] NULL,
	[EmailUniqueIdentifierKey] [varchar](1600) NULL,
	[EmailSent] [bit] NOT NULL,
	[EmailAttachmentGenerated] [bit] NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[EmailSentDateTime] [datetime] NULL,
	[EmailAttachmentGeneratedDateTime] [datetime] NULL,
	[ReportSubscriptionType] [int] NOT NULL,
	[ScheduleType] [int] NOT NULL,
	[EmailType] [int] NOT NULL,
	[NoDataPdfNotGenerated] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.EmailJobs] PRIMARY KEY CLUSTERED 
(
	[EmailJobId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmailRulesEngines]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailRulesEngines](
	[EmailRulesEngineId] [uniqueidentifier] NOT NULL,
	[EmailType] [int] NOT NULL,
	[EmailCommandHandler] [int] NOT NULL,
	[EmailXslPath] [int] NOT NULL,
	[ReportXslPath] [int] NULL,
	[ReportCommandHandler] [int] NULL,
	[EmailTriggerType] [int] NOT NULL,
	[Enabled] [bit] NOT NULL,
	[ScheduleType] [int] NULL,
 CONSTRAINT [PK_dbo.EmailRulesEngines] PRIMARY KEY CLUSTERED 
(
	[EmailRulesEngineId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpenseTypes]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpenseTypes](
	[ExpenseTypeId] [uniqueidentifier] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[IsDefault] [bit] NOT NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
 CONSTRAINT [PK_dbo.ExpenseTypes] PRIMARY KEY CLUSTERED 
(
	[ExpenseTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HandoverHandoverQuestions]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HandoverHandoverQuestions](
	[Handover_HandoverId] [uniqueidentifier] NOT NULL,
	[HandoverQuestion_HandoverQuestionId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.HandoverHandoverQuestions] PRIMARY KEY CLUSTERED 
(
	[Handover_HandoverId] ASC,
	[HandoverQuestion_HandoverQuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HandoverHandoverSettings]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HandoverHandoverSettings](
	[HandoverHandoverSettingsId] [uniqueidentifier] NOT NULL,
	[HandoverId] [uniqueidentifier] NOT NULL,
	[HandoverSettingsId] [uniqueidentifier] NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.HandoverHandoverSettings] PRIMARY KEY CLUSTERED 
(
	[HandoverHandoverSettingsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HandoverIdentifiedRiskMediaReferences]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HandoverIdentifiedRiskMediaReferences](
	[HandoverIdentifiedRisk_HandoverIdentifiedRiskId] [uniqueidentifier] NOT NULL,
	[MediaReference_MediaReferenceId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.HandoverIdentifiedRiskMediaReferences] PRIMARY KEY CLUSTERED 
(
	[HandoverIdentifiedRisk_HandoverIdentifiedRiskId] ASC,
	[MediaReference_MediaReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HandoverIdentifiedRisks]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HandoverIdentifiedRisks](
	[HandoverIdentifiedRiskId] [uniqueidentifier] NOT NULL,
	[Comments] [nvarchar](max) NULL,
	[HandoverRiskReasonId] [uniqueidentifier] NULL,
	[HandoverRiskTypeId] [uniqueidentifier] NULL,
	[HandoverId] [uniqueidentifier] NULL,
	[HandoverRiskTypeFurtherInformation] [nvarchar](max) NULL,
	[HandoverRiskReasonFurtherInformation] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.HandoverIdentifiedRisks] PRIMARY KEY CLUSTERED 
(
	[HandoverIdentifiedRiskId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HandoverLogs]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HandoverLogs](
	[HandoverLogId] [uniqueidentifier] NOT NULL,
	[HandoverId] [uniqueidentifier] NOT NULL,
	[CreatedWhen] [datetime] NOT NULL,
	[CreatedOnDevice] [nvarchar](max) NULL,
	[AppliedWhen] [datetime] NOT NULL,
	[AppliedById] [uniqueidentifier] NOT NULL,
	[CommandKey] [nvarchar](450) NULL,
	[CommandType] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.HandoverLogs] PRIMARY KEY CLUSTERED 
(
	[HandoverLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HandoverMediaReferences]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HandoverMediaReferences](
	[Handover_HandoverId] [uniqueidentifier] NOT NULL,
	[MediaReference_MediaReferenceId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.HandoverMediaReferences] PRIMARY KEY CLUSTERED 
(
	[Handover_HandoverId] ASC,
	[MediaReference_MediaReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HandoverQuestionAnswers]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HandoverQuestionAnswers](
	[HandoverQuestionAnswerId] [uniqueidentifier] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[AnswerText] [nvarchar](max) NULL,
	[AnswerIsCorrect] [bit] NOT NULL,
	[HandoverQuestionId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_dbo.HandoverQuestionAnswers] PRIMARY KEY CLUSTERED 
(
	[HandoverQuestionAnswerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HandoverQuestions]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HandoverQuestions](
	[HandoverQuestionId] [uniqueidentifier] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[QuestionText] [nvarchar](max) NULL,
	[Archived] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.HandoverQuestions] PRIMARY KEY CLUSTERED 
(
	[HandoverQuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HandoverRiskReasons]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HandoverRiskReasons](
	[HandoverRiskReasonId] [uniqueidentifier] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.HandoverRiskReasons] PRIMARY KEY CLUSTERED 
(
	[HandoverRiskReasonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HandoverRiskTypes]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HandoverRiskTypes](
	[HandoverRiskTypeId] [uniqueidentifier] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.HandoverRiskTypes] PRIMARY KEY CLUSTERED 
(
	[HandoverRiskTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Handovers]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Handovers](
	[HandoverId] [uniqueidentifier] NOT NULL,
	[HandoverComments] [nvarchar](max) NULL,
	[NextInspectionDate] [datetime] NULL,
	[RisksIdentified] [bit] NULL,
	[HandOverType] [int] NOT NULL,
	[IdentifiedRiskDetails] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[When] [datetime] NULL,
	[HandoverReference] [nvarchar](max) NULL,
	[SiteId] [uniqueidentifier] NOT NULL,
	[CustomerId] [uniqueidentifier] NOT NULL,
	[CustomerSignature_CustomerSignatureId] [uniqueidentifier] NULL,
	[StaffSignature_StaffSignatureId] [uniqueidentifier] NULL,
	[DocumentReference] [nvarchar](450) NULL,
	[HirePeriod] [int] NULL,
	[DeletedDateTime] [datetime] NULL,
	[DeletedBy] [uniqueidentifier] NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Handovers] PRIMARY KEY CLUSTERED 
(
	[HandoverId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HandoverScaffoldDiary]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HandoverScaffoldDiary](
	[ScaffoldDiaryId] [uniqueidentifier] NOT NULL,
	[HandoverId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.HandoverScaffoldDiary] PRIMARY KEY CLUSTERED 
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HandoverScaffolds]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HandoverScaffolds](
	[Handover_HandoverId] [uniqueidentifier] NOT NULL,
	[Scaffold_ScaffoldId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.HandoverScaffolds] PRIMARY KEY CLUSTERED 
(
	[Handover_HandoverId] ASC,
	[Scaffold_ScaffoldId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HandoverSettings]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HandoverSettings](
	[HandoverSettingsId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Type] [int] NOT NULL,
	[Mandatory] [bit] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.HandoverSettings] PRIMARY KEY CLUSTERED 
(
	[HandoverSettingsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hours]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hours](
	[HoursId] [uniqueidentifier] NOT NULL,
	[Quantity] [decimal](18, 2) NOT NULL,
	[StaffRateId] [uniqueidentifier] NOT NULL,
	[TimeEntry_TimeEntryId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_dbo.Hours] PRIMARY KEY CLUSTERED 
(
	[HoursId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InspectionDefectMediaReferences]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InspectionDefectMediaReferences](
	[InspectionDefect_InspectionDefectId] [uniqueidentifier] NOT NULL,
	[MediaReference_MediaReferenceId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.InspectionDefectMediaReferences] PRIMARY KEY CLUSTERED 
(
	[InspectionDefect_InspectionDefectId] ASC,
	[MediaReference_MediaReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InspectionDefects]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InspectionDefects](
	[InspectionDefectId] [uniqueidentifier] NOT NULL,
	[DefectTypeId] [uniqueidentifier] NULL,
	[DefectTypeFurtherInformation] [nvarchar](max) NULL,
	[Comments] [nvarchar](max) NULL,
	[DefectStatus] [int] NOT NULL,
	[ScaffoldInspection_ScaffoldDiaryId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_dbo.InspectionDefects] PRIMARY KEY CLUSTERED 
(
	[InspectionDefectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InspectionDefectStatusTypes]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InspectionDefectStatusTypes](
	[DefectStatusId] [uniqueidentifier] NOT NULL,
	[DefectStatus] [int] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.InspectionDefectStatusTypes] PRIMARY KEY CLUSTERED 
(
	[DefectStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InspectionFollowUp]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InspectionFollowUp](
	[ScaffoldDiaryId] [uniqueidentifier] NOT NULL,
	[RelatedInspectionId] [uniqueidentifier] NOT NULL,
	[InspectionFollowUpWorkflowStatus] [int] NOT NULL,
 CONSTRAINT [PK_dbo.InspectionFollowUp] PRIMARY KEY CLUSTERED 
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InspectionFollowUpInstruction]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InspectionFollowUpInstruction](
	[ScaffoldDiaryId] [uniqueidentifier] NOT NULL,
	[Instructions] [nvarchar](max) NULL,
	[ToBeDoneBy] [datetime] NULL,
	[EmailsSent] [datetime] NULL,
 CONSTRAINT [PK_dbo.InspectionFollowUpInstruction] PRIMARY KEY CLUSTERED 
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InspectionFollowUpInstructionStaffs]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InspectionFollowUpInstructionStaffs](
	[InspectionFollowUpInstruction_ScaffoldDiaryId] [uniqueidentifier] NOT NULL,
	[Staff_StaffId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.InspectionFollowUpInstructionStaffs] PRIMARY KEY CLUSTERED 
(
	[InspectionFollowUpInstruction_ScaffoldDiaryId] ASC,
	[Staff_StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InspectionFollowUpNotify]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InspectionFollowUpNotify](
	[ScaffoldDiaryId] [uniqueidentifier] NOT NULL,
	[InspectorsRecommendations] [nvarchar](max) NULL,
	[GenerateUnsafeReport] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.InspectionFollowUpNotify] PRIMARY KEY CLUSTERED 
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InspectionFollowUpNotifyContractContacts]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InspectionFollowUpNotifyContractContacts](
	[InspectionFollowUpNotify_ScaffoldDiaryId] [uniqueidentifier] NOT NULL,
	[ContractContact_ContractContactId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.InspectionFollowUpNotifyContractContacts] PRIMARY KEY CLUSTERED 
(
	[InspectionFollowUpNotify_ScaffoldDiaryId] ASC,
	[ContractContact_ContractContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InspectionOutcomes]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InspectionOutcomes](
	[InspectionOutcomeId] [uniqueidentifier] NOT NULL,
	[IsSafe] [bit] NOT NULL,
	[AppliesToDefectStatus] [int] NULL,
	[RequireNotify] [bit] NOT NULL,
	[RequireInstruct] [bit] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.InspectionOutcomes] PRIMARY KEY CLUSTERED 
(
	[InspectionOutcomeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InspectionTypes]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InspectionTypes](
	[InspectionTypeId] [uniqueidentifier] NOT NULL,
	[AdvanceTheClockByTicks] [bigint] NULL,
	[ParentId] [uniqueidentifier] NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.InspectionTypes] PRIMARY KEY CLUSTERED 
(
	[InspectionTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[ItemId] [uniqueidentifier] NOT NULL,
	[ContractId] [uniqueidentifier] NOT NULL,
	[QuoteId] [uniqueidentifier] NULL,
	[AllocatedHours] [decimal](18, 2) NULL,
	[AllocatedCost] [decimal](18, 2) NULL,
	[ItemName] [nvarchar](max) NULL,
	[ItemNumber] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[ItemType] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Items] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoadingLimits]    Script Date: 21/03/2020 11:35:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoadingLimits](
	[LoadingLimitId] [uniqueidentifier] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.LoadingLimits] PRIMARY KEY CLUSTERED 
(
	[LoadingLimitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MediaReferences]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MediaReferences](
	[MediaReferenceId] [uniqueidentifier] NOT NULL,
	[PathToFile] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[MimeType] [nvarchar](max) NULL,
	[CheckSum] [nvarchar](max) NULL,
	[FileSize] [int] NOT NULL,
	[Dismantle_DismantleId] [uniqueidentifier] NULL,
	[VariationInstruction_VariationInstructionId] [uniqueidentifier] NULL,
	[MediaTranscriptionId] [uniqueidentifier] NULL,
	[MediaDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.MediaReferences] PRIMARY KEY CLUSTERED 
(
	[MediaReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MediaTranscriptions]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MediaTranscriptions](
	[MediaTranscriptionId] [uniqueidentifier] NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Transcription] [nvarchar](max) NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.MediaTranscriptions] PRIMARY KEY CLUSTERED 
(
	[MediaTranscriptionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MethodOfCladdings]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MethodOfCladdings](
	[MethodOfCladdingId] [uniqueidentifier] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.MethodOfCladdings] PRIMARY KEY CLUSTERED 
(
	[MethodOfCladdingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MethodOfTyings]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MethodOfTyings](
	[MethodOfTyingId] [uniqueidentifier] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.MethodOfTyings] PRIMARY KEY CLUSTERED 
(
	[MethodOfTyingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OffHireLogs]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OffHireLogs](
	[OffHireLogId] [uniqueidentifier] NOT NULL,
	[OffHireId] [uniqueidentifier] NOT NULL,
	[CreatedWhen] [datetime] NOT NULL,
	[CreatedOnDevice] [nvarchar](max) NULL,
	[AppliedWhen] [datetime] NOT NULL,
	[AppliedById] [uniqueidentifier] NOT NULL,
	[CommandKey] [nvarchar](450) NULL,
	[CommandType] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.OffHireLogs] PRIMARY KEY CLUSTERED 
(
	[OffHireLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OffHireMediaReferences]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OffHireMediaReferences](
	[OffHire_OffHireId] [uniqueidentifier] NOT NULL,
	[MediaReference_MediaReferenceId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.OffHireMediaReferences] PRIMARY KEY CLUSTERED 
(
	[OffHire_OffHireId] ASC,
	[MediaReference_MediaReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OffHires]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OffHires](
	[OffHireId] [uniqueidentifier] NOT NULL,
	[OffHireType] [int] NOT NULL,
	[OffHireReference] [nvarchar](max) NULL,
	[SiteId] [uniqueidentifier] NOT NULL,
	[CustomerId] [uniqueidentifier] NOT NULL,
	[OffHireComments] [nvarchar](max) NULL,
	[When] [datetime] NULL,
	[RequestedOn] [datetime] NULL,
	[ContractContactId] [uniqueidentifier] NULL,
	[Status] [int] NOT NULL,
	[CustomerSignature_CustomerSignatureId] [uniqueidentifier] NULL,
	[StaffSignature_StaffSignatureId] [uniqueidentifier] NULL,
	[DeletedDateTime] [datetime] NULL,
	[DeletedBy] [uniqueidentifier] NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.OffHires] PRIMARY KEY CLUSTERED 
(
	[OffHireId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OffHireScaffoldDiary]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OffHireScaffoldDiary](
	[ScaffoldDiaryId] [uniqueidentifier] NOT NULL,
	[OffHireId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.OffHireScaffoldDiary] PRIMARY KEY CLUSTERED 
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OffHireScaffolds]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OffHireScaffolds](
	[OffHire_OffHireId] [uniqueidentifier] NOT NULL,
	[Scaffold_ScaffoldId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.OffHireScaffolds] PRIMARY KEY CLUSTERED 
(
	[OffHire_OffHireId] ASC,
	[Scaffold_ScaffoldId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quotes]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quotes](
	[QuoteId] [uniqueidentifier] NOT NULL,
	[QuoteNumber] [nvarchar](max) NULL,
	[Estimator] [nvarchar](max) NULL,
	[ContractId] [uniqueidentifier] NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Quotes] PRIMARY KEY CLUSTERED 
(
	[QuoteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RateTypes]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RateTypes](
	[RateTypeId] [uniqueidentifier] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[IsDefault] [bit] NOT NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
 CONSTRAINT [PK_dbo.RateTypes] PRIMARY KEY CLUSTERED 
(
	[RateTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RefreshTokens]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RefreshTokens](
	[Id] [uniqueidentifier] NOT NULL,
	[Subject] [nvarchar](50) NOT NULL,
	[ClientId] [nvarchar](50) NOT NULL,
	[IssuedUtc] [datetime] NOT NULL,
	[ExpiresUtc] [datetime] NOT NULL,
	[ProtectedTicket] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.RefreshTokens] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReportSections]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReportSections](
	[ReportSectionId] [uniqueidentifier] NOT NULL,
	[Report] [int] NULL,
	[Content] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.ReportSections] PRIMARY KEY CLUSTERED 
(
	[ReportSectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReportSubscriptions]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReportSubscriptions](
	[ReportSubscriptionId] [uniqueidentifier] NOT NULL,
	[ReportSubscriptionType] [int] NOT NULL,
	[ScheduleType] [int] NULL,
	[ScheduledReportStartDate] [datetime] NULL,
	[ContractContactId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.ReportSubscriptions] PRIMARY KEY CLUSTERED 
(
	[ReportSubscriptionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScaffoldDiaries]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScaffoldDiaries](
	[ScaffoldDiaryId] [uniqueidentifier] NOT NULL,
	[ScaffoldId] [uniqueidentifier] NOT NULL,
	[DiaryEntryStatus] [int] NOT NULL,
	[When] [datetime] NULL,
	[OwnerId] [uniqueidentifier] NULL,
	[OffsetFromUtc] [int] NOT NULL,
	[DeletedDateTime] [datetime] NULL,
	[DeletedBy] [uniqueidentifier] NULL,
	[IsDeleted] [bit] NOT NULL,
	[AppliedWhen] [datetime] NULL,
 CONSTRAINT [PK_dbo.ScaffoldDiaries] PRIMARY KEY CLUSTERED 
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScaffoldingSystems]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScaffoldingSystems](
	[ScaffoldingSystemId] [uniqueidentifier] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[IsDefault] [bit] NOT NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
 CONSTRAINT [PK_dbo.ScaffoldingSystems] PRIMARY KEY CLUSTERED 
(
	[ScaffoldingSystemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScaffoldInspection]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScaffoldInspection](
	[ScaffoldDiaryId] [uniqueidentifier] NOT NULL,
	[InspectorsSignature_StaffSignatureId] [uniqueidentifier] NULL,
	[InspectionWorkflowStatus] [int] NOT NULL,
	[Comments] [nvarchar](max) NULL,
	[InspectionTypeId] [uniqueidentifier] NULL,
	[InspectionTypeFurtherInformation] [nvarchar](max) NULL,
	[InspectionOutcomeId] [uniqueidentifier] NULL,
	[IsDetailedInspectionReportAvailable] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.ScaffoldInspection] PRIMARY KEY CLUSTERED 
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScaffoldInspectionMediaReferences]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScaffoldInspectionMediaReferences](
	[ScaffoldInspection_ScaffoldDiaryId] [uniqueidentifier] NOT NULL,
	[MediaReference_MediaReferenceId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.ScaffoldInspectionMediaReferences] PRIMARY KEY CLUSTERED 
(
	[ScaffoldInspection_ScaffoldDiaryId] ASC,
	[MediaReference_MediaReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScaffoldItems]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScaffoldItems](
	[ScaffoldItemId] [uniqueidentifier] NOT NULL,
	[ScaffoldTypeId] [uniqueidentifier] NULL,
	[ScaffoldTypeFurtherInformation] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[QuoteNumber] [nvarchar](max) NULL,
	[QuoteItemNumber] [nvarchar](max) NULL,
	[SiteInstructionReference] [nvarchar](max) NULL,
	[ContractPrice] [int] NULL,
	[ExtraHireRate] [int] NULL,
	[DesignTypeId] [uniqueidentifier] NULL,
	[DesignTypeFurtherInformation] [nvarchar](max) NULL,
	[LoadingLimitId] [uniqueidentifier] NULL,
	[LoadingLimitFurtherInformation] [nvarchar](max) NULL,
	[MethodOfTyingId] [uniqueidentifier] NULL,
	[MethodOfTyingFurtherInformation] [nvarchar](max) NULL,
	[MethodOfCladdingId] [uniqueidentifier] NULL,
	[MethodOfCladdingFurtherInformation] [nvarchar](max) NULL,
	[ScaffoldItemDimensions_Quantity] [nvarchar](max) NULL,
	[ScaffoldItemDimensions_Length] [nvarchar](max) NULL,
	[ScaffoldItemDimensions_Width] [nvarchar](max) NULL,
	[ScaffoldItemDimensions_Height] [nvarchar](max) NULL,
	[ScaffoldItemDimensions_HeightBand] [nvarchar](max) NULL,
	[ScaffoldItemDimensions_TotalNumberOfLifts] [nvarchar](max) NULL,
	[ScaffoldItemDimensions_NumberOfBoardedLifts] [nvarchar](max) NULL,
	[ScaffoldItemDimensions_BaySize] [nvarchar](max) NULL,
	[ScaffoldItemDimensions_NumberOfTies] [nvarchar](max) NULL,
	[SiteInstructionRecivedFrom_ContractContactId] [uniqueidentifier] NULL,
	[ScaffoldItemStatus] [int] NOT NULL,
	[HirePeriod] [int] NULL,
	[ScaffoldingSystemId] [uniqueidentifier] NULL,
	[MaximumTonnage] [decimal](18, 2) NOT NULL,
	[StandingTonnage] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_dbo.ScaffoldItems] PRIMARY KEY CLUSTERED 
(
	[ScaffoldItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScaffoldLogs]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScaffoldLogs](
	[ScaffoldLogId] [uniqueidentifier] NOT NULL,
	[ScaffoldId] [uniqueidentifier] NOT NULL,
	[CreatedWhen] [datetime] NOT NULL,
	[CreatedOnDevice] [nvarchar](max) NULL,
	[AppliedWhen] [datetime] NOT NULL,
	[AppliedById] [uniqueidentifier] NOT NULL,
	[CommandKey] [nvarchar](450) NULL,
	[CommandType] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.ScaffoldLogs] PRIMARY KEY CLUSTERED 
(
	[ScaffoldLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Scaffolds]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Scaffolds](
	[ScaffoldId] [uniqueidentifier] NOT NULL,
	[SiteAreaId] [uniqueidentifier] NOT NULL,
	[ContractId] [uniqueidentifier] NOT NULL,
	[ScaffoldStatusId] [uniqueidentifier] NOT NULL,
	[ScaffoldNumber] [nvarchar](max) NULL,
	[SpecificLocationDetails] [nvarchar](max) NULL,
	[DateOfNextInspection] [datetime] NULL,
	[AdverseWeatherIndicator] [bit] NOT NULL,
	[ParentScaffoldId] [uniqueidentifier] NULL,
	[OffHireDate] [datetime] NULL,
	[OnHireDate] [datetime] NULL,
	[Dismantle_DismantleId] [uniqueidentifier] NULL,
	[ScaffoldImageId] [uniqueidentifier] NOT NULL,
	[ScaffoldImage_MediaReferenceId] [uniqueidentifier] NULL,
	[ModifiedDate] [datetime] NULL,
	[ItemId] [uniqueidentifier] NULL,
	[Latitude] [float] NULL,
	[Longitude] [float] NULL,
 CONSTRAINT [PK_dbo.Scaffolds] PRIMARY KEY CLUSTERED 
(
	[ScaffoldId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScaffoldSpecificationDiary]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScaffoldSpecificationDiary](
	[ScaffoldDiaryId] [uniqueidentifier] NOT NULL,
	[Handover_HandoverId] [uniqueidentifier] NULL,
	[ScaffoldItemId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.ScaffoldSpecificationDiary] PRIMARY KEY CLUSTERED 
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScaffoldStatus]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScaffoldStatus](
	[ScaffoldStatusId] [uniqueidentifier] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.ScaffoldStatus] PRIMARY KEY CLUSTERED 
(
	[ScaffoldStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScaffoldTags]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScaffoldTags](
	[ScaffoldTagId] [uniqueidentifier] NOT NULL,
	[ScaffoldId] [uniqueidentifier] NOT NULL,
	[TagContents] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.ScaffoldTags] PRIMARY KEY CLUSTERED 
(
	[ScaffoldTagId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScaffoldTypeHandoverQuestions]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScaffoldTypeHandoverQuestions](
	[HandoverQuestion_HandoverQuestionId] [uniqueidentifier] NOT NULL,
	[ScaffoldType_ScaffoldTypeId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.ScaffoldTypeHandoverQuestions] PRIMARY KEY CLUSTERED 
(
	[ScaffoldType_ScaffoldTypeId] ASC,
	[HandoverQuestion_HandoverQuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScaffoldTypes]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScaffoldTypes](
	[ScaffoldTypeId] [uniqueidentifier] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.ScaffoldTypes] PRIMARY KEY CLUSTERED 
(
	[ScaffoldTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SiteAreas]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiteAreas](
	[SiteAreaId] [uniqueidentifier] NOT NULL,
	[AreaName] [nvarchar](max) NULL,
	[SiteId] [uniqueidentifier] NOT NULL,
	[IsDefaultArea] [bit] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.SiteAreas] PRIMARY KEY CLUSTERED 
(
	[SiteAreaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SiteDepots]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiteDepots](
	[SiteDepotId] [uniqueidentifier] NOT NULL,
	[DepotName] [nvarchar](max) NULL,
	[Deleted] [bit] NOT NULL,
	[Latitude] [float] NULL,
	[Longitude] [float] NULL,
	[DepotAddress] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[EmailAddress] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.SiteDepots] PRIMARY KEY CLUSTERED 
(
	[SiteDepotId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SiteLogs]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiteLogs](
	[SiteLogId] [uniqueidentifier] NOT NULL,
	[SiteId] [uniqueidentifier] NOT NULL,
	[CreatedWhen] [datetime] NOT NULL,
	[CreatedOnDevice] [nvarchar](max) NULL,
	[AppliedWhen] [datetime] NOT NULL,
	[AppliedById] [uniqueidentifier] NOT NULL,
	[CommandKey] [nvarchar](450) NULL,
	[CommandType] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.SiteLogs] PRIMARY KEY CLUSTERED 
(
	[SiteLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sites]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sites](
	[SiteId] [uniqueidentifier] NOT NULL,
	[SiteName] [nvarchar](max) NULL,
	[SiteReference] [nvarchar](250) NOT NULL,
	[SiteAddress] [nvarchar](max) NULL,
	[Latitude] [float] NULL,
	[Longitude] [float] NULL,
	[SiteStatusId] [uniqueidentifier] NOT NULL,
	[SiteDepotId] [uniqueidentifier] NOT NULL,
	[SiteImageId] [uniqueidentifier] NOT NULL,
	[SiteImage_MediaReferenceId] [uniqueidentifier] NULL,
	[IsCameraAllowed] [bit] NOT NULL,
	[SiteSetupFrom] [int] NULL,
	[IsManageStockControl] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Sites] PRIMARY KEY CLUSTERED 
(
	[SiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SiteStatus]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiteStatus](
	[SiteStatusId] [uniqueidentifier] NOT NULL,
	[IsClosed] [bit] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
	[IsDefault] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.SiteStatus] PRIMARY KEY CLUSTERED 
(
	[SiteStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SiteTonnages]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiteTonnages](
	[SiteTonnageId] [uniqueidentifier] NOT NULL,
	[SiteId] [uniqueidentifier] NOT NULL,
	[ScaffoldingSystemId] [uniqueidentifier] NOT NULL,
	[TotalTonnage] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_dbo.SiteTonnages] PRIMARY KEY CLUSTERED 
(
	[SiteTonnageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffDepots]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffDepots](
	[SiteDepotId] [uniqueidentifier] NOT NULL,
	[StaffId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.StaffDepots] PRIMARY KEY CLUSTERED 
(
	[SiteDepotId] ASC,
	[StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffExpenses]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffExpenses](
	[StaffExpenseId] [uniqueidentifier] NOT NULL,
	[ExpenseTypeId] [uniqueidentifier] NOT NULL,
	[Cost] [decimal](18, 2) NOT NULL,
	[TimesheetPeriodStaff_TimesheetPeriodStaffId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_dbo.StaffExpenses] PRIMARY KEY CLUSTERED 
(
	[StaffExpenseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffLogs]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffLogs](
	[StaffLogId] [uniqueidentifier] NOT NULL,
	[StaffId] [uniqueidentifier] NOT NULL,
	[CreatedWhen] [datetime] NOT NULL,
	[CreatedOnDevice] [nvarchar](max) NULL,
	[AppliedWhen] [datetime] NOT NULL,
	[AppliedById] [uniqueidentifier] NOT NULL,
	[CommandKey] [nvarchar](450) NULL,
	[CommandType] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.StaffLogs] PRIMARY KEY CLUSTERED 
(
	[StaffLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffRates]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffRates](
	[StaffRateId] [uniqueidentifier] NOT NULL,
	[HourlyRate] [decimal](18, 2) NOT NULL,
	[EffectiveFrom] [datetime] NOT NULL,
	[EffectiveTo] [datetime] NULL,
	[RateTypeId] [uniqueidentifier] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[Staff_StaffId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_dbo.StaffRates] PRIMARY KEY CLUSTERED 
(
	[StaffRateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffRoles]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffRoles](
	[StaffId] [uniqueidentifier] NOT NULL,
	[ApplicationRoleId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.StaffRoles] PRIMARY KEY CLUSTERED 
(
	[StaffId] ASC,
	[ApplicationRoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staffs]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staffs](
	[StaffId] [uniqueidentifier] NOT NULL,
	[Deleted] [bit] NOT NULL,
	[ContactName] [nvarchar](max) NULL,
	[EmailAddress] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[UserAccountId] [uniqueidentifier] NOT NULL,
	[UserCode] [int] NOT NULL,
	[ExternalAuthUserId] [uniqueidentifier] NOT NULL,
	[CanEstimate] [bit] NOT NULL,
	[EulaAgreedVersion] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Staffs] PRIMARY KEY CLUSTERED 
(
	[StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffSignatures]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffSignatures](
	[StaffSignatureId] [uniqueidentifier] NOT NULL,
	[StaffId] [uniqueidentifier] NOT NULL,
	[DataPath] [nvarchar](max) NULL,
	[When] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.StaffSignatures] PRIMARY KEY CLUSTERED 
(
	[StaffSignatureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffSites]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffSites](
	[StaffSiteId] [uniqueidentifier] NOT NULL,
	[SiteId] [uniqueidentifier] NOT NULL,
	[StaffId] [uniqueidentifier] NOT NULL,
	[ReceiveInspectionReports] [bit] NOT NULL,
	[CanView] [bit] NOT NULL,
	[CanEdit] [bit] NOT NULL,
	[IsInactive] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.StaffSites] PRIMARY KEY CLUSTERED 
(
	[StaffSiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tasks](
	[TaskId] [uniqueidentifier] NOT NULL,
	[TaskTypeId] [uniqueidentifier] NOT NULL,
	[AllocatedHours] [decimal](18, 2) NULL,
	[ActualHours] [decimal](18, 2) NULL,
	[AllocatedCost] [decimal](18, 2) NULL,
	[TaskStatus] [int] NOT NULL,
	[PercentageComplete] [decimal](18, 2) NOT NULL,
	[Item_ItemId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_dbo.Tasks] PRIMARY KEY CLUSTERED 
(
	[TaskId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaskTypes]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskTypes](
	[TaskTypeId] [uniqueidentifier] NOT NULL,
	[GroupTitle] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[ReportText] [nvarchar](max) NULL,
	[RequireFurtherInformation] [bit] NOT NULL,
	[SortOrder] [int] NOT NULL,
	[IconName] [nvarchar](max) NULL,
	[IsDefault] [bit] NOT NULL,
	[ReplacedWithId] [uniqueidentifier] NULL,
	[Deleted] [bit] NOT NULL,
	[Configuration_ConfigurationId] [bit] NULL,
 CONSTRAINT [PK_dbo.TaskTypes] PRIMARY KEY CLUSTERED 
(
	[TaskTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimeEntries]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeEntries](
	[TimeEntryId] [uniqueidentifier] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Cost] [decimal](18, 2) NULL,
	[TimesheetPeriodStaff_TimesheetPeriodStaffId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_dbo.TimeEntries] PRIMARY KEY CLUSTERED 
(
	[TimeEntryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimesheetPeriods]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimesheetPeriods](
	[TimesheetPeriodId] [uniqueidentifier] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[PercentageComplete] [decimal](18, 2) NOT NULL,
	[Status] [int] NOT NULL,
	[PreviousTimesheetPeriodId] [uniqueidentifier] NULL,
	[CumulativeHoursSubmitted] [decimal](18, 2) NULL,
	[CumulativeCostSubmitted] [decimal](18, 2) NULL,
	[Timesheet_TimesheetId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_dbo.TimesheetPeriods] PRIMARY KEY CLUSTERED 
(
	[TimesheetPeriodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimesheetPeriodStaffs]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimesheetPeriodStaffs](
	[TimesheetPeriodStaffId] [uniqueidentifier] NOT NULL,
	[StaffId] [uniqueidentifier] NOT NULL,
	[Deleted] [bit] NOT NULL,
	[TimesheetPeriod_TimesheetPeriodId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_dbo.TimesheetPeriodStaffs] PRIMARY KEY CLUSTERED 
(
	[TimesheetPeriodStaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Timesheets]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Timesheets](
	[TimesheetId] [uniqueidentifier] NOT NULL,
	[ContractId] [uniqueidentifier] NOT NULL,
	[ItemId] [uniqueidentifier] NOT NULL,
	[TaskId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.Timesheets] PRIMARY KEY CLUSTERED 
(
	[TimesheetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnsafeScaffoldReport]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnsafeScaffoldReport](
	[ScaffoldDiaryId] [uniqueidentifier] NOT NULL,
	[CustomerSignature_CustomerSignatureId] [uniqueidentifier] NULL,
	[InspectorsSignature_StaffSignatureId] [uniqueidentifier] NULL,
	[SiteManager_StaffId] [uniqueidentifier] NULL,
	[SiteManagersSignature_StaffSignatureId] [uniqueidentifier] NULL,
	[SiteManagerRecommendations] [nvarchar](max) NULL,
	[EmailsSent] [datetime] NULL,
 CONSTRAINT [PK_dbo.UnsafeScaffoldReport] PRIMARY KEY CLUSTERED 
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnsafeScaffoldReportContractContacts]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnsafeScaffoldReportContractContacts](
	[UnsafeScaffoldReport_ScaffoldDiaryId] [uniqueidentifier] NOT NULL,
	[ContractContact_ContractContactId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.UnsafeScaffoldReportContractContacts] PRIMARY KEY CLUSTERED 
(
	[UnsafeScaffoldReport_ScaffoldDiaryId] ASC,
	[ContractContact_ContractContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnsafeScaffoldReportStaffs]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnsafeScaffoldReportStaffs](
	[UnsafeScaffoldReport_ScaffoldDiaryId] [uniqueidentifier] NOT NULL,
	[Staff_StaffId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_dbo.UnsafeScaffoldReportStaffs] PRIMARY KEY CLUSTERED 
(
	[UnsafeScaffoldReport_ScaffoldDiaryId] ASC,
	[Staff_StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VariationInstructions]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VariationInstructions](
	[VariationInstructionId] [uniqueidentifier] NOT NULL,
	[SiteInstructionReference] [nvarchar](max) NULL,
	[SiteInstructionReceivedFromId] [uniqueidentifier] NULL,
	[Notes] [nvarchar](max) NULL,
	[EstimatorId] [uniqueidentifier] NULL,
	[SubmittedForPricing] [bit] NOT NULL,
	[ContractPrice] [decimal](9, 2) NULL,
	[ExtraHireRate] [decimal](9, 2) NULL,
	[HirePeriod] [int] NULL,
 CONSTRAINT [PK_dbo.VariationInstructions] PRIMARY KEY CLUSTERED 
(
	[VariationInstructionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VariationLogs]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VariationLogs](
	[VariationLogId] [uniqueidentifier] NOT NULL,
	[VariationId] [uniqueidentifier] NOT NULL,
	[SendEmailToEstimator] [bit] NOT NULL,
	[CreatedWhen] [datetime] NOT NULL,
	[CreatedOnDevice] [nvarchar](max) NULL,
	[AppliedWhen] [datetime] NOT NULL,
	[AppliedById] [uniqueidentifier] NOT NULL,
	[CommandKey] [nvarchar](450) NULL,
	[CommandType] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.VariationLogs] PRIMARY KEY CLUSTERED 
(
	[VariationLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Variations]    Script Date: 21/03/2020 11:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Variations](
	[VariationId] [uniqueidentifier] NOT NULL,
	[HandoverId] [uniqueidentifier] NOT NULL,
	[VariationType] [int] NOT NULL,
	[VariationInstructionId] [uniqueidentifier] NULL,
	[DeletedDateTime] [datetime] NULL,
	[DeletedBy] [uniqueidentifier] NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Variations] PRIMARY KEY CLUSTERED 
(
	[VariationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_ApplicationPermissionId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ApplicationPermissionId] ON [dbo].[ApplicationRolePermission]
(
	[ApplicationPermissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ApplicationRoleId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ApplicationRoleId] ON [dbo].[ApplicationRolePermission]
(
	[ApplicationRoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[ApplicationRoles]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_CommandKey]    Script Date: 21/03/2020 11:35:14 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_CommandKey] ON [dbo].[ConfigurationLogs]
(
	[CommandKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ConfigurationId] ON [dbo].[ConfigurationLogs]
(
	[ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MediaReferenceId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_MediaReferenceId] ON [dbo].[Configurations]
(
	[MediaReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_NewContractStatus_ContractStatusId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_NewContractStatus_ContractStatusId] ON [dbo].[Configurations]
(
	[NewContractStatus_ContractStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_NewCustomerStatus_CustomerStatusId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_NewCustomerStatus_CustomerStatusId] ON [dbo].[Configurations]
(
	[NewCustomerStatus_CustomerStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_NewInspectionDefectStatus_DefectStatusId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_NewInspectionDefectStatus_DefectStatusId] ON [dbo].[Configurations]
(
	[NewInspectionDefectStatus_DefectStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_NewScaffoldStatus_ScaffoldStatusId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_NewScaffoldStatus_ScaffoldStatusId] ON [dbo].[Configurations]
(
	[NewScaffoldStatus_ScaffoldStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_NewSiteStatus_SiteStatusId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_NewSiteStatus_SiteStatusId] ON [dbo].[Configurations]
(
	[NewSiteStatus_SiteStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[ContactTypes]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContactTypeId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ContactTypeId] ON [dbo].[ContractContacts]
(
	[ContactTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContractId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ContractId] ON [dbo].[ContractContacts]
(
	[ContractId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_CommandKey]    Script Date: 21/03/2020 11:35:14 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_CommandKey] ON [dbo].[ContractLogs]
(
	[CommandKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContractId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ContractId] ON [dbo].[ContractLogs]
(
	[ContractId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContractStatusId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ContractStatusId] ON [dbo].[Contracts]
(
	[ContractStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContractTypeId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ContractTypeId] ON [dbo].[Contracts]
(
	[ContractTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CustomerId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_CustomerId] ON [dbo].[Contracts]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_SiteId] ON [dbo].[Contracts]
(
	[SiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldDiaryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldDiaryId] ON [dbo].[ContractScaffoldDiary]
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[ContractStatus]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[ContractTypes]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_CommandKey]    Script Date: 21/03/2020 11:35:14 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_CommandKey] ON [dbo].[CustomerLogs]
(
	[CommandKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CustomerId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_CustomerId] ON [dbo].[CustomerLogs]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CustomerImage_MediaReferenceId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_CustomerImage_MediaReferenceId] ON [dbo].[Customers]
(
	[CustomerImage_MediaReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CustomerStatusId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_CustomerStatusId] ON [dbo].[Customers]
(
	[CustomerStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContractContactId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ContractContactId] ON [dbo].[CustomerSignatures]
(
	[ContractContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[CustomerStatus]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[DefectTypes]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[DesignTypes]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DiaryCategoryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_DiaryCategoryId] ON [dbo].[Diary]
(
	[DiaryCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldDiaryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldDiaryId] ON [dbo].[Diary]
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[DiaryCategories]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Diary_ScaffoldDiaryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Diary_ScaffoldDiaryId] ON [dbo].[DiaryMediaReferences]
(
	[Diary_ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MediaReference_MediaReferenceId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_MediaReference_MediaReferenceId] ON [dbo].[DiaryMediaReferences]
(
	[MediaReference_MediaReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldId] ON [dbo].[Dimensions]
(
	[ScaffoldId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_VariationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_VariationId] ON [dbo].[Dimensions]
(
	[VariationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_CommandKey]    Script Date: 21/03/2020 11:35:14 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_CommandKey] ON [dbo].[DismantleLogs]
(
	[CommandKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DismantleId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_DismantleId] ON [dbo].[DismantleLogs]
(
	[DismantleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DismantleId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_DismantleId] ON [dbo].[DismantleScaffoldDiary]
(
	[DismantleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldDiaryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldDiaryId] ON [dbo].[DismantleScaffoldDiary]
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_EmailUniqueIdentifierKey]    Script Date: 21/03/2020 11:35:14 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UC_EmailUniqueIdentifierKey] ON [dbo].[EmailJobs]
(
	[EmailUniqueIdentifierKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[ExpenseTypes]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Handover_HandoverId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Handover_HandoverId] ON [dbo].[HandoverHandoverQuestions]
(
	[Handover_HandoverId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_HandoverQuestion_HandoverQuestionId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_HandoverQuestion_HandoverQuestionId] ON [dbo].[HandoverHandoverQuestions]
(
	[HandoverQuestion_HandoverQuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_HandoverId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_HandoverId] ON [dbo].[HandoverHandoverSettings]
(
	[HandoverId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_HandoverSettingsId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_HandoverSettingsId] ON [dbo].[HandoverHandoverSettings]
(
	[HandoverSettingsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_HandoverIdentifiedRisk_HandoverIdentifiedRiskId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_HandoverIdentifiedRisk_HandoverIdentifiedRiskId] ON [dbo].[HandoverIdentifiedRiskMediaReferences]
(
	[HandoverIdentifiedRisk_HandoverIdentifiedRiskId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MediaReference_MediaReferenceId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_MediaReference_MediaReferenceId] ON [dbo].[HandoverIdentifiedRiskMediaReferences]
(
	[MediaReference_MediaReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_HandoverId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_HandoverId] ON [dbo].[HandoverIdentifiedRisks]
(
	[HandoverId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_HandoverRiskReasonId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_HandoverRiskReasonId] ON [dbo].[HandoverIdentifiedRisks]
(
	[HandoverRiskReasonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_HandoverRiskTypeId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_HandoverRiskTypeId] ON [dbo].[HandoverIdentifiedRisks]
(
	[HandoverRiskTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_CommandKey]    Script Date: 21/03/2020 11:35:14 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_CommandKey] ON [dbo].[HandoverLogs]
(
	[CommandKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_HandoverId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_HandoverId] ON [dbo].[HandoverLogs]
(
	[HandoverId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Handover_HandoverId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Handover_HandoverId] ON [dbo].[HandoverMediaReferences]
(
	[Handover_HandoverId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MediaReference_MediaReferenceId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_MediaReference_MediaReferenceId] ON [dbo].[HandoverMediaReferences]
(
	[MediaReference_MediaReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_HandoverQuestionId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_HandoverQuestionId] ON [dbo].[HandoverQuestionAnswers]
(
	[HandoverQuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[HandoverRiskReasons]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[HandoverRiskTypes]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [AK_Handover_DocumentReference]    Script Date: 21/03/2020 11:35:14 ******/
CREATE UNIQUE NONCLUSTERED INDEX [AK_Handover_DocumentReference] ON [dbo].[Handovers]
(
	[DocumentReference] ASC
)
WHERE ([DocumentReference] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CustomerId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_CustomerId] ON [dbo].[Handovers]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CustomerSignature_CustomerSignatureId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_CustomerSignature_CustomerSignatureId] ON [dbo].[Handovers]
(
	[CustomerSignature_CustomerSignatureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DeletedBy]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_DeletedBy] ON [dbo].[Handovers]
(
	[DeletedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_SiteId] ON [dbo].[Handovers]
(
	[SiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_StaffSignature_StaffSignatureId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_StaffSignature_StaffSignatureId] ON [dbo].[Handovers]
(
	[StaffSignature_StaffSignatureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_HandoverId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_HandoverId] ON [dbo].[HandoverScaffoldDiary]
(
	[HandoverId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldDiaryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldDiaryId] ON [dbo].[HandoverScaffoldDiary]
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Handover_HandoverId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Handover_HandoverId] ON [dbo].[HandoverScaffolds]
(
	[Handover_HandoverId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Scaffold_ScaffoldId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Scaffold_ScaffoldId] ON [dbo].[HandoverScaffolds]
(
	[Scaffold_ScaffoldId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_StaffRateId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_StaffRateId] ON [dbo].[Hours]
(
	[StaffRateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_TimeEntry_TimeEntryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_TimeEntry_TimeEntryId] ON [dbo].[Hours]
(
	[TimeEntry_TimeEntryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_InspectionDefect_InspectionDefectId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_InspectionDefect_InspectionDefectId] ON [dbo].[InspectionDefectMediaReferences]
(
	[InspectionDefect_InspectionDefectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MediaReference_MediaReferenceId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_MediaReference_MediaReferenceId] ON [dbo].[InspectionDefectMediaReferences]
(
	[MediaReference_MediaReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DefectTypeId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_DefectTypeId] ON [dbo].[InspectionDefects]
(
	[DefectTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldInspection_ScaffoldDiaryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldInspection_ScaffoldDiaryId] ON [dbo].[InspectionDefects]
(
	[ScaffoldInspection_ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[InspectionDefectStatusTypes]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_RelatedInspectionId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_RelatedInspectionId] ON [dbo].[InspectionFollowUp]
(
	[RelatedInspectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldDiaryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldDiaryId] ON [dbo].[InspectionFollowUp]
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldDiaryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldDiaryId] ON [dbo].[InspectionFollowUpInstruction]
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_InspectionFollowUpInstruction_ScaffoldDiaryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_InspectionFollowUpInstruction_ScaffoldDiaryId] ON [dbo].[InspectionFollowUpInstructionStaffs]
(
	[InspectionFollowUpInstruction_ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Staff_StaffId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Staff_StaffId] ON [dbo].[InspectionFollowUpInstructionStaffs]
(
	[Staff_StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldDiaryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldDiaryId] ON [dbo].[InspectionFollowUpNotify]
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContractContact_ContractContactId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ContractContact_ContractContactId] ON [dbo].[InspectionFollowUpNotifyContractContacts]
(
	[ContractContact_ContractContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_InspectionFollowUpNotify_ScaffoldDiaryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_InspectionFollowUpNotify_ScaffoldDiaryId] ON [dbo].[InspectionFollowUpNotifyContractContacts]
(
	[InspectionFollowUpNotify_ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[InspectionOutcomes]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[InspectionTypes]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContractId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ContractId] ON [dbo].[Items]
(
	[ContractId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_QuoteId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_QuoteId] ON [dbo].[Items]
(
	[QuoteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[LoadingLimits]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Dismantle_DismantleId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Dismantle_DismantleId] ON [dbo].[MediaReferences]
(
	[Dismantle_DismantleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MediaTranscriptionId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_MediaTranscriptionId] ON [dbo].[MediaReferences]
(
	[MediaTranscriptionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_VariationInstruction_VariationInstructionId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_VariationInstruction_VariationInstructionId] ON [dbo].[MediaReferences]
(
	[VariationInstruction_VariationInstructionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[MethodOfCladdings]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[MethodOfTyings]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_CommandKey]    Script Date: 21/03/2020 11:35:14 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_CommandKey] ON [dbo].[OffHireLogs]
(
	[CommandKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OffHireId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_OffHireId] ON [dbo].[OffHireLogs]
(
	[OffHireId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MediaReference_MediaReferenceId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_MediaReference_MediaReferenceId] ON [dbo].[OffHireMediaReferences]
(
	[MediaReference_MediaReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OffHire_OffHireId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_OffHire_OffHireId] ON [dbo].[OffHireMediaReferences]
(
	[OffHire_OffHireId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContractContactId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ContractContactId] ON [dbo].[OffHires]
(
	[ContractContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CustomerId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_CustomerId] ON [dbo].[OffHires]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CustomerSignature_CustomerSignatureId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_CustomerSignature_CustomerSignatureId] ON [dbo].[OffHires]
(
	[CustomerSignature_CustomerSignatureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DeletedBy]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_DeletedBy] ON [dbo].[OffHires]
(
	[DeletedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_SiteId] ON [dbo].[OffHires]
(
	[SiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_StaffSignature_StaffSignatureId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_StaffSignature_StaffSignatureId] ON [dbo].[OffHires]
(
	[StaffSignature_StaffSignatureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OffHireId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_OffHireId] ON [dbo].[OffHireScaffoldDiary]
(
	[OffHireId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldDiaryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldDiaryId] ON [dbo].[OffHireScaffoldDiary]
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OffHire_OffHireId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_OffHire_OffHireId] ON [dbo].[OffHireScaffolds]
(
	[OffHire_OffHireId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Scaffold_ScaffoldId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Scaffold_ScaffoldId] ON [dbo].[OffHireScaffolds]
(
	[Scaffold_ScaffoldId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContractId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ContractId] ON [dbo].[Quotes]
(
	[ContractId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[RateTypes]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContractContactId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ContractContactId] ON [dbo].[ReportSubscriptions]
(
	[ContractContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DeletedBy]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_DeletedBy] ON [dbo].[ScaffoldDiaries]
(
	[DeletedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OwnerId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_OwnerId] ON [dbo].[ScaffoldDiaries]
(
	[OwnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldId] ON [dbo].[ScaffoldDiaries]
(
	[ScaffoldId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[ScaffoldingSystems]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_InspectionOutcomeId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_InspectionOutcomeId] ON [dbo].[ScaffoldInspection]
(
	[InspectionOutcomeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_InspectionTypeId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_InspectionTypeId] ON [dbo].[ScaffoldInspection]
(
	[InspectionTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_InspectorsSignature_StaffSignatureId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_InspectorsSignature_StaffSignatureId] ON [dbo].[ScaffoldInspection]
(
	[InspectorsSignature_StaffSignatureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldDiaryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldDiaryId] ON [dbo].[ScaffoldInspection]
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MediaReference_MediaReferenceId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_MediaReference_MediaReferenceId] ON [dbo].[ScaffoldInspectionMediaReferences]
(
	[MediaReference_MediaReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldInspection_ScaffoldDiaryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldInspection_ScaffoldDiaryId] ON [dbo].[ScaffoldInspectionMediaReferences]
(
	[ScaffoldInspection_ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DesignTypeId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_DesignTypeId] ON [dbo].[ScaffoldItems]
(
	[DesignTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_LoadingLimitId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_LoadingLimitId] ON [dbo].[ScaffoldItems]
(
	[LoadingLimitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MethodOfCladdingId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_MethodOfCladdingId] ON [dbo].[ScaffoldItems]
(
	[MethodOfCladdingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MethodOfTyingId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_MethodOfTyingId] ON [dbo].[ScaffoldItems]
(
	[MethodOfTyingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldingSystemId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldingSystemId] ON [dbo].[ScaffoldItems]
(
	[ScaffoldingSystemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldTypeId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldTypeId] ON [dbo].[ScaffoldItems]
(
	[ScaffoldTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteInstructionRecivedFrom_ContractContactId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_SiteInstructionRecivedFrom_ContractContactId] ON [dbo].[ScaffoldItems]
(
	[SiteInstructionRecivedFrom_ContractContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_CommandKey]    Script Date: 21/03/2020 11:35:14 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_CommandKey] ON [dbo].[ScaffoldLogs]
(
	[CommandKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldId] ON [dbo].[ScaffoldLogs]
(
	[ScaffoldId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContractId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ContractId] ON [dbo].[Scaffolds]
(
	[ContractId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Dismantle_DismantleId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Dismantle_DismantleId] ON [dbo].[Scaffolds]
(
	[Dismantle_DismantleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ItemId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ItemId] ON [dbo].[Scaffolds]
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ParentScaffoldId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ParentScaffoldId] ON [dbo].[Scaffolds]
(
	[ParentScaffoldId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldImage_MediaReferenceId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldImage_MediaReferenceId] ON [dbo].[Scaffolds]
(
	[ScaffoldImage_MediaReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldStatusId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldStatusId] ON [dbo].[Scaffolds]
(
	[ScaffoldStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteAreaId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_SiteAreaId] ON [dbo].[Scaffolds]
(
	[SiteAreaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Handover_HandoverId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Handover_HandoverId] ON [dbo].[ScaffoldSpecificationDiary]
(
	[Handover_HandoverId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldDiaryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldDiaryId] ON [dbo].[ScaffoldSpecificationDiary]
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldItemId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldItemId] ON [dbo].[ScaffoldSpecificationDiary]
(
	[ScaffoldItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[ScaffoldStatus]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldId] ON [dbo].[ScaffoldTags]
(
	[ScaffoldId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_HandoverQuestion_HandoverQuestionId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_HandoverQuestion_HandoverQuestionId] ON [dbo].[ScaffoldTypeHandoverQuestions]
(
	[HandoverQuestion_HandoverQuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldType_ScaffoldTypeId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldType_ScaffoldTypeId] ON [dbo].[ScaffoldTypeHandoverQuestions]
(
	[ScaffoldType_ScaffoldTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[ScaffoldTypes]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_SiteId] ON [dbo].[SiteAreas]
(
	[SiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_CommandKey]    Script Date: 21/03/2020 11:35:14 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_CommandKey] ON [dbo].[SiteLogs]
(
	[CommandKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_SiteId] ON [dbo].[SiteLogs]
(
	[SiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteDepotId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_SiteDepotId] ON [dbo].[Sites]
(
	[SiteDepotId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteImage_MediaReferenceId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_SiteImage_MediaReferenceId] ON [dbo].[Sites]
(
	[SiteImage_MediaReferenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_SiteReference]    Script Date: 21/03/2020 11:35:14 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_SiteReference] ON [dbo].[Sites]
(
	[SiteReference] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteStatusId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_SiteStatusId] ON [dbo].[Sites]
(
	[SiteStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[SiteStatus]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldingSystemId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldingSystemId] ON [dbo].[SiteTonnages]
(
	[ScaffoldingSystemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_SiteId] ON [dbo].[SiteTonnages]
(
	[SiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteDepotId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_SiteDepotId] ON [dbo].[StaffDepots]
(
	[SiteDepotId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_StaffId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_StaffId] ON [dbo].[StaffDepots]
(
	[StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ExpenseTypeId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ExpenseTypeId] ON [dbo].[StaffExpenses]
(
	[ExpenseTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_TimesheetPeriodStaff_TimesheetPeriodStaffId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_TimesheetPeriodStaff_TimesheetPeriodStaffId] ON [dbo].[StaffExpenses]
(
	[TimesheetPeriodStaff_TimesheetPeriodStaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_CommandKey]    Script Date: 21/03/2020 11:35:14 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_CommandKey] ON [dbo].[StaffLogs]
(
	[CommandKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_StaffId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_StaffId] ON [dbo].[StaffLogs]
(
	[StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_RateTypeId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_RateTypeId] ON [dbo].[StaffRates]
(
	[RateTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Staff_StaffId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Staff_StaffId] ON [dbo].[StaffRates]
(
	[Staff_StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ApplicationRoleId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ApplicationRoleId] ON [dbo].[StaffRoles]
(
	[ApplicationRoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_StaffId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_StaffId] ON [dbo].[StaffRoles]
(
	[StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_StaffId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_StaffId] ON [dbo].[StaffSignatures]
(
	[StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_SiteId] ON [dbo].[StaffSites]
(
	[SiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_StaffId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_StaffId] ON [dbo].[StaffSites]
(
	[StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Item_ItemId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Item_ItemId] ON [dbo].[Tasks]
(
	[Item_ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_TaskTypeId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_TaskTypeId] ON [dbo].[Tasks]
(
	[TaskTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Configuration_ConfigurationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Configuration_ConfigurationId] ON [dbo].[TaskTypes]
(
	[Configuration_ConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_TimesheetPeriodStaff_TimesheetPeriodStaffId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_TimesheetPeriodStaff_TimesheetPeriodStaffId] ON [dbo].[TimeEntries]
(
	[TimesheetPeriodStaff_TimesheetPeriodStaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PreviousTimesheetPeriodId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_PreviousTimesheetPeriodId] ON [dbo].[TimesheetPeriods]
(
	[PreviousTimesheetPeriodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Timesheet_TimesheetId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Timesheet_TimesheetId] ON [dbo].[TimesheetPeriods]
(
	[Timesheet_TimesheetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_StaffId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_StaffId] ON [dbo].[TimesheetPeriodStaffs]
(
	[StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_TimesheetPeriod_TimesheetPeriodId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_TimesheetPeriod_TimesheetPeriodId] ON [dbo].[TimesheetPeriodStaffs]
(
	[TimesheetPeriod_TimesheetPeriodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContractId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ContractId] ON [dbo].[Timesheets]
(
	[ContractId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ItemId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ItemId] ON [dbo].[Timesheets]
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_TaskId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_TaskId] ON [dbo].[Timesheets]
(
	[TaskId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CustomerSignature_CustomerSignatureId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_CustomerSignature_CustomerSignatureId] ON [dbo].[UnsafeScaffoldReport]
(
	[CustomerSignature_CustomerSignatureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_InspectorsSignature_StaffSignatureId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_InspectorsSignature_StaffSignatureId] ON [dbo].[UnsafeScaffoldReport]
(
	[InspectorsSignature_StaffSignatureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ScaffoldDiaryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ScaffoldDiaryId] ON [dbo].[UnsafeScaffoldReport]
(
	[ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteManager_StaffId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_SiteManager_StaffId] ON [dbo].[UnsafeScaffoldReport]
(
	[SiteManager_StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteManagersSignature_StaffSignatureId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_SiteManagersSignature_StaffSignatureId] ON [dbo].[UnsafeScaffoldReport]
(
	[SiteManagersSignature_StaffSignatureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ContractContact_ContractContactId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_ContractContact_ContractContactId] ON [dbo].[UnsafeScaffoldReportContractContacts]
(
	[ContractContact_ContractContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UnsafeScaffoldReport_ScaffoldDiaryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_UnsafeScaffoldReport_ScaffoldDiaryId] ON [dbo].[UnsafeScaffoldReportContractContacts]
(
	[UnsafeScaffoldReport_ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Staff_StaffId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_Staff_StaffId] ON [dbo].[UnsafeScaffoldReportStaffs]
(
	[Staff_StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UnsafeScaffoldReport_ScaffoldDiaryId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_UnsafeScaffoldReport_ScaffoldDiaryId] ON [dbo].[UnsafeScaffoldReportStaffs]
(
	[UnsafeScaffoldReport_ScaffoldDiaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EstimatorId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_EstimatorId] ON [dbo].[VariationInstructions]
(
	[EstimatorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SiteInstructionReceivedFromId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_SiteInstructionReceivedFromId] ON [dbo].[VariationInstructions]
(
	[SiteInstructionReceivedFromId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_CommandKey]    Script Date: 21/03/2020 11:35:14 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_CommandKey] ON [dbo].[VariationLogs]
(
	[CommandKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_VariationId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_VariationId] ON [dbo].[VariationLogs]
(
	[VariationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DeletedBy]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_DeletedBy] ON [dbo].[Variations]
(
	[DeletedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_HandoverId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_HandoverId] ON [dbo].[Variations]
(
	[HandoverId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_VariationInstructionId]    Script Date: 21/03/2020 11:35:14 ******/
CREATE NONCLUSTERED INDEX [IX_VariationInstructionId] ON [dbo].[Variations]
(
	[VariationInstructionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Configurations] ADD  DEFAULT ('') FOR [ScaffoldReferencePrefix]
GO
ALTER TABLE [dbo].[Configurations] ADD  DEFAULT ('') FOR [ScaffoldReferenceSuffix]
GO
ALTER TABLE [dbo].[Configurations] ADD  DEFAULT ((5)) FOR [ScaffoldReferenceLength]
GO
ALTER TABLE [dbo].[Configurations] ADD  DEFAULT ((0)) FOR [WebConsoleSetupComplete]
GO
ALTER TABLE [dbo].[Configurations] ADD  DEFAULT ((0)) FOR [DepotsEnabled]
GO
ALTER TABLE [dbo].[Configurations] ADD  DEFAULT ((0)) FOR [EstimationMethod]
GO
ALTER TABLE [dbo].[Configurations] ADD  DEFAULT ((0)) FOR [PeriodType]
GO
ALTER TABLE [dbo].[ContactTypes] ADD  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[ContractContacts] ADD  DEFAULT ((0)) FOR [ReportSubscriptionTypes]
GO
ALTER TABLE [dbo].[ContractContacts] ADD  DEFAULT ((0)) FOR [ScheduleType]
GO
ALTER TABLE [dbo].[ContractContacts] ADD  DEFAULT ((0)) FOR [ReportSubscriptionId]
GO
ALTER TABLE [dbo].[Contracts] ADD  DEFAULT ((0)) FOR [IsCustomerNotPresent]
GO
ALTER TABLE [dbo].[Contracts] ADD  DEFAULT ((0)) FOR [IsScheduleRatesAgreed]
GO
ALTER TABLE [dbo].[Contracts] ADD  DEFAULT ((0)) FOR [CanSubmitDocumentsWithoutSignature]
GO
ALTER TABLE [dbo].[Contracts] ADD  DEFAULT ((0)) FOR [ContractInspectionStatus]
GO
ALTER TABLE [dbo].[Contracts] ADD  DEFAULT ((0)) FOR [IsCameraAllowed]
GO
ALTER TABLE [dbo].[Contracts] ADD  DEFAULT ((0)) FOR [AllowDismantleWithoutOffhire]
GO
ALTER TABLE [dbo].[ContractStatus] ADD  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[ContractTypes] ADD  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[CustomerStatus] ADD  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[DefectTypes] ADD  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[DesignTypes] ADD  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[DiaryCategories] ADD  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[EmailJobs] ADD  DEFAULT ((0)) FOR [EmailType]
GO
ALTER TABLE [dbo].[EmailJobs] ADD  DEFAULT ((0)) FOR [NoDataPdfNotGenerated]
GO
ALTER TABLE [dbo].[EmailRulesEngines] ADD  DEFAULT ((0)) FOR [EmailCommandHandler]
GO
ALTER TABLE [dbo].[EmailRulesEngines] ADD  DEFAULT ((0)) FOR [EmailXslPath]
GO
ALTER TABLE [dbo].[EmailRulesEngines] ADD  DEFAULT ((0)) FOR [EmailTriggerType]
GO
ALTER TABLE [dbo].[EmailRulesEngines] ADD  DEFAULT ((0)) FOR [Enabled]
GO
ALTER TABLE [dbo].[HandoverRiskReasons] ADD  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[HandoverRiskTypes] ADD  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[Handovers] ADD  DEFAULT ((0)) FOR [RisksIdentified]
GO
ALTER TABLE [dbo].[Handovers] ADD  DEFAULT ((0)) FOR [HandOverType]
GO
ALTER TABLE [dbo].[Handovers] ADD  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[Handovers] ADD  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [SiteId]
GO
ALTER TABLE [dbo].[Handovers] ADD  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [CustomerId]
GO
ALTER TABLE [dbo].[Handovers] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[InspectionDefectStatusTypes] ADD  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[InspectionOutcomes] ADD  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[InspectionTypes] ADD  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[LoadingLimits] ADD  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[MediaReferences] ADD  DEFAULT ((0)) FOR [MediaDeleted]
GO
ALTER TABLE [dbo].[MethodOfCladdings] ADD  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[MethodOfTyings] ADD  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[OffHires] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[ScaffoldDiaries] ADD  DEFAULT ((0)) FOR [OffsetFromUtc]
GO
ALTER TABLE [dbo].[ScaffoldDiaries] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[ScaffoldInspection] ADD  DEFAULT ((0)) FOR [IsDetailedInspectionReportAvailable]
GO
ALTER TABLE [dbo].[ScaffoldItems] ADD  DEFAULT ((0)) FOR [ScaffoldItemStatus]
GO
ALTER TABLE [dbo].[ScaffoldItems] ADD  DEFAULT ((0)) FOR [MaximumTonnage]
GO
ALTER TABLE [dbo].[ScaffoldItems] ADD  DEFAULT ((0)) FOR [StandingTonnage]
GO
ALTER TABLE [dbo].[Scaffolds] ADD  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [ScaffoldImageId]
GO
ALTER TABLE [dbo].[ScaffoldStatus] ADD  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[ScaffoldTypes] ADD  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[SiteAreas] ADD  DEFAULT ((0)) FOR [Deleted]
GO
ALTER TABLE [dbo].[Sites] ADD  DEFAULT ((1)) FOR [IsCameraAllowed]
GO
ALTER TABLE [dbo].[Sites] ADD  DEFAULT ((0)) FOR [IsManageStockControl]
GO
ALTER TABLE [dbo].[SiteStatus] ADD  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[Staffs] ADD  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [ExternalAuthUserId]
GO
ALTER TABLE [dbo].[Staffs] ADD  DEFAULT ((0)) FOR [CanEstimate]
GO
ALTER TABLE [dbo].[Variations] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[ApplicationRolePermission]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ApplicationRolePermission_dbo.ApplicationPermissions_ApplicationPermissionId] FOREIGN KEY([ApplicationPermissionId])
REFERENCES [dbo].[ApplicationPermissions] ([ApplicationPermissionId])
GO
ALTER TABLE [dbo].[ApplicationRolePermission] CHECK CONSTRAINT [FK_dbo.ApplicationRolePermission_dbo.ApplicationPermissions_ApplicationPermissionId]
GO
ALTER TABLE [dbo].[ApplicationRolePermission]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ApplicationRolePermission_dbo.ApplicationRoles_ApplicationRoleId] FOREIGN KEY([ApplicationRoleId])
REFERENCES [dbo].[ApplicationRoles] ([ApplicationRoleId])
GO
ALTER TABLE [dbo].[ApplicationRolePermission] CHECK CONSTRAINT [FK_dbo.ApplicationRolePermission_dbo.ApplicationRoles_ApplicationRoleId]
GO
ALTER TABLE [dbo].[ApplicationRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetRoles_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[ApplicationRoles] CHECK CONSTRAINT [FK_dbo.AspNetRoles_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[ConfigurationLogs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ConfigurationLogs_dbo.Configurations_ConfigurationId] FOREIGN KEY([ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[ConfigurationLogs] CHECK CONSTRAINT [FK_dbo.ConfigurationLogs_dbo.Configurations_ConfigurationId]
GO
ALTER TABLE [dbo].[Configurations]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Configurations_dbo.ContractStatus_NewContractStatus_ContractStatusId] FOREIGN KEY([NewContractStatus_ContractStatusId])
REFERENCES [dbo].[ContractStatus] ([ContractStatusId])
GO
ALTER TABLE [dbo].[Configurations] CHECK CONSTRAINT [FK_dbo.Configurations_dbo.ContractStatus_NewContractStatus_ContractStatusId]
GO
ALTER TABLE [dbo].[Configurations]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Configurations_dbo.CustomerStatus_NewCustomerStatus_CustomerStatusId] FOREIGN KEY([NewCustomerStatus_CustomerStatusId])
REFERENCES [dbo].[CustomerStatus] ([CustomerStatusId])
GO
ALTER TABLE [dbo].[Configurations] CHECK CONSTRAINT [FK_dbo.Configurations_dbo.CustomerStatus_NewCustomerStatus_CustomerStatusId]
GO
ALTER TABLE [dbo].[Configurations]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Configurations_dbo.InspectionDefectStatusTypes_NewInspectionDefectStatus_DefectStatusId] FOREIGN KEY([NewInspectionDefectStatus_DefectStatusId])
REFERENCES [dbo].[InspectionDefectStatusTypes] ([DefectStatusId])
GO
ALTER TABLE [dbo].[Configurations] CHECK CONSTRAINT [FK_dbo.Configurations_dbo.InspectionDefectStatusTypes_NewInspectionDefectStatus_DefectStatusId]
GO
ALTER TABLE [dbo].[Configurations]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Configurations_dbo.MediaReferences_MediaReferenceId] FOREIGN KEY([MediaReferenceId])
REFERENCES [dbo].[MediaReferences] ([MediaReferenceId])
GO
ALTER TABLE [dbo].[Configurations] CHECK CONSTRAINT [FK_dbo.Configurations_dbo.MediaReferences_MediaReferenceId]
GO
ALTER TABLE [dbo].[Configurations]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Configurations_dbo.ScaffoldStatus_NewScaffoldStatus_ScaffoldStatusId] FOREIGN KEY([NewScaffoldStatus_ScaffoldStatusId])
REFERENCES [dbo].[ScaffoldStatus] ([ScaffoldStatusId])
GO
ALTER TABLE [dbo].[Configurations] CHECK CONSTRAINT [FK_dbo.Configurations_dbo.ScaffoldStatus_NewScaffoldStatus_ScaffoldStatusId]
GO
ALTER TABLE [dbo].[Configurations]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Configurations_dbo.SiteStatus_NewSiteStatus_SiteStatusId] FOREIGN KEY([NewSiteStatus_SiteStatusId])
REFERENCES [dbo].[SiteStatus] ([SiteStatusId])
GO
ALTER TABLE [dbo].[Configurations] CHECK CONSTRAINT [FK_dbo.Configurations_dbo.SiteStatus_NewSiteStatus_SiteStatusId]
GO
ALTER TABLE [dbo].[ContactTypes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ContactTypes_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[ContactTypes] CHECK CONSTRAINT [FK_dbo.ContactTypes_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[ContractContacts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ContractContacts_dbo.ContactTypes_ContactTypeId] FOREIGN KEY([ContactTypeId])
REFERENCES [dbo].[ContactTypes] ([ContactTypeId])
GO
ALTER TABLE [dbo].[ContractContacts] CHECK CONSTRAINT [FK_dbo.ContractContacts_dbo.ContactTypes_ContactTypeId]
GO
ALTER TABLE [dbo].[ContractContacts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ContractContacts_dbo.Contracts_ContractId] FOREIGN KEY([ContractId])
REFERENCES [dbo].[Contracts] ([ContractId])
GO
ALTER TABLE [dbo].[ContractContacts] CHECK CONSTRAINT [FK_dbo.ContractContacts_dbo.Contracts_ContractId]
GO
ALTER TABLE [dbo].[ContractLogs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ContractLogs_dbo.Contracts_ContractId] FOREIGN KEY([ContractId])
REFERENCES [dbo].[Contracts] ([ContractId])
GO
ALTER TABLE [dbo].[ContractLogs] CHECK CONSTRAINT [FK_dbo.ContractLogs_dbo.Contracts_ContractId]
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Contracts_dbo.ContractStatus_ContractStatusId] FOREIGN KEY([ContractStatusId])
REFERENCES [dbo].[ContractStatus] ([ContractStatusId])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [FK_dbo.Contracts_dbo.ContractStatus_ContractStatusId]
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Contracts_dbo.ContractTypes_ContractTypeId] FOREIGN KEY([ContractTypeId])
REFERENCES [dbo].[ContractTypes] ([ContractTypeId])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [FK_dbo.Contracts_dbo.ContractTypes_ContractTypeId]
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Contracts_dbo.Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [FK_dbo.Contracts_dbo.Customers_CustomerId]
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Contracts_dbo.Sites_SiteId] FOREIGN KEY([SiteId])
REFERENCES [dbo].[Sites] ([SiteId])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [FK_dbo.Contracts_dbo.Sites_SiteId]
GO
ALTER TABLE [dbo].[ContractScaffoldDiary]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ContractScaffoldDiary_dbo.ScaffoldDiaries_ScaffoldDiaryId] FOREIGN KEY([ScaffoldDiaryId])
REFERENCES [dbo].[ScaffoldDiaries] ([ScaffoldDiaryId])
GO
ALTER TABLE [dbo].[ContractScaffoldDiary] CHECK CONSTRAINT [FK_dbo.ContractScaffoldDiary_dbo.ScaffoldDiaries_ScaffoldDiaryId]
GO
ALTER TABLE [dbo].[ContractStatus]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ContractStatus_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[ContractStatus] CHECK CONSTRAINT [FK_dbo.ContractStatus_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[ContractTypes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ContractTypes_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[ContractTypes] CHECK CONSTRAINT [FK_dbo.ContractTypes_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[CustomerLogs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CustomerLogs_dbo.Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[CustomerLogs] CHECK CONSTRAINT [FK_dbo.CustomerLogs_dbo.Customers_CustomerId]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Customers_dbo.CustomerStatus_CustomerStatusId] FOREIGN KEY([CustomerStatusId])
REFERENCES [dbo].[CustomerStatus] ([CustomerStatusId])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_dbo.Customers_dbo.CustomerStatus_CustomerStatusId]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Customers_dbo.MediaReferences_CustomerImage_MediaReferenceId] FOREIGN KEY([CustomerImage_MediaReferenceId])
REFERENCES [dbo].[MediaReferences] ([MediaReferenceId])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_dbo.Customers_dbo.MediaReferences_CustomerImage_MediaReferenceId]
GO
ALTER TABLE [dbo].[CustomerSignatures]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CustomerSignatures_dbo.ContractContacts_ContractContactId] FOREIGN KEY([ContractContactId])
REFERENCES [dbo].[ContractContacts] ([ContractContactId])
GO
ALTER TABLE [dbo].[CustomerSignatures] CHECK CONSTRAINT [FK_dbo.CustomerSignatures_dbo.ContractContacts_ContractContactId]
GO
ALTER TABLE [dbo].[CustomerStatus]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CustomerStatus_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[CustomerStatus] CHECK CONSTRAINT [FK_dbo.CustomerStatus_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[DefectTypes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DefectTypes_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[DefectTypes] CHECK CONSTRAINT [FK_dbo.DefectTypes_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[DesignTypes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DesignTypes_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[DesignTypes] CHECK CONSTRAINT [FK_dbo.DesignTypes_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[Diary]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Diary_dbo.DiaryCategories_DiaryCategoryId] FOREIGN KEY([DiaryCategoryId])
REFERENCES [dbo].[DiaryCategories] ([DiaryCategoryId])
GO
ALTER TABLE [dbo].[Diary] CHECK CONSTRAINT [FK_dbo.Diary_dbo.DiaryCategories_DiaryCategoryId]
GO
ALTER TABLE [dbo].[Diary]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Diary_dbo.ScaffoldDiaries_ScaffoldDiaryId] FOREIGN KEY([ScaffoldDiaryId])
REFERENCES [dbo].[ScaffoldDiaries] ([ScaffoldDiaryId])
GO
ALTER TABLE [dbo].[Diary] CHECK CONSTRAINT [FK_dbo.Diary_dbo.ScaffoldDiaries_ScaffoldDiaryId]
GO
ALTER TABLE [dbo].[DiaryCategories]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DiaryCategories_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[DiaryCategories] CHECK CONSTRAINT [FK_dbo.DiaryCategories_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[DiaryMediaReferences]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DiaryMediaReferences_dbo.Diary_Diary_ScaffoldDiaryId] FOREIGN KEY([Diary_ScaffoldDiaryId])
REFERENCES [dbo].[Diary] ([ScaffoldDiaryId])
GO
ALTER TABLE [dbo].[DiaryMediaReferences] CHECK CONSTRAINT [FK_dbo.DiaryMediaReferences_dbo.Diary_Diary_ScaffoldDiaryId]
GO
ALTER TABLE [dbo].[DiaryMediaReferences]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DiaryMediaReferences_dbo.MediaReferences_MediaReference_MediaReferenceId] FOREIGN KEY([MediaReference_MediaReferenceId])
REFERENCES [dbo].[MediaReferences] ([MediaReferenceId])
GO
ALTER TABLE [dbo].[DiaryMediaReferences] CHECK CONSTRAINT [FK_dbo.DiaryMediaReferences_dbo.MediaReferences_MediaReference_MediaReferenceId]
GO
ALTER TABLE [dbo].[Dimensions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Dimensions_dbo.Scaffolds_ScaffoldId] FOREIGN KEY([ScaffoldId])
REFERENCES [dbo].[Scaffolds] ([ScaffoldId])
GO
ALTER TABLE [dbo].[Dimensions] CHECK CONSTRAINT [FK_dbo.Dimensions_dbo.Scaffolds_ScaffoldId]
GO
ALTER TABLE [dbo].[Dimensions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Dimensions_dbo.Variations_VariationId] FOREIGN KEY([VariationId])
REFERENCES [dbo].[Variations] ([VariationId])
GO
ALTER TABLE [dbo].[Dimensions] CHECK CONSTRAINT [FK_dbo.Dimensions_dbo.Variations_VariationId]
GO
ALTER TABLE [dbo].[DismantleLogs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DismantleLogs_dbo.Dismantles_DismantleId] FOREIGN KEY([DismantleId])
REFERENCES [dbo].[Dismantles] ([DismantleId])
GO
ALTER TABLE [dbo].[DismantleLogs] CHECK CONSTRAINT [FK_dbo.DismantleLogs_dbo.Dismantles_DismantleId]
GO
ALTER TABLE [dbo].[DismantleScaffoldDiary]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DismantleScaffoldDiary_dbo.Dismantles_DismantleId] FOREIGN KEY([DismantleId])
REFERENCES [dbo].[Dismantles] ([DismantleId])
GO
ALTER TABLE [dbo].[DismantleScaffoldDiary] CHECK CONSTRAINT [FK_dbo.DismantleScaffoldDiary_dbo.Dismantles_DismantleId]
GO
ALTER TABLE [dbo].[DismantleScaffoldDiary]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DismantleScaffoldDiary_dbo.ScaffoldDiaries_ScaffoldDiaryId] FOREIGN KEY([ScaffoldDiaryId])
REFERENCES [dbo].[ScaffoldDiaries] ([ScaffoldDiaryId])
GO
ALTER TABLE [dbo].[DismantleScaffoldDiary] CHECK CONSTRAINT [FK_dbo.DismantleScaffoldDiary_dbo.ScaffoldDiaries_ScaffoldDiaryId]
GO
ALTER TABLE [dbo].[ExpenseTypes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ExpenseTypes_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[ExpenseTypes] CHECK CONSTRAINT [FK_dbo.ExpenseTypes_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[HandoverHandoverQuestions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverHandoverQuestions_dbo.HandoverQuestions_HandoverQuestion_HandoverQuestionId] FOREIGN KEY([HandoverQuestion_HandoverQuestionId])
REFERENCES [dbo].[HandoverQuestions] ([HandoverQuestionId])
GO
ALTER TABLE [dbo].[HandoverHandoverQuestions] CHECK CONSTRAINT [FK_dbo.HandoverHandoverQuestions_dbo.HandoverQuestions_HandoverQuestion_HandoverQuestionId]
GO
ALTER TABLE [dbo].[HandoverHandoverQuestions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverHandoverQuestions_dbo.Handovers_Handover_HandoverId] FOREIGN KEY([Handover_HandoverId])
REFERENCES [dbo].[Handovers] ([HandoverId])
GO
ALTER TABLE [dbo].[HandoverHandoverQuestions] CHECK CONSTRAINT [FK_dbo.HandoverHandoverQuestions_dbo.Handovers_Handover_HandoverId]
GO
ALTER TABLE [dbo].[HandoverHandoverSettings]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverHandoverSettings_dbo.Handovers_HandoverId] FOREIGN KEY([HandoverId])
REFERENCES [dbo].[Handovers] ([HandoverId])
GO
ALTER TABLE [dbo].[HandoverHandoverSettings] CHECK CONSTRAINT [FK_dbo.HandoverHandoverSettings_dbo.Handovers_HandoverId]
GO
ALTER TABLE [dbo].[HandoverHandoverSettings]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverHandoverSettings_dbo.HandoverSettings_HandoverSettingsId] FOREIGN KEY([HandoverSettingsId])
REFERENCES [dbo].[HandoverSettings] ([HandoverSettingsId])
GO
ALTER TABLE [dbo].[HandoverHandoverSettings] CHECK CONSTRAINT [FK_dbo.HandoverHandoverSettings_dbo.HandoverSettings_HandoverSettingsId]
GO
ALTER TABLE [dbo].[HandoverIdentifiedRiskMediaReferences]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverIdentifiedRiskMediaReferences_dbo.HandoverIdentifiedRisks_HandoverIdentifiedRisk_HandoverIdentifiedRiskId] FOREIGN KEY([HandoverIdentifiedRisk_HandoverIdentifiedRiskId])
REFERENCES [dbo].[HandoverIdentifiedRisks] ([HandoverIdentifiedRiskId])
GO
ALTER TABLE [dbo].[HandoverIdentifiedRiskMediaReferences] CHECK CONSTRAINT [FK_dbo.HandoverIdentifiedRiskMediaReferences_dbo.HandoverIdentifiedRisks_HandoverIdentifiedRisk_HandoverIdentifiedRiskId]
GO
ALTER TABLE [dbo].[HandoverIdentifiedRiskMediaReferences]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverIdentifiedRiskMediaReferences_dbo.MediaReferences_MediaReference_MediaReferenceId] FOREIGN KEY([MediaReference_MediaReferenceId])
REFERENCES [dbo].[MediaReferences] ([MediaReferenceId])
GO
ALTER TABLE [dbo].[HandoverIdentifiedRiskMediaReferences] CHECK CONSTRAINT [FK_dbo.HandoverIdentifiedRiskMediaReferences_dbo.MediaReferences_MediaReference_MediaReferenceId]
GO
ALTER TABLE [dbo].[HandoverIdentifiedRisks]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverIdentifiedRisks_dbo.HandoverRiskReasons_HandoverRiskReason_HandoverRiskReasonId] FOREIGN KEY([HandoverRiskReasonId])
REFERENCES [dbo].[HandoverRiskReasons] ([HandoverRiskReasonId])
GO
ALTER TABLE [dbo].[HandoverIdentifiedRisks] CHECK CONSTRAINT [FK_dbo.HandoverIdentifiedRisks_dbo.HandoverRiskReasons_HandoverRiskReason_HandoverRiskReasonId]
GO
ALTER TABLE [dbo].[HandoverIdentifiedRisks]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverIdentifiedRisks_dbo.HandoverRiskTypes_HandoverRiskType_HandoverRiskTypeId] FOREIGN KEY([HandoverRiskTypeId])
REFERENCES [dbo].[HandoverRiskTypes] ([HandoverRiskTypeId])
GO
ALTER TABLE [dbo].[HandoverIdentifiedRisks] CHECK CONSTRAINT [FK_dbo.HandoverIdentifiedRisks_dbo.HandoverRiskTypes_HandoverRiskType_HandoverRiskTypeId]
GO
ALTER TABLE [dbo].[HandoverIdentifiedRisks]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverIdentifiedRisks_dbo.Handovers_Handover_HandoverId] FOREIGN KEY([HandoverId])
REFERENCES [dbo].[Handovers] ([HandoverId])
GO
ALTER TABLE [dbo].[HandoverIdentifiedRisks] CHECK CONSTRAINT [FK_dbo.HandoverIdentifiedRisks_dbo.Handovers_Handover_HandoverId]
GO
ALTER TABLE [dbo].[HandoverLogs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverLogs_dbo.Handovers_HandoverId] FOREIGN KEY([HandoverId])
REFERENCES [dbo].[Handovers] ([HandoverId])
GO
ALTER TABLE [dbo].[HandoverLogs] CHECK CONSTRAINT [FK_dbo.HandoverLogs_dbo.Handovers_HandoverId]
GO
ALTER TABLE [dbo].[HandoverMediaReferences]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverMediaReferences_dbo.Handovers_Handover_HandoverId] FOREIGN KEY([Handover_HandoverId])
REFERENCES [dbo].[Handovers] ([HandoverId])
GO
ALTER TABLE [dbo].[HandoverMediaReferences] CHECK CONSTRAINT [FK_dbo.HandoverMediaReferences_dbo.Handovers_Handover_HandoverId]
GO
ALTER TABLE [dbo].[HandoverMediaReferences]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverMediaReferences_dbo.MediaReferences_MediaReference_MediaReferenceId] FOREIGN KEY([MediaReference_MediaReferenceId])
REFERENCES [dbo].[MediaReferences] ([MediaReferenceId])
GO
ALTER TABLE [dbo].[HandoverMediaReferences] CHECK CONSTRAINT [FK_dbo.HandoverMediaReferences_dbo.MediaReferences_MediaReference_MediaReferenceId]
GO
ALTER TABLE [dbo].[HandoverQuestionAnswers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverQuestionAnswers_dbo.HandoverQuestions_HandoverQuestion_HandoverQuestionId] FOREIGN KEY([HandoverQuestionId])
REFERENCES [dbo].[HandoverQuestions] ([HandoverQuestionId])
GO
ALTER TABLE [dbo].[HandoverQuestionAnswers] CHECK CONSTRAINT [FK_dbo.HandoverQuestionAnswers_dbo.HandoverQuestions_HandoverQuestion_HandoverQuestionId]
GO
ALTER TABLE [dbo].[HandoverRiskReasons]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverRiskReasons_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[HandoverRiskReasons] CHECK CONSTRAINT [FK_dbo.HandoverRiskReasons_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[HandoverRiskTypes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverRiskTypes_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[HandoverRiskTypes] CHECK CONSTRAINT [FK_dbo.HandoverRiskTypes_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[Handovers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Handovers_dbo.Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Handovers] CHECK CONSTRAINT [FK_dbo.Handovers_dbo.Customers_CustomerId]
GO
ALTER TABLE [dbo].[Handovers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Handovers_dbo.CustomerSignatures_CustomerSignature_CustomerSignatureId] FOREIGN KEY([CustomerSignature_CustomerSignatureId])
REFERENCES [dbo].[CustomerSignatures] ([CustomerSignatureId])
GO
ALTER TABLE [dbo].[Handovers] CHECK CONSTRAINT [FK_dbo.Handovers_dbo.CustomerSignatures_CustomerSignature_CustomerSignatureId]
GO
ALTER TABLE [dbo].[Handovers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Handovers_dbo.Sites_SiteId] FOREIGN KEY([SiteId])
REFERENCES [dbo].[Sites] ([SiteId])
GO
ALTER TABLE [dbo].[Handovers] CHECK CONSTRAINT [FK_dbo.Handovers_dbo.Sites_SiteId]
GO
ALTER TABLE [dbo].[Handovers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Handovers_dbo.Staffs_DeletedBy] FOREIGN KEY([DeletedBy])
REFERENCES [dbo].[Staffs] ([StaffId])
GO
ALTER TABLE [dbo].[Handovers] CHECK CONSTRAINT [FK_dbo.Handovers_dbo.Staffs_DeletedBy]
GO
ALTER TABLE [dbo].[Handovers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Handovers_dbo.StaffSignatures_StaffSignature_StaffSignatureId] FOREIGN KEY([StaffSignature_StaffSignatureId])
REFERENCES [dbo].[StaffSignatures] ([StaffSignatureId])
GO
ALTER TABLE [dbo].[Handovers] CHECK CONSTRAINT [FK_dbo.Handovers_dbo.StaffSignatures_StaffSignature_StaffSignatureId]
GO
ALTER TABLE [dbo].[HandoverScaffoldDiary]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverScaffoldDiary_dbo.Handovers_HandoverId] FOREIGN KEY([HandoverId])
REFERENCES [dbo].[Handovers] ([HandoverId])
GO
ALTER TABLE [dbo].[HandoverScaffoldDiary] CHECK CONSTRAINT [FK_dbo.HandoverScaffoldDiary_dbo.Handovers_HandoverId]
GO
ALTER TABLE [dbo].[HandoverScaffoldDiary]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverScaffoldDiary_dbo.ScaffoldDiaries_ScaffoldDiaryId] FOREIGN KEY([ScaffoldDiaryId])
REFERENCES [dbo].[ScaffoldDiaries] ([ScaffoldDiaryId])
GO
ALTER TABLE [dbo].[HandoverScaffoldDiary] CHECK CONSTRAINT [FK_dbo.HandoverScaffoldDiary_dbo.ScaffoldDiaries_ScaffoldDiaryId]
GO
ALTER TABLE [dbo].[HandoverScaffolds]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverScaffolds_dbo.Handovers_Handover_HandoverId] FOREIGN KEY([Handover_HandoverId])
REFERENCES [dbo].[Handovers] ([HandoverId])
GO
ALTER TABLE [dbo].[HandoverScaffolds] CHECK CONSTRAINT [FK_dbo.HandoverScaffolds_dbo.Handovers_Handover_HandoverId]
GO
ALTER TABLE [dbo].[HandoverScaffolds]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverScaffolds_dbo.Scaffolds_Scaffold_ScaffoldId] FOREIGN KEY([Scaffold_ScaffoldId])
REFERENCES [dbo].[Scaffolds] ([ScaffoldId])
GO
ALTER TABLE [dbo].[HandoverScaffolds] CHECK CONSTRAINT [FK_dbo.HandoverScaffolds_dbo.Scaffolds_Scaffold_ScaffoldId]
GO
ALTER TABLE [dbo].[Hours]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Hours_dbo.StaffRates_StaffRateId] FOREIGN KEY([StaffRateId])
REFERENCES [dbo].[StaffRates] ([StaffRateId])
GO
ALTER TABLE [dbo].[Hours] CHECK CONSTRAINT [FK_dbo.Hours_dbo.StaffRates_StaffRateId]
GO
ALTER TABLE [dbo].[Hours]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Hours_dbo.TimeEntries_TimeEntry_TimeEntryId] FOREIGN KEY([TimeEntry_TimeEntryId])
REFERENCES [dbo].[TimeEntries] ([TimeEntryId])
GO
ALTER TABLE [dbo].[Hours] CHECK CONSTRAINT [FK_dbo.Hours_dbo.TimeEntries_TimeEntry_TimeEntryId]
GO
ALTER TABLE [dbo].[InspectionDefectMediaReferences]  WITH CHECK ADD  CONSTRAINT [FK_dbo.InspectionDefectMediaReferences_dbo.InspectionDefects_InspectionDefect_InspectionDefectId] FOREIGN KEY([InspectionDefect_InspectionDefectId])
REFERENCES [dbo].[InspectionDefects] ([InspectionDefectId])
GO
ALTER TABLE [dbo].[InspectionDefectMediaReferences] CHECK CONSTRAINT [FK_dbo.InspectionDefectMediaReferences_dbo.InspectionDefects_InspectionDefect_InspectionDefectId]
GO
ALTER TABLE [dbo].[InspectionDefectMediaReferences]  WITH CHECK ADD  CONSTRAINT [FK_dbo.InspectionDefectMediaReferences_dbo.MediaReferences_MediaReference_MediaReferenceId] FOREIGN KEY([MediaReference_MediaReferenceId])
REFERENCES [dbo].[MediaReferences] ([MediaReferenceId])
GO
ALTER TABLE [dbo].[InspectionDefectMediaReferences] CHECK CONSTRAINT [FK_dbo.InspectionDefectMediaReferences_dbo.MediaReferences_MediaReference_MediaReferenceId]
GO
ALTER TABLE [dbo].[InspectionDefects]  WITH CHECK ADD  CONSTRAINT [FK_dbo.InspectionDefects_dbo.DefectTypes_DefectTypeId] FOREIGN KEY([DefectTypeId])
REFERENCES [dbo].[DefectTypes] ([DefectTypeId])
GO
ALTER TABLE [dbo].[InspectionDefects] CHECK CONSTRAINT [FK_dbo.InspectionDefects_dbo.DefectTypes_DefectTypeId]
GO
ALTER TABLE [dbo].[InspectionDefects]  WITH CHECK ADD  CONSTRAINT [FK_dbo.InspectionDefects_dbo.ScaffoldInspection_ScaffoldInspection_ScaffoldDiaryId] FOREIGN KEY([ScaffoldInspection_ScaffoldDiaryId])
REFERENCES [dbo].[ScaffoldInspection] ([ScaffoldDiaryId])
GO
ALTER TABLE [dbo].[InspectionDefects] CHECK CONSTRAINT [FK_dbo.InspectionDefects_dbo.ScaffoldInspection_ScaffoldInspection_ScaffoldDiaryId]
GO
ALTER TABLE [dbo].[InspectionDefectStatusTypes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.InspectionDefectStatusTypes_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[InspectionDefectStatusTypes] CHECK CONSTRAINT [FK_dbo.InspectionDefectStatusTypes_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[InspectionFollowUp]  WITH CHECK ADD  CONSTRAINT [FK_dbo.InspectionFollowUp_dbo.ScaffoldDiaries_ScaffoldDiaryId] FOREIGN KEY([ScaffoldDiaryId])
REFERENCES [dbo].[ScaffoldDiaries] ([ScaffoldDiaryId])
GO
ALTER TABLE [dbo].[InspectionFollowUp] CHECK CONSTRAINT [FK_dbo.InspectionFollowUp_dbo.ScaffoldDiaries_ScaffoldDiaryId]
GO
ALTER TABLE [dbo].[InspectionFollowUp]  WITH CHECK ADD  CONSTRAINT [FK_dbo.InspectionFollowUp_dbo.ScaffoldInspection_RelatedInspectionId] FOREIGN KEY([RelatedInspectionId])
REFERENCES [dbo].[ScaffoldInspection] ([ScaffoldDiaryId])
GO
ALTER TABLE [dbo].[InspectionFollowUp] CHECK CONSTRAINT [FK_dbo.InspectionFollowUp_dbo.ScaffoldInspection_RelatedInspectionId]
GO
ALTER TABLE [dbo].[InspectionFollowUpInstruction]  WITH CHECK ADD  CONSTRAINT [FK_dbo.InspectionFollowUpInstruction_dbo.InspectionFollowUp_ScaffoldDiaryId] FOREIGN KEY([ScaffoldDiaryId])
REFERENCES [dbo].[InspectionFollowUp] ([ScaffoldDiaryId])
GO
ALTER TABLE [dbo].[InspectionFollowUpInstruction] CHECK CONSTRAINT [FK_dbo.InspectionFollowUpInstruction_dbo.InspectionFollowUp_ScaffoldDiaryId]
GO
ALTER TABLE [dbo].[InspectionFollowUpInstructionStaffs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.InspectionFollowUpInstructionStaffs_dbo.InspectionFollowUpInstruction_InspectionFollowUpInstruction_ScaffoldDiaryId] FOREIGN KEY([InspectionFollowUpInstruction_ScaffoldDiaryId])
REFERENCES [dbo].[InspectionFollowUpInstruction] ([ScaffoldDiaryId])
GO
ALTER TABLE [dbo].[InspectionFollowUpInstructionStaffs] CHECK CONSTRAINT [FK_dbo.InspectionFollowUpInstructionStaffs_dbo.InspectionFollowUpInstruction_InspectionFollowUpInstruction_ScaffoldDiaryId]
GO
ALTER TABLE [dbo].[InspectionFollowUpInstructionStaffs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.InspectionFollowUpInstructionStaffs_dbo.Staffs_Staff_StaffId] FOREIGN KEY([Staff_StaffId])
REFERENCES [dbo].[Staffs] ([StaffId])
GO
ALTER TABLE [dbo].[InspectionFollowUpInstructionStaffs] CHECK CONSTRAINT [FK_dbo.InspectionFollowUpInstructionStaffs_dbo.Staffs_Staff_StaffId]
GO
ALTER TABLE [dbo].[InspectionFollowUpNotify]  WITH CHECK ADD  CONSTRAINT [FK_dbo.InspectionFollowUpNotify_dbo.InspectionFollowUp_ScaffoldDiaryId] FOREIGN KEY([ScaffoldDiaryId])
REFERENCES [dbo].[InspectionFollowUp] ([ScaffoldDiaryId])
GO
ALTER TABLE [dbo].[InspectionFollowUpNotify] CHECK CONSTRAINT [FK_dbo.InspectionFollowUpNotify_dbo.InspectionFollowUp_ScaffoldDiaryId]
GO
ALTER TABLE [dbo].[InspectionFollowUpNotifyContractContacts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.InspectionFollowUpNotifyContractContacts_dbo.ContractContacts_ContractContact_ContractContactId] FOREIGN KEY([ContractContact_ContractContactId])
REFERENCES [dbo].[ContractContacts] ([ContractContactId])
GO
ALTER TABLE [dbo].[InspectionFollowUpNotifyContractContacts] CHECK CONSTRAINT [FK_dbo.InspectionFollowUpNotifyContractContacts_dbo.ContractContacts_ContractContact_ContractContactId]
GO
ALTER TABLE [dbo].[InspectionFollowUpNotifyContractContacts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.InspectionFollowUpNotifyContractContacts_dbo.InspectionFollowUpNotify_InspectionFollowUpNotify_ScaffoldDiaryId] FOREIGN KEY([InspectionFollowUpNotify_ScaffoldDiaryId])
REFERENCES [dbo].[InspectionFollowUpNotify] ([ScaffoldDiaryId])
GO
ALTER TABLE [dbo].[InspectionFollowUpNotifyContractContacts] CHECK CONSTRAINT [FK_dbo.InspectionFollowUpNotifyContractContacts_dbo.InspectionFollowUpNotify_InspectionFollowUpNotify_ScaffoldDiaryId]
GO
ALTER TABLE [dbo].[InspectionOutcomes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.InspectionOutcomes_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[InspectionOutcomes] CHECK CONSTRAINT [FK_dbo.InspectionOutcomes_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[InspectionTypes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.InspectionTypes_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[InspectionTypes] CHECK CONSTRAINT [FK_dbo.InspectionTypes_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[Items]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.Items_dbo.Contracts_ContractId] FOREIGN KEY([ContractId])
REFERENCES [dbo].[Contracts] ([ContractId])
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_dbo.Items_dbo.Contracts_ContractId]
GO
ALTER TABLE [dbo].[Items]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.Items_dbo.Quotes_QuoteId] FOREIGN KEY([QuoteId])
REFERENCES [dbo].[Quotes] ([QuoteId])
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_dbo.Items_dbo.Quotes_QuoteId]
GO
ALTER TABLE [dbo].[LoadingLimits]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LoadingLimits_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[LoadingLimits] CHECK CONSTRAINT [FK_dbo.LoadingLimits_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[MediaReferences]  WITH CHECK ADD  CONSTRAINT [FK_dbo.MediaReferences_dbo.Dismantles_Dismantle_DismantleId] FOREIGN KEY([Dismantle_DismantleId])
REFERENCES [dbo].[Dismantles] ([DismantleId])
GO
ALTER TABLE [dbo].[MediaReferences] CHECK CONSTRAINT [FK_dbo.MediaReferences_dbo.Dismantles_Dismantle_DismantleId]
GO
ALTER TABLE [dbo].[MediaReferences]  WITH CHECK ADD  CONSTRAINT [FK_dbo.MediaReferences_dbo.MediaTranscriptions_MediaTranscriptionId] FOREIGN KEY([MediaTranscriptionId])
REFERENCES [dbo].[MediaTranscriptions] ([MediaTranscriptionId])
GO
ALTER TABLE [dbo].[MediaReferences] CHECK CONSTRAINT [FK_dbo.MediaReferences_dbo.MediaTranscriptions_MediaTranscriptionId]
GO
ALTER TABLE [dbo].[MediaReferences]  WITH CHECK ADD  CONSTRAINT [FK_dbo.MediaReferences_dbo.VariationInstructions_VariationInstruction_VariationInstructionId] FOREIGN KEY([VariationInstruction_VariationInstructionId])
REFERENCES [dbo].[VariationInstructions] ([VariationInstructionId])
GO
ALTER TABLE [dbo].[MediaReferences] CHECK CONSTRAINT [FK_dbo.MediaReferences_dbo.VariationInstructions_VariationInstruction_VariationInstructionId]
GO
ALTER TABLE [dbo].[MethodOfCladdings]  WITH CHECK ADD  CONSTRAINT [FK_dbo.MethodOfCladdings_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[MethodOfCladdings] CHECK CONSTRAINT [FK_dbo.MethodOfCladdings_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[MethodOfTyings]  WITH CHECK ADD  CONSTRAINT [FK_dbo.MethodOfTyings_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[MethodOfTyings] CHECK CONSTRAINT [FK_dbo.MethodOfTyings_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[OffHireLogs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.OffHireLogs_dbo.OffHires_OffHireId] FOREIGN KEY([OffHireId])
REFERENCES [dbo].[OffHires] ([OffHireId])
GO
ALTER TABLE [dbo].[OffHireLogs] CHECK CONSTRAINT [FK_dbo.OffHireLogs_dbo.OffHires_OffHireId]
GO
ALTER TABLE [dbo].[OffHireMediaReferences]  WITH CHECK ADD  CONSTRAINT [FK_dbo.OffHireMediaReferences_dbo.MediaReferences_MediaReference_MediaReferenceId] FOREIGN KEY([MediaReference_MediaReferenceId])
REFERENCES [dbo].[MediaReferences] ([MediaReferenceId])
GO
ALTER TABLE [dbo].[OffHireMediaReferences] CHECK CONSTRAINT [FK_dbo.OffHireMediaReferences_dbo.MediaReferences_MediaReference_MediaReferenceId]
GO
ALTER TABLE [dbo].[OffHireMediaReferences]  WITH CHECK ADD  CONSTRAINT [FK_dbo.OffHireMediaReferences_dbo.OffHires_OffHire_OffHireId] FOREIGN KEY([OffHire_OffHireId])
REFERENCES [dbo].[OffHires] ([OffHireId])
GO
ALTER TABLE [dbo].[OffHireMediaReferences] CHECK CONSTRAINT [FK_dbo.OffHireMediaReferences_dbo.OffHires_OffHire_OffHireId]
GO
ALTER TABLE [dbo].[OffHires]  WITH CHECK ADD  CONSTRAINT [FK_dbo.OffHires_dbo.ContractContacts_ContractContactId] FOREIGN KEY([ContractContactId])
REFERENCES [dbo].[ContractContacts] ([ContractContactId])
GO
ALTER TABLE [dbo].[OffHires] CHECK CONSTRAINT [FK_dbo.OffHires_dbo.ContractContacts_ContractContactId]
GO
ALTER TABLE [dbo].[OffHires]  WITH CHECK ADD  CONSTRAINT [FK_dbo.OffHires_dbo.Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[OffHires] CHECK CONSTRAINT [FK_dbo.OffHires_dbo.Customers_CustomerId]
GO
ALTER TABLE [dbo].[OffHires]  WITH CHECK ADD  CONSTRAINT [FK_dbo.OffHires_dbo.CustomerSignatures_CustomerSignature_CustomerSignatureId] FOREIGN KEY([CustomerSignature_CustomerSignatureId])
REFERENCES [dbo].[CustomerSignatures] ([CustomerSignatureId])
GO
ALTER TABLE [dbo].[OffHires] CHECK CONSTRAINT [FK_dbo.OffHires_dbo.CustomerSignatures_CustomerSignature_CustomerSignatureId]
GO
ALTER TABLE [dbo].[OffHires]  WITH CHECK ADD  CONSTRAINT [FK_dbo.OffHires_dbo.Sites_SiteId] FOREIGN KEY([SiteId])
REFERENCES [dbo].[Sites] ([SiteId])
GO
ALTER TABLE [dbo].[OffHires] CHECK CONSTRAINT [FK_dbo.OffHires_dbo.Sites_SiteId]
GO
ALTER TABLE [dbo].[OffHires]  WITH CHECK ADD  CONSTRAINT [FK_dbo.OffHires_dbo.Staffs_DeletedBy] FOREIGN KEY([DeletedBy])
REFERENCES [dbo].[Staffs] ([StaffId])
GO
ALTER TABLE [dbo].[OffHires] CHECK CONSTRAINT [FK_dbo.OffHires_dbo.Staffs_DeletedBy]
GO
ALTER TABLE [dbo].[OffHires]  WITH CHECK ADD  CONSTRAINT [FK_dbo.OffHires_dbo.StaffSignatures_StaffSignature_StaffSignatureId] FOREIGN KEY([StaffSignature_StaffSignatureId])
REFERENCES [dbo].[StaffSignatures] ([StaffSignatureId])
GO
ALTER TABLE [dbo].[OffHires] CHECK CONSTRAINT [FK_dbo.OffHires_dbo.StaffSignatures_StaffSignature_StaffSignatureId]
GO
ALTER TABLE [dbo].[OffHireScaffoldDiary]  WITH CHECK ADD  CONSTRAINT [FK_dbo.OffHireScaffoldDiary_dbo.OffHires_OffHireId] FOREIGN KEY([OffHireId])
REFERENCES [dbo].[OffHires] ([OffHireId])
GO
ALTER TABLE [dbo].[OffHireScaffoldDiary] CHECK CONSTRAINT [FK_dbo.OffHireScaffoldDiary_dbo.OffHires_OffHireId]
GO
ALTER TABLE [dbo].[OffHireScaffoldDiary]  WITH CHECK ADD  CONSTRAINT [FK_dbo.OffHireScaffoldDiary_dbo.ScaffoldDiaries_ScaffoldDiaryId] FOREIGN KEY([ScaffoldDiaryId])
REFERENCES [dbo].[ScaffoldDiaries] ([ScaffoldDiaryId])
GO
ALTER TABLE [dbo].[OffHireScaffoldDiary] CHECK CONSTRAINT [FK_dbo.OffHireScaffoldDiary_dbo.ScaffoldDiaries_ScaffoldDiaryId]
GO
ALTER TABLE [dbo].[OffHireScaffolds]  WITH CHECK ADD  CONSTRAINT [FK_dbo.OffHireScaffolds_dbo.OffHires_OffHire_OffHireId] FOREIGN KEY([OffHire_OffHireId])
REFERENCES [dbo].[OffHires] ([OffHireId])
GO
ALTER TABLE [dbo].[OffHireScaffolds] CHECK CONSTRAINT [FK_dbo.OffHireScaffolds_dbo.OffHires_OffHire_OffHireId]
GO
ALTER TABLE [dbo].[OffHireScaffolds]  WITH CHECK ADD  CONSTRAINT [FK_dbo.OffHireScaffolds_dbo.Scaffolds_Scaffold_ScaffoldId] FOREIGN KEY([Scaffold_ScaffoldId])
REFERENCES [dbo].[Scaffolds] ([ScaffoldId])
GO
ALTER TABLE [dbo].[OffHireScaffolds] CHECK CONSTRAINT [FK_dbo.OffHireScaffolds_dbo.Scaffolds_Scaffold_ScaffoldId]
GO
ALTER TABLE [dbo].[Quotes]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.Quotes_dbo.Contracts_ContractId] FOREIGN KEY([ContractId])
REFERENCES [dbo].[Contracts] ([ContractId])
GO
ALTER TABLE [dbo].[Quotes] CHECK CONSTRAINT [FK_dbo.Quotes_dbo.Contracts_ContractId]
GO
ALTER TABLE [dbo].[RateTypes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.RateTypes_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[RateTypes] CHECK CONSTRAINT [FK_dbo.RateTypes_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[ReportSubscriptions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ReportSubscriptions_dbo.ContractContacts_ContractContactId] FOREIGN KEY([ContractContactId])
REFERENCES [dbo].[ContractContacts] ([ContractContactId])
GO
ALTER TABLE [dbo].[ReportSubscriptions] CHECK CONSTRAINT [FK_dbo.ReportSubscriptions_dbo.ContractContacts_ContractContactId]
GO
ALTER TABLE [dbo].[ScaffoldDiaries]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.ScaffoldDiaries_dbo.Scaffolds_ScaffoldId] FOREIGN KEY([ScaffoldId])
REFERENCES [dbo].[Scaffolds] ([ScaffoldId])
GO
ALTER TABLE [dbo].[ScaffoldDiaries] CHECK CONSTRAINT [FK_dbo.ScaffoldDiaries_dbo.Scaffolds_ScaffoldId]
GO
ALTER TABLE [dbo].[ScaffoldDiaries]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.ScaffoldDiaries_dbo.Staffs_DeletedBy] FOREIGN KEY([DeletedBy])
REFERENCES [dbo].[Staffs] ([StaffId])
GO
ALTER TABLE [dbo].[ScaffoldDiaries] CHECK CONSTRAINT [FK_dbo.ScaffoldDiaries_dbo.Staffs_DeletedBy]
GO
ALTER TABLE [dbo].[ScaffoldDiaries]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.ScaffoldDiaries_dbo.Staffs_Owner_StaffId] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[Staffs] ([StaffId])
GO
ALTER TABLE [dbo].[ScaffoldDiaries] CHECK CONSTRAINT [FK_dbo.ScaffoldDiaries_dbo.Staffs_Owner_StaffId]
GO
ALTER TABLE [dbo].[ScaffoldingSystems]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ScaffoldingSystems_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[ScaffoldingSystems] CHECK CONSTRAINT [FK_dbo.ScaffoldingSystems_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[ScaffoldInspection]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ScaffoldInspection_dbo.InspectionOutcomes_InspectionOutcomeId] FOREIGN KEY([InspectionOutcomeId])
REFERENCES [dbo].[InspectionOutcomes] ([InspectionOutcomeId])
GO
ALTER TABLE [dbo].[ScaffoldInspection] CHECK CONSTRAINT [FK_dbo.ScaffoldInspection_dbo.InspectionOutcomes_InspectionOutcomeId]
GO
ALTER TABLE [dbo].[ScaffoldInspection]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ScaffoldInspection_dbo.InspectionTypes_InspectionTypeId] FOREIGN KEY([InspectionTypeId])
REFERENCES [dbo].[InspectionTypes] ([InspectionTypeId])
GO
ALTER TABLE [dbo].[ScaffoldInspection] CHECK CONSTRAINT [FK_dbo.ScaffoldInspection_dbo.InspectionTypes_InspectionTypeId]
GO
ALTER TABLE [dbo].[ScaffoldInspection]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ScaffoldInspection_dbo.ScaffoldDiaries_ScaffoldDiaryId] FOREIGN KEY([ScaffoldDiaryId])
REFERENCES [dbo].[ScaffoldDiaries] ([ScaffoldDiaryId])
GO
ALTER TABLE [dbo].[ScaffoldInspection] CHECK CONSTRAINT [FK_dbo.ScaffoldInspection_dbo.ScaffoldDiaries_ScaffoldDiaryId]
GO
ALTER TABLE [dbo].[ScaffoldInspection]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ScaffoldInspection_dbo.StaffSignatures_InspectorsSignature_StaffSignatureId] FOREIGN KEY([InspectorsSignature_StaffSignatureId])
REFERENCES [dbo].[StaffSignatures] ([StaffSignatureId])
GO
ALTER TABLE [dbo].[ScaffoldInspection] CHECK CONSTRAINT [FK_dbo.ScaffoldInspection_dbo.StaffSignatures_InspectorsSignature_StaffSignatureId]
GO
ALTER TABLE [dbo].[ScaffoldInspectionMediaReferences]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ScaffoldInspectionMediaReferences_dbo.MediaReferences_MediaReference_MediaReferenceId] FOREIGN KEY([MediaReference_MediaReferenceId])
REFERENCES [dbo].[MediaReferences] ([MediaReferenceId])
GO
ALTER TABLE [dbo].[ScaffoldInspectionMediaReferences] CHECK CONSTRAINT [FK_dbo.ScaffoldInspectionMediaReferences_dbo.MediaReferences_MediaReference_MediaReferenceId]
GO
ALTER TABLE [dbo].[ScaffoldInspectionMediaReferences]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ScaffoldInspectionMediaReferences_dbo.ScaffoldInspection_ScaffoldInspection_ScaffoldDiaryId] FOREIGN KEY([ScaffoldInspection_ScaffoldDiaryId])
REFERENCES [dbo].[ScaffoldInspection] ([ScaffoldDiaryId])
GO
ALTER TABLE [dbo].[ScaffoldInspectionMediaReferences] CHECK CONSTRAINT [FK_dbo.ScaffoldInspectionMediaReferences_dbo.ScaffoldInspection_ScaffoldInspection_ScaffoldDiaryId]
GO
ALTER TABLE [dbo].[ScaffoldItems]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.ScaffoldItems_dbo.ContractContacts_SiteInstructionRecivedFrom_ContractContactId] FOREIGN KEY([SiteInstructionRecivedFrom_ContractContactId])
REFERENCES [dbo].[ContractContacts] ([ContractContactId])
GO
ALTER TABLE [dbo].[ScaffoldItems] CHECK CONSTRAINT [FK_dbo.ScaffoldItems_dbo.ContractContacts_SiteInstructionRecivedFrom_ContractContactId]
GO
ALTER TABLE [dbo].[ScaffoldItems]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.ScaffoldItems_dbo.DesignTypes_DesignTypeId] FOREIGN KEY([DesignTypeId])
REFERENCES [dbo].[DesignTypes] ([DesignTypeId])
GO
ALTER TABLE [dbo].[ScaffoldItems] CHECK CONSTRAINT [FK_dbo.ScaffoldItems_dbo.DesignTypes_DesignTypeId]
GO
ALTER TABLE [dbo].[ScaffoldItems]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.ScaffoldItems_dbo.LoadingLimits_LoadingLimitId] FOREIGN KEY([LoadingLimitId])
REFERENCES [dbo].[LoadingLimits] ([LoadingLimitId])
GO
ALTER TABLE [dbo].[ScaffoldItems] CHECK CONSTRAINT [FK_dbo.ScaffoldItems_dbo.LoadingLimits_LoadingLimitId]
GO
ALTER TABLE [dbo].[ScaffoldItems]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.ScaffoldItems_dbo.MethodOfCladdings_MethodOfCladdingId] FOREIGN KEY([MethodOfCladdingId])
REFERENCES [dbo].[MethodOfCladdings] ([MethodOfCladdingId])
GO
ALTER TABLE [dbo].[ScaffoldItems] CHECK CONSTRAINT [FK_dbo.ScaffoldItems_dbo.MethodOfCladdings_MethodOfCladdingId]
GO
ALTER TABLE [dbo].[ScaffoldItems]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.ScaffoldItems_dbo.MethodOfTyings_MethodOfTyingId] FOREIGN KEY([MethodOfTyingId])
REFERENCES [dbo].[MethodOfTyings] ([MethodOfTyingId])
GO
ALTER TABLE [dbo].[ScaffoldItems] CHECK CONSTRAINT [FK_dbo.ScaffoldItems_dbo.MethodOfTyings_MethodOfTyingId]
GO
ALTER TABLE [dbo].[ScaffoldItems]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.ScaffoldItems_dbo.ScaffoldingSystems_ScaffoldingSystemId] FOREIGN KEY([ScaffoldingSystemId])
REFERENCES [dbo].[ScaffoldingSystems] ([ScaffoldingSystemId])
GO
ALTER TABLE [dbo].[ScaffoldItems] CHECK CONSTRAINT [FK_dbo.ScaffoldItems_dbo.ScaffoldingSystems_ScaffoldingSystemId]
GO
ALTER TABLE [dbo].[ScaffoldItems]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.ScaffoldItems_dbo.ScaffoldTypes_ScaffoldTypeId] FOREIGN KEY([ScaffoldTypeId])
REFERENCES [dbo].[ScaffoldTypes] ([ScaffoldTypeId])
GO
ALTER TABLE [dbo].[ScaffoldItems] CHECK CONSTRAINT [FK_dbo.ScaffoldItems_dbo.ScaffoldTypes_ScaffoldTypeId]
GO
ALTER TABLE [dbo].[ScaffoldLogs]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.ScaffoldLogs_dbo.Scaffolds_ScaffoldId] FOREIGN KEY([ScaffoldId])
REFERENCES [dbo].[Scaffolds] ([ScaffoldId])
GO
ALTER TABLE [dbo].[ScaffoldLogs] CHECK CONSTRAINT [FK_dbo.ScaffoldLogs_dbo.Scaffolds_ScaffoldId]
GO
ALTER TABLE [dbo].[Scaffolds]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.Scaffolds_dbo.Contracts_ContractId] FOREIGN KEY([ContractId])
REFERENCES [dbo].[Contracts] ([ContractId])
GO
ALTER TABLE [dbo].[Scaffolds] CHECK CONSTRAINT [FK_dbo.Scaffolds_dbo.Contracts_ContractId]
GO
ALTER TABLE [dbo].[Scaffolds]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.Scaffolds_dbo.Dismantles_Dismantle_DismantleId] FOREIGN KEY([Dismantle_DismantleId])
REFERENCES [dbo].[Dismantles] ([DismantleId])
GO
ALTER TABLE [dbo].[Scaffolds] CHECK CONSTRAINT [FK_dbo.Scaffolds_dbo.Dismantles_Dismantle_DismantleId]
GO
ALTER TABLE [dbo].[Scaffolds]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.Scaffolds_dbo.Items_ItemId] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Items] ([ItemId])
GO
ALTER TABLE [dbo].[Scaffolds] CHECK CONSTRAINT [FK_dbo.Scaffolds_dbo.Items_ItemId]
GO
ALTER TABLE [dbo].[Scaffolds]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.Scaffolds_dbo.MediaReferences_ScaffoldImage_MediaReferenceId] FOREIGN KEY([ScaffoldImage_MediaReferenceId])
REFERENCES [dbo].[MediaReferences] ([MediaReferenceId])
GO
ALTER TABLE [dbo].[Scaffolds] CHECK CONSTRAINT [FK_dbo.Scaffolds_dbo.MediaReferences_ScaffoldImage_MediaReferenceId]
GO
ALTER TABLE [dbo].[Scaffolds]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.Scaffolds_dbo.Scaffolds_ParentScaffoldId] FOREIGN KEY([ParentScaffoldId])
REFERENCES [dbo].[Scaffolds] ([ScaffoldId])
GO
ALTER TABLE [dbo].[Scaffolds] CHECK CONSTRAINT [FK_dbo.Scaffolds_dbo.Scaffolds_ParentScaffoldId]
GO
ALTER TABLE [dbo].[Scaffolds]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.Scaffolds_dbo.ScaffoldStatus_ScaffoldStatusId] FOREIGN KEY([ScaffoldStatusId])
REFERENCES [dbo].[ScaffoldStatus] ([ScaffoldStatusId])
GO
ALTER TABLE [dbo].[Scaffolds] CHECK CONSTRAINT [FK_dbo.Scaffolds_dbo.ScaffoldStatus_ScaffoldStatusId]
GO
ALTER TABLE [dbo].[Scaffolds]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.Scaffolds_dbo.SiteAreas_SiteAreaId] FOREIGN KEY([SiteAreaId])
REFERENCES [dbo].[SiteAreas] ([SiteAreaId])
GO
ALTER TABLE [dbo].[Scaffolds] CHECK CONSTRAINT [FK_dbo.Scaffolds_dbo.SiteAreas_SiteAreaId]
GO
ALTER TABLE [dbo].[ScaffoldSpecificationDiary]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.ScaffoldSpecificationDiary_dbo.Handovers_Handover_HandoverId] FOREIGN KEY([Handover_HandoverId])
REFERENCES [dbo].[Handovers] ([HandoverId])
GO
ALTER TABLE [dbo].[ScaffoldSpecificationDiary] CHECK CONSTRAINT [FK_dbo.ScaffoldSpecificationDiary_dbo.Handovers_Handover_HandoverId]
GO
ALTER TABLE [dbo].[ScaffoldSpecificationDiary]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.ScaffoldSpecificationDiary_dbo.ScaffoldDiaries_ScaffoldDiaryId] FOREIGN KEY([ScaffoldDiaryId])
REFERENCES [dbo].[ScaffoldDiaries] ([ScaffoldDiaryId])
GO
ALTER TABLE [dbo].[ScaffoldSpecificationDiary] CHECK CONSTRAINT [FK_dbo.ScaffoldSpecificationDiary_dbo.ScaffoldDiaries_ScaffoldDiaryId]
GO
ALTER TABLE [dbo].[ScaffoldSpecificationDiary]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.ScaffoldSpecificationDiary_dbo.ScaffoldItems_ScaffoldItemId] FOREIGN KEY([ScaffoldItemId])
REFERENCES [dbo].[ScaffoldItems] ([ScaffoldItemId])
GO
ALTER TABLE [dbo].[ScaffoldSpecificationDiary] CHECK CONSTRAINT [FK_dbo.ScaffoldSpecificationDiary_dbo.ScaffoldItems_ScaffoldItemId]
GO
ALTER TABLE [dbo].[ScaffoldStatus]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ScaffoldStatus_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[ScaffoldStatus] CHECK CONSTRAINT [FK_dbo.ScaffoldStatus_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[ScaffoldTags]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ScaffoldTags_dbo.Scaffolds_ScaffoldId] FOREIGN KEY([ScaffoldId])
REFERENCES [dbo].[Scaffolds] ([ScaffoldId])
GO
ALTER TABLE [dbo].[ScaffoldTags] CHECK CONSTRAINT [FK_dbo.ScaffoldTags_dbo.Scaffolds_ScaffoldId]
GO
ALTER TABLE [dbo].[ScaffoldTypeHandoverQuestions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverQuestionScaffoldTypes_dbo.HandoverQuestions_HandoverQuestion_HandoverQuestionId] FOREIGN KEY([HandoverQuestion_HandoverQuestionId])
REFERENCES [dbo].[HandoverQuestions] ([HandoverQuestionId])
GO
ALTER TABLE [dbo].[ScaffoldTypeHandoverQuestions] CHECK CONSTRAINT [FK_dbo.HandoverQuestionScaffoldTypes_dbo.HandoverQuestions_HandoverQuestion_HandoverQuestionId]
GO
ALTER TABLE [dbo].[ScaffoldTypeHandoverQuestions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HandoverQuestionScaffoldTypes_dbo.ScaffoldTypes_ScaffoldType_ScaffoldTypeId] FOREIGN KEY([ScaffoldType_ScaffoldTypeId])
REFERENCES [dbo].[ScaffoldTypes] ([ScaffoldTypeId])
GO
ALTER TABLE [dbo].[ScaffoldTypeHandoverQuestions] CHECK CONSTRAINT [FK_dbo.HandoverQuestionScaffoldTypes_dbo.ScaffoldTypes_ScaffoldType_ScaffoldTypeId]
GO
ALTER TABLE [dbo].[ScaffoldTypes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ScaffoldTypes_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[ScaffoldTypes] CHECK CONSTRAINT [FK_dbo.ScaffoldTypes_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[SiteAreas]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.SiteAreas_dbo.Sites_SiteId] FOREIGN KEY([SiteId])
REFERENCES [dbo].[Sites] ([SiteId])
GO
ALTER TABLE [dbo].[SiteAreas] CHECK CONSTRAINT [FK_dbo.SiteAreas_dbo.Sites_SiteId]
GO
ALTER TABLE [dbo].[SiteLogs]  WITH NOCHECK ADD  CONSTRAINT [FK_dbo.SiteLogs_dbo.Sites_SiteId] FOREIGN KEY([SiteId])
REFERENCES [dbo].[Sites] ([SiteId])
GO
ALTER TABLE [dbo].[SiteLogs] CHECK CONSTRAINT [FK_dbo.SiteLogs_dbo.Sites_SiteId]
GO
ALTER TABLE [dbo].[Sites]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Sites_dbo.MediaReferences_SiteImage_MediaReferenceId] FOREIGN KEY([SiteImage_MediaReferenceId])
REFERENCES [dbo].[MediaReferences] ([MediaReferenceId])
GO
ALTER TABLE [dbo].[Sites] CHECK CONSTRAINT [FK_dbo.Sites_dbo.MediaReferences_SiteImage_MediaReferenceId]
GO
ALTER TABLE [dbo].[Sites]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Sites_dbo.SiteDepots_SiteDepotId] FOREIGN KEY([SiteDepotId])
REFERENCES [dbo].[SiteDepots] ([SiteDepotId])
GO
ALTER TABLE [dbo].[Sites] CHECK CONSTRAINT [FK_dbo.Sites_dbo.SiteDepots_SiteDepotId]
GO
ALTER TABLE [dbo].[Sites]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Sites_dbo.SiteStatus_SiteStatusId] FOREIGN KEY([SiteStatusId])
REFERENCES [dbo].[SiteStatus] ([SiteStatusId])
GO
ALTER TABLE [dbo].[Sites] CHECK CONSTRAINT [FK_dbo.Sites_dbo.SiteStatus_SiteStatusId]
GO
ALTER TABLE [dbo].[SiteStatus]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SiteStatus_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[SiteStatus] CHECK CONSTRAINT [FK_dbo.SiteStatus_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[SiteTonnages]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SiteTonnages_dbo.ScaffoldingSystems_ScaffoldingSystemId] FOREIGN KEY([ScaffoldingSystemId])
REFERENCES [dbo].[ScaffoldingSystems] ([ScaffoldingSystemId])
GO
ALTER TABLE [dbo].[SiteTonnages] CHECK CONSTRAINT [FK_dbo.SiteTonnages_dbo.ScaffoldingSystems_ScaffoldingSystemId]
GO
ALTER TABLE [dbo].[SiteTonnages]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SiteTonnages_dbo.Sites_SiteId] FOREIGN KEY([SiteId])
REFERENCES [dbo].[Sites] ([SiteId])
GO
ALTER TABLE [dbo].[SiteTonnages] CHECK CONSTRAINT [FK_dbo.SiteTonnages_dbo.Sites_SiteId]
GO
ALTER TABLE [dbo].[StaffDepots]  WITH CHECK ADD  CONSTRAINT [FK_dbo.StaffDepots_dbo.SiteDepots_SiteDepotId] FOREIGN KEY([SiteDepotId])
REFERENCES [dbo].[SiteDepots] ([SiteDepotId])
GO
ALTER TABLE [dbo].[StaffDepots] CHECK CONSTRAINT [FK_dbo.StaffDepots_dbo.SiteDepots_SiteDepotId]
GO
ALTER TABLE [dbo].[StaffDepots]  WITH CHECK ADD  CONSTRAINT [FK_dbo.StaffDepots_dbo.Staffs_StaffId] FOREIGN KEY([StaffId])
REFERENCES [dbo].[Staffs] ([StaffId])
GO
ALTER TABLE [dbo].[StaffDepots] CHECK CONSTRAINT [FK_dbo.StaffDepots_dbo.Staffs_StaffId]
GO
ALTER TABLE [dbo].[StaffExpenses]  WITH CHECK ADD  CONSTRAINT [FK_dbo.StaffExpenses_dbo.ExpenseTypes_ExpenseTypeId] FOREIGN KEY([ExpenseTypeId])
REFERENCES [dbo].[ExpenseTypes] ([ExpenseTypeId])
GO
ALTER TABLE [dbo].[StaffExpenses] CHECK CONSTRAINT [FK_dbo.StaffExpenses_dbo.ExpenseTypes_ExpenseTypeId]
GO
ALTER TABLE [dbo].[StaffExpenses]  WITH CHECK ADD  CONSTRAINT [FK_dbo.StaffExpenses_dbo.TimesheetPeriodStaffs_TimesheetPeriodStaff_TimesheetPeriodStaffId] FOREIGN KEY([TimesheetPeriodStaff_TimesheetPeriodStaffId])
REFERENCES [dbo].[TimesheetPeriodStaffs] ([TimesheetPeriodStaffId])
GO
ALTER TABLE [dbo].[StaffExpenses] CHECK CONSTRAINT [FK_dbo.StaffExpenses_dbo.TimesheetPeriodStaffs_TimesheetPeriodStaff_TimesheetPeriodStaffId]
GO
ALTER TABLE [dbo].[StaffLogs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.StaffLogs_dbo.Staffs_StaffId] FOREIGN KEY([StaffId])
REFERENCES [dbo].[Staffs] ([StaffId])
GO
ALTER TABLE [dbo].[StaffLogs] CHECK CONSTRAINT [FK_dbo.StaffLogs_dbo.Staffs_StaffId]
GO
ALTER TABLE [dbo].[StaffRates]  WITH CHECK ADD  CONSTRAINT [FK_dbo.StaffRates_dbo.RateTypes_RateTypeId] FOREIGN KEY([RateTypeId])
REFERENCES [dbo].[RateTypes] ([RateTypeId])
GO
ALTER TABLE [dbo].[StaffRates] CHECK CONSTRAINT [FK_dbo.StaffRates_dbo.RateTypes_RateTypeId]
GO
ALTER TABLE [dbo].[StaffRates]  WITH CHECK ADD  CONSTRAINT [FK_dbo.StaffRates_dbo.Staffs_Staff_StaffId] FOREIGN KEY([Staff_StaffId])
REFERENCES [dbo].[Staffs] ([StaffId])
GO
ALTER TABLE [dbo].[StaffRates] CHECK CONSTRAINT [FK_dbo.StaffRates_dbo.Staffs_Staff_StaffId]
GO
ALTER TABLE [dbo].[StaffRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.StaffRoles_dbo.ApplicationRoles_ApplicationRoleId] FOREIGN KEY([ApplicationRoleId])
REFERENCES [dbo].[ApplicationRoles] ([ApplicationRoleId])
GO
ALTER TABLE [dbo].[StaffRoles] CHECK CONSTRAINT [FK_dbo.StaffRoles_dbo.ApplicationRoles_ApplicationRoleId]
GO
ALTER TABLE [dbo].[StaffRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.StaffRoles_dbo.Staffs_StaffId] FOREIGN KEY([StaffId])
REFERENCES [dbo].[Staffs] ([StaffId])
GO
ALTER TABLE [dbo].[StaffRoles] CHECK CONSTRAINT [FK_dbo.StaffRoles_dbo.Staffs_StaffId]
GO
ALTER TABLE [dbo].[StaffSignatures]  WITH CHECK ADD  CONSTRAINT [FK_dbo.StaffSignatures_dbo.Staffs_StaffId] FOREIGN KEY([StaffId])
REFERENCES [dbo].[Staffs] ([StaffId])
GO
ALTER TABLE [dbo].[StaffSignatures] CHECK CONSTRAINT [FK_dbo.StaffSignatures_dbo.Staffs_StaffId]
GO
ALTER TABLE [dbo].[StaffSites]  WITH CHECK ADD  CONSTRAINT [FK_dbo.StaffSites_dbo.Sites_SiteId] FOREIGN KEY([SiteId])
REFERENCES [dbo].[Sites] ([SiteId])
GO
ALTER TABLE [dbo].[StaffSites] CHECK CONSTRAINT [FK_dbo.StaffSites_dbo.Sites_SiteId]
GO
ALTER TABLE [dbo].[StaffSites]  WITH CHECK ADD  CONSTRAINT [FK_dbo.StaffSites_dbo.Staffs_StaffId] FOREIGN KEY([StaffId])
REFERENCES [dbo].[Staffs] ([StaffId])
GO
ALTER TABLE [dbo].[StaffSites] CHECK CONSTRAINT [FK_dbo.StaffSites_dbo.Staffs_StaffId]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Tasks_dbo.Items_Item_ItemId] FOREIGN KEY([Item_ItemId])
REFERENCES [dbo].[Items] ([ItemId])
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_dbo.Tasks_dbo.Items_Item_ItemId]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Tasks_dbo.TaskTypes_TaskTypeId] FOREIGN KEY([TaskTypeId])
REFERENCES [dbo].[TaskTypes] ([TaskTypeId])
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK_dbo.Tasks_dbo.TaskTypes_TaskTypeId]
GO
ALTER TABLE [dbo].[TaskTypes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.TaskTypes_dbo.Configurations_Configuration_ConfigurationId] FOREIGN KEY([Configuration_ConfigurationId])
REFERENCES [dbo].[Configurations] ([ConfigurationId])
GO
ALTER TABLE [dbo].[TaskTypes] CHECK CONSTRAINT [FK_dbo.TaskTypes_dbo.Configurations_Configuration_ConfigurationId]
GO
ALTER TABLE [dbo].[TimeEntries]  WITH CHECK ADD  CONSTRAINT [FK_dbo.TimeEntries_dbo.TimesheetPeriodStaffs_TimesheetPeriodStaff_TimesheetPeriodStaffId] FOREIGN KEY([TimesheetPeriodStaff_TimesheetPeriodStaffId])
REFERENCES [dbo].[TimesheetPeriodStaffs] ([TimesheetPeriodStaffId])
GO
ALTER TABLE [dbo].[TimeEntries] CHECK CONSTRAINT [FK_dbo.TimeEntries_dbo.TimesheetPeriodStaffs_TimesheetPeriodStaff_TimesheetPeriodStaffId]
GO
ALTER TABLE [dbo].[TimesheetPeriods]  WITH CHECK ADD  CONSTRAINT [FK_dbo.TimesheetPeriods_dbo.TimesheetPeriods_PreviousTimesheetPeriodId] FOREIGN KEY([PreviousTimesheetPeriodId])
REFERENCES [dbo].[TimesheetPeriods] ([TimesheetPeriodId])
GO
ALTER TABLE [dbo].[TimesheetPeriods] CHECK CONSTRAINT [FK_dbo.TimesheetPeriods_dbo.TimesheetPeriods_PreviousTimesheetPeriodId]
GO
ALTER TABLE [dbo].[TimesheetPeriods]  WITH CHECK ADD  CONSTRAINT [FK_dbo.TimesheetPeriods_dbo.Timesheets_Timesheet_TimesheetId] FOREIGN KEY([Timesheet_TimesheetId])
REFERENCES [dbo].[Timesheets] ([TimesheetId])
GO
ALTER TABLE [dbo].[TimesheetPeriods] CHECK CONSTRAINT [FK_dbo.TimesheetPeriods_dbo.Timesheets_Timesheet_TimesheetId]
GO
ALTER TABLE [dbo].[TimesheetPeriodStaffs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.TimesheetPeriodStaffs_dbo.Staffs_StaffId] FOREIGN KEY([StaffId])
REFERENCES [dbo].[Staffs] ([StaffId])
GO
ALTER TABLE [dbo].[TimesheetPeriodStaffs] CHECK CONSTRAINT [FK_dbo.TimesheetPeriodStaffs_dbo.Staffs_StaffId]
GO
ALTER TABLE [dbo].[TimesheetPeriodStaffs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.TimesheetPeriodStaffs_dbo.TimesheetPeriods_TimesheetPeriod_TimesheetPeriodId] FOREIGN KEY([TimesheetPeriod_TimesheetPeriodId])
REFERENCES [dbo].[TimesheetPeriods] ([TimesheetPeriodId])
GO
ALTER TABLE [dbo].[TimesheetPeriodStaffs] CHECK CONSTRAINT [FK_dbo.TimesheetPeriodStaffs_dbo.TimesheetPeriods_TimesheetPeriod_TimesheetPeriodId]
GO
ALTER TABLE [dbo].[Timesheets]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Timesheets_dbo.Contracts_ContractId] FOREIGN KEY([ContractId])
REFERENCES [dbo].[Contracts] ([ContractId])
GO
ALTER TABLE [dbo].[Timesheets] CHECK CONSTRAINT [FK_dbo.Timesheets_dbo.Contracts_ContractId]
GO
ALTER TABLE [dbo].[Timesheets]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Timesheets_dbo.Items_ItemId] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Items] ([ItemId])
GO
ALTER TABLE [dbo].[Timesheets] CHECK CONSTRAINT [FK_dbo.Timesheets_dbo.Items_ItemId]
GO
ALTER TABLE [dbo].[Timesheets]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Timesheets_dbo.Tasks_TaskId] FOREIGN KEY([TaskId])
REFERENCES [dbo].[Tasks] ([TaskId])
GO
ALTER TABLE [dbo].[Timesheets] CHECK CONSTRAINT [FK_dbo.Timesheets_dbo.Tasks_TaskId]
GO
ALTER TABLE [dbo].[UnsafeScaffoldReport]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UnsafeScaffoldReport_dbo.CustomerSignatures_CustomerSignature_CustomerSignatureId] FOREIGN KEY([CustomerSignature_CustomerSignatureId])
REFERENCES [dbo].[CustomerSignatures] ([CustomerSignatureId])
GO
ALTER TABLE [dbo].[UnsafeScaffoldReport] CHECK CONSTRAINT [FK_dbo.UnsafeScaffoldReport_dbo.CustomerSignatures_CustomerSignature_CustomerSignatureId]
GO
ALTER TABLE [dbo].[UnsafeScaffoldReport]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UnsafeScaffoldReport_dbo.InspectionFollowUp_ScaffoldDiaryId] FOREIGN KEY([ScaffoldDiaryId])
REFERENCES [dbo].[InspectionFollowUp] ([ScaffoldDiaryId])
GO
ALTER TABLE [dbo].[UnsafeScaffoldReport] CHECK CONSTRAINT [FK_dbo.UnsafeScaffoldReport_dbo.InspectionFollowUp_ScaffoldDiaryId]
GO
ALTER TABLE [dbo].[UnsafeScaffoldReport]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UnsafeScaffoldReport_dbo.Staffs_SiteManager_StaffId] FOREIGN KEY([SiteManager_StaffId])
REFERENCES [dbo].[Staffs] ([StaffId])
GO
ALTER TABLE [dbo].[UnsafeScaffoldReport] CHECK CONSTRAINT [FK_dbo.UnsafeScaffoldReport_dbo.Staffs_SiteManager_StaffId]
GO
ALTER TABLE [dbo].[UnsafeScaffoldReport]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UnsafeScaffoldReport_dbo.StaffSignatures_InspectorsSignature_StaffSignatureId] FOREIGN KEY([InspectorsSignature_StaffSignatureId])
REFERENCES [dbo].[StaffSignatures] ([StaffSignatureId])
GO
ALTER TABLE [dbo].[UnsafeScaffoldReport] CHECK CONSTRAINT [FK_dbo.UnsafeScaffoldReport_dbo.StaffSignatures_InspectorsSignature_StaffSignatureId]
GO
ALTER TABLE [dbo].[UnsafeScaffoldReport]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UnsafeScaffoldReport_dbo.StaffSignatures_SiteManagersSignature_StaffSignatureId] FOREIGN KEY([SiteManagersSignature_StaffSignatureId])
REFERENCES [dbo].[StaffSignatures] ([StaffSignatureId])
GO
ALTER TABLE [dbo].[UnsafeScaffoldReport] CHECK CONSTRAINT [FK_dbo.UnsafeScaffoldReport_dbo.StaffSignatures_SiteManagersSignature_StaffSignatureId]
GO
ALTER TABLE [dbo].[UnsafeScaffoldReportContractContacts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UnsafeScaffoldReportContractContacts_dbo.ContractContacts_ContractContact_ContractContactId] FOREIGN KEY([ContractContact_ContractContactId])
REFERENCES [dbo].[ContractContacts] ([ContractContactId])
GO
ALTER TABLE [dbo].[UnsafeScaffoldReportContractContacts] CHECK CONSTRAINT [FK_dbo.UnsafeScaffoldReportContractContacts_dbo.ContractContacts_ContractContact_ContractContactId]
GO
ALTER TABLE [dbo].[UnsafeScaffoldReportContractContacts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UnsafeScaffoldReportContractContacts_dbo.UnsafeScaffoldReport_UnsafeScaffoldReport_ScaffoldDiaryId] FOREIGN KEY([UnsafeScaffoldReport_ScaffoldDiaryId])
REFERENCES [dbo].[UnsafeScaffoldReport] ([ScaffoldDiaryId])
GO
ALTER TABLE [dbo].[UnsafeScaffoldReportContractContacts] CHECK CONSTRAINT [FK_dbo.UnsafeScaffoldReportContractContacts_dbo.UnsafeScaffoldReport_UnsafeScaffoldReport_ScaffoldDiaryId]
GO
ALTER TABLE [dbo].[UnsafeScaffoldReportStaffs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UnsafeScaffoldReportStaffs_dbo.Staffs_Staff_StaffId] FOREIGN KEY([Staff_StaffId])
REFERENCES [dbo].[Staffs] ([StaffId])
GO
ALTER TABLE [dbo].[UnsafeScaffoldReportStaffs] CHECK CONSTRAINT [FK_dbo.UnsafeScaffoldReportStaffs_dbo.Staffs_Staff_StaffId]
GO
ALTER TABLE [dbo].[UnsafeScaffoldReportStaffs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UnsafeScaffoldReportStaffs_dbo.UnsafeScaffoldReport_UnsafeScaffoldReport_ScaffoldDiaryId] FOREIGN KEY([UnsafeScaffoldReport_ScaffoldDiaryId])
REFERENCES [dbo].[UnsafeScaffoldReport] ([ScaffoldDiaryId])
GO
ALTER TABLE [dbo].[UnsafeScaffoldReportStaffs] CHECK CONSTRAINT [FK_dbo.UnsafeScaffoldReportStaffs_dbo.UnsafeScaffoldReport_UnsafeScaffoldReport_ScaffoldDiaryId]
GO
ALTER TABLE [dbo].[VariationInstructions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.VariationInstructions_dbo.ContractContacts_SiteInstructionReceivedFromId] FOREIGN KEY([SiteInstructionReceivedFromId])
REFERENCES [dbo].[ContractContacts] ([ContractContactId])
GO
ALTER TABLE [dbo].[VariationInstructions] CHECK CONSTRAINT [FK_dbo.VariationInstructions_dbo.ContractContacts_SiteInstructionReceivedFromId]
GO
ALTER TABLE [dbo].[VariationInstructions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.VariationInstructions_dbo.Staffs_EstimatorId] FOREIGN KEY([EstimatorId])
REFERENCES [dbo].[Staffs] ([StaffId])
GO
ALTER TABLE [dbo].[VariationInstructions] CHECK CONSTRAINT [FK_dbo.VariationInstructions_dbo.Staffs_EstimatorId]
GO
ALTER TABLE [dbo].[VariationLogs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.VariationLogs_dbo.Variations_VariationId] FOREIGN KEY([VariationId])
REFERENCES [dbo].[Variations] ([VariationId])
GO
ALTER TABLE [dbo].[VariationLogs] CHECK CONSTRAINT [FK_dbo.VariationLogs_dbo.Variations_VariationId]
GO
ALTER TABLE [dbo].[Variations]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Variations_dbo.Handovers_HandoverId] FOREIGN KEY([HandoverId])
REFERENCES [dbo].[Handovers] ([HandoverId])
GO
ALTER TABLE [dbo].[Variations] CHECK CONSTRAINT [FK_dbo.Variations_dbo.Handovers_HandoverId]
GO
ALTER TABLE [dbo].[Variations]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Variations_dbo.Staffs_DeletedBy] FOREIGN KEY([DeletedBy])
REFERENCES [dbo].[Staffs] ([StaffId])
GO
ALTER TABLE [dbo].[Variations] CHECK CONSTRAINT [FK_dbo.Variations_dbo.Staffs_DeletedBy]
GO
ALTER TABLE [dbo].[Variations]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Variations_dbo.VariationInstructions_VariationInstructionId] FOREIGN KEY([VariationInstructionId])
REFERENCES [dbo].[VariationInstructions] ([VariationInstructionId])
GO
ALTER TABLE [dbo].[Variations] CHECK CONSTRAINT [FK_dbo.Variations_dbo.VariationInstructions_VariationInstructionId]
GO
USE [master]
GO
ALTER DATABASE [DEC2019_77aef15d1c0b41d78e04564910ea7547] SET  READ_WRITE 
GO
