USE [EdanDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_LoginAccount]    Script Date: 4/14/2021 6:26:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_LoginAccount]
	@Username varchar(20)
,	@Password varchar(20)
AS

UPDATE Accounts
SET LastLoginTime			= GETDATE()
WHERE Username				= @Username
AND [Password]				= @Password

SELECT AccountID, FirstName, LastName, LastLoginTime FROM Accounts
WHERE Username = @Username 
AND [Password] = @Password
GO
