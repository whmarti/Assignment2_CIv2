USE [Developer]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 4/11/2021 3:11:47 AM ******/
DROP TABLE [dbo].[Teacher]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 4/11/2021 3:11:47 AM ******/
DROP TABLE [dbo].[Student]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 4/11/2021 3:11:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[IdStudent] [int] IDENTITY(1,1) NOT NULL,
	[fullName] [nvarchar](100) NOT NULL,
	[IdNumber] [nchar](15) NOT NULL,
	[email] [nvarchar](100) NOT NULL,
	[pass] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[IdStudent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 4/11/2021 3:11:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[IdTeacher] [int] IDENTITY(1,1) NOT NULL,
	[fullName] [nvarchar](100) NOT NULL,
	[IdNumber] [nchar](15) NULL,
	[email] [nvarchar](100) NOT NULL,
	[pass] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[IdTeacher] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([IdStudent], [fullName], [IdNumber], [email], [pass]) VALUES (1, N'Cristiano Ronaldo', N'78940578       ', N'cristiano.ronaldo@hotmail.com', N'P@ass123*           ')
INSERT [dbo].[Student] ([IdStudent], [fullName], [IdNumber], [email], [pass]) VALUES (2, N'Ronaldinho Gaucho', N'76546234       ', N'ronaldinhogaucho@hotmail.com', N'P@ass123*           ')
INSERT [dbo].[Student] ([IdStudent], [fullName], [IdNumber], [email], [pass]) VALUES (3, N'Diego Maradona', N'73654908       ', N'diegomaradona@hotmail.com', N'P@ass123*           ')
INSERT [dbo].[Student] ([IdStudent], [fullName], [IdNumber], [email], [pass]) VALUES (6, N'Constanza', N'32343411       ', N'whmarti@hotmail.com', N'123456              ')
INSERT [dbo].[Student] ([IdStudent], [fullName], [IdNumber], [email], [pass]) VALUES (10, N'Constanza', N'32343411       ', N'whmarti@hotmail.com', N'Pa$w0rd             ')
SET IDENTITY_INSERT [dbo].[Student] OFF
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([IdTeacher], [fullName], [IdNumber], [email], [pass]) VALUES (1, N'Sean Conery', N'89760435       ', N'sean.conery@hotmail.com', N'P@ass123*           ')
INSERT [dbo].[Teacher] ([IdTeacher], [fullName], [IdNumber], [email], [pass]) VALUES (2, N'Will Smith', N'45876320       ', N'will.smith@hotmail.com', N'P@ass123*           ')
INSERT [dbo].[Teacher] ([IdTeacher], [fullName], [IdNumber], [email], [pass]) VALUES (3, N'Sylvester Stallone', N'67908645       ', N'sylvester.stallone@hotmail.com', N'P@ass123*           ')
INSERT [dbo].[Teacher] ([IdTeacher], [fullName], [IdNumber], [email], [pass]) VALUES (5, N'Constanza', N'32343411       ', N'whmarti@hotmail.com', N'Pa$w0rd             ')
INSERT [dbo].[Teacher] ([IdTeacher], [fullName], [IdNumber], [email], [pass]) VALUES (1004, N'Tiger Woods', N'558763207      ', N'tigerw@hotmail.com', N'Pa$w0rd             ')
SET IDENTITY_INSERT [dbo].[Teacher] OFF
