USE [Notifications]
GO
/****** Object:  Table [dbo].[Message]    Script Date: 7/12/2017 11:44:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Message](
	[MessageID] [int] NOT NULL,
	[MessageText] [varchar](50) NULL,
	[UserID] [int] NULL,
	[IsSent] [bit] NULL,
 CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED 
(
	[MessageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (0, N'somtext', 5, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (1, N'text', 44, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (3, N'sometext', 42, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (4, N'sometext', 42, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (5, N'sometext', 42, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (6, N'sometext', 424, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (7, N'sometext', 424, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (9, N'sometext', 424, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (19, N'sometext', 424, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (34, N'not read', 42, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (97, N'i was not read', 7, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (129, N'sometext', 424, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (314, N'not read', 42, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (1289, N'sometext', 424, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (3000, N'no t hfh read', 42, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (3154, N'not read', 42, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (3214, N'not read', 42, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (4000, N'no t hfh read', 42, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (5000, N'no t hfh read', 42, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (32144, N'not read', 42, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (322224, N'not read', 42, 1)
INSERT [dbo].[Message] ([MessageID], [MessageText], [UserID], [IsSent]) VALUES (3222274, N'not read', 42, 1)
