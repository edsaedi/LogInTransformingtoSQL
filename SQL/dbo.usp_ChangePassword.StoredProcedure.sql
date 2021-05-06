USE [EdanDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_ChangePassword]    Script Date: 5/5/2021 6:20:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_ChangePassword]
@id int, @newPassword varchar(20)

AS

UPDATE Accounts
SET [Password] = @newPassword
WHERE AccountID = @id;

SELECT	@@ROWCOUNT	AS RowsUpdated
GO
