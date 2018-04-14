USE [db_wyyqq]
GO
/****** Object:  Table [dbo].[t_user]    Script Date: 2018/4/14 22:50:22 ******/
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
ALTER TABLE [dbo].[t_user] ADD  CONSTRAINT [DF_t_user_sex]  DEFAULT ((2)) FOR [sex]
GO
ALTER TABLE [dbo].[t_user] ADD  CONSTRAINT [DF_t_user_head]  DEFAULT ((8)) FOR [head]
GO
