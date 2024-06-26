USE [master]
GO
/****** Object:  Database [Applicants]    Script Date: 26.05.2024 23:20:12 ******/
CREATE DATABASE [Applicants]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Applicants', FILENAME = N'D:\Applicants.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Applicants_log', FILENAME = N'D:\Applicants_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Applicants] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Applicants].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Applicants] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Applicants] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Applicants] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Applicants] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Applicants] SET ARITHABORT OFF 
GO
ALTER DATABASE [Applicants] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Applicants] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Applicants] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Applicants] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Applicants] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Applicants] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Applicants] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Applicants] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Applicants] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Applicants] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Applicants] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Applicants] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Applicants] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Applicants] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Applicants] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Applicants] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Applicants] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Applicants] SET RECOVERY FULL 
GO
ALTER DATABASE [Applicants] SET  MULTI_USER 
GO
ALTER DATABASE [Applicants] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Applicants] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Applicants] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Applicants] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Applicants] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Applicants] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Applicants', N'ON'
GO
ALTER DATABASE [Applicants] SET QUERY_STORE = OFF
GO
USE [Applicants]
GO
/****** Object:  Table [dbo].[Direction]    Script Date: 26.05.2024 23:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direction](
	[Код_направления] [nvarchar](10) NOT NULL,
	[Название] [nvarchar](50) NULL,
	[Проходной_балл] [int] NULL,
	[Количество_бюджетных_мест] [int] NULL,
	[Количество_мест] [int] NULL,
	[Цена_обучения_в_год] [money] NULL,
	[Название_факультета] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Direction] PRIMARY KEY CLUSTERED 
(
	[Код_направления] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Faculty]    Script Date: 26.05.2024 23:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculty](
	[Название] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Faculty] PRIMARY KEY CLUSTERED 
(
	[Название] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questionnaire]    Script Date: 26.05.2024 23:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questionnaire](
	[ID_анкеты] [int] IDENTITY(1,1) NOT NULL,
	[Фамилия] [nvarchar](50) NULL,
	[Имя] [nvarchar](50) NULL,
	[Отчество] [nvarchar](50) NULL,
	[Пол] [nchar](10) NULL,
	[Год_окончания_обучения] [int] NULL,
	[Номер_телефона] [nvarchar](50) NULL,
 CONSTRAINT [PK_Questionnaire] PRIMARY KEY CLUSTERED 
(
	[ID_анкеты] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RequiredSubjects]    Script Date: 26.05.2024 23:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequiredSubjects](
	[Название] [nvarchar](50) NOT NULL,
	[Код_направления] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_RequiredSubjects] PRIMARY KEY CLUSTERED 
(
	[Название] ASC,
	[Код_направления] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SelectedSubject]    Script Date: 26.05.2024 23:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SelectedSubject](
	[Название] [nvarchar](50) NOT NULL,
	[ID_анкеты] [int] NOT NULL,
 CONSTRAINT [PK_SelectedSubject] PRIMARY KEY CLUSTERED 
(
	[Название] ASC,
	[ID_анкеты] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 26.05.2024 23:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[Название] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[Название] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 26.05.2024 23:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID_пользователя] [int] IDENTITY(1,1) NOT NULL,
	[Админ] [bit] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Пароль] [nvarchar](50) NOT NULL,
	[ID_анкеты] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID_пользователя] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_Админ]  DEFAULT ((0)) FOR [Админ]
GO
ALTER TABLE [dbo].[Direction]  WITH CHECK ADD  CONSTRAINT [FK_Faculty_Direction] FOREIGN KEY([Название_факультета])
REFERENCES [dbo].[Faculty] ([Название])
GO
ALTER TABLE [dbo].[Direction] CHECK CONSTRAINT [FK_Faculty_Direction]
GO
ALTER TABLE [dbo].[RequiredSubjects]  WITH CHECK ADD  CONSTRAINT [FK_Direction_RequiredSubjects] FOREIGN KEY([Код_направления])
REFERENCES [dbo].[Direction] ([Код_направления])
GO
ALTER TABLE [dbo].[RequiredSubjects] CHECK CONSTRAINT [FK_Direction_RequiredSubjects]
GO
ALTER TABLE [dbo].[RequiredSubjects]  WITH CHECK ADD  CONSTRAINT [FK_Subjects_RequiredSubjects] FOREIGN KEY([Название])
REFERENCES [dbo].[Subjects] ([Название])
GO
ALTER TABLE [dbo].[RequiredSubjects] CHECK CONSTRAINT [FK_Subjects_RequiredSubjects]
GO
ALTER TABLE [dbo].[SelectedSubject]  WITH CHECK ADD  CONSTRAINT [FK_SelectedSubject_Questionnaire] FOREIGN KEY([ID_анкеты])
REFERENCES [dbo].[Questionnaire] ([ID_анкеты])
GO
ALTER TABLE [dbo].[SelectedSubject] CHECK CONSTRAINT [FK_SelectedSubject_Questionnaire]
GO
ALTER TABLE [dbo].[SelectedSubject]  WITH CHECK ADD  CONSTRAINT [FK_SelectedSubject_Subjects] FOREIGN KEY([Название])
REFERENCES [dbo].[Subjects] ([Название])
GO
ALTER TABLE [dbo].[SelectedSubject] CHECK CONSTRAINT [FK_SelectedSubject_Subjects]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Questionnaire] FOREIGN KEY([ID_анкеты])
REFERENCES [dbo].[Questionnaire] ([ID_анкеты])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Questionnaire]
GO
ALTER TABLE [dbo].[Direction]  WITH CHECK ADD  CONSTRAINT [CK_Direction_Код_направления] CHECK  (([Код_направления] like '[0-9][0-9].[0-9][0-9].[0-9][0-9]'))
GO
ALTER TABLE [dbo].[Direction] CHECK CONSTRAINT [CK_Direction_Код_направления]
GO
ALTER TABLE [dbo].[Direction]  WITH CHECK ADD  CONSTRAINT [CK_Direction_Количество_бюджетных_мест] CHECK  (([Количество_бюджетных_мест]>=(0)))
GO
ALTER TABLE [dbo].[Direction] CHECK CONSTRAINT [CK_Direction_Количество_бюджетных_мест]
GO
ALTER TABLE [dbo].[Direction]  WITH CHECK ADD  CONSTRAINT [CK_Direction_Количество_мест] CHECK  (([Количество_мест]>=(0)))
GO
ALTER TABLE [dbo].[Direction] CHECK CONSTRAINT [CK_Direction_Количество_мест]
GO
ALTER TABLE [dbo].[Direction]  WITH CHECK ADD  CONSTRAINT [CK_Direction_Проходной_балл] CHECK  (([Проходной_балл]>(0)))
GO
ALTER TABLE [dbo].[Direction] CHECK CONSTRAINT [CK_Direction_Проходной_балл]
GO
ALTER TABLE [dbo].[Questionnaire]  WITH CHECK ADD  CONSTRAINT [CK_Questionnaire_Год] CHECK  (([Год_окончания_обучения]>=(2000) AND [Год_окончания_обучения]<=(3000)))
GO
ALTER TABLE [dbo].[Questionnaire] CHECK CONSTRAINT [CK_Questionnaire_Год]
GO
ALTER TABLE [dbo].[Questionnaire]  WITH CHECK ADD  CONSTRAINT [CK_Questionnaire_Номер] CHECK  (([Номер_телефона] like '+[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Questionnaire] CHECK CONSTRAINT [CK_Questionnaire_Номер]
GO
ALTER TABLE [dbo].[Questionnaire]  WITH CHECK ADD  CONSTRAINT [CK_Questionnaire_Пол] CHECK  (([Пол]='Женский' OR [Пол]='Мужской'))
GO
ALTER TABLE [dbo].[Questionnaire] CHECK CONSTRAINT [CK_Questionnaire_Пол]
GO
USE [master]
GO
ALTER DATABASE [Applicants] SET  READ_WRITE 
GO
