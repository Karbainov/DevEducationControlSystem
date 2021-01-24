CREATE PROCEDURE [dbo] . [Feedback_Delete]
	@Id int 
AS 
	DELETE FROM [dbo] . [Feedback] WHERE Id=@Id
