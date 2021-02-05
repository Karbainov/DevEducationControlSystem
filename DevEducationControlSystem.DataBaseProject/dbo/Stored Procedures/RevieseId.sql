CREATE PROCEDURE RevieseId
@Login nvarchar(100)
AS
BEGIN
SELECT * FROM [User] WHERE [Login]=@Login
END