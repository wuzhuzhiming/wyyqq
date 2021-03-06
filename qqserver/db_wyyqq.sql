USE [db_wyyqq]
GO
/****** Object:  Table [dbo].[t_friend]    Script Date: 2018/4/21 17:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_friend](
	[userid] [int] NOT NULL,
	[with_userid] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[t_group]    Script Date: 2018/4/21 17:17:04 ******/
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
/****** Object:  Table [dbo].[t_news]    Script Date: 2018/4/21 17:17:04 ******/
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
/****** Object:  Table [dbo].[t_user]    Script Date: 2018/4/21 17:17:04 ******/
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
/****** Object:  View [dbo].[v_friend]    Script Date: 2018/4/21 17:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_friend]
AS
SELECT   dbo.t_friend.userid, dbo.t_friend.with_userid AS friend_userid, dbo.t_user.name, dbo.t_user.sex, dbo.t_user.head
FROM      dbo.t_friend LEFT OUTER JOIN
                dbo.t_user ON dbo.t_friend.with_userid = dbo.t_user.userid

GO
/****** Object:  View [dbo].[v_news]    Script Date: 2018/4/21 17:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_news]
AS
SELECT   dbo.t_news.userid, dbo.t_news.news_type, dbo.t_news.with_userid, dbo.t_news.with_groupid, 
                dbo.t_user.name AS with_username, dbo.t_group.name AS with_groupname
FROM      dbo.t_news INNER JOIN
                dbo.t_user ON dbo.t_news.with_userid = dbo.t_user.userid LEFT OUTER JOIN
                dbo.t_group ON dbo.t_news.with_groupid = dbo.t_group.groupid

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
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "t_friend"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 209
               Right = 229
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "t_user"
            Begin Extent = 
               Top = 33
               Left = 352
               Bottom = 244
               Right = 494
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 3000
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_friend'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_friend'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[19] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "t_news"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 250
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "t_user"
            Begin Extent = 
               Top = 6
               Left = 262
               Bottom = 145
               Right = 404
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "t_group"
            Begin Extent = 
               Top = 87
               Left = 507
               Bottom = 226
               Right = 649
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1920
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 1935
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 2040
         Or = 1515
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_news'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_news'
GO
