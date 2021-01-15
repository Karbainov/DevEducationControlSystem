CREATE PROCEDURE AnswerStatus_Update
	@ID int,
	@Name NVARCHAR(100)
AS
UPDATE AnswerStatus 
SET 
[Name] = @Name
WHERE AnswerStatus.ID = @ID
GO