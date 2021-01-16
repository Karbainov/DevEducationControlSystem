CREATE PROCEDURE [dbo].[AnswerStatus_Update]
	@Id int,
	@Name NVARCHAR(100)
AS
UPDATE [dbo].[AnswerStatus] 
SET 
[Name] = @Name
WHERE [dbo].[AnswerStatus].Id = @Id