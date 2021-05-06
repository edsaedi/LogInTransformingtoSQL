USE [EdanDB]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 5/5/2021 6:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](20) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[LastLoginTime] [smalldatetime] NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Accounts] ADD  CONSTRAINT [DF_Accounts_LastLoginTime]  DEFAULT (NULL) FOR [LastLoginTime]
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [CK_AccountsUsernameUnique] CHECK  (([dbo].[fn_IsUsernameUnique]()=(1)))
GO
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [CK_AccountsUsernameUnique]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Username must be unique' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Accounts', @level2type=N'CONSTRAINT',@level2name=N'CK_AccountsUsernameUnique'
GO
