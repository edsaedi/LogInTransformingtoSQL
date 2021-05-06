USE [EdanDB]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_IsUsernameUnique]    Script Date: 5/5/2021 6:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fn_IsUsernameUnique]()
RETURNS	bit

BEGIN

	DECLARE @temp		int

	SELECT  @temp = COUNT(Username) - COUNT(DISTINCT(Username))
	FROM	Accounts

	RETURN	IIF(@temp = 0, 1, 0)

END
GO
