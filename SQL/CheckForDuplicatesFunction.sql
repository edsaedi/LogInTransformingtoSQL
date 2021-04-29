CREATE PROCEDURE usp_AddUser
@FirstName varchar(50), @LastName varchar(50), @Username varchar(20), @Password varchar(20)

AS

INSERT INTO Accounts (Username, Password, FirstName, LastName)
VALUES (@Username, @Password, @FirstName, @LastName);



SELECT * FROM Accounts


--usp_AddUser 'Bobby', 'Tables', 'bobbytables', 'dropdb'

SELECT dbo.fn_IsUsernameUnique() AS IsValid

GO;

CREATE FUNCTION fn_IsUsernameUnique()
RETURNS	bit

BEGIN

	DECLARE @temp		int

	SELECT  @temp = COUNT(Username) - COUNT(DISTINCT(Username))
	FROM	Accounts

	RETURN	IIF(@temp = 0, 1, 0)

END