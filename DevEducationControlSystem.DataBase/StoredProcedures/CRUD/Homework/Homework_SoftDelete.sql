CREATE PROCEDURE [dbo].[Homework_SoftDelete]
	@ID int
		
AS
	UPDATE dbo.Homework SET
		IsDeleted = 1
WHERE ID = @ID
	