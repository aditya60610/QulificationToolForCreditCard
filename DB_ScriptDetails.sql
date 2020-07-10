USE [CreditCardDetailsDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10-07-2020 16:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CardDetails]    Script Date: 10-07-2020 16:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CardDetails](
	[CreditCardId] [int] IDENTITY(1,1) NOT NULL,
	[CardName] [nvarchar](50) NULL,
	[APR] [decimal](18, 2) NOT NULL,
	[Message] [nvarchar](max) NULL,
	[CreatedDateTime] [datetime2](7) NOT NULL,
	[ModifiedDateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_CardDetails] PRIMARY KEY CLUSTERED 
(
	[CreditCardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 10-07-2020 16:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[DOB] [datetime2](7) NOT NULL,
	[Annual_Income] [decimal](18, 2) NOT NULL,
	[CreditCardId] [int] NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[CreatedDateTime] [datetime2](7) NOT NULL,
	[ModifiedDateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200706183526_initialcreate', N'2.1.14-servicing-32113')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200706213729_updatedColumnDetailsAndSeed', N'2.1.14-servicing-32113')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200707150658_addedDatetimeField', N'2.1.14-servicing-32113')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200709081854_updateCreditCardMastermessages', N'2.1.14-servicing-32113')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200709082134_updateMessages', N'2.1.14-servicing-32113')
GO
SET IDENTITY_INSERT [dbo].[CardDetails] ON 
GO
INSERT [dbo].[CardDetails] ([CreditCardId], [CardName], [APR], [Message], [CreatedDateTime], [ModifiedDateTime]) VALUES (1, N'None', CAST(0.00 AS Decimal(18, 2)), N'No credit cards are available for the customer below 18 Age.', CAST(N'2020-07-09T10:21:33.7580000' AS DateTime2), CAST(N'2020-07-09T10:21:33.7620000' AS DateTime2))
GO
INSERT [dbo].[CardDetails] ([CreditCardId], [CardName], [APR], [Message], [CreatedDateTime], [ModifiedDateTime]) VALUES (2, N'Barclay', CAST(24.60 AS Decimal(18, 2)), N'Enjoy the Barclay credit card, Barclay credit card now offers an APR of 24.60 %', CAST(N'2020-07-09T10:21:33.7630000' AS DateTime2), CAST(N'2020-07-09T10:21:33.7630000' AS DateTime2))
GO
INSERT [dbo].[CardDetails] ([CreditCardId], [CardName], [APR], [Message], [CreatedDateTime], [ModifiedDateTime]) VALUES (3, N'Vanquis', CAST(36.80 AS Decimal(18, 2)), N'Enjoy the Vanquis credit card, Vanquis credit card now offers an APR of 36.80 %', CAST(N'2020-07-09T10:21:33.7630000' AS DateTime2), CAST(N'2020-07-09T10:21:33.7630000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[CardDetails] OFF
GO
ALTER TABLE [dbo].[CardDetails] ADD  DEFAULT ((0.0)) FOR [APR]
GO
ALTER TABLE [dbo].[CardDetails] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedDateTime]
GO
ALTER TABLE [dbo].[CardDetails] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [ModifiedDateTime]
GO
ALTER TABLE [dbo].[Customers] ADD  DEFAULT (N'') FOR [LastName]
GO
ALTER TABLE [dbo].[Customers] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedDateTime]
GO
ALTER TABLE [dbo].[Customers] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [ModifiedDateTime]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_CardDetails_CreditCardId] FOREIGN KEY([CreditCardId])
REFERENCES [dbo].[CardDetails] ([CreditCardId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_CardDetails_CreditCardId]
GO
