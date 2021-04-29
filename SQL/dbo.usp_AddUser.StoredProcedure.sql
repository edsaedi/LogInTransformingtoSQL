USE [EdanDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_AddUser]    Script Date: 4/28/2021 6:26:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_AddUser]
@FirstName varchar(50), @LastName varchar(50), @Username varchar(20), @Password varchar(20)

AS

INSERT INTO Accounts (Username, Password, FirstName, LastName)
VALUES (@Username, @Password, @FirstName, @LastName);

GO
