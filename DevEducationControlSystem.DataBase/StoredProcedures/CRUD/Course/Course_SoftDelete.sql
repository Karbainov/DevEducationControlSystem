CREATE PROCEDURE [dbo].[Course_SoftDelete]
	@Id int
		
AS
	UPDATE dbo.Course SET
		IsDeleted = 1
WHERE ID = @Id