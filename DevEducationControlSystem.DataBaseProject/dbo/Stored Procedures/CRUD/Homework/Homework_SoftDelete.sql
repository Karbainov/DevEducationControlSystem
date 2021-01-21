CREATE PROCEDURE [dbo].[Homework_SoftDelete]
	@Id int
		
AS
	UPDATE dbo.Homework SET
		IsDeleted = 1
WHERE Id = @Id