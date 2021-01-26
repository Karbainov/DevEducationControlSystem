CREATE PROCEDURE [dbo].[Group_Homework_Delete]
	@Id int
AS
	DELETE FROM Group_Homework WHERE Id=@Id
GO