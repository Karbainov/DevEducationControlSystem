CREATE PROCEDURE [dbo].[Homework_RecoverSoftDeleted]
	@Id int
		
AS
	UPDATE dbo.Homework SET
		IsDeleted = 0
WHERE Id = @Id