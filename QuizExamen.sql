USE [master]
GO
/****** Object:  Database [QuizExamen]    Script Date: 6/25/2023 7:45:50 PM ******/
CREATE DATABASE [QuizExamen]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuizExamen', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuizExamen.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuizExamen_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuizExamen_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuizExamen] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuizExamen].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuizExamen] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuizExamen] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuizExamen] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuizExamen] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuizExamen] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuizExamen] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuizExamen] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuizExamen] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuizExamen] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuizExamen] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuizExamen] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuizExamen] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuizExamen] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuizExamen] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuizExamen] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuizExamen] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuizExamen] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuizExamen] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuizExamen] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuizExamen] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuizExamen] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuizExamen] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuizExamen] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuizExamen] SET  MULTI_USER 
GO
ALTER DATABASE [QuizExamen] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuizExamen] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuizExamen] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuizExamen] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuizExamen] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuizExamen] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuizExamen] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuizExamen] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuizExamen]
GO
/****** Object:  Table [dbo].[Answer]    Script Date: 6/25/2023 7:45:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answer](
	[answerID] [int] IDENTITY(1,1) NOT NULL,
	[optionID] [int] NULL,
	[quizID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[answerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 6/25/2023 7:45:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[categoryID] [int] IDENTITY(1,1) NOT NULL,
	[description] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[categoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemOption]    Script Date: 6/25/2023 7:45:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemOption](
	[optionID] [int] IDENTITY(1,1) NOT NULL,
	[text] [varchar](255) NULL,
	[isRight] [bit] NOT NULL,
	[questionID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[optionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 6/25/2023 7:45:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[questionID] [int] IDENTITY(1,1) NOT NULL,
	[text] [varchar](255) NULL,
	[categoryID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[questionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionQuiz]    Script Date: 6/25/2023 7:45:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionQuiz](
	[questionID] [int] NOT NULL,
	[quizID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[questionID] ASC,
	[quizID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quiz]    Script Date: 6/25/2023 7:45:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quiz](
	[quizID] [int] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](50) NULL,
	[email] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[quizID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Answer] ON 

INSERT [dbo].[Answer] ([answerID], [optionID], [quizID]) VALUES (2261, 2, 2055)
INSERT [dbo].[Answer] ([answerID], [optionID], [quizID]) VALUES (2262, 4, 2055)
INSERT [dbo].[Answer] ([answerID], [optionID], [quizID]) VALUES (2263, 6, 2055)
INSERT [dbo].[Answer] ([answerID], [optionID], [quizID]) VALUES (2264, 9, 2055)
INSERT [dbo].[Answer] ([answerID], [optionID], [quizID]) VALUES (2265, 11, 2055)
INSERT [dbo].[Answer] ([answerID], [optionID], [quizID]) VALUES (2266, 14, 2055)
SET IDENTITY_INSERT [dbo].[Answer] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([categoryID], [description]) VALUES (1, N'easy')
INSERT [dbo].[Category] ([categoryID], [description]) VALUES (2, N'medium')
INSERT [dbo].[Category] ([categoryID], [description]) VALUES (3, N'hard')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[ItemOption] ON 

INSERT [dbo].[ItemOption] ([optionID], [text], [isRight], [questionID]) VALUES (1, N'a coffee', 0, 1)
INSERT [dbo].[ItemOption] ([optionID], [text], [isRight], [questionID]) VALUES (2, N'a high-level programming language', 1, 1)
INSERT [dbo].[ItemOption] ([optionID], [text], [isRight], [questionID]) VALUES (3, N'a source code editor', 0, 1)
INSERT [dbo].[ItemOption] ([optionID], [text], [isRight], [questionID]) VALUES (4, N'is a template that describes the behavior that the object of its type support', 1, 2)
INSERT [dbo].[ItemOption] ([optionID], [text], [isRight], [questionID]) VALUES (5, N'can only include one method', 0, 2)
INSERT [dbo].[ItemOption] ([optionID], [text], [isRight], [questionID]) VALUES (6, N'the process where one class acquires the properties (methods and fields) of another.', 1, 3)
INSERT [dbo].[ItemOption] ([optionID], [text], [isRight], [questionID]) VALUES (7, N'a problem that arises during the execution of a program.', 0, 3)
INSERT [dbo].[ItemOption] ([optionID], [text], [isRight], [questionID]) VALUES (8, N'it mainly used to traverse collection of elements including arrays.', 0, 3)
INSERT [dbo].[ItemOption] ([optionID], [text], [isRight], [questionID]) VALUES (9, N'true', 1, 4)
INSERT [dbo].[ItemOption] ([optionID], [text], [isRight], [questionID]) VALUES (10, N'false', 0, 4)
INSERT [dbo].[ItemOption] ([optionID], [text], [isRight], [questionID]) VALUES (11, N'true', 1, 5)
INSERT [dbo].[ItemOption] ([optionID], [text], [isRight], [questionID]) VALUES (12, N'false', 0, 5)
INSERT [dbo].[ItemOption] ([optionID], [text], [isRight], [questionID]) VALUES (13, N'variables', 0, 6)
INSERT [dbo].[ItemOption] ([optionID], [text], [isRight], [questionID]) VALUES (14, N'arrays', 1, 6)
INSERT [dbo].[ItemOption] ([optionID], [text], [isRight], [questionID]) VALUES (15, N'methods', 0, 6)
SET IDENTITY_INSERT [dbo].[ItemOption] OFF
GO
SET IDENTITY_INSERT [dbo].[Question] ON 

INSERT [dbo].[Question] ([questionID], [text], [categoryID]) VALUES (1, N'Java is ……..', 1)
INSERT [dbo].[Question] ([questionID], [text], [categoryID]) VALUES (2, N'A Java class', 2)
INSERT [dbo].[Question] ([questionID], [text], [categoryID]) VALUES (3, N'What is Java inheritance?', 2)
INSERT [dbo].[Question] ([questionID], [text], [categoryID]) VALUES (4, N'Polymorphism is the ability of an object to take on many forms.', 3)
INSERT [dbo].[Question] ([questionID], [text], [categoryID]) VALUES (5, N'Local variables are declared in methods, constructors, or blocks.', 1)
INSERT [dbo].[Question] ([questionID], [text], [categoryID]) VALUES (6, N'…….. stores a fixed-size sequential collection of elements of the same type?', 3)
SET IDENTITY_INSERT [dbo].[Question] OFF
GO
INSERT [dbo].[QuestionQuiz] ([questionID], [quizID]) VALUES (1, 2055)
INSERT [dbo].[QuestionQuiz] ([questionID], [quizID]) VALUES (2, 2055)
INSERT [dbo].[QuestionQuiz] ([questionID], [quizID]) VALUES (3, 2055)
INSERT [dbo].[QuestionQuiz] ([questionID], [quizID]) VALUES (4, 2055)
INSERT [dbo].[QuestionQuiz] ([questionID], [quizID]) VALUES (5, 2055)
INSERT [dbo].[QuestionQuiz] ([questionID], [quizID]) VALUES (6, 2055)
GO
SET IDENTITY_INSERT [dbo].[Quiz] ON 

INSERT [dbo].[Quiz] ([quizID], [userName], [email]) VALUES (1, N'williamo', N'william@gmail.com')
INSERT [dbo].[Quiz] ([quizID], [userName], [email]) VALUES (2, N'allo21', N'alex.gh@gmail.com')
INSERT [dbo].[Quiz] ([quizID], [userName], [email]) VALUES (2055, N'alanpern', N'alain@alainpernot.com')
SET IDENTITY_INSERT [dbo].[Quiz] OFF
GO
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD FOREIGN KEY([optionID])
REFERENCES [dbo].[ItemOption] ([optionID])
GO
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD FOREIGN KEY([quizID])
REFERENCES [dbo].[Quiz] ([quizID])
GO
ALTER TABLE [dbo].[ItemOption]  WITH CHECK ADD FOREIGN KEY([questionID])
REFERENCES [dbo].[Question] ([questionID])
GO
ALTER TABLE [dbo].[Question]  WITH CHECK ADD FOREIGN KEY([categoryID])
REFERENCES [dbo].[Category] ([categoryID])
GO
ALTER TABLE [dbo].[QuestionQuiz]  WITH CHECK ADD FOREIGN KEY([questionID])
REFERENCES [dbo].[Question] ([questionID])
GO
ALTER TABLE [dbo].[QuestionQuiz]  WITH CHECK ADD FOREIGN KEY([quizID])
REFERENCES [dbo].[Quiz] ([quizID])
GO
USE [master]
GO
ALTER DATABASE [QuizExamen] SET  READ_WRITE 
GO
